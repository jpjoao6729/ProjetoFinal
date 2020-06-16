using Core.Negocio.ClasseDeNegocio;
using System;
using System.Windows.Forms;
using Core;
using Core.Processo;

namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroOperador : frmBase
    {

        public frmCadastroOperador()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Cadastro de Operadores";
            InpCodigoOperador.Text = new ProcessoDeOperador().ObtenhaProximoCodigo().ToString();
            InpCodigoOperador.Enabled = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!PodeSalvarOperador()) return;
            var Operador = CrieOperador();
            try
            {
                new ProcessoDeOperador().SalveNoBanco(Operador);
                MessageBox.Show("Operador Salvo com sucesso.", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception erro)
            {

                var publicadorDeExceccoes = new PublicadorDeException(erro);
            }
        }

        private Operador CrieOperador()
        {
            return new Operador()
            {
                Codigo = InpCodigoOperador.Text.ConvertaParaInt(),
                Nome = InpNome.Text,
                CPF = mkpCpf.Text,
                Endereco = ctlEndereco1.ObtenhaEndereco(),
                Email = ctlEmail1.ObtenhaEmail(),
                Telefone = ctlTelefone1.ObtenhaTelefone()
            };
        }

        public bool PodeSalvarOperador()
        {
            if (!ctlEndereco1.EhValido())
            {
                MessageBox.Show("Endereço inválido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ctlTelefone1.EhValido())
            {
                MessageBox.Show("Telefone inválido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ctlEmail1.EhValido())
            {
                MessageBox.Show("E-mail inválido.", "Inconsistencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


