using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samet_Pansiyon
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtKAdi.Text == "admin" && TxtKSifre.Text == "13579")
            {
                Panel fr = new Panel();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yanlış!");
            }
        }
    }
}
