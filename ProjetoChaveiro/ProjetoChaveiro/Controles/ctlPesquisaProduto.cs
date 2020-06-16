using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoChaveiro.Telascadastros;
using Core.Processo;
using Core.Negocio.ClasseDeNegocio;

namespace ProjetoChaveiro.Controles
{
    public partial class ctlPesquisaProduto : UserControl
    {
        private class ProdutoMV
        {
            private Produto _produto;
            public ProdutoMV(Produto produto)
            {
                _produto = produto;
            }
            public int Codigo => _produto.Codigo;
            public string Descricao => _produto.Descricao;
            public decimal ValorProduto => _produto.Valor;
        }

        private BindingSource _bs;

        public ctlPesquisaProduto()
        {
            InitializeComponent();

            CarregueDGV();
            CarregueDadosProdutos();
            CarregueEventos();
        }

        private void CarregueDGV()
        {
            _bs = new BindingSource();
            dgvProdutos.CarregueBindSource(_bs);
            dgvProdutos.CrieCabecalho("Codigo", nameof(ProdutoMV.Codigo), 50);
            dgvProdutos.CrieCabecalhoPreenchido("Descrição", nameof(ProdutoMV.Descricao));
            dgvProdutos.CrieCabecalho("Valor", nameof(ProdutoMV.ValorProduto), 232);
            dgvProdutos.DesabiliteHeader();
        }

        public void AdicioneBaingSource(BindingSource bs)
        {
            _bs = bs;
        }
        public void CarregueDadosProdutos()
        {
            var produtos = new ProcessoDeProduto().ObtenhaPorDescricao(inpDescricao.Text);
            _bs.DataSource = produtos.Select(x => new ProdutoMV(x));
        }

        public void AdicioneEvento(DataGridViewCellEventHandler eventoDeSelecao)
        {
            this.dgvProdutos.AdicioneEvent(eventoDeSelecao);          
        }
        private void CarregueEventos()
        {
            btnNovo.Click += (object sender, EventArgs e) => { AbraFormularioNovo(); };
            btnExcluir.Click += (object sender, EventArgs e) => { ExcluaProduto(); };
            button3.Click += (object sender, EventArgs e) => { AbraFormularioEditar(); };

        }

        private void AbraFormularioEditar()
        {
            var form = new frmCadastroDeProduto();
            form.Show();
        }

        private void AbraFormularioNovo()
        {
            var form = new frmCadastroDeProduto();
            form.Show();
            form.FormClosing += (object obj, FormClosingEventArgs evt) => { CarregueDadosProdutos(); };
        }

        private void ExcluaProduto()
        {
            //Apagar no banco
        }

        private void inpDescricao_TextChanged(object sender, EventArgs e)
        {
            CarregueDadosProdutos();
        }
    }
}
