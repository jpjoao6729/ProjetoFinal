using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    class ItemOrdemDeServico : IObjeto
    {
        public int Codigo { get; set; }

        public string String()
        {
            return "Ordem de serviço";
        }
    }
}
