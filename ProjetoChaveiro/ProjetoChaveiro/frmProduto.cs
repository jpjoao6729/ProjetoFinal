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

        private void ctlPesquisaProduto1_Load(object sender, EventArgs e)
        {
            //var produtoSelecionado = ((ProdutoMV)bindingSource1.Current)?.Operador;
            //if (operadorSelecionado != null)
            //{
            //    var form = new frmCadastroOperador(operadorSelecionado);
            //    form.FormClosed += new FormClosedEventHandler((object s, FormClosedEventArgs evt) => {
            //        CarregueGDV();
            //    });
            //    form.Show();
            //}
        }
    }
}
