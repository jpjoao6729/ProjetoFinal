using ProjetoChaveiro.TelasComplementares;
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
    public partial class frmNovaOrdemDeServico : frmBase
    {
        private class itemVM
        {
            public itemVM()
            {

            }
            public string Descricao { get; set; }
            public int Quantidade { get; set; }
            public decimal ValorItem { get; set; }
        }

        public frmNovaOrdemDeServico()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Ordem de serviço";
            lblNomeTela.Text = nameof(frmNovaOrdemDeServico);
            ConfigureDGV();
           
        }

        private void ConfigureDGV()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AdicionaProduto
            var frm = new frmSelecaoProdutos();
            frm.AtribuaEvento(new DataGridViewCellEventHandler((object obj, DataGridViewCellEventArgs evt) => {

                frm.Close();
            }));
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AdicionaServico
            var frm = new frmSelecaoServicos();
            frm.AtribuaEvento(new DataGridViewCellEventHandler((object obj, DataGridViewCellEventArgs evt) => {

                frm.Close();
            }));
            frm.Show();
        }
    }
}
