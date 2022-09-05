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
    public partial class havale_islemi : Form
    {
        private string gonderenAd, gonderenSoyad, gonderenTelefon;
        public int k_havale_id,gonderenBakiye;
        SqlDataReader oku,gonderen_oku;


        private void menu_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            islemler yonlendir = new islemler();
            yonlendir.k_id = k_havale_id;
            yonlendir.Show();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=musteriler;Integrated Security=True");
        public havale_islemi()
        {
            InitializeComponent();
        }

        private void havale_islemi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string con = "select musteriAd,musteriSoyad,musteriBakiye,musteriTelefon from musteri_tablo where musteriId=@id";
            SqlCommand sendId = new SqlCommand(con, baglanti);
            sendId.Parameters.AddWithValue("@id", k_havale_id);
            gonderen_oku = sendId.ExecuteReader();
            gonderen_oku.Read();
            gonderenAd = (string)gonderen_oku["musteriAd"];
            gonderenSoyad = (string)gonderen_oku["musteriSoyad"];
            gonderenTelefon = (string)gonderen_oku["musteriTelefon"];
            gonderenBakiye = (int)gonderen_oku["musteriBakiye"];
            baglanti.Close();
            ad_soyad_lbl.Text = gonderenAd + " " + gonderenSoyad;
            bakiye_lbl.Text = "Bakiye: "+gonderenBakiye;
        }

        private void para_gonder_buton_Click(object sender, EventArgs e)
        {
            int cekilecek_tutar;
            baglanti.Open();
            string gonderilecekTel = y_kisi_text.Text;
            cekilecek_tutar = Convert.ToInt32(y_miktar_text.Text);
            string kayit = "select musteriId,musteriTelefon,musteriAd,musteriSoyad from musteri_tablo where musteriTelefon=@tel";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@tel", gonderilecekTel);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                if (gonderenBakiye >= cekilecek_tutar && cekilecek_tutar > 0)
                {
                    int gonderilenId = (int)oku["musteriId"];
                    string cekilenTel = (string)oku["musteriTelefon"];
                    string musteriAd = (string)oku["musteriAd"];
                    string musteriSoyad = (string)oku["musteriSoyad"];
                    baglanti.Close();
                    
                    baglanti.Open(); //gonderenden para cekildi.
                    kayit = "update musteri_tablo set musteriBakiye-=@cekilecek where musteriId=@id";
                    SqlCommand command = new SqlCommand(kayit, baglanti);
                    command.Parameters.AddWithValue("@cekilecek", cekilecek_tutar);
                    command.Parameters.AddWithValue("@id", k_havale_id);
                    command.ExecuteNonQuery();
                    baglanti.Close();
                    havale_islemi_Load(null, null);
                    baglanti.Open(); //Gonderilene Para Gidiyor.
                    string sorgu = "update musteri_tablo set musteriBakiye+=@gonderilenPara where musteriId=@gonderilenId";
                    SqlCommand gonderi = new SqlCommand(sorgu, baglanti);
                    gonderi.Parameters.AddWithValue("@gonderilenPara", cekilecek_tutar);
                    gonderi.Parameters.AddWithValue("@gonderilenId", gonderilenId);
                    gonderi.ExecuteNonQuery();
                    baglanti.Close();

                    y_kisi_text.Clear();
                    y_miktar_text.Clear();

                    MessageBox.Show(musteriAd + " " + musteriSoyad + " Adlı Kişiye " + cekilecek_tutar + " Birim Para Gonderdiniz.");
                   
                    //pdf işlemleri
                    DialogResult dekont_secim = MessageBox.Show("Dekont İstiyor musunuz?", "Dekont", MessageBoxButtons.YesNo);
                    if (dekont_secim == DialogResult.Yes) 
                    {
                        string bilgiler = "\n------Dekont------\nParayı Gönderen;\n--------------------"
                            + "\n\nAd: " + gonderenAd + "\nSoyad: " + gonderenSoyad
                            + "\nTelefon: " + gonderenTelefon + "\n--------------------\n\nPara Gönderilen;"
                            + "\n\nAd: " + musteriAd
                            + "\nSoyad: " + musteriSoyad
                            + "\nTelefon: " + cekilenTel
                            + "\n\n\nGönderilen Bakiye: " + cekilecek_tutar;

                        
                        PdfDocument dokuman = new PdfDocument();
                        PdfPage sayfa = dokuman.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(sayfa);
                        XFont font = new XFont("Times New Roman", 10, XFontStyle.Italic);
                        XTextFormatter yazi_format = new XTextFormatter(gfx);
                        XRect rect = new XRect(40, 100, 250, 220);
                        gfx.DrawRectangle(XBrushes.Goldenrod, rect);
                        yazi_format.DrawString(bilgiler, font, XBrushes.White, rect, XStringFormats.TopLeft);
                        SaveFileDialog kaydet = new SaveFileDialog();
                        kaydet.FileName = "Dekont";
                        kaydet.DefaultExt = ".pdf";
                        kaydet.Filter = "PDF documents (.pdf)|*.pdf";
                        kaydet.ShowDialog();
                        string dosya_adi = kaydet.FileName;
                        dokuman.Save(dosya_adi);
                    }
                    
                }

                else
                {
                    if (cekilecek_tutar <= 0)
                    {
                        MessageBox.Show("0 veya 0'dan Daha Küçük Birim Gönderemezsiniz!!!");
                        y_miktar_text.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Hesabınızda Bulunan Paradan Fazlasını Gönderemezsiniz.");
                        y_miktar_text.Clear();
                    }
                    baglanti.Close();
                }
            }

            else
            {
                MessageBox.Show("Bu Numaraya Sahip Biri Bankamızda Bulunmamaktadır, Lütfen Yeniden Deneyiniz.");
                y_kisi_text.Clear();
                baglanti.Close();
            }
        }
    }
}
