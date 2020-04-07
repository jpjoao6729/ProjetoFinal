using Core.Negocio.Enumeradores;
using System.Reflection;
using System.Collections.Generic;
using System;

namespace Core.Negocio.Menu
{
    public class MenuAplicacao
    {
        public static EnumeradorMenuCadastro _menuCadastro;
        public static EnumeradorMenuEstoque _menuEstoque;
        public static EnumeradorMenuCaixa _menuCaixa;
        public static EnumeradorMenuOrdemServico _menuOrdemDeServico;
        public static EnumeradorMenuConfiguracoes _menuConfiguracoes;

        public Dictionary<Type, FieldInfo[]> ObtenhaOpcoes()
        {
            var propriedades = typeof(MenuAplicacao).GetFields();
            var dicionario = new Dictionary<Type, FieldInfo[]>();
            foreach (var propriedade in propriedades)
            {
                var instancia = propriedade.FieldType.GetFields(BindingFlags.Static | BindingFlags.Public);
                dicionario.Add(propriedade.FieldType, instancia);
            }

            return dicionario;
        }

    }
}
