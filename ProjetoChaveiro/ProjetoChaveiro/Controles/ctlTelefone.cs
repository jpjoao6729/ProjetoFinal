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
using Core.Negocio.Enumerador;

namespace ProjetoChaveiro.Controles
{
    public partial class ctlTelefone : UserControl
    {
        public ctlTelefone()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            inpNumero.Text = "";
            inpDDD.Text = "";
            inpNumero.Mask = "0000-0000";
                
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            inpNumero.Text = "";
            inpDDD.Text = "";
            inpNumero.Mask = "00000-0000";
        }

        internal bool EhValido()
        {
            if (inpDDD.Text.Contains("_")) return false;
            if (inpNumero.Text.Contains("_")) return false;
            if (rbCelular.Checked && inpNumero.Text[0] != '9') return false;

            return true;
        }

        internal Telefone ObtenhaTelefone()
        {
            return new Telefone()
            {
                DDD = inpDDD.Text,
                Numero = inpNumero.Text,
                Tipo = rbCelular.Checked ? EnumeradorTelefone.Celular : EnumeradorTelefone.Fixo
            };

        }

        internal void CarregueTelefone(Telefone telefone)
        {
            inpDDD.Text = telefone.DDD;
            inpNumero.Text = telefone.Numero;
            rbCelular.Checked = telefone.Tipo == EnumeradorTelefone.Celular;
            rbFixo.Checked = telefone.Tipo == EnumeradorTelefone.Fixo;
        }
    }
}
