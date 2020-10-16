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
    public partial class MusteriList : Form
    {
        public MusteriList()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRONIC;Initial Catalog=SametPansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e) //Verileri Güncelleme Ekranı Veri Bilgileri//
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            MTxtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtTc.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtOda.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TarihGiris.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TarihCikis.Text = listView1.SelectedItems[0].SubItems[8].Text;

        }

        private void btnverisil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Müşteri bilgilerini silmek ister misiniz?", "Silme Onayı", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error) == DialogResult.OK)
            { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            TxtAdi.Clear();
            TxtOda.Clear();
            TxtUcret.Clear();
            TxtSoyadi.Clear();
            TxtTc.Clear();
            MTxtTelefon.Clear();
            TarihCikis.Text = "";
            TarihGiris.Text = "";
            };


        }

        private void MusteriList_Load(object sender, EventArgs e)
        {

        }

      
    }
}
