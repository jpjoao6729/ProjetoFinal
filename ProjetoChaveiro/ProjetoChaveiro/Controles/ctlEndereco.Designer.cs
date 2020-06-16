namespace ProjetoChaveiro.Controles
{
    partial class ctlEndereco
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.ctlUF1 = new ProjetoChaveiro.Controles.ctlUF();
            this.button1 = new System.Windows.Forms.Button();
            this.lbUf = new System.Windows.Forms.Label();
            this.inpCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.inpBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.inpComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.inpLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.mkCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.ctlUF1);
            this.pnlControl.Controls.Add(this.button1);
            this.pnlControl.Controls.Add(this.lbUf);
            this.pnlControl.Controls.Add(this.inpCidade);
            this.pnlControl.Controls.Add(this.lblCidade);
            this.pnlControl.Controls.Add(this.inpBairro);
            this.pnlControl.Controls.Add(this.lblBairro);
            this.pnlControl.Controls.Add(this.inpComplemento);
            this.pnlControl.Controls.Add(this.lblComplemento);
            this.pnlControl.Controls.Add(this.inpLogradouro);
            this.pnlControl.Controls.Add(this.lblLogradouro);
            this.pnlControl.Controls.Add(this.mkCEP);
            this.pnlControl.Controls.Add(this.lblCep);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(3, 16);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(609, 126);
            this.pnlControl.TabIndex = 8;
            // 
            // ctlUF1
            // 
            this.ctlUF1.Location = new System.Drawing.Point(361, 33);
            this.ctlUF1.Name = "ctlUF1";
            this.ctlUF1.Size = new System.Drawing.Size(212, 23);
            this.ctlUF1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbUf
            // 
            this.lbUf.AutoSize = true;
            this.lbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUf.Location = new System.Drawing.Point(324, 33);
            this.lbUf.Name = "lbUf";
            this.lbUf.Size = new System.Drawing.Size(30, 17);
            this.lbUf.TabIndex = 10;
            this.lbUf.Text = "UF:";
            // 
            // inpCidade
            // 
            this.inpCidade.Location = new System.Drawing.Point(113, 33);
            this.inpCidade.Name = "inpCidade";
            this.inpCidade.Size = new System.Drawing.Size(205, 20);
            this.inpCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(3, 33);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 17);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // inpBairro
            // 
            this.inpBairro.Location = new System.Drawing.Point(113, 87);
            this.inpBairro.Name = "inpBairro";
            this.inpBairro.Size = new System.Drawing.Size(460, 20);
            this.inpBairro.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(3, 86);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 17);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // inpComplemento
            // 
            this.inpComplemento.Location = new System.Drawing.Point(423, 62);
            this.inpComplemento.Name = "inpComplemento";
            this.inpComplemento.Size = new System.Drawing.Size(150, 20);
            this.inpComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(324, 62);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(98, 17);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complemento:";
            // 
            // inpLogradouro
            // 
            this.inpLogradouro.Location = new System.Drawing.Point(113, 59);
            this.inpLogradouro.Name = "inpLogradouro";
            this.inpLogradouro.Size = new System.Drawing.Size(205, 20);
            this.inpLogradouro.TabIndex = 3;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(3, 61);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(86, 17);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // mkCEP
            // 
            this.mkCEP.Location = new System.Drawing.Point(113, 5);
            this.mkCEP.Mask = "00000-000";
            this.mkCEP.Name = "mkCEP";
            this.mkCEP.Size = new System.Drawing.Size(97, 20);
            this.mkCEP.TabIndex = 1;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(3, 6);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(39, 17);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP:";
            // 
            // ctlEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctlEndereco";
            this.Size = new System.Drawing.Size(615, 145);
            this.groupBox1.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbUf;
        private System.Windows.Forms.TextBox inpCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox inpBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox inpComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox inpLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.MaskedTextBox mkCEP;
        private System.Windows.Forms.Label lblCep;
        private ctlUF ctlUF1;
    }
}
