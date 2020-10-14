using Core;
using Core.Negocio.ClasseDeNegocio;
using Core.Processo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoChaveiro.Telascadastros
{
    public partial class frmCadastroFuncao : frmBase
    {
        public frmCadastroFuncao()
        {
            InitializeComponent();
            inpCodigo.Text = new ProcessoDeFuncao().ObtenhaProximoCodigo().ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!podeSalvar()) return;
            var funcao = CrieFuncao();
            try
            {
                new ProcessoDeFuncao().Salve(funcao);
                MessageBox.Show("Operador Salvo com sucesso.", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                new PublicadorDeException(ex);
            }
        }

        private Funcao CrieFuncao()
        {
            return new Funcao()
            {
                Codigo = inpCodigo.Text.ConvertaParaInt(),
                Descricao = inpDescricao.Text
            };
        }

        private bool podeSalvar()
        {
            if (inpDescricao.Text == "")
            {
                MessageBox.Show("Campo descrição está vazio.", "Inconsistência.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
