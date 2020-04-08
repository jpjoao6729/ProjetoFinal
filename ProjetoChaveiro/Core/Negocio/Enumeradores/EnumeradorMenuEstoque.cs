using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuEstoque : EnumeradorSeguro<int>
    {
        private static string NomeFuncao = "Estoque";
        public static EnumeradorMenuEstoque EstoqueEntrada = new EnumeradorMenuEstoque(1, "Registra Entrada");
        public static EnumeradorMenuEstoque EmissaoEstoque = new EnumeradorMenuEstoque(2, "Emissao do Estoque");

        public EnumeradorMenuEstoque(int codigo, string descricao) : base(codigo, descricao) { }
    }
}
