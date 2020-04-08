namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuCadastro : EnumeradorSeguro<int>
    {
        private static string NomeFuncao = "Cadastros";
        public static EnumeradorMenuCadastro CadastroDeProduto = new EnumeradorMenuCadastro(1,"Cadastro de Produtos");
        public static EnumeradorMenuCadastro CadastroDeCliente = new EnumeradorMenuCadastro(2, "Cadastro de Clientes");
        public static EnumeradorMenuCadastro CadastroDeFornecedores = new EnumeradorMenuCadastro(3, "Cadastro de Fornecedores");

        public EnumeradorMenuCadastro(int codigo, string descricao) : base(codigo, descricao){ }
    }
}
