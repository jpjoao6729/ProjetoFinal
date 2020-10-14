using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuConfiguracoes : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Configurações";
        public static EnumeradorMenuConfiguracoes CadastroDeFuncaoOperador = new EnumeradorMenuConfiguracoes("Cadastro de Funções de Operadores", "frmFuncoes");
        public static EnumeradorMenuConfiguracoes CadastroOperadores = new EnumeradorMenuConfiguracoes("Cadastro operadores", "frmPermissoes");
        public static EnumeradorMenuConfiguracoes Sistema = new EnumeradorMenuConfiguracoes("Configurações do Sistema", "frmConfiguracoes");

        public EnumeradorMenuConfiguracoes(string codigo, string descricao) : base(codigo, descricao) { }
    }
}
