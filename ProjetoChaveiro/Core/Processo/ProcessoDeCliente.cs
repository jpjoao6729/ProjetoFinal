using Core.Mapeadores;
using Core.Negocio.ClasseDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Processo
{
    public class ProcessoDeCliente
    {
        public void SalveNoBanco(ClienteAbstrato cliente)
        {
            new MapeadorDeCliente().SalveNoBanco(cliente);
        }

        public int ObtenhaProximoCodigo()
        {
            return new MapeadorDeCliente().ObtenhaProximoCodigo();
        }

        public IEnumerable<ClienteAbstrato> ObtenhaPorDescricao(string texto)
        {
            return new MapeadorDeCliente().ObtenhaPorDescricao(texto);
        }
    }
}
