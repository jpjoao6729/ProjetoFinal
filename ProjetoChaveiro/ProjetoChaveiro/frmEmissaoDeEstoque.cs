﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoChaveiro
{
    public partial class frmEmissaoDeEstoque : frmBase
    {
        public frmEmissaoDeEstoque()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Emissao Estoque";
            lblNomeTela.Text = nameof(frmEmissaoDeEstoque);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
