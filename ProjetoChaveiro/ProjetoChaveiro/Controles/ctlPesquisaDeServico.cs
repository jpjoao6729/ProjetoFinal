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

namespace ProjetoChaveiro.Controles
{
    public partial class ctlPesquisaDeServico : UserControl
    {
        private class ServicoMV
        {
            public Servico Servico { get; set; }
            public ServicoMV(Servico servico)
            {
                Servico = servico;
            }
            public int Codigo => Servico.Codigo;
            public string Descricao => Servico.Descricao;
            public string ValorProduto => Servico.Preco.ToString("0.00");
        }
        private BindingSource _bs;
        public ctlPesquisaDeServico()
        {
            InitializeComponent();

            CarregueDGV();
            CarregueServicos();
            CarregueEventos();
        }

        private void CarregueDGV()
        {
            _bs = new BindingSource();
            dgvProdutos.CarregueBindSource(_bs);
            dgvProdutos.CrieCabecalho("Codigo", nameof(ServicoMV.Codigo), 50);
            dgvProdutos.CrieCabecalho("Descrição", nameof(ServicoMV.Descricao), 150);
            dgvProdutos.CrieCabecalho("Valor", nameof(ServicoMV.ValorProduto), 232);
            dgvProdutos.DesabiliteHeader();
        }
        public void AdicioneBaingSource(BindingSource bs)
        {
            _bs = bs;
        }
        private void CarregueServicos()
        {
            var servicos = new ProcessoDeServico().ObtenhaPorDescricao(inpDescricao.Text);
            _bs.DataSource = servicos.Select(x => new ServicoMV(x));
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
            var form = new frmCadastroServico();
            form.Show();
        }

        private void AbraFormularioNovo()
        {
            var form = new frmCadastroServico();
            form.FormClosing += (object obj, FormClosingEventArgs evt) => { CarregueServicos(); };
            form.Show();
        }

        private void ExcluaProduto()
        {
            var servicoSelecionado = ((ServicoMV)_bs.Current)?.Servico;
            if (servicoSelecionado != null)
            {
                try
                {
                    if (MessageBox.Show("Deseja Excluir o serviço selecionado?", "Sucesso.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        new ProcessoDeServico().Exclua(servicoSelecionado);
                    }
                }

                catch (Exception erro)
                {
                    new PublicadorDeException(erro);
                }
                finally
                {
                    CarregueServicos();
                }
            }
        }



        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void inpDescricao_TextChanged(object sender, EventArgs e)
        {
            CarregueServicos();
        }

        private void editar(object sender, EventArgs e)
        {
            CarregueServicos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
