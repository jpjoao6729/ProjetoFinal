namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuCadastro : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Cadastros";
        public static EnumeradorMenuCadastro CadastroDeProduto = new EnumeradorMenuCadastro("Cadastro de Produtos", "frmCadastroDeProduto");
        public static EnumeradorMenuCadastro CadastroDeCliente = new EnumeradorMenuCadastro("Cadastro de Clientes", "frmCadastroDeCliente");
        public static EnumeradorMenuCadastro CadastroDeFornecedores = new EnumeradorMenuCadastro("Cadastro de Fornecedores", "frmCadastroDeFornecedor");

        public EnumeradorMenuCadastro(string codigo, string descricao) : base(codigo, descricao){ }
    }
}
