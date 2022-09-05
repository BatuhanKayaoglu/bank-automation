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
    public partial class ana_ekran : Form
    {
        
        public ana_ekran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kayit_ol_buton_Click(object sender, EventArgs e)
        {
            kayit_ol yonlendir = new kayit_ol();
            yonlendir.Show();
            this.Hide();
        }

        private void giris_yap_buton_Click(object sender, EventArgs e)
        {
            giris_yap yonlendir = new giris_yap();
            yonlendir.Show();
            this.Hide();
        }
    }
}
