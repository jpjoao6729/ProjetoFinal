using Core.Negocio.ClasseDeNegocio;
using Core.Processo;
using System;
using System.Windows.Forms;

namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroCliente : frmBase
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Clientes";
            inpCodigo.Text = new ProcessoDeCliente().ObtenhaProximoCodigo().ToString();
            inpRazaoSocial.Enabled = false;
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!PodeSalvaCliente()) return;
            var cliente = CrieCliente();
            try
            {
                new ProcessoDeCliente().SalveNoBanco(cliente);
                MessageBox.Show("Cliente Salvo com sucesso.", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception erro)
            {
                var publicadorDeExceccoes = new PublicadorDeException(erro);
            }
        }

        private ICliente CrieCliente()
        {
            ICliente pessoa;
            if(rbFisico.Checked)
            {
                pessoa = new PessoaFisica()
                { 
                    CPF = mkCpfCnpj.Text
                };
            }
            else
            {
                pessoa = new PessoaJuridica()
                { 
                    CNPJ = mkCpfCnpj.Text,
                    RazaoSocial = inpRazaoSocial.Text
                };
            }

            pessoa.Nome = inpNome.Text;
            pessoa.Endereco = ctlEndereco1.ObtenhaEndereco();
            pessoa.Telefone = ctlTelefone1.ObtenhaTelefone();
            pessoa.Email = ctlEmail1.ObtenhaEmail();
            return pessoa;
        }

        private bool PodeSalvaCliente()
        {
            if (inpNome.Text == "")
            {
                return false;
            }


            if(rbFisico.Checked)
            {
                if(mkCpfCnpj.Text == "___-___-___.__")
                {
                    return false;
                }
            }
            else 
            {
                if (mkCpfCnpj.Text == "__.___.___/____-__")
                {
                    return false;
                }
                if(inpRazaoSocial.Text == "")
                {
                    return false;
                }
            }

            if(!ctlEndereco1.EhValido())
            {
                return false;
            }

            if(!ctlTelefone1.EhValido())
            {
                return false;
            }

            if(!ctlEmail1.EhValido())
            {
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Realmente cancelar?","Pergunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            inpRazaoSocial.Text = "";
            inpRazaoSocial.Enabled = false;
            lblCpfCnpj.Text = "CPF:";
            mkCpfCnpj.Text = "";
            mkCpfCnpj.Mask = "000-000-000.00";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            inpRazaoSocial.Enabled = true;
            lblCpfCnpj.Text = "CNPJ:";
            mkCpfCnpj.Text = "";
            mkCpfCnpj.Mask = "00.000.000/0000-00";

        }
    }
}
