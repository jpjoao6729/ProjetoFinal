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
    public partial class frmMovimentacoesEstoque : frmBase
    {
        private class EntradaMV
        { 
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public int QdteEstoque { get; set; }
            public int QtdeEntrada { get; set; }
        }

        public frmMovimentacoesEstoque()
        {
            InitializeComponent();
            CarregueDGV();
            MetodoComplementar();
            base.lblNomeFuncao.Text = "Movimentações Estoque";
            lblNomeTela.Text = nameof(frmMovimentacoesEstoque);
        }

        private void MetodoComplementar()
        {
            //dgvProdutos.ReadOnly = true;
            var item = new EntradaMV()
            {
                Codigo = 1,
                Descricao = "Chave grande",
                QdteEstoque = 0,
                QtdeEntrada = 15
            };

            //dgvProdutos.DataSource = new List<ProdutoMV>() { item };
        }
        private void CarregueDGV()
        {
            dataGridViewFacil1.CrieCabecalho("Codigo", nameof(EntradaMV.Codigo), 45);
            dataGridViewFacil1.CrieCabecalhoPreenchido("Descrição", nameof(EntradaMV.Codigo));
            dataGridViewFacil1.CrieCabecalho("Qtde Estoque", nameof(EntradaMV.Codigo), 50);
            dataGridViewFacil1.CrieCabecalho("Qtde Entrada", nameof(EntradaMV.Codigo), 50);
            dataGridViewFacil1.DesabiliteHeader();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frm = new frmEntradaEstoque();
            frm.Show();
        }
    }
}
