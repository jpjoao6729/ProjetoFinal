using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class MetodosDeExtensao
    {
        public static int ConvertaParaInt(this string valor)
        {
            if(int.TryParse(valor, out int valorConvertido))
            {
                return valorConvertido;
            }
            throw new Exception("Valor não pode ser convertido para int");
        }
    }
}
