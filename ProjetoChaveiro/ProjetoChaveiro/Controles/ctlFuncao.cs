using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Negocio.ClasseDeNegocio;
using Core.Processo;

namespace ProjetoChaveiro.Controles
{
    public partial class ctlFuncao : UserControl
    {

        public ctlFuncao()
        {
            InitializeComponent();
            var bs = new BindingSource();
            comboBox1.DataSource = bsFuncao;
            comboBox1_TextChanged(null, null);

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            var funcoes = new ProcessoDeFuncao().ObtenhaporDescricao(comboBox1.Text);
            bsFuncao.DataSource = funcoes;
        }

        public Funcao ObtenhaFuncaoSelecionada()
        {
            return ((Funcao)comboBox1.SelectedItem) ;
        }

        public void SelecioneFuncao(Funcao funcao)
        {
            comboBox1.SelectedItem = funcao;
        }
    }
}
