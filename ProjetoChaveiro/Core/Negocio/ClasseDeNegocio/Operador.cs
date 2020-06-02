using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public class Operador : IObjeto
    {
        public string CPF;
        public Endereco Endereco;
        public Email Email;
        public Telefone Telefone;

        public object Codigo { get; set; }
        public string Nome { get; set; }

        public string String()
        {
            throw new NotImplementedException();
        }
    }
}
