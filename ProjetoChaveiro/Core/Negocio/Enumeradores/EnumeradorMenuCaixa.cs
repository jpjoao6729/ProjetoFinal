using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuCaixa : EnumeradorSeguro<int>
    {
        private static string NomeFuncao = "Financeiro";
        public static EnumeradorMenuCaixa Caixa = new EnumeradorMenuCaixa(6, "Caixa");
        public static EnumeradorMenuCaixa AberturaCaixa = new EnumeradorMenuCaixa(7, "Abertura Caixa");
        public static EnumeradorMenuCaixa EmissaoCaixa = new EnumeradorMenuCaixa(8, "Relatorios Caixa");


        public EnumeradorMenuCaixa(int codigo, string descricao) : base(codigo, descricao) { }
    }
}
