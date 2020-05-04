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
    public partial class frmAberturaCaixa : frmBase
    {
        public frmAberturaCaixa()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Caixa";
            lblNomeTela.Text = nameof(frmAberturaCaixa);
        }
    }
}
