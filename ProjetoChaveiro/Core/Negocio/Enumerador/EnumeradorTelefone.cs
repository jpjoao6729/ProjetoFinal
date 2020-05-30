using Core.Negocio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.Enumerador
{
    public class EnumeradorTelefone : EnumeradorSeguro<int>
    {
        public static EnumeradorTelefone Fixo = new EnumeradorTelefone(1, "Fixo");
        public static EnumeradorTelefone Celular = new EnumeradorTelefone(2, "Celular");
        public EnumeradorTelefone(int codigo, string descricao) : base(codigo, descricao) { }

    }
}
