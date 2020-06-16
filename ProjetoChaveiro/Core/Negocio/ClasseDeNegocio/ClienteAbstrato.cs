using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public abstract class ClienteAbstrato 
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public Email Email { get; set; }
        public int Codigo { get ; set ; }

        public string String()
        {
            return $"{Codigo} - {Nome}";
        }
    }
}
