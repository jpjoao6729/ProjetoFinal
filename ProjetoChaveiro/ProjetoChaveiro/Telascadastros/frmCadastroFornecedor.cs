
namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroFornecedor : frmBase
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Fornecedor";
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
