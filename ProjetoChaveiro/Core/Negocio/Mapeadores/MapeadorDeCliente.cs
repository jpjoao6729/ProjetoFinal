using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Enumerador;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapeadores
{
    class MapeadorDeCliente
    {
        internal void SalveNoBanco(ClienteAbstrato cliente)
        {
            using (var conexao = new Conexao())
            using (var trns = conexao.Transacao())
            {
                if (!Update(cliente, conexao))
                Insira(cliente, conexao);
                trns.Commit();
            }
        }

        private bool Update(ClienteAbstrato cliente, Conexao conexao)
        {
            using (var comando = conexao.CrieComando())
            {
                if(!AtualizaCliente(cliente, comando)) return false;
            }
            using(var comando = conexao.CrieComando())
            {
                    ApagueDetalhesClienteFisico(cliente.Codigo, comando);
                    ApagueDetalhesClienteJuridico(cliente.Codigo, comando);
            }
            using (var comando = conexao.CrieComando())
            {
                CriaDadosPessoaFisicaJuridica(cliente, comando);
            }
            return true;
        }

        private static bool AtualizaCliente(ClienteAbstrato cliente, FbCommand comando)
        {
            var sql = $@"UPDATE TBCLIENTE SET
FISICO = {(cliente is PessoaFisica ? "1" : "null")}, 
JURIDICO = {(cliente is PessoaJuridica ? "1" : "null")},
CEP = '{cliente.Endereco.CEP.Replace("-", "")}',
CIDADE = '{cliente.Endereco.Cidade}',
UF = '{cliente.Endereco.UF}',
LAGRADOURO = '{cliente.Endereco.Logradouro}',
COMPLEMENTO = '{cliente.Endereco.Complemento}',
BAIRRO = '{cliente.Endereco.Bairro}',
TELEFONEFIXO = {(cliente.Telefone.Tipo.Equals(EnumeradorTelefone.Fixo) ? $"'{cliente.Telefone.ToString()}'" : "null")},
TELEFONECELULAR = {(cliente.Telefone.Tipo.Equals(EnumeradorTelefone.Celular) ? $"'{cliente.Telefone.ToString()}'" : "null")}, 
EMAIL = '{cliente.Email.ToString()}'
WHERE CODIGO = {cliente.Codigo}";
            comando.CommandText = sql;

            return comando.ExecuteNonQuery() != 0;
        }

        private void Insira(ClienteAbstrato cliente, Conexao conexao)
        {
            using (var comando = conexao.CrieComando())
            {
                var sql = @"INSERT INTO TBCLIENTE (CODIGO, FISICO, JURIDICO ,CEP ,CIDADE,UF,LAGRADOURO,COMPLEMENTO,BAIRRO,TELEFONEFIXO,TELEFONECELULAR, EMAIL)
VALUES ";
                if (cliente is PessoaFisica)
                {
                    sql += CrieComandoPessoaFisica(cliente);
                }
                else
                {
                    sql += CrieComandoPessoaJuridica(cliente);
                }

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

            }
            using (var comando = conexao.CrieComando())
            {
                CriaDadosPessoaFisicaJuridica(cliente, comando);
            }
        }

        private static void CriaDadosPessoaFisicaJuridica(ClienteAbstrato cliente, FbCommand comando)
        {
            if (cliente is PessoaFisica pessoafisicas)
            {
                comando.CommandText = $@"INSERT INTO TBCLIENTEFISICO (CODIGOCLIENTE, NOME, CPF) VALUES 
({pessoafisicas.Codigo}, '{pessoafisicas.Nome}', '{pessoafisicas.CPF}')";

            }
            else if (cliente is PessoaJuridica pessoaJuridica)
            {
                comando.CommandText = $@"INSERT INTO TBCLIENTEJURIDICO (CODIGOCLIENTE, RAZAOSOCIAL, NOME, CNPJ) VALUES
({pessoaJuridica.Codigo},'{pessoaJuridica.RazaoSocial}','{pessoaJuridica.Nome}','{pessoaJuridica.CNPJ}')";
            }
            comando.ExecuteNonQuery();
        }

        internal void ApagueCliente(ClienteAbstrato cliente)
        {
            using (var conexao = new Conexao())
            using (var trns = conexao.Transacao())
            {
                using (var comando = conexao.CrieComando())
                {
                    if (cliente is PessoaFisica pessoafisicas)
                    {
                        ApagueDetalhesClienteFisico(pessoafisicas.Codigo, comando);
                    }
                    else if (cliente is PessoaJuridica pessoaJuridica)
                    {
                        ApagueDetalhesClienteJuridico(pessoaJuridica.Codigo, comando);
                    }
                }
                using (var comando = conexao.CrieComando())
                {
                    ApagueDadosGerais(cliente, comando);
                }
                trns.Commit();
            }
        }

        private void ApagueDadosGerais(ClienteAbstrato cliente, FbCommand comando)
        {
            comando.CommandText = $"DELETE FROM TBCLIENTE WHERE CODIGO = {cliente.Codigo}";
            comando.ExecuteNonQuery();
        }

        private void ApagueDetalhesClienteJuridico(int codigo, FbCommand comando)
        {
            comando.CommandText = $"DELETE FROM TBCLIENTEJURIDICO WHERE CODIGOCLIENTE = {codigo}";
            comando.ExecuteNonQuery();
        }

        private void ApagueDetalhesClienteFisico(int codigo, FbCommand comando)
        {
            comando.CommandText = $"DELETE FROM TBCLIENTEFISICO WHERE CODIGOCLIENTE = {codigo}";
            comando.ExecuteNonQuery();
        }

        internal IEnumerable<ClienteAbstrato> ObtenhaPorDescricao(string descricao)
        {
            using (var conexao = new Conexao())
            {
                conexao.AdicioneComando($@"SELECT 
 TBC.*, 
 TBCF.CODIGOCLIENTE AS CODIGOCLIENTEFISICO,
 TBCF.CPF,
 TBCF.NOME AS NOMECLIENTEFISICO,
 TBCJ.CODIGOCLIENTE AS CODIGOCLIENTEJURIDICO,
 TBCJ.CNPJ,
 TBCJ.NOME AS NOMECLIENTEJURIDICO,
 TBCJ.RAZAOSOCIAL
FROM TBCLIENTE TBC
 LEFT JOIN TBCLIENTEFISICO TBCF  on TBCF.CODIGOCLIENTE = TBC.CODIGO
 LEFT JOIN TBCLIENTEJURIDICO TBCJ ON TBCJ.CODIGOCLIENTE = TBC.CODIGO
 WHERE TBCF.NOME LIKE '%{descricao}%' OR TBCJ.NOME LIKE '%{descricao}%'");

                using (var dr = conexao.ObtenhaDataReader())
                {
                    var clientes = new List<ClienteAbstrato>();
                    while (dr.Read())
                    {
                        ClienteAbstrato cliente;
                        if (dr["FISICO"].ToString() == "1")
                        {
                            cliente = MapeieClienteFisico(dr);
                        }
                        else
                        {
                            cliente = MapeieClienteJuridico(dr);
                        }
                        clientes.Add(cliente);
                    }
                    return clientes;
                }
            }
        }

        private PessoaJuridica MapeieClienteJuridico(FbDataReader dr)
        {
            return new PessoaJuridica()
            {
                Codigo = dr["CODIGOCLIENTEJURIDICO"].ToString().ConvertaParaInt(),
                CNPJ = dr["CNPJ"].ToString(),
                Email = MapeieEmail(dr),
                Endereco = MapeieEndereco(dr),
                Nome = dr["NOMECLIENTEJURIDICO"].ToString(),
                RazaoSocial = dr["RAZAOSOCIAL"].ToString(),
                Telefone = MapeieTelefone(dr)
            };

        }

        private Telefone MapeieTelefone(FbDataReader dr)
        {
            Telefone telefone;
            var numero = "";
            if (dr["TELEFONEFIXO"].ToString() != "")
            {
                telefone = new Telefone()
                { Tipo = EnumeradorTelefone.Fixo };
                numero = dr["TELEFONEFIXO"].ToString();
            }
            else
            {
                telefone = new Telefone()
                { Tipo = EnumeradorTelefone.Celular };
                numero = dr["TELEFONECELULAR"].ToString();
            }

            telefone.DDD = numero.Substring(1, 2);
            telefone.Numero = numero.Substring(4, numero.Length - 4);
            return telefone;
        }

        private Endereco MapeieEndereco(FbDataReader dr)
        {
            return new Endereco()
            {
                CEP = dr["CEP"].ToString(),
                Cidade = dr["CIDADE"].ToString(),
                UF = EnumeradorUF.Obtenha<EnumeradorUF>(dr["UF"].ToString()),
                Logradouro = dr["LAGRADOURO"].ToString(),
                Complemento = dr["COMPLEMENTO"].ToString(),
                Bairro = dr["BAIRRO"].ToString()

            };

        }

        private Email MapeieEmail(FbDataReader dr)
        {
            return new Email()
            {
                Texto = dr["EMAIL"].ToString()
            };
        }

        private PessoaFisica MapeieClienteFisico(FbDataReader dr)
        {
            return new PessoaFisica()
            {
                Codigo = dr["CODIGOCLIENTEFISICO"].ToString().ConvertaParaInt(),
                CPF = dr["CPF"].ToString(),
                Email = MapeieEmail(dr),
                Endereco = MapeieEndereco(dr),
                Nome = dr["NOMECLIENTEFISICO"].ToString(),
                Telefone = MapeieTelefone(dr)
            };
        }

        internal int ObtenhaProximoCodigo()
        {
            using (var conexao = new Conexao())
            {
                conexao.AdicioneComando("Select max(CODIGO) as codigo from TBCLIENTE");
                using (var dr = conexao.ObtenhaDataReader())
                {
                    if (dr.Read() && dr["codigo"] is int codigo)
                    {
                        return codigo + 1;
                    }
                    return 0;
                }
            }
        }

        private string CrieComandoPessoaJuridica(ClienteAbstrato cliente)
        {
            var sql = $@"({cliente.Codigo}, null,{1},'{cliente.Endereco.CEP.Replace("-", "").ConvertaParaInt()}','{cliente.Endereco.Cidade}','{cliente.Endereco.UF}', '{cliente.Endereco.Logradouro}'
                ,'{cliente.Endereco.Complemento}','{cliente.Endereco.Bairro}'";

            if (cliente.Telefone.Tipo == EnumeradorTelefone.Fixo)
            {
                sql += $", '{cliente.Telefone.ToString()}', null";
            }
            else
            {
                sql += $", null, '{cliente.Telefone.ToString()}'";
            }
            sql += $",'{cliente.Email.ToString()}')";
            return sql;
        }

        private string CrieComandoPessoaFisica(ClienteAbstrato cliente)
        {
            var sql = $@"({cliente.Codigo}, {1},null,'{cliente.Endereco.CEP.Replace("-", "").ConvertaParaInt()}','{cliente.Endereco.Cidade}','{cliente.Endereco.UF}'
 ,'{cliente.Endereco.Logradouro}','{cliente.Endereco.Complemento}','{cliente.Endereco.Bairro}'";

            if (cliente.Telefone.Tipo == EnumeradorTelefone.Fixo)
            {
                sql += $", '{cliente.Telefone.ToString()}', null";
            }
            else
            {
                sql += $", null, '{cliente.Telefone.ToString()}'";
            }
            sql += $",'{cliente.Email.ToString()}')";
            return sql;
        }

    }
}








