using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public class Email
    {
        public string Texto { get; set; }
        public string ToString()
        {
            return $"{Texto}";
        }
    }
}
