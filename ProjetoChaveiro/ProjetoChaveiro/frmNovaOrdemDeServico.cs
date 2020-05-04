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
    public partial class frmNovaOrdemDeServico : frmBase
    {
        public frmNovaOrdemDeServico()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Ordem de serviço";
            lblNomeTela.Text = nameof(frmNovaOrdemDeServico);
        }
    }
}
