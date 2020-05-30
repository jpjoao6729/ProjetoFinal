namespace ProjetoChaveiro.TelasComplementares
{
    partial class frmSelecaoProdutos
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
            this.ctlPesquisaProduto1 = new ProjetoChaveiro.Controles.ctlPesquisaProduto();
            this.SuspendLayout();
            // 
            // ctlPesquisaProduto1
            // 
            this.ctlPesquisaProduto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPesquisaProduto1.Location = new System.Drawing.Point(0, 0);
            this.ctlPesquisaProduto1.Name = "ctlPesquisaProduto1";
            this.ctlPesquisaProduto1.Size = new System.Drawing.Size(566, 299);
            this.ctlPesquisaProduto1.TabIndex = 6;
            // 
            // frmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 299);
            this.Controls.Add(this.ctlPesquisaProduto1);
            this.Name = "frmSelecao";
            this.Text = "SelecaoProduto";
            this.Controls.SetChildIndex(this.ctlPesquisaProduto1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ctlPesquisaProduto ctlPesquisaProduto1;
    }
}