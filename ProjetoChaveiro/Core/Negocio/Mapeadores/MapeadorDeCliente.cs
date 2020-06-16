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
            using (var trns = conexao.CrieTransaceo())
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
                    if (cliente is PessoaFisica pessoafisicas)
                    {
                        comando.CommandText = $@"INSERT INTO TBCLIENTEFISICO (CODIGOCLIENTE, NOME, CPF) VALUES 
({pessoafisicas.Codigo}, '{pessoafisicas.Nome}', '{pessoafisicas.CPF}')";

                    }
                    else if (cliente is PessoaJuridica pessoaJuridica)
                    {
                        comando.CommandText = $@"INSERT INTO TBCLIENTEJURIDICO (CODIGOCLIENTE, RAZAOSOCIAL, NOME, CNPJ) VALUES
({pessoaJuridica.Codigo},{pessoaJuridica.RazaoSocial},{pessoaJuridica.Nome},{pessoaJuridica.CNPJ})";
                    }
                    comando.ExecuteNonQuery();
                }
                trns.Commit();
            }
        }

        internal IEnumerable<ClienteAbstrato> ObtenhaPorDescricao(string descricao)
        {
            using (var conexao = new Conexao())
            {
                conexao.AdicioneComando($@"SELECT * FROM TBCLIENTE TBC
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
                Codigo = dr["CODIGO"].ToString().ConvertaParaInt(),
                CNPJ = dr["CNPJ"].ToString(),
                Email = MapeieEmail(dr),
                Endereco = MapeieEndereco(dr),
                Nome = dr["NOME"].ToString(),
                RazaoSocial = dr["RAZAOSOCIAL"].ToString(),
                Telefone = MapeieTelefone(dr)
            };

        }

        private Telefone MapeieTelefone(FbDataReader dr)
        {
            Telefone telefone;
            var numero = "";
            if(dr["TELEFONEFIXO"].ToString() != "")
            {
                telefone = new Telefone()
                { Tipo = EnumeradorTelefone.Fixo};
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
                UF = EnumeradorUF.Obtenha< EnumeradorUF>(dr["UF"].ToString()),   
                Logradouro =  dr["LAGRADOURO"].ToString(),  
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
                Codigo = dr["CODIGO"].ToString().ConvertaParaInt(),
                CPF = dr["CPF"].ToString(),
                Email = MapeieEmail(dr),
                Endereco = MapeieEndereco(dr),
                Nome = dr["NOME"].ToString(),
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








