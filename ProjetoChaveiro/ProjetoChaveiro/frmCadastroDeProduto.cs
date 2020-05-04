

namespace ProjetoChaveiro
{
    public partial class frmCadastroDeProduto : frmBase
    {
        public frmCadastroDeProduto()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Cadastro Produto";
            lblNomeTela.Text = nameof(frmCadastroDeProduto);

        }
    }
}
