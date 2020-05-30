using ProjetoChaveiro.Telascadastros;
using System;

namespace ProjetoChaveiro
{
    public partial class frmProduto : frmBase
    {
        public frmProduto()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Produtos";
            lblNomeTela.Text = nameof(frmProduto);
            CarregueEventos();

        }
    

        private void CarregueEventos()
        {
            ctlPesquisaProduto1.btnSair.Click += (object sender, EventArgs e) => { Close(); };
        }

        

        private void frmCadastroProdutos_Load(object sender, System.EventArgs e)
        {

        }

        private void lblNomeFuncao_Click(object sender, EventArgs e)
        {

        }
    }
}
