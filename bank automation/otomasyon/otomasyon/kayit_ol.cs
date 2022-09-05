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
    public partial class kayit_ol : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        
        public kayit_ol()
        {
            InitializeComponent();
        }

        private void kayit_ol_buton_Click(object sender, EventArgs e)
        {
            int kontrol = email_text.Text.IndexOf("@gmail");

            if (ad_text.Text=="" || soyad_text.Text=="" || telefon_text.Text=="" || sifre_text.Text=="" || bakiye_text.Text=="" || email_text.Text=="")
            {
                MessageBox.Show("Kayıt Olma Ekranındaki Hiçbir Bilgi Kutusu Boş Bırakılamaz!");
            }


            else if (ad_text.Text.Length < 3 || soyad_text.Text.Length < 3)
            {
                MessageBox.Show("Adınız veya Soyadınız En Az 3 Harfli Olamlıdır.");
            }

            else if (telefon_text.Text.Length < 10)
            {
                MessageBox.Show("Telefonunuz 10 Rakam İçermelidir !!!");
            }

            else if (kontrol == -1)
            {
                MessageBox.Show("E-mail Adresiniz '@gmail' İbaresini İçermelidir");
            }

            else if (sifre_text.Text.Length < 8) 
            {
                MessageBox.Show("Şifreniz En Az 8 Karakter Uzunluğuna Sahip Olmalıdır.");
            }


            else
            {
                baglanti.Open();
                string kayit = "insert into musteri_tablo(musteriAd,musteriSoyad,musteriTelefon,musteriSifre,musteriBakiye,musteriEmail) VALUES (@ad,@soyad,@telefon,@sifre,@bakiye,@email)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@ad", ad_text.Text);
                komut.Parameters.AddWithValue("@soyad", soyad_text.Text);
                komut.Parameters.AddWithValue("@telefon", telefon_text.Text);
                komut.Parameters.AddWithValue("@sifre", sifre_text.Text);
                komut.Parameters.AddWithValue("@bakiye", bakiye_text.Text);
                komut.Parameters.AddWithValue("@email", email_text.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ad_text.Clear(); soyad_text.Clear(); telefon_text.Clear(); sifre_text.Clear(); bakiye_text.Clear(); email_text.Clear();
                MessageBox.Show("Kayıt İşleminiz Başarıyla Tamamlandı, Bankamıza Hoşgeldiniz.");
                ana_ekran yonlendir = new ana_ekran();
                yonlendir.Show();
                this.Hide();
            }

        }

        private void menu_buton_Click(object sender, EventArgs e)
        {
            ana_ekran yonlendir = new ana_ekran();
            yonlendir.Show();
            this.Hide();
        }
    }
}
