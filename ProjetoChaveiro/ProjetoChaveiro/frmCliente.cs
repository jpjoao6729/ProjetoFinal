
using Core.Negocio.ClasseDeNegocio;
using Core.Processo;
using ProjetoChaveiro.Telascadastros;
using System;
using System.Linq;

namespace ProjetoChaveiro
{
    public partial class frmCliente : frmBase
    {
        public frmCliente()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Clientes";
            lblNomeTela.Text = nameof(frmCliente);
            AjusteDVG();
        }

        private void CarregueDGV()
        {
            var clientes = new ProcessoDeCliente().ObtenhaPorDescricao(inpDescricao.Text);
            bindingSource1.DataSource = clientes.Select(x => new ClienteMV(x));
        }

        private void AjusteDVG()
        {
            dataGridViewFacil1.CarregueBindSource(bindingSource1);
            dataGridViewFacil1.CrieCabecalho("Codigo", nameof(ClienteMV.Codigo), 40);
            dataGridViewFacil1.CrieCabecalhoPreenchido("Nome", nameof(ClienteMV.Nome));
            dataGridViewFacil1.CrieCabecalho("Tipo", nameof(ClienteMV.TipoCliente), 40);
            dataGridViewFacil1.CrieCabecalho("CPF/CNPJ", nameof(ClienteMV.CPFCNPJ), 100);
            dataGridViewFacil1.DesabiliteHeader();
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            var form = new frmCadastroCliente();
            form.Show();
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            var form = new frmCadastroCliente();
            form.Show();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            //Chamar metodo de excluir no banco
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void inpDescricao_TextChanged(object sender, System.EventArgs e)
        {
            CarregueDGV();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregueDGV();
        }
        private void frmCliente_Enter(object sender, EventArgs e)
        {
            CarregueDGV();
        }

        private class ClienteMV
        {
            public ClienteAbstrato Cliente;
            public ClienteMV(ClienteAbstrato cliente)
            {
                Cliente = cliente;
            }
            public int Codigo => Cliente.Codigo;
            public string Nome => Cliente.Nome;
            public string TipoCliente => Cliente is PessoaFisica pessoa ? "PF" : "PJ";
            public string CPFCNPJ { 
                get {
                    if (Cliente is PessoaFisica pessoaF) return pessoaF.CPF;
                    if (Cliente is PessoaJuridica pessoaJ) return pessoaJ.CNPJ;
                    return "";
                }
            }
        }

        private void frmCliente_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }
    }
}
