namespace otomasyon
{
    partial class para_yatir
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
            this.para_yatir_text = new System.Windows.Forms.TextBox();
            this.para_yatir_buton = new System.Windows.Forms.Button();
            this.baslik_label = new System.Windows.Forms.Label();
            this.menu_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // para_yatir_text
            // 
            this.para_yatir_text.Location = new System.Drawing.Point(106, 55);
            this.para_yatir_text.Name = "para_yatir_text";
            this.para_yatir_text.Size = new System.Drawing.Size(157, 20);
            this.para_yatir_text.TabIndex = 0;
            // 
            // para_yatir_buton
            // 
            this.para_yatir_buton.Location = new System.Drawing.Point(106, 81);
            this.para_yatir_buton.Name = "para_yatir_buton";
            this.para_yatir_buton.Size = new System.Drawing.Size(75, 23);
            this.para_yatir_buton.TabIndex = 1;
            this.para_yatir_buton.Text = "Para Yatır";
            this.para_yatir_buton.UseVisualStyleBackColor = true;
            this.para_yatir_buton.Click += new System.EventHandler(this.para_yatir_buton_Click);
            // 
            // baslik_label
            // 
            this.baslik_label.AutoSize = true;
            this.baslik_label.Location = new System.Drawing.Point(158, 29);
            this.baslik_label.Name = "baslik_label";
            this.baslik_label.Size = new System.Drawing.Size(53, 13);
            this.baslik_label.TabIndex = 2;
            this.baslik_label.Text = "Para Yatır";
            // 
            // menu_buton
            // 
            this.menu_buton.Location = new System.Drawing.Point(188, 82);
            this.menu_buton.Name = "menu_buton";
            this.menu_buton.Size = new System.Drawing.Size(75, 23);
            this.menu_buton.TabIndex = 3;
            this.menu_buton.Text = "Menü";
            this.menu_buton.UseVisualStyleBackColor = true;
            this.menu_buton.Click += new System.EventHandler(this.menu_buton_Click);
            // 
            // para_yatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 131);
            this.Controls.Add(this.menu_buton);
            this.Controls.Add(this.baslik_label);
            this.Controls.Add(this.para_yatir_buton);
            this.Controls.Add(this.para_yatir_text);
            this.Name = "para_yatir";
            this.Text = "Para Yaıtr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox para_yatir_text;
        private System.Windows.Forms.Button para_yatir_buton;
        private System.Windows.Forms.Label baslik_label;
        private System.Windows.Forms.Button menu_buton;
    }
}