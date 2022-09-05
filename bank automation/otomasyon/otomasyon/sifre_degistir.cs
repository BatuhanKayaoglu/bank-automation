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
using System.Net;
using System.Net.Mail;
namespace otomasyon
{
    public partial class sifre_degistir : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        SqlDataReader oku;
        public int k_sifre_degistir_id;
        private string email,eskiSifre,kopyaKod;
       

        public sifre_degistir()
        {
            InitializeComponent();
        }

        private void sifre_degistir_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string con = "select musteriSifre,musteriEmail from musteri_tablo where musteriId=@id";
            SqlCommand sendId = new SqlCommand(con, baglanti);
            sendId.Parameters.AddWithValue("@id", k_sifre_degistir_id);
            oku = sendId.ExecuteReader();
            oku.Read();
            email = (string)oku["musteriEmail"];
            eskiSifre = (string)oku["musteriSifre"];
            baglanti.Close();
            dogrulama_text.ReadOnly = true;
            dogrulama_text.Text = "Mail Adresinize Gönderilecek Kodu Buraya Girin.";
        }

        private void menu_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            islemler yonlendir = new islemler();
            yonlendir.k_id = k_sifre_degistir_id;
            yonlendir.Show();
        }

        private void sifre_degistir_btn_Click(object sender, EventArgs e)
        {
            string girilen_eski_sifre = eski_sifre_text.Text;
            string yeni_sifre = yeni_sifre_text.Text;
            string tekrar_sifre = tekrar_sifre_text.Text;
            if (eski_sifre_text.Text=="" || yeni_sifre_text.Text == "" || tekrar_sifre_text.Text == "")
            {
                MessageBox.Show("Bu Sayfadaki Hiçbir Alan Boş Bırakılamaz");
            }

            else
            {
                if (girilen_eski_sifre != eskiSifre)
                {
                    MessageBox.Show("Girdiğiniz Eski Şifreniz Doğru Değil!!!");
                }
                else
                {
                    if (yeni_sifre != tekrar_sifre) 
                    {
                        MessageBox.Show("Şifreler Eşleşmiyor!!!");
                    }

                    else 
                    {
                        if (yeni_sifre_text.Text.Length < 8) 
                        {
                            MessageBox.Show("Şifreniz En Az 8 Karakter Uzunluğuna Sahip Olmalıdır.");
                        }

                        else 
                        {     
                            eski_sifre_text.ReadOnly = true;
                            yeni_sifre_text.ReadOnly = true;
                            tekrar_sifre_text.ReadOnly = true;
                            dogrulama_text.Clear();
                            dogrulama_text.ReadOnly = false;
                            MessageBox.Show("Mail Adresinize Bir Doğrulama Kodu Gönderildi, Doğrulama Kodunu Giriniz.");
                            Random rastgele = new Random();
                            StringBuilder kod = new StringBuilder();
                            for (int i = 0; i < 5; i++)
                            {
                                int ascii = rastgele.Next(65, 91);
                                char karakter = Convert.ToChar(ascii);
                                kod.Append(karakter);
                            }
                            kopyaKod = kod.ToString();
                            MailMessage ePosta = new MailMessage();
                            ePosta.From = new MailAddress("aydinbanka@gmail.com");
                            ePosta.To.Add(email);
                            ePosta.Subject = "Doğrulama Kodu";
                            ePosta.Body = "Doğrulama Kodunuz: "+kopyaKod;
                            SmtpClient smtp = new SmtpClient();
                            smtp.Credentials = new System.Net.NetworkCredential("aydinbanka@gmail.com", "aydin123");
                            smtp.Port = 587;
                            smtp.Host = "smtp.gmail.com";
                            smtp.EnableSsl = true;
                            smtp.Send(ePosta);
                            sifre_degistir_btn.Enabled = false;
                        }
                    }

                }
            }
           
        }

        private void dogrula_buton_Click(object sender, EventArgs e)
        {
            string yeni_sifre = yeni_sifre_text.Text;
            
            if (dogrulama_text.Text == kopyaKod)
            {
                baglanti.Open();
                string sorgu = "update musteri_tablo set musteriSifre=@sifre where musteriId=@id";
                SqlCommand gonderi = new SqlCommand(sorgu, baglanti);
                gonderi.Parameters.AddWithValue("@sifre", yeni_sifre);
                gonderi.Parameters.AddWithValue("@id", k_sifre_degistir_id);
                gonderi.ExecuteNonQuery();
                baglanti.Close();


                MessageBox.Show("Bilgileriniz Başarıyla Güncellenmiştir.");
                this.Hide();
                giris_yap yonlendir = new giris_yap();
                yonlendir.Show();
            }

            else
            {
                MessageBox.Show("E-postanıza Gönderilen Doğrulama Kodunu Yanlış Girdiniz, Lütfen Yeniden Deneyin");
                dogrulama_text.Clear();
            }
        }
    }
}
