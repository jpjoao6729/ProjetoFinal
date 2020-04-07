using Core.Negocio.Menu;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ProjetoChaveiro
{
    public partial class frmPrincipal : Form
    {
        private MenuAplicacao _menu = new MenuAplicacao();
        public frmPrincipal()
        { 
            InitializeComponent();
            CarregaMenu();
        }

        private void CarregaMenu()
        {
            var opcoesDomenu = _menu.ObtenhaOpcoes();
            foreach(var menu in opcoesDomenu)
            {
                
            }

        }

        private void saierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AbraFormulario(object sender, EventArgs e)
        {

        }
    }
}
