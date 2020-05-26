namespace Core.Negocio.Enumeradores
{
    public class EnumeradorMenuOrdemServico : EnumeradorSeguro<string>
    {
        private static string NomeFuncao = "Ordem De Serviço";
        public static EnumeradorMenuOrdemServico OrdemDeServico = new EnumeradorMenuOrdemServico("Nova Ordem de Serviços", "frmNovaOrdemDeServico");
        public EnumeradorMenuOrdemServico(string codigo, string descricao) : base(codigo, descricao) { }
    }
}
