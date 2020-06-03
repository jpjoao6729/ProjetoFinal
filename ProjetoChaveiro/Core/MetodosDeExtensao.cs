using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public static decimal ConvertaParaDecimal(this string valor)
        {
            if(decimal.TryParse(valor, out decimal valorConvertido))
            {
                return valorConvertido;
            }
            throw new Exception("Valor não pode ser convertido para decimal");
        }
    }
}
