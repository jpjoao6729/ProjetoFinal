using Core.Negocio.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public class Produto : IObjeto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal PrecoVenda { get; set; }
        public EnumeradorUnidadeProduto Unidade { get; set; }
        public bool Ativo { get; set; }
        public string String()
        {
            throw new NotImplementedException();
        }
    }
}
