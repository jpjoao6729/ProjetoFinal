using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorSeguro<T>
    {
        public T Codigo;
        public string Descricao;
        public EnumeradorSeguro(T chave, string descricao)
        {
            Codigo = chave;
            Descricao = descricao;
        }

        public static IEnumerable<Enumerador> ObtenhaTodos<Enumerador>()
        {
            var tipo = typeof(Enumerador);
            return tipo.GetFields(BindingFlags.Static | BindingFlags.Public).Select(campo => (Enumerador)campo.GetValue(null)).ToList();
        }

        public static Enumerador Obtenha<Enumerador>(int codigo) where Enumerador : EnumeradorSeguro<T>
        {
            var propriedades = ObtenhaTodos<Enumerador>();
            return propriedades.Where(x => x.Codigo.Equals(codigo)).FirstOrDefault();
        }

        public static Enumerador Obtenha<Enumerador>(string codigo) where Enumerador : EnumeradorSeguro<T>
        {
            var propriedades = ObtenhaTodos<Enumerador>();
            return propriedades.Where(x => x.Codigo.Equals(codigo)).FirstOrDefault();
        }

    }
}
