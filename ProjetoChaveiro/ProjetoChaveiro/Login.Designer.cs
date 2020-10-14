namespace ProjetoChaveiro
{
    partial class lblLogin
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
            this.inpLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.inpSenha = new System.Windows.Forms.TextBox();
            this.btnEsqueciSenha = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.g = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // inpLogin
            // 
            this.inpLogin.Location = new System.Drawing.Point(55, 103);
            this.inpLogin.Name = "inpLogin";
            this.inpLogin.Size = new System.Drawing.Size(156, 20);
            this.inpLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(55, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // inpSenha
            // 
            this.inpSenha.Location = new System.Drawing.Point(55, 129);
            this.inpSenha.Name = "inpSenha";
            this.inpSenha.Size = new System.Drawing.Size(156, 20);
            this.inpSenha.TabIndex = 3;
            // 
            // btnEsqueciSenha
            // 
            this.btnEsqueciSenha.Location = new System.Drawing.Point(136, 155);
            this.btnEsqueciSenha.Name = "btnEsqueciSenha";
            this.btnEsqueciSenha.Size = new System.Drawing.Size(75, 23);
            this.btnEsqueciSenha.TabIndex = 4;
            this.btnEsqueciSenha.Text = "Esqueci";
            this.btnEsqueciSenha.UseVisualStyleBackColor = true;
            this.btnEsqueciSenha.Click += new System.EventHandler(this.btnEsqueciSenha_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ProjetoChaveiro.Properties.Resources.logo1;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(241, 85);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(85, 53);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(101, 39);
            this.g.TabIndex = 7;
            this.g.Text = "Login";
            // 
            // lblLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 191);
            this.Controls.Add(this.g);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnEsqueciSenha);
            this.Controls.Add(this.inpSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inpLogin);
            this.Name = "lblLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inpLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox inpSenha;
        private System.Windows.Forms.Button btnEsqueciSenha;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label g;
    }
}