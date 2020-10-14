namespace ProjetoChaveiro.Telascadastros
{
    partial class frmCadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.InpCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.inpNomeFantasia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InpRazaoSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mkpCnpjFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlEmail1 = new ProjetoChaveiro.Controles.ctlEmail();
            this.ctlEndereco1 = new ProjetoChaveiro.Controles.ctlEndereco();
            this.ctlTelefone1 = new ProjetoChaveiro.Controles.ctlTelefone();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo:";
            // 
            // InpCodigoFornecedor
            // 
            this.InpCodigoFornecedor.Enabled = false;
            this.InpCodigoFornecedor.Location = new System.Drawing.Point(117, 15);
            this.InpCodigoFornecedor.Name = "InpCodigoFornecedor";
            this.InpCodigoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.InpCodigoFornecedor.TabIndex = 6;
            // 
            // inpNomeFantasia
            // 
            this.inpNomeFantasia.Location = new System.Drawing.Point(117, 64);
            this.inpNomeFantasia.Name = "inpNomeFantasia";
            this.inpNomeFantasia.Size = new System.Drawing.Size(462, 20);
            this.inpNomeFantasia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome Fantasia:";
            // 
            // InpRazaoSocial
            // 
            this.InpRazaoSocial.Location = new System.Drawing.Point(117, 40);
            this.InpRazaoSocial.Name = "InpRazaoSocial";
            this.InpRazaoSocial.Size = new System.Drawing.Size(462, 20);
            this.InpRazaoSocial.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Razão Social:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mkpCnpjFornecedor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.InpCodigoFornecedor);
            this.groupBox3.Controls.Add(this.inpNomeFantasia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.InpRazaoSocial);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 115);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // mkpCnpjFornecedor
            // 
            this.mkpCnpjFornecedor.Location = new System.Drawing.Point(117, 88);
            this.mkpCnpjFornecedor.Mask = "00.000.000/000-00";
            this.mkpCnpjFornecedor.Name = "mkpCnpjFornecedor";
            this.mkpCnpjFornecedor.Size = new System.Drawing.Size(168, 20);
            this.mkpCnpjFornecedor.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CNPJ:";
            // 
            // ctlEmail1
            // 
            this.ctlEmail1.Location = new System.Drawing.Point(12, 350);
            this.ctlEmail1.Name = "ctlEmail1";
            this.ctlEmail1.Size = new System.Drawing.Size(325, 70);
            this.ctlEmail1.TabIndex = 8;
            // 
            // ctlEndereco1
            // 
            this.ctlEndereco1.Location = new System.Drawing.Point(12, 206);
            this.ctlEndereco1.Name = "ctlEndereco1";
            this.ctlEndereco1.Size = new System.Drawing.Size(596, 145);
            this.ctlEndereco1.TabIndex = 5;
            // 
            // ctlTelefone1
            // 
            this.ctlTelefone1.Location = new System.Drawing.Point(343, 350);
            this.ctlTelefone1.Name = "ctlTelefone1";
            this.ctlTelefone1.Size = new System.Drawing.Size(265, 70);
            this.ctlTelefone1.TabIndex = 9;
            this.ctlTelefone1.Load += new System.EventHandler(this.ctlTelefone1_Load);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(626, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(626, 363);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 26);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 455);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ctlTelefone1);
            this.Controls.Add(this.ctlEmail1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ctlEndereco1);
            this.MaximumSize = new System.Drawing.Size(740, 494);
            this.MinimumSize = new System.Drawing.Size(740, 494);
            this.Name = "frmCadastroFornecedor";
            this.Text = "frmCadastroFornecedor";
            this.Controls.SetChildIndex(this.ctlEndereco1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.ctlEmail1, 0);
            this.Controls.SetChildIndex(this.ctlTelefone1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InpCodigoFornecedor;
        private System.Windows.Forms.TextBox inpNomeFantasia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InpRazaoSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private Controles.ctlEmail ctlEmail1;
        private System.Windows.Forms.Label label2;
        private Controles.ctlEndereco ctlEndereco1;
        private Controles.ctlTelefone ctlTelefone1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mkpCnpjFornecedor;
    }
}