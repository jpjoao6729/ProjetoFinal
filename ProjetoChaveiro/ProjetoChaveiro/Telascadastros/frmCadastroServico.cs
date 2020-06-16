using Core.Negocio.ClasseDeNegocio;
using System;
using System.Windows.Forms;
using Core;
using Core.Processo;

namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroServico : frmBase
    {
        public frmCadastroServico()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Serviços";
            inpCodigo.Text = new ProcessoDeServico().ObtenhaCodigo().ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!PodeProsseguir()) return;
            var servico = CrieServico();
            try
            {
                new ProcessoDeServico().SalveNoBanco(servico);
            }
            catch(Exception ex)
            {
                var publicadorDeExceccoes = new PublicadorDeException(ex);
            }
        }

        private Servico CrieServico()
        {
            return new Servico()
            { 
                Codigo = inpCodigo.Text.ConvertaParaInt(),
                Descricao = inpDescricao.Text,
                Valor = inpPreco.Text.ConvertaParaDecimal()

            };

        }

        private bool PodeProsseguir()
        {
            if(inpDescricao.Text == "")
            {
                MessageBox.Show("Campo descrição vazio.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(inpPreco.Text.ConvertaParaInt() > 0)
            {
                MessageBox.Show("Valor do serviço negativo.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
