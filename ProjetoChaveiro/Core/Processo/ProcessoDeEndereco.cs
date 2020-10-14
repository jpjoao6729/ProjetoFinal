using Core.Negocio.ClasseDeNegocio;
using Core.Negocio.Exception;
using Core.Negocio.Tradutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Processo
{
    public class ProcessoDeEndereco
    {
        private static string _endPoint = "https://viacep.com.br/ws";
        private static string _tipoResposta = "json";
        public Endereco Pesquise(string cep)
        {
            try
            {
                var endPoint = $@"{_endPoint}/{cep}/{_tipoResposta}";

                var wc = new WebClient();
                var resposta = wc.DownloadString(endPoint);

                var endereco = (Newtonsoft.Json.JsonConvert.DeserializeObject<TradutorEndereco>(resposta)).Converta();
                return endereco;
            }
            catch(Exception ex)
            {
                throw new EnderecoNaoEncontradoException();
            }

        }
    }
}
