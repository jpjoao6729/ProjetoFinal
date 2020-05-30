using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public class PessoaFisica : ICliente
    {
        public string CPF { get; set; }

        public string String()
        {
            return $"{Nome} - {CPF}";
        }
    }
}
