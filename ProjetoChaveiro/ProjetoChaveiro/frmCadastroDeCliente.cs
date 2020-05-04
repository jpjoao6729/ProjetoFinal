
namespace ProjetoChaveiro
{
    public partial class frmCadastroDeCliente : frmBase
    {
        public frmCadastroDeCliente()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Cadastro de Clientes";
            lblNomeTela.Text = nameof(frmCadastroDeCliente);
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
