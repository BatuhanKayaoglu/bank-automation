using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;

namespace otomasyon
{
    public partial class islemler : Form
    {

        SqlDataReader oku;
  
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        public int k_id;
        
        public islemler()
        {
            InitializeComponent();
        }

       
        private void islemler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "select musteriAd,musteriSoyad,musteriBakiye from musteri_tablo where musteriId=@id";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@id", k_id);
            oku = komut.ExecuteReader();
            oku.Read();
            string ad = (string)oku["musteriAd"];
            string soyad = (string)oku["musteriSoyad"];
            int bakiye= (int)oku["musteriBakiye"];
            giris_k_ad_label.Text = "Hoşgeldiniz, " + ad + " " + soyad;
            k_bakiye_label.Text = "Bakiyeniz: " + bakiye;
            baglanti.Close();
    }
      

      

        private void bilgi_guncelle_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            bilgi_guncelle yonlendir = new bilgi_guncelle();
            yonlendir.k_guncelle_id = k_id;
            yonlendir.Show();

        }

        private void sifre_degistir_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sifre_degistir yonlendir = new sifre_degistir();
            yonlendir.k_sifre_degistir_id = k_id;
            yonlendir.Show();
        }

        private void para_cek_yonlendir_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            para_cek yonlendir = new para_cek();
            yonlendir.k_cek_id = k_id;
            yonlendir.Show();

        }

        private void para_yatir_yonlendir_Click(object sender, EventArgs e)
        {
            this.Hide();
            para_yatir yonlendir = new para_yatir();
            yonlendir.k_yatir_id = k_id;
            yonlendir.Show();
        }

        private void havale_yonlendir_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            havale_islemi yonlendir = new havale_islemi();
            yonlendir.k_havale_id = k_id;
            yonlendir.Show();
        }

        private void cikis_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana_ekran yonlendir = new ana_ekran();
            yonlendir.Show();
        }

        private void fatura_ode_yonlendir_Click(object sender, EventArgs e)
        {
            this.Hide();
            fatura_ode yonlendir = new fatura_ode();
            yonlendir.k_faturaId = k_id;
            yonlendir.Show();
        }
    }
}
