using Core.Negocio.Exception;
using System;

namespace ProjetoChaveiro
{
    public class FormularioHelper
    {
        public static frmBase CrieFormulario(string nomeFormulario)
        {
            try
            {
                var instancia = Activator.CreateInstance("ProjetoChaveiro", $"ProjetoChaveiro.{nomeFormulario}");
                var formulario = (frmBase)instancia.Unwrap();
                return formulario;
            }
            catch(Exception erro)
            {
                throw new FormularioNaoEncontradoException();
            }
        }
    }
}
