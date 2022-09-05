namespace otomasyon
{
    partial class ana_ekran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.hg_label = new System.Windows.Forms.Label();
            this.kayit_ol_buton = new System.Windows.Forms.Button();
            this.giris_yap_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hg_label
            // 
            this.hg_label.AutoSize = true;
            this.hg_label.Location = new System.Drawing.Point(120, 28);
            this.hg_label.Name = "hg_label";
            this.hg_label.Size = new System.Drawing.Size(61, 13);
            this.hg_label.TabIndex = 0;
            this.hg_label.Text = "Hoşgeldiniz";
            // 
            // kayit_ol_buton
            // 
            this.kayit_ol_buton.Location = new System.Drawing.Point(106, 61);
            this.kayit_ol_buton.Name = "kayit_ol_buton";
            this.kayit_ol_buton.Size = new System.Drawing.Size(95, 40);
            this.kayit_ol_buton.TabIndex = 1;
            this.kayit_ol_buton.Text = "Kayıt Ol";
            this.kayit_ol_buton.UseVisualStyleBackColor = true;
            this.kayit_ol_buton.Click += new System.EventHandler(this.kayit_ol_buton_Click);
            // 
            // giris_yap_buton
            // 
            this.giris_yap_buton.Location = new System.Drawing.Point(106, 122);
            this.giris_yap_buton.Name = "giris_yap_buton";
            this.giris_yap_buton.Size = new System.Drawing.Size(95, 38);
            this.giris_yap_buton.TabIndex = 2;
            this.giris_yap_buton.Text = "Giriş Yap";
            this.giris_yap_buton.UseVisualStyleBackColor = true;
            this.giris_yap_buton.Click += new System.EventHandler(this.giris_yap_buton_Click);
            // 
            // ana_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 193);
            this.Controls.Add(this.giris_yap_buton);
            this.Controls.Add(this.kayit_ol_buton);
            this.Controls.Add(this.hg_label);
            this.Name = "ana_ekran";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hg_label;
        private System.Windows.Forms.Button kayit_ol_buton;
        private System.Windows.Forms.Button giris_yap_buton;
    }
}

