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

        public Dictionary<string, FieldInfo[]> ObtenhaOpcoes()
        {
            var propriedades = typeof(MenuAplicacao).GetFields();
            var dicionario = new Dictionary<string, FieldInfo[]>();
            foreach (var propriedade in propriedades)
            {
                var nome = propriedade.FieldType.GetFields(BindingFlags.NonPublic | BindingFlags.Static)[0].GetValue(null);
                var subMenus = propriedade.FieldType.GetFields(BindingFlags.Static | BindingFlags.Public);
                dicionario.Add(nome.ToString(), subMenus);
            }

            return dicionario;
        }

    }
}
