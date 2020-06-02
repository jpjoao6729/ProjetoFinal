using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public class Fornecedor : IObjeto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
        public Email Email { get; set; }
        public Telefone Telefone { get; set; }

        
        public string String()
        {
            //mano vamos continuar depois
            throw new NotImplementedException();
        }
    }
}
