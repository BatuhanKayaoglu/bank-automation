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
namespace otomasyon
{
    public partial class bilgi_guncelle : Form
    {
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        public int k_guncelle_id;
        private string ad, soyad, telefon,email;

        public bilgi_guncelle()
        {
            InitializeComponent();
        }
        private void ad_guncelle_text_TextChanged(object sender, EventArgs e)
        {
            guncelle_buton.Enabled = true;
        }

        private void soyad_guncelle_text_TextChanged(object sender, EventArgs e)
        {
            guncelle_buton.Enabled = true;
        }

        private void telefon_guncelle_text_TextChanged(object sender, EventArgs e)
        {
            guncelle_buton.Enabled = true;
        }

        private void e_mail_guncelle_text_TextChanged(object sender, EventArgs e)
        {
            guncelle_buton.Enabled = true;
        }

        private void menu_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            islemler yonlendir = new islemler();
            yonlendir.k_id = k_guncelle_id;
            yonlendir.Show();
        }

        private void bilgi_guncelle_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            string con = "select musteriAd,musteriSoyad,musteriBakiye,musteriTelefon,musteriEmail from musteri_tablo where musteriId=@id";
            SqlCommand sendId = new SqlCommand(con, baglanti);
            sendId.Parameters.AddWithValue("@id", k_guncelle_id);
            oku = sendId.ExecuteReader();
            oku.Read();
            ad = (string)oku["musteriAd"];
            soyad = (string)oku["musteriSoyad"];
            telefon = (string)oku["musteriTelefon"];
            email = (string)oku["musteriEmail"];
            baglanti.Close();
            ad_guncelle_text.Text = ad;
            soyad_guncelle_text.Text = soyad;
            telefon_guncelle_text.Text = telefon;
            e_mail_guncelle_text.Text = email;
            guncelle_buton.Enabled = false;

        }
        
        private void guncelle_buton_Click(object sender, EventArgs e)
        {
            int kontrol = e_mail_guncelle_text.Text.IndexOf("@gmail");

            if (ad_guncelle_text.Text == ad && soyad_guncelle_text.Text == soyad && telefon_guncelle_text.Text == telefon && e_mail_guncelle_text.Text==email)
                {
                    MessageBox.Show("Herhangi Bir Değişiklik Yapmadın !");
                }

                else
                {

                 if(ad_guncelle_text.Text == "" || soyad_guncelle_text.Text == "" || telefon_guncelle_text.Text == "" || e_mail_guncelle_text.Text == "") 
                  
                {
                    MessageBox.Show("Herhangi Bir Bölüm Boş Bırakılamaz !!!");
                }

                else if (ad_guncelle_text.Text.Length < 3 || soyad_guncelle_text.Text.Length < 3)
                {
                    MessageBox.Show("Adınız veya Soyadınız En Az 3 Harfli Olamlıdır.");
                }

                else if(telefon_guncelle_text.Text.Length < 10) 
                {
                    MessageBox.Show("Telefonunuz 10 Rakam İçermelidir !!!");
                }
        
                else if (kontrol!=1) 
                {
                    MessageBox.Show("E-mail Adresiniz '@gmail' İbaresini İçermelidir");
                }

                else 
                {
                    ad = ad_guncelle_text.Text;
                    soyad = soyad_guncelle_text.Text;
                    telefon = telefon_guncelle_text.Text;
                    email = e_mail_guncelle_text.Text;
                    baglanti.Open();
                    string sorgu = "update musteri_tablo set musteriAd=@ad,musteriSoyad=@soyad,musteriTelefon=@tel,musteriEmail=@email where musteriId=@id";
                    SqlCommand gonderi = new SqlCommand(sorgu, baglanti);
                    gonderi.Parameters.AddWithValue("@ad", ad);
                    gonderi.Parameters.AddWithValue("@soyad", soyad);
                    gonderi.Parameters.AddWithValue("@tel", telefon);
                    gonderi.Parameters.AddWithValue("@email", email);
                    gonderi.Parameters.AddWithValue("@id", k_guncelle_id);    
                    gonderi.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Bilgileriniz Başarıyla Güncellenmiştir.");
                    bilgi_guncelle_Load(null, null);
                }

            }
        }
    }


}

