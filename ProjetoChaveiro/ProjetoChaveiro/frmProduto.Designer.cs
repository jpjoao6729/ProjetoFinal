namespace ProjetoChaveiro
{
    partial class frmProduto
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctlPesquisaProduto1 = new ProjetoChaveiro.Controles.ctlPesquisaProduto();
            this.SuspendLayout();
            // 
            // lblNomeFuncao
            // 
            // 
            // ctlPesquisaProduto1
            // 
            this.ctlPesquisaProduto1.Location = new System.Drawing.Point(3, 91);
            this.ctlPesquisaProduto1.Name = "ctlPesquisaProduto1";
            this.ctlPesquisaProduto1.Size = new System.Drawing.Size(567, 186);
            this.ctlPesquisaProduto1.TabIndex = 6;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 291);
            this.Controls.Add(this.ctlPesquisaProduto1);
            this.MaximumSize = new System.Drawing.Size(592, 330);
            this.MinimumSize = new System.Drawing.Size(592, 330);
            this.Name = "frmProduto";
            this.Text = "";
            this.Controls.SetChildIndex(this.ctlPesquisaProduto1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Controles.ctlPesquisaProduto ctlPesquisaProduto1;
    }
}