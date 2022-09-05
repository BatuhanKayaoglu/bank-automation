namespace otomasyon
{
    partial class sifre_degistir
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
            this.eski_sifre_label = new System.Windows.Forms.Label();
            this.yeni_sifre_label = new System.Windows.Forms.Label();
            this.tekrar_sifre_label = new System.Windows.Forms.Label();
            this.sifre_degistir_btn = new System.Windows.Forms.Button();
            this.eski_sifre_text = new System.Windows.Forms.TextBox();
            this.yeni_sifre_text = new System.Windows.Forms.TextBox();
            this.tekrar_sifre_text = new System.Windows.Forms.TextBox();
            this.sifre_degistir_baslik = new System.Windows.Forms.Label();
            this.dogrulama_text = new System.Windows.Forms.TextBox();
            this.dogrulama_lbl = new System.Windows.Forms.Label();
            this.dogrula_buton = new System.Windows.Forms.Button();
            this.menu_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eski_sifre_label
            // 
            this.eski_sifre_label.AutoSize = true;
            this.eski_sifre_label.Location = new System.Drawing.Point(44, 59);
            this.eski_sifre_label.Name = "eski_sifre_label";
            this.eski_sifre_label.Size = new System.Drawing.Size(54, 13);
            this.eski_sifre_label.TabIndex = 0;
            this.eski_sifre_label.Text = "Eski Şife: ";
            // 
            // yeni_sifre_label
            // 
            this.yeni_sifre_label.AutoSize = true;
            this.yeni_sifre_label.Location = new System.Drawing.Point(44, 91);
            this.yeni_sifre_label.Name = "yeni_sifre_label";
            this.yeni_sifre_label.Size = new System.Drawing.Size(52, 13);
            this.yeni_sifre_label.TabIndex = 1;
            this.yeni_sifre_label.Text = "Yeni Şifre";
            // 
            // tekrar_sifre_label
            // 
            this.tekrar_sifre_label.AutoSize = true;
            this.tekrar_sifre_label.Location = new System.Drawing.Point(28, 124);
            this.tekrar_sifre_label.Name = "tekrar_sifre_label";
            this.tekrar_sifre_label.Size = new System.Drawing.Size(98, 13);
            this.tekrar_sifre_label.TabIndex = 2;
            this.tekrar_sifre_label.Text = "Yeni Şifre (Tekrar): ";
            // 
            // sifre_degistir_btn
            // 
            this.sifre_degistir_btn.Location = new System.Drawing.Point(174, 147);
            this.sifre_degistir_btn.Name = "sifre_degistir_btn";
            this.sifre_degistir_btn.Size = new System.Drawing.Size(75, 23);
            this.sifre_degistir_btn.TabIndex = 3;
            this.sifre_degistir_btn.Text = "Şifre Değiştir";
            this.sifre_degistir_btn.UseVisualStyleBackColor = true;
            this.sifre_degistir_btn.Click += new System.EventHandler(this.sifre_degistir_btn_Click);
            // 
            // eski_sifre_text
            // 
            this.eski_sifre_text.Location = new System.Drawing.Point(132, 52);
            this.eski_sifre_text.Name = "eski_sifre_text";
            this.eski_sifre_text.PasswordChar = '*';
            this.eski_sifre_text.Size = new System.Drawing.Size(162, 20);
            this.eski_sifre_text.TabIndex = 4;
            // 
            // yeni_sifre_text
            // 
            this.yeni_sifre_text.Location = new System.Drawing.Point(132, 88);
            this.yeni_sifre_text.Name = "yeni_sifre_text";
            this.yeni_sifre_text.PasswordChar = '*';
            this.yeni_sifre_text.Size = new System.Drawing.Size(162, 20);
            this.yeni_sifre_text.TabIndex = 5;
            // 
            // tekrar_sifre_text
            // 
            this.tekrar_sifre_text.Location = new System.Drawing.Point(132, 121);
            this.tekrar_sifre_text.Name = "tekrar_sifre_text";
            this.tekrar_sifre_text.PasswordChar = '*';
            this.tekrar_sifre_text.Size = new System.Drawing.Size(162, 20);
            this.tekrar_sifre_text.TabIndex = 6;
            // 
            // sifre_degistir_baslik
            // 
            this.sifre_degistir_baslik.AutoSize = true;
            this.sifre_degistir_baslik.Location = new System.Drawing.Point(119, 18);
            this.sifre_degistir_baslik.Name = "sifre_degistir_baslik";
            this.sifre_degistir_baslik.Size = new System.Drawing.Size(69, 13);
            this.sifre_degistir_baslik.TabIndex = 7;
            this.sifre_degistir_baslik.Text = "Şifre Değiştir;";
            // 
            // dogrulama_text
            // 
            this.dogrulama_text.Location = new System.Drawing.Point(132, 179);
            this.dogrulama_text.Name = "dogrulama_text";
            this.dogrulama_text.Size = new System.Drawing.Size(162, 20);
            this.dogrulama_text.TabIndex = 8;
            // 
            // dogrulama_lbl
            // 
            this.dogrulama_lbl.AutoSize = true;
            this.dogrulama_lbl.Location = new System.Drawing.Point(28, 182);
            this.dogrulama_lbl.Name = "dogrulama_lbl";
            this.dogrulama_lbl.Size = new System.Drawing.Size(92, 13);
            this.dogrulama_lbl.TabIndex = 9;
            this.dogrulama_lbl.Text = "Doğrulama Kodu: ";
            // 
            // dogrula_buton
            // 
            this.dogrula_buton.Location = new System.Drawing.Point(174, 208);
            this.dogrula_buton.Name = "dogrula_buton";
            this.dogrula_buton.Size = new System.Drawing.Size(75, 23);
            this.dogrula_buton.TabIndex = 10;
            this.dogrula_buton.Text = "Doğrula";
            this.dogrula_buton.UseVisualStyleBackColor = true;
            this.dogrula_buton.Click += new System.EventHandler(this.dogrula_buton_Click);
            // 
            // menu_buton
            // 
            this.menu_buton.Location = new System.Drawing.Point(31, 208);
            this.menu_buton.Name = "menu_buton";
            this.menu_buton.Size = new System.Drawing.Size(75, 23);
            this.menu_buton.TabIndex = 11;
            this.menu_buton.Text = "Menü";
            this.menu_buton.UseVisualStyleBackColor = true;
            this.menu_buton.Click += new System.EventHandler(this.menu_buton_Click);
            // 
            // sifre_degistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 243);
            this.Controls.Add(this.menu_buton);
            this.Controls.Add(this.dogrula_buton);
            this.Controls.Add(this.dogrulama_lbl);
            this.Controls.Add(this.dogrulama_text);
            this.Controls.Add(this.sifre_degistir_baslik);
            this.Controls.Add(this.tekrar_sifre_text);
            this.Controls.Add(this.yeni_sifre_text);
            this.Controls.Add(this.eski_sifre_text);
            this.Controls.Add(this.sifre_degistir_btn);
            this.Controls.Add(this.tekrar_sifre_label);
            this.Controls.Add(this.yeni_sifre_label);
            this.Controls.Add(this.eski_sifre_label);
            this.Name = "sifre_degistir";
            this.Text = "sifre_degistir";
            this.Load += new System.EventHandler(this.sifre_degistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eski_sifre_label;
        private System.Windows.Forms.Label yeni_sifre_label;
        private System.Windows.Forms.Label tekrar_sifre_label;
        private System.Windows.Forms.Button sifre_degistir_btn;
        private System.Windows.Forms.TextBox eski_sifre_text;
        private System.Windows.Forms.TextBox yeni_sifre_text;
        private System.Windows.Forms.TextBox tekrar_sifre_text;
        private System.Windows.Forms.Label sifre_degistir_baslik;
        private System.Windows.Forms.TextBox dogrulama_text;
        private System.Windows.Forms.Label dogrulama_lbl;
        private System.Windows.Forms.Button dogrula_buton;
        private System.Windows.Forms.Button menu_buton;
    }
}