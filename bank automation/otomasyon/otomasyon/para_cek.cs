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
using otomasyon.Models;
namespace otomasyon
{
    public partial class para_cek : Form
    {
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        public int k_cek_id;
        int cekilecek_tutar;
        private string sms,telefon;
        

        public para_cek()
        {
            InitializeComponent();
        }
        public void para_cek_fonksiyon()
        {
            baglanti.Open();
            string kayit = "update musteri_tablo set musteriBakiye-=@cekilecek where musteriId=@id";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@cekilecek", cekilecek_tutar);
            komut.Parameters.AddWithValue("@id", k_cek_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            para_cek_Load(null, null);
        }



        private void para_cek_Load(object sender, EventArgs e)
        {
            string ad,soyad; 
            baglanti.Open();
            string kayit = "select musteriAd,musteriSoyad,musteriTelefon,musteriBakiye from musteri_tablo where musteriId=@id";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@id", k_cek_id);
            oku = komut.ExecuteReader();
            oku.Read();
            int bakiye = (int)oku["musteriBakiye"];
            ad = (string)oku["musteriAd"];
            soyad = (string)oku["musteriSoyad"];
            telefon=(string)oku["musteriTelefon"];
            baglanti.Close();
            kalan_bakiye_label.Text=bakiye.ToString();
            sms = "Sayın " + ad + " " + soyad + " Hesabınızdan " + cekilecek_tutar + " Tl Çekilmiştir.";
        }

        public void smsGonder()
        {
            mesajGonder gonder = new mesajGonder();
            gonder.smsGonder(telefon,sms);
        }

        private void buton10_Click(object sender, EventArgs e)
        {
            cekilecek_tutar = 10;
            para_cek_fonksiyon();
            smsGonder();

        }

        private void buton20_Click(object sender, EventArgs e)
        {
            cekilecek_tutar = 20;
            para_cek_fonksiyon();
            smsGonder();
        }

        private void buton50_Click(object sender, EventArgs e)
        {
            cekilecek_tutar = 50;
            para_cek_fonksiyon();
            smsGonder();
        }

        private void buton100_Click(object sender, EventArgs e)
        {
            cekilecek_tutar = 100;
            para_cek_fonksiyon();
            smsGonder();
        }

        private void buton200_Click(object sender, EventArgs e)
        {
            cekilecek_tutar = 200;
            para_cek_fonksiyon();
            smsGonder();
        }

        private void buton500_Click(object sender, EventArgs e)
        {
            cekilecek_tutar = 500;
            para_cek_fonksiyon();
            smsGonder();
        }

        private void para_cek_buton_Click(object sender, EventArgs e)
        {
            cekilecek_tutar = Convert.ToInt32(para_cek_text.Text);
            if (cekilecek_tutar % 10 != 0)
            {
                MessageBox.Show("Çekeceğiniz Para 10 veya 10'un katı olmalıdır.");

            }
            else
            {
                para_cek_fonksiyon();
                smsGonder();
            }
            para_cek_text.Clear();
        }

        private void menu_buton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            islemler yonlendir = new islemler();
            yonlendir.k_id = k_cek_id;
            yonlendir.Show();  
        }
    }
}
