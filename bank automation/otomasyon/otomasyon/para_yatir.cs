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
    public partial class para_yatir : Form
    {

        public int k_yatir_id;

        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");

        public para_yatir()
        {
            InitializeComponent();
        }

        private void para_yatir_buton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int yatirilacak_tutar = Convert.ToInt32(para_yatir_text.Text);
            if (yatirilacak_tutar < 5) 
            {
                MessageBox.Show("5 Tl'den Az Para Yatırılamaz");
                baglanti.Close();
            }

            else { 
            string kayit = "update musteri_tablo set musteriBakiye+=@cekilecek where musteriId=@id";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@cekilecek", yatirilacak_tutar);
            komut.Parameters.AddWithValue("@id", k_yatir_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hesabınıza " + yatirilacak_tutar + " Tl Eklenmiştir, İşlemler Sayfasına Yönlendiriliyorsunuz...");
            this.Hide();
            islemler yonlendir = new islemler();
                yonlendir.k_id = k_yatir_id;
            yonlendir.Show();
                
            }

        }
        private void menu_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            islemler yonlendir = new islemler();
            yonlendir.k_id = k_yatir_id;
            yonlendir.Show();
        }
    }
}
