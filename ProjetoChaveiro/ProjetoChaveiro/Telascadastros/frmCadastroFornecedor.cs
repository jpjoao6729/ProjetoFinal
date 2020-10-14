using Core.Negocio.ClasseDeNegocio;
using System;
using System.Windows.Forms;
using Core;
using Core.Processo;

namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroFornecedor : frmBase
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro Fornecedor";
            InpCodigoFornecedor.Text = new ProcessoDeFornecedor().ObtenhaProximoCodigo().ToString();
            InpCodigoFornecedor.Enabled = false;
        }

        public frmCadastroFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Editar Fornecedor";
            CarregueDadosFornecedor(fornecedor);
        }

        private void CarregueDadosFornecedor(Fornecedor fornecedor)
        {
            InpCodigoFornecedor.Text = fornecedor.Codigo.ToString();
            InpRazaoSocial.Text = fornecedor.RazaoSocial;
            inpNomeFantasia.Text = fornecedor.Nome;
            mkpCnpjFornecedor.Text = fornecedor.CNPJ;
            ctlEndereco1.CarregueEndereco(fornecedor.Endereco);
            ctlTelefone1.CarregueTelefone(fornecedor.Telefone);
            ctlEmail1.CarregueEmail(fornecedor.Email);

        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (!PodeSalvarFornecedor()) return;
            var fornecedor = CrieFornecedor();
            try
            {
                new ProcessoDeFornecedor().SalveNoBanco(fornecedor);
                MessageBox.Show("Fornecedor Salvo com sucesso.", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch (Exception erro)
            {
                var publicadorDeExceccoes = new PublicadorDeException(erro);

            }
        }

        private Fornecedor CrieFornecedor()
        {
            return new Fornecedor()
            {
                Nome = inpNomeFantasia.Text,
                Codigo = InpCodigoFornecedor.Text.ConvertaParaInt(),
                RazaoSocial = InpRazaoSocial.Text,
                CNPJ = mkpCnpjFornecedor.Text,
                Endereco = ctlEndereco1.ObtenhaEndereco(),
                Email = ctlEmail1.ObtenhaEmail(),
                Telefone = ctlTelefone1.ObtenhaTelefone()
            };
        }


        private bool PodeSalvarFornecedor()
        {
            if (inpNomeFantasia.Text == "")
            {
                MessageBox.Show("Nome fantasia vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (InpRazaoSocial.Text == "")
            {
                MessageBox.Show("Razão social está vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (mkpCnpjFornecedor.Text == "__.___.___ / ____ - __")
            {
                MessageBox.Show("CNPJ vazio ou inválido", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ctlEndereco1.EhValido())
            {
                MessageBox.Show("Endereço não é valido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ctlTelefone1.EhValido())
            {
                throw new Exception();
                MessageBox.Show("Telefone não é válido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (!ctlEmail1.EhValido())
            {
                MessageBox.Show("E-mail não é vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ctlTelefone1_Load(object sender, EventArgs e)
        {

        }
    }
}