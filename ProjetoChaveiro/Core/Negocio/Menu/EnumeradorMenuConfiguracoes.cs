using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuConfiguracoes : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Configurações";
        public static EnumeradorMenuConfiguracoes Sistema = new EnumeradorMenuConfiguracoes("Configurações do Sistema", "frmConfiguracoes");
        public static EnumeradorMenuConfiguracoes CadastroOperadores = new EnumeradorMenuConfiguracoes("Cadastro operadores", "frmCadastroOperadores");

        public EnumeradorMenuConfiguracoes(string codigo, string descricao) : base(codigo, descricao) { }
    }
}
