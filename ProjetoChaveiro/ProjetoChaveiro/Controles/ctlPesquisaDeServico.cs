﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoChaveiro.Telascadastros;

namespace ProjetoChaveiro.Controles
{
    public partial class ctlPesquisaDeServico : UserControl
    {
        private class ServicoMV
        {
            public ServicoMV()
            {

            }
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public decimal ValorProduto { get; set; }
        }
        private BindingSource _bs;
        public ctlPesquisaDeServico()
        {
            InitializeComponent();

            CarregueDGV();
            MetodoComplementar();
            CarregueEventos();
        }

        private void CarregueDGV()
        {
            dgvProdutos.CrieCabecalho("Codigo", nameof(ServicoMV.Codigo), 50);
            dgvProdutos.CrieCabecalho("Descrição", nameof(ServicoMV.Codigo), 150);
            dgvProdutos.CrieCabecalho("Valor", nameof(ServicoMV.Codigo), 232);
            dgvProdutos.DesabiliteHeader();
        }
        public void AdicioneBaingSource(BindingSource bs)
        {
            _bs = bs;
        }
        private void MetodoComplementar()
        {
            //dgvProdutos.ReadOnly = true;
            var item = new ServicoMV()
            {
                Codigo = 1,
                Descricao = "Chave grande",
                ValorProduto = 10
            };

            //dgvProdutos.DataSource = new List<ProdutoMV>() { item };
        }
        public void AdicioneEvento(DataGridViewCellEventHandler eventoDeSelecao)
        {
            this.dgvProdutos.AdicioneEvent(eventoDeSelecao);
        }
        private void CarregueEventos()
        {
            btnNovo.Click += (object sender, EventArgs e) => { AbraFormularioNovo(); };
            btnExcluir.Click += (object sender, EventArgs e) => { ExcluaProduto(); };
            button3.Click += (object sender, EventArgs e) => { AbraFormularioEditar(); };

        }
        private void AbraFormularioEditar()
        {
            var form = new frmCadastroServico();
            form.Show();
        }

        private void AbraFormularioNovo()
        {
            var form = new frmCadastroServico();
            form.Show();
        }

        private void ExcluaProduto()
        {
            //Apagar no banco
        }
    }
}
