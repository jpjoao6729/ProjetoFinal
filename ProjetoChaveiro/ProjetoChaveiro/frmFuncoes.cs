using Core;
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
    public partial class frmFuncoes : frmBase
    {
        private class FuncoesMV
        {
            public Funcao Funcao { get; set; }
            public FuncoesMV(Funcao funcao)
            {
                Funcao = funcao;
            }
            public int Codigo => Funcao.Codigo;
            public string Descricao => Funcao.Descricao;
                
        }
        public frmFuncoes()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Funcões";
            CarregueDGV();
            this.textBox1_TextChanged(null, null);
        }

        private void CarregueDGV()
        {
            dataGridViewFacil1.CarregueBindSource(bindingSource1);
            dataGridViewFacil1.CrieCabecalho("Codigo", nameof(FuncoesMV.Codigo), 40);
            dataGridViewFacil1.CrieCabecalhoPreenchido("Descricao", nameof(FuncoesMV.Descricao));
            dataGridViewFacil1.DesabiliteHeader();
            dataGridViewFacil1.AtiveSelecaoPreechida();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncao();
            form.FormClosed += new FormClosedEventHandler((object s, FormClosedEventArgs evt) => {
                textBox1_TextChanged(null,null);
            });
            form.Show();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var funcoes = new ProcessoDeFuncao().ObtenhaporDescricao(inpDescricao.Text);
            bindingSource1.DataSource = funcoes.Select(x => new FuncoesMV(x));
        }
    }
}
