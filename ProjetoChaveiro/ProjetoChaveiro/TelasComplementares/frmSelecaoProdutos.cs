﻿using ProjetoChaveiro.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoChaveiro.TelasComplementares
{
    public partial class frmSelecaoProdutos : frmBase
    {
        public frmSelecaoProdutos()
        {
            InitializeComponent();
            lblNomeFuncao.Text = "Seleção produto";
            ctlPesquisaProduto1.btnSair.Click += (object sender, EventArgs e) => { Close(); };
        }

        internal void AtribuaEvento(DataGridViewCellEventHandler eventoDeSelecao)
        {
            ctlPesquisaProduto1.AdicioneEvento(eventoDeSelecao);
        }
    }
}
