using Core.Negocio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using 


namespace ProjetoChaveiro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        { 
            InitializeComponent();
            var enumeradorDeMenu = EnumeradorDeMenu.ObtenhaTodos<EnumeradorDeMenu>();
            CarregueDicionario();
        }

        private void CarregueDicionario()
        {
            var dicionarioMenu = new Dictionary<string, string>();

        }

        private void saierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
