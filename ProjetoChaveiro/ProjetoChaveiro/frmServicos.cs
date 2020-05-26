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
    public partial class frmServicos : frmBase
    {
        public frmServicos()
        {
            InitializeComponent();
            CarregueEventos();
            lblNomeFuncao.Text = "Serviços";
        }
        private void CarregueEventos()
        {
            pesquisaDeServico1.btnSair.Click += (object sender, EventArgs e) => { Close(); };
        }
    }
}
