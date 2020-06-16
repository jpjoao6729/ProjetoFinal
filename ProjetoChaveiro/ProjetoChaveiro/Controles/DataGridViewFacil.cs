using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoChaveiro.Controles
{
    public partial class DataGridViewFacil : UserControl
    {
        public DataGridViewFacil()
        {
            InitializeComponent();
            this.dgv.AutoGenerateColumns = false;
        }

        public void CarregueBindSource(BindingSource bsDataGride)
        {
            dgv.DataSource = bsDataGride;
        }
        public void CrieCabecalho(string nomeColuna, string nomeAtributo, int tamanho)
        {
            DataGridViewColumn coluna = new DataGridViewTextBoxColumn();
            coluna.DataPropertyName = nomeAtributo;
            coluna.Name = nomeColuna;
            coluna.Width = tamanho;
            coluna.ReadOnly = true;
            dgv.Columns.Add(coluna);
        }
        public void CrieCabecalhoPreenchido(string nomeColuna, string nomeAtributo)
        {
            DataGridViewColumn coluna = new DataGridViewTextBoxColumn();
            coluna.DataPropertyName = nomeAtributo;
            coluna.Name = nomeColuna;
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coluna.ReadOnly = true;
            dgv.Columns.Add(coluna);
        }

        internal void DesabiliteHeader()
        {
            dgv.RowHeadersVisible = false;
        }
        public void AdicioneEvent(DataGridViewCellEventHandler eventoDeSelecao)
        {
            dgv.CellDoubleClick += eventoDeSelecao;
        }
    }
}
