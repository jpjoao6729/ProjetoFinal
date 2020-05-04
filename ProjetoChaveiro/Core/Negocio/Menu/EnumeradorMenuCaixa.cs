using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuCaixa : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Financeiro";
        public static EnumeradorMenuCaixa Caixa = new EnumeradorMenuCaixa("Caixa", "frmCaixa");
        public static EnumeradorMenuCaixa AberturaCaixa = new EnumeradorMenuCaixa("Abertura Caixa", "frmAberturaDoCaixa");
        public static EnumeradorMenuCaixa EmissaoCaixa = new EnumeradorMenuCaixa("Relatorios Caixa", "frmRelatorioCaixa");


        public EnumeradorMenuCaixa(string codigo, string descricao) : base(codigo, descricao) { }
    }
}
