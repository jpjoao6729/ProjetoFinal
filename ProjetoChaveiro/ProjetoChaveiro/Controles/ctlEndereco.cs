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
    public partial class ctlEndereco : UserControl
    {
        public ctlEndereco()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        internal bool EhValido()
        {
            if (mkCEP.Text.Contains("_")) return false;
            if(inpCidade.Text == "") return false;
            if (inpLogradouro.Text == "") return false;
            if (inpComplemento.Text == "") return false;
            if (inpBairro.Text == "") return false;
            return true;
        }

        internal Endereco ObtenhaEndereco()
        {
            return new Endereco()
            {
                CEP = mkCEP.Text,
                Cidade = inpCidade.Text,
                Logradouro = inpLogradouro.Text,
                Bairro = inpBairro.Text,
                Complemento = inpComplemento.Text,
                UF = ctlUF1.ObtenhaUF()
            };
        }
    }
}
