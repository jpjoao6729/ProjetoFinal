using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.Tradutor
{
    public class TradutorEndereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }

        public Endereco Converta()
        {
            return new Endereco()
            {
                CEP = cep.RemovaCharEspeciais(),
                Cidade = localidade.RemovaCharEspeciais(),
                Logradouro = logradouro.RemovaCharEspeciais(),
                Complemento = complemento.RemovaCharEspeciais(),
                Bairro = bairro.RemovaCharEspeciais(),
                UF = EnumeradorUF.Obtenha< EnumeradorUF >(uf)
            };

        }
    }
}
