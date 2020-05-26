using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuEstoque : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Estoque";
        public static EnumeradorMenuEstoque EstoqueEntrada = new EnumeradorMenuEstoque("Registra Entrada", "frmRegistraEntrada");
        public static EnumeradorMenuEstoque EmissaoEstoque = new EnumeradorMenuEstoque("Emissao do Estoque", "frmEmissaoDeEstoque");

        public EnumeradorMenuEstoque(string codigo, string descricao) : base(codigo, descricao) { }
    }
}
