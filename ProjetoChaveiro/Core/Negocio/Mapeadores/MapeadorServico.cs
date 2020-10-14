using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Enumerador;
using Core.Processo;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.Mapeadores
{
    public class MapeadorServico
    {
        public void Salve(Servico servico)
        {
            using (var conexao = new Conexao())
            using (var trns = conexao.Transacao())
            {
                using (var comando = conexao.CrieComando())
                {
                    var sql = 
                        $@"INSERT INTO TBSERVICO (CODIGO,SERVICO,PRECO)
VALUES ({servico.Codigo},'{servico.Descricao}',{servico.Preco.ToString().Replace(",", ".")})" ;
                 comando.CommandText = sql;
                 comando.ExecuteNonQuery();             
                }
                trns.Commit();
            }
        }

        internal void Exclua(Servico servicoSelecionado)
        {
            using (var conexao = new Conexao())
            using (var trns = conexao.Transacao())
            {
                using (var comando = conexao.CrieComando())
                {
                    var sql =
                        $@"
DELETE INTO TBSERVICO (CODIGO,SERVICO,PRECO)
VALUES ({servico.Codigo},
'{servico.Descricao}',
{servico.Preco.ToString().Replace(",", ".")})
";
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                }
                trns.Commit();
            }
        }

        internal List<Servico> ObtenhaPorDescricao(string text)
        {
            using (var conexao = new Conexao())
            {
                conexao.AdicioneComando($@"SELECT * FROM TBSERVICO
WHERE SERVICO LIKE '%{text}%'");

                using (var dr = conexao.ObtenhaDataReader())
                {
                    var servico = new List<Servico>();
                    while (dr.Read())
                    {
                        servico.Add(MapeieServico(dr));
                    }
                    return servico;
                }
                
            }
            
        }
            private Servico MapeieServico(FbDataReader dr)
            {
                return new Servico()
                {
                    Codigo = dr["CODIGO"].ToString().ConvertaParaInt(),
                    Descricao = dr["SERVICO"].ToString(),
                    Preco = dr["PRECO"].ToString().ConvertaParaDecimal(),

                };
            }

            public int ObtenhaProximoCodigo()
            {
                using (var conexao = new Conexao())
                {
                    conexao.AdicioneComando("Select max(CODIGO) as codigo from TBSERVICO");
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
        }
    }
