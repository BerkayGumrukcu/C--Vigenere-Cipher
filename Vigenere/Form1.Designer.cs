namespace Vigenere
{
    partial class Form1
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.txtSifreli = new System.Windows.Forms.TextBox();
            this.txtCözülen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnCöz = new System.Windows.Forms.Button();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(108, 26);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(274, 104);
            this.txtMetin.TabIndex = 0;
            // 
            // txtSifreli
            // 
            this.txtSifreli.Location = new System.Drawing.Point(108, 151);
            this.txtSifreli.Multiline = true;
            this.txtSifreli.Name = "txtSifreli";
            this.txtSifreli.Size = new System.Drawing.Size(274, 112);
            this.txtSifreli.TabIndex = 1;
            // 
            // txtCözülen
            // 
            this.txtCözülen.Location = new System.Drawing.Point(108, 289);
            this.txtCözülen.Multiline = true;
            this.txtCözülen.Name = "txtCözülen";
            this.txtCözülen.Size = new System.Drawing.Size(274, 112);
            this.txtCözülen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Metin Girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifreli Metniniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Çözülmüş Metniniz";
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(521, 137);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(153, 97);
            this.btnSifrele.TabIndex = 6;
            this.btnSifrele.Text = "ŞİFRELE";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnCöz
            // 
            this.btnCöz.Location = new System.Drawing.Point(521, 276);
            this.btnCöz.Name = "btnCöz";
            this.btnCöz.Size = new System.Drawing.Size(153, 101);
            this.btnCöz.TabIndex = 7;
            this.btnCöz.Text = "ŞİFRE ÇÖZ";
            this.btnCöz.UseVisualStyleBackColor = true;
            this.btnCöz.Click += new System.EventHandler(this.btnCöz_Click);
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(542, 62);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(100, 20);
            this.txtAnahtar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Anahtar Kelime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.btnCöz);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCözülen);
            this.Controls.Add(this.txtSifreli);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox txtSifreli;
        private System.Windows.Forms.TextBox txtCözülen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnCöz;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Label label4;
    }
}

