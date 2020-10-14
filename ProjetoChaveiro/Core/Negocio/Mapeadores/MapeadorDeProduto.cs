using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Enumerador;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.Mapeadores
{
    public class MapeadorDeProduto
    {
        public void Salve(Produto produto)
        {
            using (var conexao = new Conexao())
            using (var trns = conexao.Transacao())
            {
                if (!Atualize(produto, conexao))
                     Crie(produto, conexao);
                trns.Commit();
            }
        }

        private bool Atualize(Produto produto, Conexao conexao)
        {
            using (var comando = conexao.CrieComando())
            {
                var sql =
                    $@"UPDATE TBPRODUTO SET
PRODUTO = '{produto.Descricao}',
PRECO = {produto.Valor.ToString().Replace(",", ".")},
UNIDADE = '{produto.Unidade.Codigo}' ,
ATIVO = '{(produto.Ativo ? 'S' : 'N')}'
WHERE CODIGO = {produto.Codigo}
";
                comando.CommandText = sql;
                return comando.ExecuteNonQuery() != 0;
            }
        }

        private static void Crie(Produto produto, Conexao conexao)
        {
            using (var comando = conexao.CrieComando())
            {
                var sql =
                    $@"INSERT INTO TBPRODUTO (CODIGO,PRODUTO,PRECO,UNIDADE,ATIVO)
VALUES ({produto.Codigo},'{produto.Descricao}',{produto.Valor.ToString().Replace(",", ".")},
'{produto.Unidade.Codigo}','{(produto.Ativo ? 'S' : 'N')}')";
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }

        internal void Exclua(Produto produtoSelecionado)
        {
            using (var conexao = new Conexao())
            using (var trns = conexao.Transacao())
            {
                using (var comando = conexao.CrieComando())
                {
                    var sql =
                        $@"DELETE FROM TBPRODUTO  WHERE CODIGO = {produtoSelecionado.Codigo}";
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                }
                trns.Commit();
            }
        }

        internal List<Produto> ObtenhaPorDescricao(string text)
        {
            using (var conexao = new Conexao())
            {
                conexao.AdicioneComando($@"SELECT * FROM TBPRODUTO
 WHERE PRODUTO LIKE '%{text}%'");

                using (var dr = conexao.ObtenhaDataReader())
                {
                    var produtos = new List<Produto>();
                    while (dr.Read())
                    {
                        produtos.Add(MapeieProduto(dr));
                    }
                    return produtos;
                }
            }
        } //rodrigo.wallauer

        private Produto MapeieProduto(FbDataReader dr)
        {
            return new Produto()
            {
                Codigo = dr["CODIGO"].ToString().ConvertaParaInt(),
                Descricao = dr["PRODUTO"].ToString(),
                Valor = dr["PRECO"].ToString().ConvertaParaDecimal(),
                Unidade = EnumeradorUnidadeProduto.Obtenha<EnumeradorUnidadeProduto>(dr["UNIDADE"].ToString().ConvertaParaInt()),
                Ativo = dr["ATIVO"].ToString() == "S"
            };
        }

        public int ObtenhaProximoCodigo()
        {
            using (var conexao = new Conexao())
            {
                conexao.AdicioneComando("Select max(CODIGO) as codigo from TBPRODUTO");
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
