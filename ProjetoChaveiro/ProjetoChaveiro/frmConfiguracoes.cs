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
    public partial class frmConfiguracoes : frmBase
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Configurações do Sistema";
            lblNomeTela.Text = nameof(frmConfiguracoes);
        }
    }
}
