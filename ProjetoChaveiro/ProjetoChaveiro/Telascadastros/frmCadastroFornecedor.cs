using Core.Negocio.ClasseDeNegocio;
using System;
using System.Windows.Forms;
using Core;

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
                return false;
            }

            if (InpRazaoSocial.Text == "")
            {
                return false;
            }

            if (mkpCnpjFornecedor.Text == "__.___.___ / ____ - __")
            {
                return false;
            }

            if (!ctlEndereco1.EhValido())
            {
                return false;
            }

            if (!ctlTelefone1.EhValido())
            {
                return false;
            }

            if (!ctlEmail1.EhValido())
            {
                return false;
            }

            return true;
        }


        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}