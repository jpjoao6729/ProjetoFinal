namespace ProjetoChaveiro.Controles
{
    partial class ctlTelefone
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
            this.inpDDD = new System.Windows.Forms.MaskedTextBox();
            this.inpNumero = new System.Windows.Forms.MaskedTextBox();
            this.rbCelular = new System.Windows.Forms.RadioButton();
            this.rbFixo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inpDDD);
            this.groupBox1.Controls.Add(this.inpNumero);
            this.groupBox1.Controls.Add(this.rbCelular);
            this.groupBox1.Controls.Add(this.rbFixo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // inpDDD
            // 
            this.inpDDD.Location = new System.Drawing.Point(14, 38);
            this.inpDDD.Mask = "(00)";
            this.inpDDD.Name = "inpDDD";
            this.inpDDD.Size = new System.Drawing.Size(29, 20);
            this.inpDDD.TabIndex = 6;
            // 
            // inpNumero
            // 
            this.inpNumero.Location = new System.Drawing.Point(67, 38);
            this.inpNumero.Mask = "0000-0000";
            this.inpNumero.Name = "inpNumero";
            this.inpNumero.Size = new System.Drawing.Size(93, 20);
            this.inpNumero.TabIndex = 5;
            // 
            // rbCelular
            // 
            this.rbCelular.AutoSize = true;
            this.rbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelular.Location = new System.Drawing.Point(67, 14);
            this.rbCelular.Name = "rbCelular";
            this.rbCelular.Size = new System.Drawing.Size(70, 21);
            this.rbCelular.TabIndex = 4;
            this.rbCelular.Text = "Celular";
            this.rbCelular.UseVisualStyleBackColor = true;
            this.rbCelular.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // rbFixo
            // 
            this.rbFixo.AutoSize = true;
            this.rbFixo.Checked = true;
            this.rbFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFixo.Location = new System.Drawing.Point(7, 14);
            this.rbFixo.Name = "rbFixo";
            this.rbFixo.Size = new System.Drawing.Size(51, 21);
            this.rbFixo.TabIndex = 2;
            this.rbFixo.TabStop = true;
            this.rbFixo.Text = "Fixo";
            this.rbFixo.UseVisualStyleBackColor = true;
            this.rbFixo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ctlTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctlTelefone";
            this.Size = new System.Drawing.Size(256, 71);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCelular;
        private System.Windows.Forms.RadioButton rbFixo;
        private System.Windows.Forms.MaskedTextBox inpNumero;
        private System.Windows.Forms.MaskedTextBox inpDDD;
    }
}
