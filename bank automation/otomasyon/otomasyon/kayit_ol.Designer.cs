namespace otomasyon
{
    partial class kayit_ol
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
            this.ad_label = new System.Windows.Forms.Label();
            this.ad_text = new System.Windows.Forms.TextBox();
            this.bakiye_text = new System.Windows.Forms.TextBox();
            this.sifre_label = new System.Windows.Forms.Label();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.bakiye_label = new System.Windows.Forms.Label();
            this.telefon_text = new System.Windows.Forms.TextBox();
            this.telefon_label = new System.Windows.Forms.Label();
            this.soyad_text = new System.Windows.Forms.TextBox();
            this.soyad_label = new System.Windows.Forms.Label();
            this.kayit_ol_buton = new System.Windows.Forms.Button();
            this.menu_buton = new System.Windows.Forms.Button();
            this.email_label = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Location = new System.Drawing.Point(234, 71);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(23, 13);
            this.ad_label.TabIndex = 0;
            this.ad_label.Text = "Ad:";
            // 
            // ad_text
            // 
            this.ad_text.Location = new System.Drawing.Point(314, 71);
            this.ad_text.Name = "ad_text";
            this.ad_text.Size = new System.Drawing.Size(100, 20);
            this.ad_text.TabIndex = 1;
            // 
            // bakiye_text
            // 
            this.bakiye_text.Location = new System.Drawing.Point(314, 251);
            this.bakiye_text.Name = "bakiye_text";
            this.bakiye_text.Size = new System.Drawing.Size(100, 20);
            this.bakiye_text.TabIndex = 3;
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.Location = new System.Drawing.Point(234, 221);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(31, 13);
            this.sifre_label.TabIndex = 2;
            this.sifre_label.Text = "Şifre:";
            // 
            // sifre_text
            // 
            this.sifre_text.Location = new System.Drawing.Point(314, 218);
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.PasswordChar = '*';
            this.sifre_text.Size = new System.Drawing.Size(100, 20);
            this.sifre_text.TabIndex = 5;
            // 
            // bakiye_label
            // 
            this.bakiye_label.AutoSize = true;
            this.bakiye_label.Location = new System.Drawing.Point(232, 258);
            this.bakiye_label.Name = "bakiye_label";
            this.bakiye_label.Size = new System.Drawing.Size(42, 13);
            this.bakiye_label.TabIndex = 4;
            this.bakiye_label.Text = "Bakiye:";
            // 
            // telefon_text
            // 
            this.telefon_text.Location = new System.Drawing.Point(314, 147);
            this.telefon_text.Name = "telefon_text";
            this.telefon_text.Size = new System.Drawing.Size(100, 20);
            this.telefon_text.TabIndex = 7;
            // 
            // telefon_label
            // 
            this.telefon_label.AutoSize = true;
            this.telefon_label.Location = new System.Drawing.Point(234, 154);
            this.telefon_label.Name = "telefon_label";
            this.telefon_label.Size = new System.Drawing.Size(46, 13);
            this.telefon_label.TabIndex = 6;
            this.telefon_label.Text = "Telefon:";
            // 
            // soyad_text
            // 
            this.soyad_text.Location = new System.Drawing.Point(314, 110);
            this.soyad_text.Name = "soyad_text";
            this.soyad_text.Size = new System.Drawing.Size(100, 20);
            this.soyad_text.TabIndex = 9;
            // 
            // soyad_label
            // 
            this.soyad_label.AutoSize = true;
            this.soyad_label.Location = new System.Drawing.Point(234, 110);
            this.soyad_label.Name = "soyad_label";
            this.soyad_label.Size = new System.Drawing.Size(40, 13);
            this.soyad_label.TabIndex = 8;
            this.soyad_label.Text = "Soyad:";
            // 
            // kayit_ol_buton
            // 
            this.kayit_ol_buton.Location = new System.Drawing.Point(237, 295);
            this.kayit_ol_buton.Name = "kayit_ol_buton";
            this.kayit_ol_buton.Size = new System.Drawing.Size(88, 27);
            this.kayit_ol_buton.TabIndex = 10;
            this.kayit_ol_buton.Text = "Kayıt Ol";
            this.kayit_ol_buton.UseVisualStyleBackColor = true;
            this.kayit_ol_buton.Click += new System.EventHandler(this.kayit_ol_buton_Click);
            // 
            // menu_buton
            // 
            this.menu_buton.Location = new System.Drawing.Point(380, 295);
            this.menu_buton.Name = "menu_buton";
            this.menu_buton.Size = new System.Drawing.Size(85, 26);
            this.menu_buton.TabIndex = 11;
            this.menu_buton.Text = "Çıkış";
            this.menu_buton.UseVisualStyleBackColor = true;
            this.menu_buton.Click += new System.EventHandler(this.menu_buton_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(234, 193);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(38, 13);
            this.email_label.TabIndex = 12;
            this.email_label.Text = "E-mail:";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(314, 186);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(100, 20);
            this.email_text.TabIndex = 13;
            // 
            // kayit_ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 367);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.menu_buton);
            this.Controls.Add(this.kayit_ol_buton);
            this.Controls.Add(this.soyad_text);
            this.Controls.Add(this.soyad_label);
            this.Controls.Add(this.telefon_text);
            this.Controls.Add(this.telefon_label);
            this.Controls.Add(this.sifre_text);
            this.Controls.Add(this.bakiye_label);
            this.Controls.Add(this.bakiye_text);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.ad_text);
            this.Controls.Add(this.ad_label);
            this.Name = "kayit_ol";
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.TextBox ad_text;
        private System.Windows.Forms.TextBox bakiye_text;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.TextBox sifre_text;
        private System.Windows.Forms.Label bakiye_label;
        private System.Windows.Forms.TextBox telefon_text;
        private System.Windows.Forms.Label telefon_label;
        private System.Windows.Forms.TextBox soyad_text;
        private System.Windows.Forms.Label soyad_label;
        private System.Windows.Forms.Button kayit_ol_buton;
        private System.Windows.Forms.Button menu_buton;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_text;
    }
}