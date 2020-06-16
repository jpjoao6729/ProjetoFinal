using Core.Negocio.Enumerador;
using Core.Negocio.Enumeradores;
using System;
using System.Windows.Forms;

namespace ProjetoChaveiro.Controles
{
    public partial class ctlUF : UserControl
    {
        public ctlUF()
        {
            InitializeComponent();
            var ufs = EnumeradorUF.ObtenhaTodos<EnumeradorUF>();
            var binding = new BindingSource();
            binding.DataSource = ufs;

            comboBox1.DataSource = binding;
            comboBox1.DisplayMember = nameof(EnumeradorSeguro<EnumeradorUF>.Descricao);
        }

        internal EnumeradorUF ObtenhaUF()
        {
            var itemSelecionado = comboBox1.SelectedItem as EnumeradorUF;
            return itemSelecionado;
        }
        public void SelecioneUF(EnumeradorUF uf)
        {
            comboBox1.SelectedItem = uf;
        }
    }
}
