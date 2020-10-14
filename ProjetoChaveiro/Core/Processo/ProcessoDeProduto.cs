using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Processo
{
    public class ProcessoDeProduto
    {
        public void SalveNoBanco(Produto produto)
        {
            new MapeadorDeProduto().Salve(produto);
        }
        public int ObtenhaProximoCodigo()
        {
            return new MapeadorDeProduto().ObtenhaProximoCodigo();
        }

        public List<Produto> ObtenhaPorDescricao(string text)
        {
            return new MapeadorDeProduto().ObtenhaPorDescricao(text);
        }

        public void Exclua(Produto produtoSelecionado)
        {
            new MapeadorDeProduto().Exclua(produtoSelecionado);
        }
    }

}



