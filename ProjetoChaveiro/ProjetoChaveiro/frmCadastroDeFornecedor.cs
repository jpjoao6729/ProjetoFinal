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
    public partial class frmCadastroDeFornecedor : frmBase
    {
        public frmCadastroDeFornecedor() : base()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Fornecedores";
            lblNomeTela.Text = nameof(frmCadastroDeFornecedor);

        }

        private void ctlTelefone1_Load(object sender, EventArgs e)
        {

        }

        private void lblNomeTela_Click(object sender, EventArgs e)
        {

        }
    }
}
