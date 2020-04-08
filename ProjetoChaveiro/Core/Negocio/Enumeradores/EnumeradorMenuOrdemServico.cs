namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuOrdemServico : EnumeradorSeguro<int>
    {
        private static string NomeFuncao = "Ordem De Serviço";
        public static EnumeradorMenuOrdemServico OrdemDeServico = new EnumeradorMenuOrdemServico(1, "Nova Ordem de Serviços");
        public EnumeradorMenuOrdemServico(int codigo, string descricao) : base(codigo, descricao) {}
    }
}
