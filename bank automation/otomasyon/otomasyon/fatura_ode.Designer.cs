namespace otomasyon
{
    partial class fatura_ode
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
            this.fatura_combobox = new System.Windows.Forms.ComboBox();
            this.faturaFiyat_Textbox = new System.Windows.Forms.TextBox();
            this.fatura_ode_lbl = new System.Windows.Forms.Label();
            this.faturaOdeButon = new System.Windows.Forms.Button();
            this.ad_soyad_lbl = new System.Windows.Forms.Label();
            this.bakiye_lbl = new System.Windows.Forms.Label();
            this.fatura_turu_label = new System.Windows.Forms.Label();
            this.fatura_tutar_label = new System.Windows.Forms.Label();
            this.menu_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatura_combobox
            // 
            this.fatura_combobox.FormattingEnabled = true;
            this.fatura_combobox.Location = new System.Drawing.Point(127, 74);
            this.fatura_combobox.Name = "fatura_combobox";
            this.fatura_combobox.Size = new System.Drawing.Size(119, 21);
            this.fatura_combobox.TabIndex = 0;
            this.fatura_combobox.SelectedIndexChanged += new System.EventHandler(this.fatura_combobox_SelectedIndexChanged);
            // 
            // faturaFiyat_Textbox
            // 
            this.faturaFiyat_Textbox.Location = new System.Drawing.Point(127, 101);
            this.faturaFiyat_Textbox.Name = "faturaFiyat_Textbox";
            this.faturaFiyat_Textbox.Size = new System.Drawing.Size(119, 20);
            this.faturaFiyat_Textbox.TabIndex = 1;
            this.faturaFiyat_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fatura_ode_lbl
            // 
            this.fatura_ode_lbl.AutoSize = true;
            this.fatura_ode_lbl.Location = new System.Drawing.Point(124, 9);
            this.fatura_ode_lbl.Name = "fatura_ode_lbl";
            this.fatura_ode_lbl.Size = new System.Drawing.Size(61, 13);
            this.fatura_ode_lbl.TabIndex = 2;
            this.fatura_ode_lbl.Text = "Fatura Yatır";
            // 
            // faturaOdeButon
            // 
            this.faturaOdeButon.Location = new System.Drawing.Point(68, 127);
            this.faturaOdeButon.Name = "faturaOdeButon";
            this.faturaOdeButon.Size = new System.Drawing.Size(79, 23);
            this.faturaOdeButon.TabIndex = 3;
            this.faturaOdeButon.Text = "Fatura Yatır";
            this.faturaOdeButon.UseVisualStyleBackColor = true;
            this.faturaOdeButon.Click += new System.EventHandler(this.faturaOdeButon_Click);
            // 
            // ad_soyad_lbl
            // 
            this.ad_soyad_lbl.AutoSize = true;
            this.ad_soyad_lbl.Location = new System.Drawing.Point(35, 36);
            this.ad_soyad_lbl.Name = "ad_soyad_lbl";
            this.ad_soyad_lbl.Size = new System.Drawing.Size(23, 13);
            this.ad_soyad_lbl.TabIndex = 5;
            this.ad_soyad_lbl.Text = "Ad:";
            // 
            // bakiye_lbl
            // 
            this.bakiye_lbl.AutoSize = true;
            this.bakiye_lbl.Location = new System.Drawing.Point(235, 36);
            this.bakiye_lbl.Name = "bakiye_lbl";
            this.bakiye_lbl.Size = new System.Drawing.Size(45, 13);
            this.bakiye_lbl.TabIndex = 6;
            this.bakiye_lbl.Text = "Bakiye: ";
            // 
            // fatura_turu_label
            // 
            this.fatura_turu_label.AutoSize = true;
            this.fatura_turu_label.Location = new System.Drawing.Point(65, 77);
            this.fatura_turu_label.Name = "fatura_turu_label";
            this.fatura_turu_label.Size = new System.Drawing.Size(40, 13);
            this.fatura_turu_label.TabIndex = 7;
            this.fatura_turu_label.Text = "Fatura:";
            // 
            // fatura_tutar_label
            // 
            this.fatura_tutar_label.AutoSize = true;
            this.fatura_tutar_label.Location = new System.Drawing.Point(65, 104);
            this.fatura_tutar_label.Name = "fatura_tutar_label";
            this.fatura_tutar_label.Size = new System.Drawing.Size(38, 13);
            this.fatura_tutar_label.TabIndex = 8;
            this.fatura_tutar_label.Text = "Tutar: ";
            // 
            // menu_buton
            // 
            this.menu_buton.Location = new System.Drawing.Point(171, 127);
            this.menu_buton.Name = "menu_buton";
            this.menu_buton.Size = new System.Drawing.Size(75, 23);
            this.menu_buton.TabIndex = 9;
            this.menu_buton.Text = "Menü";
            this.menu_buton.UseVisualStyleBackColor = true;
            this.menu_buton.Click += new System.EventHandler(this.menu_buton_Click);
            // 
            // fatura_ode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 176);
            this.Controls.Add(this.menu_buton);
            this.Controls.Add(this.fatura_tutar_label);
            this.Controls.Add(this.fatura_turu_label);
            this.Controls.Add(this.bakiye_lbl);
            this.Controls.Add(this.ad_soyad_lbl);
            this.Controls.Add(this.faturaOdeButon);
            this.Controls.Add(this.fatura_ode_lbl);
            this.Controls.Add(this.faturaFiyat_Textbox);
            this.Controls.Add(this.fatura_combobox);
            this.Name = "fatura_ode";
            this.Text = "Fatura Yatır";
            this.Load += new System.EventHandler(this.fatura_ode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fatura_combobox;
        private System.Windows.Forms.TextBox faturaFiyat_Textbox;
        private System.Windows.Forms.Label fatura_ode_lbl;
        private System.Windows.Forms.Button faturaOdeButon;
        private System.Windows.Forms.Label ad_soyad_lbl;
        private System.Windows.Forms.Label bakiye_lbl;
        private System.Windows.Forms.Label fatura_turu_label;
        private System.Windows.Forms.Label fatura_tutar_label;
        private System.Windows.Forms.Button menu_buton;
    }
}