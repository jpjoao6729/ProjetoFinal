namespace ProjetoChaveiro.Telascadastros
{
    partial class frmCadastroOperador
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mkpCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InpNome = new System.Windows.Forms.TextBox();
            this.InpCodigoOperador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlEndereco1 = new ProjetoChaveiro.Controles.ctlEndereco();
            this.ctlEmail1 = new ProjetoChaveiro.Controles.ctlEmail();
            this.ctlTelefone1 = new ProjetoChaveiro.Controles.ctlTelefone();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ctlFuncao1 = new ProjetoChaveiro.Controles.ctlFuncao();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.ctlEndereco1);
            this.groupBox3.Controls.Add(this.ctlEmail1);
            this.groupBox3.Controls.Add(this.ctlTelefone1);
            this.groupBox3.Location = new System.Drawing.Point(9, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 357);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ctlFuncao1);
            this.groupBox4.Controls.Add(this.mkpCpf);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.InpNome);
            this.groupBox4.Controls.Add(this.InpCodigoOperador);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(7, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 111);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // mkpCpf
            // 
            this.mkpCpf.Location = new System.Drawing.Point(113, 74);
            this.mkpCpf.Mask = "000.000.000-00";
            this.mkpCpf.Name = "mkpCpf";
            this.mkpCpf.Size = new System.Drawing.Size(170, 20);
            this.mkpCpf.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Função:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // InpNome
            // 
            this.InpNome.Location = new System.Drawing.Point(113, 44);
            this.InpNome.Name = "InpNome";
            this.InpNome.Size = new System.Drawing.Size(309, 20);
            this.InpNome.TabIndex = 2;
            // 
            // InpCodigoOperador
            // 
            this.InpCodigoOperador.Location = new System.Drawing.Point(113, 17);
            this.InpCodigoOperador.Name = "InpCodigoOperador";
            this.InpCodigoOperador.Size = new System.Drawing.Size(100, 20);
            this.InpCodigoOperador.TabIndex = 1;
            this.InpCodigoOperador.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // ctlEndereco1
            // 
            this.ctlEndereco1.Location = new System.Drawing.Point(7, 126);
            this.ctlEndereco1.Name = "ctlEndereco1";
            this.ctlEndereco1.Size = new System.Drawing.Size(604, 145);
            this.ctlEndereco1.TabIndex = 2;
            // 
            // ctlEmail1
            // 
            this.ctlEmail1.Location = new System.Drawing.Point(8, 270);
            this.ctlEmail1.Name = "ctlEmail1";
            this.ctlEmail1.Size = new System.Drawing.Size(325, 77);
            this.ctlEmail1.TabIndex = 1;
            // 
            // ctlTelefone1
            // 
            this.ctlTelefone1.Location = new System.Drawing.Point(346, 269);
            this.ctlTelefone1.Name = "ctlTelefone1";
            this.ctlTelefone1.Size = new System.Drawing.Size(265, 77);
            this.ctlTelefone1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ctlFuncao1
            // 
            this.ctlFuncao1.Location = new System.Drawing.Point(354, 74);
            this.ctlFuncao1.Name = "ctlFuncao1";
            this.ctlFuncao1.Size = new System.Drawing.Size(208, 23);
            this.ctlFuncao1.TabIndex = 9;
            // 
            // frmCadastroOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.MaximumSize = new System.Drawing.Size(759, 562);
            this.MinimumSize = new System.Drawing.Size(759, 562);
            this.Name = "frmCadastroOperador";
            this.Text = "frmCadastroOperador";
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InpNome;
        private System.Windows.Forms.TextBox InpCodigoOperador;
        private System.Windows.Forms.Label label2;
        private Controles.ctlEndereco ctlEndereco1;
        private Controles.ctlEmail ctlEmail1;
        private Controles.ctlTelefone ctlTelefone1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mkpCpf;
        private Controles.ctlFuncao ctlFuncao1;
    }
}