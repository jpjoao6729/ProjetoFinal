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
using Core.Processo;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var endereco = new ProcessoDeEndereco().Pesquise(mkCEP.Text);
                mkCEP.Text = endereco.CEP;
                inpCidade.Text = endereco.Cidade;
                inpLogradouro.Text = endereco.Logradouro;
                inpBairro.Text = endereco.Bairro;
                inpComplemento.Text = endereco.Complemento;
                ctlUF1.SelecioneUF(endereco.UF);
            }
            catch(Exception er)
            {
                new PublicadorDeException(er);
            }

        }

        internal void CarregueEndereco(Endereco endereco)
        {
            mkCEP.Text = endereco.CEP;
            inpCidade.Text = endereco.Cidade;
            inpLogradouro.Text = endereco.Logradouro;
            inpBairro.Text = endereco.Bairro;
            inpComplemento.Text = endereco.Complemento;
            ctlUF1.SelecioneUF(endereco.UF);
        }
    }
}
