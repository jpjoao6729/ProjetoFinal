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

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroFornecedor();
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroFornecedor();
            frm.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
