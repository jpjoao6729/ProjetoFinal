using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuEstoque : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Estoque";
        public static EnumeradorMenuEstoque MovimentacaoEstoque = new EnumeradorMenuEstoque("Movimentações estoque", "frmMovimentacoesEstoque");
        public static EnumeradorMenuEstoque EmissaoEstoque = new EnumeradorMenuEstoque("Emissao do Estoque", "frmEmissaoDeEstoque");

        public EnumeradorMenuEstoque(string codigo, string descricao) : base(codigo, descricao) { }
    }
}
