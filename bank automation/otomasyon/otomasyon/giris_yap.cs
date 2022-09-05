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
    public partial class giris_yap : Form
    {
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        public giris_yap()
        {
            InitializeComponent();
        }

        private void giris_yap_buton_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            string kayit = "select musteriId from musteri_tablo where musteriTelefon=@telefon and musteriSifre=@sifre";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@telefon", k_tel_giris_text.Text);
            komut.Parameters.AddWithValue("@sifre", giris_sifre_text.Text);
            oku=komut.ExecuteReader();
            if (oku.Read()) 
            {
               int id = (int)oku["musteriId"];
               islemler yonlendir = new islemler();
               yonlendir.k_id = id;
               yonlendir.Show();
               this.Hide();   
            }

            else if ((k_tel_giris_text.Text == "") || (giris_sifre_text.Text == ""))
            {
                MessageBox.Show("Kullanıcı Telefonu/Şifre Boş Bırakılamaz!!!!");
            }

            else
            {
                MessageBox.Show("Bilgileriniz Yanlış, Lütfen Yeniden Deneyin...");
                k_tel_giris_text.Clear();
                giris_sifre_text.Clear();
            }

            baglanti.Close();
        }

        private void menu_buton_Click(object sender, EventArgs e)
        {
            ana_ekran yonlendir = new ana_ekran();
            yonlendir.Show();
            this.Hide();
        }
    }
}
