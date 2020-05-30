using System;

namespace Core.Negocio.Exception
{
    public class FormularioNaoEncontradoException : SystemException
    {
        public FormularioNaoEncontradoException() : base("Tela não foi encontrada") { }
    }
}
