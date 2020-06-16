namespace ProjetoChaveiro.Telascadastros
{
    partial class frmCadastroCliente
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mkCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.rbJuridico = new System.Windows.Forms.RadioButton();
            this.rbFisico = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.inpCodigo = new System.Windows.Forms.TextBox();
            this.inpRazaoSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inpNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlEmail1 = new ProjetoChaveiro.Controles.ctlEmail();
            this.ctlTelefone1 = new ProjetoChaveiro.Controles.ctlTelefone();
            this.ctlEndereco1 = new ProjetoChaveiro.Controles.ctlEndereco();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mkCpfCnpj);
            this.groupBox3.Controls.Add(this.rbJuridico);
            this.groupBox3.Controls.Add(this.rbFisico);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblCpfCnpj);
            this.groupBox3.Controls.Add(this.inpCodigo);
            this.groupBox3.Controls.Add(this.inpRazaoSocial);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.inpNome);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 115);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // mkCpfCnpj
            // 
            this.mkCpfCnpj.Location = new System.Drawing.Point(117, 88);
            this.mkCpfCnpj.Mask = "000-000-000.00";
            this.mkCpfCnpj.Name = "mkCpfCnpj";
            this.mkCpfCnpj.Size = new System.Drawing.Size(162, 20);
            this.mkCpfCnpj.TabIndex = 14;
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.Location = new System.Drawing.Point(305, 17);
            this.rbJuridico.Name = "rbJuridico";
            this.rbJuridico.Size = new System.Drawing.Size(63, 17);
            this.rbJuridico.TabIndex = 13;
            this.rbJuridico.TabStop = true;
            this.rbJuridico.Text = "Jurídico";
            this.rbJuridico.UseVisualStyleBackColor = true;
            this.rbJuridico.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbFisico
            // 
            this.rbFisico.AutoSize = true;
            this.rbFisico.Checked = true;
            this.rbFisico.Location = new System.Drawing.Point(245, 17);
            this.rbFisico.Name = "rbFisico";
            this.rbFisico.Size = new System.Drawing.Size(54, 17);
            this.rbFisico.TabIndex = 12;
            this.rbFisico.TabStop = true;
            this.rbFisico.Text = "Físico";
            this.rbFisico.UseVisualStyleBackColor = true;
            this.rbFisico.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(6, 86);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(38, 17);
            this.lblCpfCnpj.TabIndex = 10;
            this.lblCpfCnpj.Text = "CPF:";
            // 
            // inpCodigo
            // 
            this.inpCodigo.Enabled = false;
            this.inpCodigo.Location = new System.Drawing.Point(117, 15);
            this.inpCodigo.Name = "inpCodigo";
            this.inpCodigo.Size = new System.Drawing.Size(100, 20);
            this.inpCodigo.TabIndex = 6;
            // 
            // inpRazaoSocial
            // 
            this.inpRazaoSocial.Location = new System.Drawing.Point(117, 64);
            this.inpRazaoSocial.Name = "inpRazaoSocial";
            this.inpRazaoSocial.Size = new System.Drawing.Size(462, 20);
            this.inpRazaoSocial.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Razão Social";
            // 
            // inpNome
            // 
            this.inpNome.Location = new System.Drawing.Point(117, 40);
            this.inpNome.Name = "inpNome";
            this.inpNome.Size = new System.Drawing.Size(462, 20);
            this.inpNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // ctlEmail1
            // 
            this.ctlEmail1.Location = new System.Drawing.Point(295, 364);
            this.ctlEmail1.Name = "ctlEmail1";
            this.ctlEmail1.Size = new System.Drawing.Size(313, 79);
            this.ctlEmail1.TabIndex = 14;
            // 
            // ctlTelefone1
            // 
            this.ctlTelefone1.Location = new System.Drawing.Point(12, 364);
            this.ctlTelefone1.Name = "ctlTelefone1";
            this.ctlTelefone1.Size = new System.Drawing.Size(279, 78);
            this.ctlTelefone1.TabIndex = 13;
            // 
            // ctlEndereco1
            // 
            this.ctlEndereco1.Location = new System.Drawing.Point(12, 203);
            this.ctlEndereco1.Name = "ctlEndereco1";
            this.ctlEndereco1.Size = new System.Drawing.Size(596, 162);
            this.ctlEndereco1.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(637, 385);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 26);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(637, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 26);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 466);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ctlEmail1);
            this.Controls.Add(this.ctlTelefone1);
            this.Controls.Add(this.ctlEndereco1);
            this.MaximumSize = new System.Drawing.Size(753, 505);
            this.MinimumSize = new System.Drawing.Size(753, 505);
            this.Name = "frmCadastroCliente";
            this.Text = "frmCadastroCliente";
            this.Controls.SetChildIndex(this.ctlEndereco1, 0);
            this.Controls.SetChildIndex(this.ctlTelefone1, 0);
            this.Controls.SetChildIndex(this.ctlEmail1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox inpCodigo;
        private System.Windows.Forms.TextBox inpRazaoSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpNome;
        private System.Windows.Forms.Label label5;
        private Controles.ctlEmail ctlEmail1;
        private Controles.ctlTelefone ctlTelefone1;
        private Controles.ctlEndereco ctlEndereco1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbJuridico;
        private System.Windows.Forms.RadioButton rbFisico;
        private System.Windows.Forms.MaskedTextBox mkCpfCnpj;
    }
}