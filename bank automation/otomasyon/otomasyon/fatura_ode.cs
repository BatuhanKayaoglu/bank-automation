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
    public partial class fatura_ode : Form
    {
        public fatura_ode()
        {
            InitializeComponent();
            
        }
        private int tutar,bakiye;
        public int k_faturaId;

        void geriDon() 
        {
            this.Hide();
            islemler yonlendir = new islemler();
            yonlendir.k_id = k_faturaId;
            yonlendir.Show();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        SqlDataReader oku;

        private void fatura_ode_Load(object sender, EventArgs e)
        {
            string ad, soyad;
            baglanti.Open();
            string kayit = "select musteriAd,musteriSoyad,musteriBakiye from musteri_tablo where musteriId=@id";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@id", k_faturaId);
            oku = komut.ExecuteReader();
            oku.Read();
            bakiye = (int)oku["musteriBakiye"];
            ad = (string)oku["musteriAd"];
            soyad = (string)oku["musteriSoyad"];
            baglanti.Close();

            ad_soyad_lbl.Text = ad + " " + soyad;
            bakiye_lbl.Text = bakiye.ToString();

            fatura_combobox.Items.Add("---faturayı seçiniz---");
            fatura_combobox.Items.Add("Elektrik");
            fatura_combobox.Items.Add("Doğalgaz");
            fatura_combobox.Items.Add("Internet");
            fatura_combobox.Items.Add("Su");
            fatura_combobox.SelectedIndex = 0;
        }

       

        private void fatura_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fatura_combobox.SelectedIndex != 0)
            {
                Random random = new Random();
                tutar = random.Next(50, 150);
                faturaFiyat_Textbox.Text = tutar.ToString();
            }

        }

        private void menu_buton_Click(object sender, EventArgs e)
        {
            geriDon();
        }

        private void faturaOdeButon_Click(object sender, EventArgs e)
        {
            if (fatura_combobox.SelectedIndex != 0)
            {
                baglanti.Open();
                string kayit = "update musteri_tablo set musteriBakiye-=@cekilecek where musteriId=@id";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@cekilecek", tutar);
                komut.Parameters.AddWithValue("@id", k_faturaId);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                string kayit2 = "select musteriBakiye from musteri_tablo where musteriId=@id";
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
                komut2.Parameters.AddWithValue("@id", k_faturaId);
                oku = komut2.ExecuteReader();
                oku.Read();
                bakiye = (int)oku["musteriBakiye"];
                baglanti.Close();

                bakiye_lbl.Text = bakiye.ToString();

                fatura_combobox.Items.Remove(fatura_combobox.SelectedItem);
                faturaFiyat_Textbox.Clear();
                MessageBox.Show(tutar + " TL Tutarındaki " + fatura_combobox.Text + " Faturanız Ödenmiştir.");
            }

            else 
            {
                MessageBox.Show("Ödeyeceğiniz Faturayı Seçin!");
            }


            fatura_combobox.SelectedIndex = 0;


            if(fatura_combobox.Items.Count == 1) 
            {
                MessageBox.Show("Başka Ödeyecek Faturanız Kalmadı, İşlemler Sayfasına Yönlendiriliyorsunuz...");
                geriDon();
            }
        }

    }
}
