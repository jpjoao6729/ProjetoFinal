﻿namespace ProjetoChaveiro
{
    partial class frmCadastroDeFuncioanio
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlEndereco1 = new ProjetoChaveiro.Controles.ctlEndereco();
            this.ctlEmail1 = new ProjetoChaveiro.Controles.ctlEmail();
            this.ctlTelefone1 = new ProjetoChaveiro.Controles.ctlTelefone();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 128);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // ctlEndereco1
            // 
            this.ctlEndereco1.Location = new System.Drawing.Point(4, 206);
            this.ctlEndereco1.Name = "ctlEndereco1";
            this.ctlEndereco1.Size = new System.Drawing.Size(615, 145);
            this.ctlEndereco1.TabIndex = 10;
            // 
            // ctlEmail1
            // 
            this.ctlEmail1.Location = new System.Drawing.Point(288, 349);
            this.ctlEmail1.Name = "ctlEmail1";
            this.ctlEmail1.Size = new System.Drawing.Size(325, 77);
            this.ctlEmail1.TabIndex = 11;
            // 
            // ctlTelefone1
            // 
            this.ctlTelefone1.Location = new System.Drawing.Point(4, 346);
            this.ctlTelefone1.Name = "ctlTelefone1";
            this.ctlTelefone1.Size = new System.Drawing.Size(261, 87);
            this.ctlTelefone1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // frmCadastroDeFuncioanio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 462);
            this.Controls.Add(this.ctlTelefone1);
            this.Controls.Add(this.ctlEmail1);
            this.Controls.Add(this.ctlEndereco1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCadastroDeFuncioanio";
            this.Text = "frmCadastroDeFuncioanio";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.ctlEndereco1, 0);
            this.Controls.SetChildIndex(this.ctlEmail1, 0);
            this.Controls.SetChildIndex(this.ctlTelefone1, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private Controles.ctlEndereco ctlEndereco1;
        private Controles.ctlEmail ctlEmail1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private Controles.ctlTelefone ctlTelefone1;
    }
}