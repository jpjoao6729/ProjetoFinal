
namespace ProjetoChaveiro
{
    public partial class frmCadastroDeFuncionario : frmBase
    {
        public frmCadastroDeFuncionario()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Cadstro Funcionario";
            lblNomeTela.Text = nameof(frmCadastroDeFuncionario);

        }
    }
}