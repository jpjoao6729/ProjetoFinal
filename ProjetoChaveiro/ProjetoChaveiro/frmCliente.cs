
using ProjetoChaveiro.Telascadastros;

namespace ProjetoChaveiro
{
    public partial class frmCliente : frmBase
    {
        public frmCliente()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Clientes";
            lblNomeTela.Text = nameof(frmCliente);
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            var form = new frmCadastroCliente();
            form.Show();
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            var form = new frmCadastroCliente();
            form.Show();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            //Chamar metodo de excluir no banco
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
