using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Processo
{
    public class ProcessoDeFornecedor
    {

        public void SalveNoBanco(Fornecedor fornecedor)
        {
            new MapeadorDeFornecedor().Salve(fornecedor);
        }

        public IEnumerable<Fornecedor> ObtenhaPorDescricao(string descricao)
        {
            return new MapeadorDeFornecedor().ObtenhaPorDescricao(descricao);
        }

        public int ObtenhaProximoCodigo()
        {
            return new MapeadorDeFornecedor().ObtenhaProximoCodigo();
        }

        public void Apague(Fornecedor fornecedor)
        {
            new MapeadorDeFornecedor().Apague(fornecedor); 
        }
    }
}