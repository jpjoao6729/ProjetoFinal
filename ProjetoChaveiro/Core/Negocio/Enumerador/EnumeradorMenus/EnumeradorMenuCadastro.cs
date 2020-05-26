namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuCadastro : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Cadastros";
        public static EnumeradorMenuCadastro CadastroDeCliente = new EnumeradorMenuCadastro("Cadastro de Clientes", "frmCliente");
        public static EnumeradorMenuCadastro CadastroDeFornecedores = new EnumeradorMenuCadastro("Cadastro de Fornecedores", "frmFornecedor");
        public static EnumeradorMenuCadastro CadastroDeOperador = new EnumeradorMenuCadastro("Cadastro de Operador", "frmOperador");
        public static EnumeradorMenuCadastro CadastroDeProduto = new EnumeradorMenuCadastro("Cadastro de Produtos", "frmProduto");
        public static EnumeradorMenuCadastro CadastroDeServico = new EnumeradorMenuCadastro("Cadastro de Serviço", "frmServicos");

        public EnumeradorMenuCadastro(string codigo, string descricao) : base(codigo, descricao) { }
    }
}
