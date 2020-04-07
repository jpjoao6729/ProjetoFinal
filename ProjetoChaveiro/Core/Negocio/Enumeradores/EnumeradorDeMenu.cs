namespace Core.Negocio.Enumeradores
{
    public class EnumeradorDeMenu : EnumeradorSeguro<int>
    {
        public static EnumeradorDeMenu CadastroDeProduto = new EnumeradorDeMenu(1,"Cadastro de Produtos");
        public static EnumeradorDeMenu CadastroDeCliente = new EnumeradorDeMenu(2, "Cadastro de Clientes");
        public static EnumeradorDeMenu CadastroDeFornecedores = new EnumeradorDeMenu(3, "Cadastro de Fornecedores");
        public static EnumeradorDeMenu EstoqueEntrada = new EnumeradorDeMenu(4, "Registra Entrada");
        public static EnumeradorDeMenu EmissaoEstoque = new EnumeradorDeMenu(5, "Emissao do Estoque");
        public static EnumeradorDeMenu Caixa = new EnumeradorDeMenu(6, "Caixa");
        public static EnumeradorDeMenu AberturaCaixa = new EnumeradorDeMenu(7, "Abertura Caixa");
        public static EnumeradorDeMenu EmissaoCaixa = new EnumeradorDeMenu(8, "Relatorios Caixa");
        public static EnumeradorDeMenu OrdemDeServico = new EnumeradorDeMenu(9, "Nova Ordem de Serviços");
        public static EnumeradorDeMenu Sistema = new EnumeradorDeMenu(10, "Configurações do Sistema");
        public static EnumeradorDeMenu CadastroOperadores = new EnumeradorDeMenu(11, "Cadastro operadores");
        public static EnumeradorDeMenu Sair = new EnumeradorDeMenu(12, "Sair");

        public EnumeradorDeMenu(int codigo, string descricao) : base(codigo, descricao){ }
    }
}
