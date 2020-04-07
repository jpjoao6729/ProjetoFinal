using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuConfiguracoes : EnumeradorSeguro<int>
    {
        public static EnumeradorMenuConfiguracoes Sistema = new EnumeradorMenuConfiguracoes(1, "Configurações do Sistema");
        public static EnumeradorMenuConfiguracoes CadastroOperadores = new EnumeradorMenuConfiguracoes(2, "Cadastro operadores");

        public EnumeradorMenuConfiguracoes(int codigo, string descricao) : base(codigo, descricao) { }
    }
}
