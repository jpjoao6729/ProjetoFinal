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
            this.ctlPesquisaDeServico1 = new ProjetoChaveiro.Controles.ctlPesquisaDeServico();
            this.SuspendLayout();
            // 
            // pesquisaDeServico1
            // 
            this.ctlPesquisaDeServico1.Location = new System.Drawing.Point(6, 92);
            this.ctlPesquisaDeServico1.Name = "pesquisaDeServico1";
            this.ctlPesquisaDeServico1.Size = new System.Drawing.Size(570, 214);
            this.ctlPesquisaDeServico1.TabIndex = 6;
            this.ctlPesquisaDeServico1.Load += new System.EventHandler(this.pesquisaDeServico1_Load);
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 309);
            this.Controls.Add(this.ctlPesquisaDeServico1);
            this.MaximumSize = new System.Drawing.Size(604, 348);
            this.MinimumSize = new System.Drawing.Size(604, 348);
            this.Name = "frmServicos";
            this.Text = "frmServicos";
            this.Controls.SetChildIndex(this.ctlPesquisaDeServico1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ctlPesquisaDeServico ctlPesquisaDeServico1;
    }
}