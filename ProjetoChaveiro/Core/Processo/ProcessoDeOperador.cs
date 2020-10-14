using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Processo
{
    public class ProcessoDeOperador
    {
        public void SalveNoBanco(Operador operador)
        {
            new MapeadorOperador().Salve(operador);
        }
        public int ObtenhaProximoCodigo()
        {
            return new MapeadorOperador().ObtenhaProximoCodigo();
        }

        public List<Operador> ObtenhaPorDescricao(string text)
        {
            return new MapeadorOperador().ObtenhaPorDescricao(text);
        }

        public void Apague(Operador operador)
        {
            new MapeadorOperador().Apague(operador);
        }
    }
}