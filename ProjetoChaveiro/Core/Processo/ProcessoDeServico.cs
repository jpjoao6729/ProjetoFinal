using Core.Negocio.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Processo
{
    public class ProcessoDeServico
    {
        public void SalveNoBanco(Servico servico)
        {
            new MapeadorServico().Salve(servico);
        }

        public int ObtenhaCodigo()
        {
            return new MapeadorServico().ObtenhaProximoCodigo();
        }

        public IEnumerable<Servico> ObtenhaPorDescricao(string text)
        {
            return new MapeadorServico().ObtenhaPorDescricao(text);
        }

        public void Exclua(Servico servicoSelecionado)
        {
            new MapeadorServico().Exclua(servicoSelecionado);
        }
    }


}
