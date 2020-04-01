using System;
using System.Windows.Forms;

namespace ProjetoChaveiro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void saierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
