using Core.Negocio.ClasseDeNegocio;
using System;
using System.Windows.Forms;
using Core;



namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroDeProduto : frmBase
    {
        private int Codigo;
        private string Produto;
        private int Preco;

        public TextBox Unidade { get; private set; }

        public frmCadastroDeProduto()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Produtos";
            InpCodigoProduto.Text = new Core.Processo.ProcessoDeProduto().ObtenhaCodigo().ToString();
            InpCodigoProduto.Enabled = false;
        }

        private Produto CrieProduto()
        {
            return new Produto()
            {
                Codigo = InpCodigoProduto.Text.ConvertaParaInt(),
                Descricao = InpProduto.Text,
                Valor = InpPreco.Text.ConvertaParaDecimal(),
                Unidade = InpUnidade.Text
            };
        }

        public bool PodeSalvarProduto()
        {
            if (InpProduto.Text == "")
            {
                return false;
            }

            var valor = InpPreco.Text.ConvertaParaDecimal();
            if (valor < 0)
            {
                return false;
            }

            if (InpUnidade.Text == "")
            {
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!PodeSalvarProduto()) return;
            var Produto = CrieProduto();
            try
            {
                new Core.Processo.ProcessoDeProduto().SalveNoBanco(Produto);
                MessageBox.Show("Produto Salvo com sucesso.", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception erro)
            {
                var publicadorDeExceccoes = new PublicadorDeException(erro);
            }
        }
    }
}




