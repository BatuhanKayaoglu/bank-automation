namespace otomasyon
{
    partial class havale_islemi
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
            this.y_kisi_text = new System.Windows.Forms.TextBox();
            this.y_miktar_text = new System.Windows.Forms.TextBox();
            this.para_yatir_lbl = new System.Windows.Forms.Label();
            this.y_kisi_label = new System.Windows.Forms.Label();
            this.y_miktar = new System.Windows.Forms.Label();
            this.para_gonder_buton = new System.Windows.Forms.Button();
            this.bakiye_lbl = new System.Windows.Forms.Label();
            this.ad_soyad_lbl = new System.Windows.Forms.Label();
            this.menu_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // y_kisi_text
            // 
            this.y_kisi_text.Location = new System.Drawing.Point(189, 80);
            this.y_kisi_text.Name = "y_kisi_text";
            this.y_kisi_text.Size = new System.Drawing.Size(135, 20);
            this.y_kisi_text.TabIndex = 0;
            // 
            // y_miktar_text
            // 
            this.y_miktar_text.Location = new System.Drawing.Point(189, 116);
            this.y_miktar_text.Name = "y_miktar_text";
            this.y_miktar_text.Size = new System.Drawing.Size(135, 20);
            this.y_miktar_text.TabIndex = 1;
            // 
            // para_yatir_lbl
            // 
            this.para_yatir_lbl.AutoSize = true;
            this.para_yatir_lbl.Location = new System.Drawing.Point(49, 50);
            this.para_yatir_lbl.Name = "para_yatir_lbl";
            this.para_yatir_lbl.Size = new System.Drawing.Size(41, 13);
            this.para_yatir_lbl.TabIndex = 18;
            this.para_yatir_lbl.Text = "Havale";
            // 
            // y_kisi_label
            // 
            this.y_kisi_label.AutoSize = true;
            this.y_kisi_label.Location = new System.Drawing.Point(48, 80);
            this.y_kisi_label.Name = "y_kisi_label";
            this.y_kisi_label.Size = new System.Drawing.Size(134, 13);
            this.y_kisi_label.TabIndex = 21;
            this.y_kisi_label.Text = "Yatırılacak Kişini Telefonu: ";
            // 
            // y_miktar
            // 
            this.y_miktar.AutoSize = true;
            this.y_miktar.Location = new System.Drawing.Point(49, 116);
            this.y_miktar.Name = "y_miktar";
            this.y_miktar.Size = new System.Drawing.Size(97, 13);
            this.y_miktar.TabIndex = 22;
            this.y_miktar.Text = "Yatıcılacak Miktar: ";
            // 
            // para_gonder_buton
            // 
            this.para_gonder_buton.Location = new System.Drawing.Point(107, 164);
            this.para_gonder_buton.Name = "para_gonder_buton";
            this.para_gonder_buton.Size = new System.Drawing.Size(75, 23);
            this.para_gonder_buton.TabIndex = 23;
            this.para_gonder_buton.Text = "Gönder";
            this.para_gonder_buton.UseVisualStyleBackColor = true;
            this.para_gonder_buton.Click += new System.EventHandler(this.para_gonder_buton_Click);
            // 
            // bakiye_lbl
            // 
            this.bakiye_lbl.AutoSize = true;
            this.bakiye_lbl.Location = new System.Drawing.Point(310, 13);
            this.bakiye_lbl.Name = "bakiye_lbl";
            this.bakiye_lbl.Size = new System.Drawing.Size(39, 13);
            this.bakiye_lbl.TabIndex = 24;
            this.bakiye_lbl.Text = "Bakiye";
            // 
            // ad_soyad_lbl
            // 
            this.ad_soyad_lbl.AutoSize = true;
            this.ad_soyad_lbl.Location = new System.Drawing.Point(49, 13);
            this.ad_soyad_lbl.Name = "ad_soyad_lbl";
            this.ad_soyad_lbl.Size = new System.Drawing.Size(62, 13);
            this.ad_soyad_lbl.TabIndex = 25;
            this.ad_soyad_lbl.Text = "Ad: Soyad: ";
            // 
            // menu_buton
            // 
            this.menu_buton.Location = new System.Drawing.Point(249, 164);
            this.menu_buton.Name = "menu_buton";
            this.menu_buton.Size = new System.Drawing.Size(75, 23);
            this.menu_buton.TabIndex = 26;
            this.menu_buton.Text = "Menü";
            this.menu_buton.UseVisualStyleBackColor = true;
            this.menu_buton.Click += new System.EventHandler(this.menu_buton_Click);
            // 
            // havale_islemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 199);
            this.Controls.Add(this.menu_buton);
            this.Controls.Add(this.ad_soyad_lbl);
            this.Controls.Add(this.bakiye_lbl);
            this.Controls.Add(this.para_gonder_buton);
            this.Controls.Add(this.y_miktar);
            this.Controls.Add(this.y_kisi_label);
            this.Controls.Add(this.para_yatir_lbl);
            this.Controls.Add(this.y_miktar_text);
            this.Controls.Add(this.y_kisi_text);
            this.Name = "havale_islemi";
            this.Text = "havale_islemi";
            this.Load += new System.EventHandler(this.havale_islemi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox y_kisi_text;
        private System.Windows.Forms.TextBox y_miktar_text;
        private System.Windows.Forms.Label para_yatir_lbl;
        private System.Windows.Forms.Label y_kisi_label;
        private System.Windows.Forms.Label y_miktar;
        private System.Windows.Forms.Button para_gonder_buton;
        private System.Windows.Forms.Label bakiye_lbl;
        private System.Windows.Forms.Label ad_soyad_lbl;
        private System.Windows.Forms.Button menu_buton;
    }
}