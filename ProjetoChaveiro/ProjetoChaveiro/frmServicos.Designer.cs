namespace ProjetoChaveiro
{
    partial class frmServicos
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
            this.pesquisaDeServico1 = new ProjetoChaveiro.Controles.ctlPesquisaDeServico();
            this.SuspendLayout();
            // 
            // pesquisaDeServico1
            // 
            this.pesquisaDeServico1.Location = new System.Drawing.Point(6, 92);
            this.pesquisaDeServico1.Name = "pesquisaDeServico1";
            this.pesquisaDeServico1.Size = new System.Drawing.Size(570, 214);
            this.pesquisaDeServico1.TabIndex = 6;
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 309);
            this.Controls.Add(this.pesquisaDeServico1);
            this.MaximumSize = new System.Drawing.Size(604, 348);
            this.MinimumSize = new System.Drawing.Size(604, 348);
            this.Name = "frmServicos";
            this.Text = "frmServicos";
            this.Controls.SetChildIndex(this.pesquisaDeServico1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ctlPesquisaDeServico pesquisaDeServico1;
    }
}