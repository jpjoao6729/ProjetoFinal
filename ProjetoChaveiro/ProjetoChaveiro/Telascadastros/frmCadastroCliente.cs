using Core;
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

        public frmCadastroCliente(ClienteAbstrato cliente)
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Edição de Clientes";
            CarregueDadosCliente(cliente);
        }

        private void CarregueDadosCliente(ClienteAbstrato cliente)
        {
            if(cliente is PessoaFisica fisica)
            {
                rbFisico.Checked = true;
                rbJuridico.Checked = false;
                lblCpfCnpj.Text = "CPF";
                mkCpfCnpj.Mask = "000-000-000.00";
                mkCpfCnpj.Text = fisica.CPF;
                inpRazaoSocial.Enabled = false;
            }
            else if(cliente is PessoaJuridica juridica)
            {
                rbFisico.Checked = false;
                rbJuridico.Checked = true;
                lblCpfCnpj.Text = "CNPJ";
                mkCpfCnpj.Text = juridica.CNPJ;
                mkCpfCnpj.Mask = "00.000.000/0000-00";
                inpRazaoSocial.Text = juridica.RazaoSocial;
            }
            inpCodigo.Text = cliente.Codigo.ToString();
            inpNome.Text = cliente.Nome;
            ctlEndereco1.CarregueEndereco(cliente.Endereco);
            ctlTelefone1.CarregueTelefone(cliente.Telefone);
            ctlEmail1.CarregueEmail(cliente.Email);
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

        private ClienteAbstrato CrieCliente()
        {
            ClienteAbstrato pessoa;
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
            pessoa.Codigo = inpCodigo.Text.ConvertaParaInt();
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
                MessageBox.Show("Nome vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if(rbFisico.Checked)
            {
                if(mkCpfCnpj.Text == "___-___-___.__")
                {
                    MessageBox.Show("Campo CPF vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else 
            {
                if (mkCpfCnpj.Text == "__.___.___/____-__")
                {
                    MessageBox.Show("Campo CNPJ vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(inpRazaoSocial.Text == "")
                {
                    MessageBox.Show("Razão social Vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if(!ctlEndereco1.EhValido())
            {
                MessageBox.Show("Endereço inválido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(!ctlTelefone1.EhValido())
            {
                MessageBox.Show("Telefone inválido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(!ctlEmail1.EhValido())
            {
                MessageBox.Show("E-mail inválido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
