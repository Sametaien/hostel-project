using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Samet_Pansiyon;
using Panel = Samet_Pansiyon.Panel;

namespace Samet_Pansiyon
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniMusteri fr = new YeniMusteri();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            GirisPaneli fr = new GirisPaneli();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdalarPanel fr = new OdalarPanel();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak ister misiniz?", "Çıkış Onayı", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) 
            {
                this.Close();
            }


        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            MusteriList fr = new MusteriList();
            fr.Show();

        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriList fr = new MusteriList();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriSil fr = new MusteriSil();
            fr.Show();
        }
    }
}

