using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Negocio.Enumerador;
using Core.Negocio.Enumeradores;

namespace ProjetoChaveiro.Controles
{
    public partial class ctlUnidadeProduto : UserControl
    {
        public ctlUnidadeProduto()
        {
            InitializeComponent();
            var binding = new BindingSource();
            var unidadesProdutos = EnumeradorUnidadeProduto.ObtenhaTodos<EnumeradorUnidadeProduto>();
            binding.DataSource = unidadesProdutos;

            comboBox1.DataSource = binding;
            var teste = nameof(EnumeradorSeguro<EnumeradorUnidadeProduto>.Descricao);
            comboBox1.DisplayMember = teste;
        }

        public EnumeradorUnidadeProduto ObtenhaUnidadeSelecionada()
        {
            var itemSelecionado = comboBox1.SelectedItem as EnumeradorUnidadeProduto;
            return itemSelecionado;
        }

        public void Selecione(EnumeradorUnidadeProduto unidade)
        {
            comboBox1.SelectedItem = unidade;
        }
    }
}
