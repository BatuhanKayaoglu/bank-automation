namespace otomasyon
{
    partial class giris_yap
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
            this.giris_yap_buton = new System.Windows.Forms.Button();
            this.sifre_giris_label = new System.Windows.Forms.Label();
            this.giris_sifre_text = new System.Windows.Forms.TextBox();
            this.k_tel_giris_text = new System.Windows.Forms.TextBox();
            this.menu_buton = new System.Windows.Forms.Button();
            this.k_tel_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giris_yap_buton
            // 
            this.giris_yap_buton.Location = new System.Drawing.Point(124, 130);
            this.giris_yap_buton.Name = "giris_yap_buton";
            this.giris_yap_buton.Size = new System.Drawing.Size(75, 23);
            this.giris_yap_buton.TabIndex = 0;
            this.giris_yap_buton.Text = "Giriş Yap";
            this.giris_yap_buton.UseVisualStyleBackColor = true;
            this.giris_yap_buton.Click += new System.EventHandler(this.giris_yap_buton_Click);
            // 
            // sifre_giris_label
            // 
            this.sifre_giris_label.AutoSize = true;
            this.sifre_giris_label.Location = new System.Drawing.Point(121, 93);
            this.sifre_giris_label.Name = "sifre_giris_label";
            this.sifre_giris_label.Size = new System.Drawing.Size(34, 13);
            this.sifre_giris_label.TabIndex = 2;
            this.sifre_giris_label.Text = "Şifre: ";
            // 
            // giris_sifre_text
            // 
            this.giris_sifre_text.Location = new System.Drawing.Point(161, 90);
            this.giris_sifre_text.Name = "giris_sifre_text";
            this.giris_sifre_text.PasswordChar = '*';
            this.giris_sifre_text.Size = new System.Drawing.Size(140, 20);
            this.giris_sifre_text.TabIndex = 3;
            // 
            // k_tel_giris_text
            // 
            this.k_tel_giris_text.Location = new System.Drawing.Point(161, 47);
            this.k_tel_giris_text.Name = "k_tel_giris_text";
            this.k_tel_giris_text.Size = new System.Drawing.Size(140, 20);
            this.k_tel_giris_text.TabIndex = 4;
            // 
            // menu_buton
            // 
            this.menu_buton.Location = new System.Drawing.Point(217, 130);
            this.menu_buton.Name = "menu_buton";
            this.menu_buton.Size = new System.Drawing.Size(84, 23);
            this.menu_buton.TabIndex = 5;
            this.menu_buton.Text = "Çıkış";
            this.menu_buton.UseVisualStyleBackColor = true;
            this.menu_buton.Click += new System.EventHandler(this.menu_buton_Click);
            // 
            // k_tel_label
            // 
            this.k_tel_label.AutoSize = true;
            this.k_tel_label.Location = new System.Drawing.Point(109, 50);
            this.k_tel_label.Name = "k_tel_label";
            this.k_tel_label.Size = new System.Drawing.Size(46, 13);
            this.k_tel_label.TabIndex = 6;
            this.k_tel_label.Text = "Telefon:";
            // 
            // giris_yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 185);
            this.Controls.Add(this.k_tel_label);
            this.Controls.Add(this.menu_buton);
            this.Controls.Add(this.k_tel_giris_text);
            this.Controls.Add(this.giris_sifre_text);
            this.Controls.Add(this.sifre_giris_label);
            this.Controls.Add(this.giris_yap_buton);
            this.Name = "giris_yap";
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_yap_buton;
        private System.Windows.Forms.Label sifre_giris_label;
        private System.Windows.Forms.TextBox giris_sifre_text;
        private System.Windows.Forms.TextBox k_tel_giris_text;
        private System.Windows.Forms.Button menu_buton;
        private System.Windows.Forms.Label k_tel_label;
    }
}