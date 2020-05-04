namespace ProjetoChaveiro
{
    partial class PublicadorDeException
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
            this.imgErro = new System.Windows.Forms.PictureBox();
            this.lblOps = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgErro)).BeginInit();
            this.SuspendLayout();
            // 
            // imgErro
            // 
            this.imgErro.Image = global::ProjetoChaveiro.Properties.Resources.Erro1;
            this.imgErro.Location = new System.Drawing.Point(13, 13);
            this.imgErro.Name = "imgErro";
            this.imgErro.Size = new System.Drawing.Size(128, 128);
            this.imgErro.TabIndex = 0;
            this.imgErro.TabStop = false;
            // 
            // lblOps
            // 
            this.lblOps.AutoSize = true;
            this.lblOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOps.Location = new System.Drawing.Point(216, 42);
            this.lblOps.Name = "lblOps";
            this.lblOps.Size = new System.Drawing.Size(94, 31);
            this.lblOps.TabIndex = 1;
            this.lblOps.Text = "Ops...";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(156, 84);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(178, 25);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Algo deu de errado";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(13, 148);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(327, 152);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publicador de Exception";
            // 
            // PublicadorDeException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblOps);
            this.Controls.Add(this.imgErro);
            this.Name = "PublicadorDeException";
            this.Text = "PublicadorDeExcessoes";
            ((System.ComponentModel.ISupportInitialize)(this.imgErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgErro;
        private System.Windows.Forms.Label lblOps;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label3;
    }
}