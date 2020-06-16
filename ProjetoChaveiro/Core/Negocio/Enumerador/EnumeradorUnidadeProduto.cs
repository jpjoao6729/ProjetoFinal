using Core.Negocio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.Enumerador
{
    public class EnumeradorUnidadeProduto : EnumeradorSeguro<int>
    {
        public static EnumeradorUnidadeProduto Litro = new EnumeradorUnidadeProduto(1, "Litro");
        public static EnumeradorUnidadeProduto Quilo = new EnumeradorUnidadeProduto(2, "Quilo");
        public static EnumeradorUnidadeProduto Metro = new EnumeradorUnidadeProduto(3, "Métros");
        public static EnumeradorUnidadeProduto Quantidade = new EnumeradorUnidadeProduto(4, "Quantidade");

        public EnumeradorUnidadeProduto(int codigo, string descricao) : base(codigo, descricao) { }
        public override string ToString()
        {
            return base.Descricao;
        }
    }
}
