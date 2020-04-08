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
            IsMdiContainer = true;
            CarregaMenu();
        }

        private void CarregaMenu()
        {

            //var toolStripContainer1 = new ToolStripMenuItem();
            //var toolStrip1 = new ToolStripMenuItem();
            //toolStrip1.DropDownItems.Add("One");

            //toolStripContainer1.DropDownItems.Add(toolStrip1);


            //menuStrip1.Items.Add(toolStripContainer1);



            var opcoesDomenu = _menu.ObtenhaOpcoes();
            
            foreach (var menu in opcoesDomenu)
            {
                var tsMenu = new ToolStripMenuItem();
                tsMenu.Text = menu.Key;
                foreach (var subMenu in menu.Value)
                {
                    var tsSubMenu = new ToolStripMenuItem();
                    tsSubMenu.Text = tsSubMenu.Name;// subMenu.GetValue("");
                    tsSubMenu.Click += AbraFormulario;

                    tsMenu.DropDownItems.Add(tsSubMenu);
                }
                menuStrip1.Items.Add(tsMenu);
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
