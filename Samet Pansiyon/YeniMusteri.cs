using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Samet_Pansiyon
{
    public partial class YeniMusteri : Form
    {
        public YeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = EXTRONIC; Initial Catalog = SametPansiyon; Integrated Security = True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "101";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "106";
        }

        private void BtnOda110_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "110";
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "201";
        }

        private void BtnOda210_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "210";
        }

        private void BtnOda211_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "211";
        }

        private void BtnOda212_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "212";
        }

        private void BtnOda215_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "215";
        }

        private void BtnOda216_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "216";
        }

        private void BtnOdaBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Odaları Temsil Etmektedir.");
        }

        private void BtnOdaDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu Odaları Temsil Etmektedir");
        }

        private void TarihCikis_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(TarihGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(TarihCikis.Text);

            TimeSpan Sonuc = BuyukTarih - KucukTarih;

            GunDegeri.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(GunDegeri.Text) * 75;
            TxtUcret.Text = Ucret.ToString();

        }

        private void GunDegeri_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Telefon,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + MTxtTelefon.Text + "','" + TxtTc.Text + "','" + TxtOda.Text + "','" + TxtUcret.Text +"','"+TarihGiris.Value.ToString("MM/dd/yyyy") + "','" + TarihCikis.Value.ToString("MM/dd/yyyy") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Tamamlanmıştır!");
        }

        private void TxtSoyadi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
//Data Source=EXTRONIC;Initial Catalog=SametPansiyon;Integrated Security=True