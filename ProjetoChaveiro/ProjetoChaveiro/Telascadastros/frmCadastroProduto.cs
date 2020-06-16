using Core.Negocio.ClasseDeNegocio;
using System;
using System.Windows.Forms;
using Core;
using Core.Processo;
using Core.Negocio.Enumerador;
using Core.Negocio.Enumeradores;

namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroDeProduto : frmBase
    {
        private int Codigo;
        private string Produto;
        private int Preco;

        public frmCadastroDeProduto()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Produtos";
            InpCodigoProduto.Text = new ProcessoDeProduto().ObtenhaProximoCodigo().ToString();
            InpCodigoProduto.Enabled = false;
            
        }

        private Produto CrieProduto()
        {
            return new Produto()
            {
                Codigo = InpCodigoProduto.Text.ConvertaParaInt(),
                Descricao = InpProduto.Text,
                Valor = inpPreco.Text.ConvertaParaDecimal(),
                Unidade = ctlUnidadeProduto1.ObtenhaUnidadeSelecionada(),
                Ativo = chkAtivo.Checked
            };
        }


        public bool PodeSalvarProduto()
        {
            if (InpProduto.Text == "")
            {
                MessageBox.Show("Descrição de produto vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var valor = inpPreco.Text.ConvertaParaDecimal();
            if (valor < 0)
            {
                MessageBox.Show("Valor de produto negativo.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                new ProcessoDeProduto().SalveNoBanco(Produto);
                MessageBox.Show("Produto Salvo com sucesso.", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception erro)
            {
                 new PublicadorDeException(erro);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}




