using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Negocio.ClasseDeNegocio;

namespace ProjetoChaveiro.Controles
{
    public partial class ctlEmail : UserControl
    {
        public ctlEmail()
        {
            InitializeComponent();
        }

        internal bool EhValido()
        {
            return true;
        }

        internal Email ObtenhaEmail()
        {
            return new Email()
            {
                Texto = inpEmail.Text
            };

        }
    }
}
