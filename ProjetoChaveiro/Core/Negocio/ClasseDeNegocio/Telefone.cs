using Core.Negocio.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public class Telefone
    {
        public EnumeradorTelefone Tipo { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public string ToString()
        {
            return $"{DDD}{Numero}";
        }
    }
}
