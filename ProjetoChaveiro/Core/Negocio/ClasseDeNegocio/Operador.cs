using System;

namespace Core.Negocio.ClasseDeNegocio
{
    public class Operador : IObjeto
    {
        public string CPF;
        public Endereco Endereco;
        public Email Email;
        public Telefone Telefone;
        public Funcao Funcao { get; set; }

        public int Codigo { get; set; }
        public string Nome { get; set; }

        public string String()
        {
            throw new NotImplementedException();
        }
    }
}
