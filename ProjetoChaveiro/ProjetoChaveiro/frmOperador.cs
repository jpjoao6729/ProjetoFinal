using Core.Negocio.ClasseDeNegocio;
using Core.Processo;
using ProjetoChaveiro.Telascadastros;
using System;
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
    public partial class frmOperador : frmBase
    {
        private class OperadorMV {
            public Operador Operador;
            public OperadorMV(Operador operador)
            {
                Operador = operador;
            }
            public int Codigo => Operador.Codigo;
            public string Nome => Operador.Nome;
            public string Funcao => Operador.Funcao.Descricao;

        }

        private TextBox inpDescricao;
        private Button btnSair;
        private Button btnNovo;
        private Button btnEditar;
        private Controles.DataGridViewFacil dataGridViewFacil1;
        private BindingSource bindingSource1;
        private IContainer components;
        private Button btnExcluir;


        public frmOperador()
        {
            InitializeComponent();
            base.lblNomeFuncao.Text = "Cadastro de Operadores";
            lblNomeTela.Text = nameof(frmOperador);
            AjusteGridView();
            textBox1_TextChanged(null,null);
        }

        private void AjusteGridView()
        {
            dataGridViewFacil1.CarregueBindSource(bindingSource1);
            dataGridViewFacil1.CrieCabecalho("Codigo", nameof(OperadorMV.Codigo), 40);
            dataGridViewFacil1.CrieCabecalhoPreenchido("Nome", nameof(OperadorMV.Nome));
            dataGridViewFacil1.CrieCabecalho("Funcão", nameof(OperadorMV.Funcao), 100);
            dataGridViewFacil1.DesabiliteHeader();
            dataGridViewFacil1.AtiveSelecaoPreechida();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroOperador();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var operadorSelecionado = ((OperadorMV)bindingSource1.Current)?.Operador;
            if (operadorSelecionado != null)
            {
                var form = new frmCadastroOperador(operadorSelecionado);
                form.FormClosed += new FormClosedEventHandler((object s, FormClosedEventArgs evt) => {
                    CarregueGDV();
                });
                form.Show();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is OperadorMV operador)
            {
                try
                {
                    new ProcessoDeOperador().Apague(operador.Operador);
                    MessageBox.Show("Operador removido com sucesso", "Sucesso");
                    CarregueGDV();
                }
                catch (Exception erro)
                {
                    new PublicadorDeException(erro);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarregueGDV();
        }

        private void CarregueGDV()
        {
            var operadores = new ProcessoDeOperador().ObtenhaPorDescricao(inpDescricao.Text);
            bindingSource1.DataSource = operadores.Select(x => new OperadorMV(x));
        }







        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inpDescricao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridViewFacil1 = new ProjetoChaveiro.Controles.DataGridViewFacil();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // inpDescricao
            // 
            this.inpDescricao.Location = new System.Drawing.Point(7, 91);
            this.inpDescricao.Name = "inpDescricao";
            this.inpDescricao.Size = new System.Drawing.Size(439, 20);
            this.inpDescricao.TabIndex = 7;
            this.inpDescricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(473, 266);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 26);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(473, 170);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(78, 26);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(473, 202);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 26);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(473, 234);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 26);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridViewFacil1
            // 
            this.dataGridViewFacil1.Location = new System.Drawing.Point(7, 117);
            this.dataGridViewFacil1.Name = "dataGridViewFacil1";
            this.dataGridViewFacil1.Size = new System.Drawing.Size(439, 175);
            this.dataGridViewFacil1.TabIndex = 12;
            // 
            // frmOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(582, 322);
            this.Controls.Add(this.dataGridViewFacil1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.inpDescricao);
            this.MaximumSize = new System.Drawing.Size(598, 361);
            this.MinimumSize = new System.Drawing.Size(598, 361);
            this.Name = "frmOperador";
            this.Controls.SetChildIndex(this.inpDescricao, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.dataGridViewFacil1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
