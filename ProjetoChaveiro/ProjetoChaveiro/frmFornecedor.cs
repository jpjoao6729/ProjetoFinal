using Core.Negocio.ClasseDeNegocio;
using Core.Processo;
using ProjetoChaveiro.Telascadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoChaveiro
{
    public partial class frmFornecedor : frmBase
    {

        public frmFornecedor() : base()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Fornecedores";
            lblNomeTela.Text = nameof(frmFornecedor);
            AjusteGDV();
            CarregueGDV();
        }

        private void CarregueGDV()
        {
            var fornecedores = new ProcessoDeFornecedor().ObtenhaPorDescricao(inpDescricao.Text);
            if(fornecedores.Any())
            {
                bindingSource1.DataSource = fornecedores.Select(x => new FornecedorMV(x));
            }
        }

        private void AjusteGDV()
        {
            dataGridViewFacil1.CarregueBindSource(bindingSource1);
            dataGridViewFacil1.CrieCabecalho("Codigo", nameof(FornecedorMV.Codigo), 50);
            dataGridViewFacil1.CrieCabecalhoPreenchido("Nome", nameof(FornecedorMV.Nome));
            dataGridViewFacil1.CrieCabecalho("CPF/CNPJ", nameof(FornecedorMV.CPFCNPJ), 100);
            dataGridViewFacil1.DesabiliteHeader();
            dataGridViewFacil1.AtiveSelecaoPreechida();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroFornecedor();
            frm.FormClosed += new FormClosedEventHandler((object s, FormClosedEventArgs evt) =>
            {
                CarregueGDV();
            });
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            var fornecedorSelecionado = ((FornecedorMV)bindingSource1.Current)?.Fornecedor;
            if (fornecedorSelecionado != null)
            {
                var form = new frmCadastroFornecedor(fornecedorSelecionado);
                form.FormClosed += new FormClosedEventHandler((object s, FormClosedEventArgs evt) => {
                    CarregueGDV();
                });
                form.Show();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is FornecedorMV fornecedor)
            {
                try
                {
                    new ProcessoDeFornecedor().Apague(fornecedor.Fornecedor);
                    CarregueGDV();
                }
                catch (Exception erro)
                {
                    new PublicadorDeException(erro);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private class FornecedorMV
        {
            public Fornecedor Fornecedor { get; set; }
            public FornecedorMV(Fornecedor fornecedor)
            {
                Fornecedor = fornecedor;
            }
            public int Codigo => Fornecedor.Codigo;
            public string Nome => Fornecedor.Nome + "(" + Fornecedor.RazaoSocial + ")";
            public string CPFCNPJ => Fornecedor.CNPJ;


        }
    }
}
