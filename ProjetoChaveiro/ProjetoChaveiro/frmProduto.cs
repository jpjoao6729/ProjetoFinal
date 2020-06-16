using Core.Processo;
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
    }
}
