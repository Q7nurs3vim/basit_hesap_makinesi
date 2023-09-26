using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basit_hesap_makınesı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
            sonuc = sayi1 * sayi2;
            lblSonuc.Text = "sonuç :" + sonuc;
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {

            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
            sonuc = sayi1 - sayi2;
            lblSonuc.Text = "sonuç :" + sonuc;


        }

        private void btnBol_Click(object sender, EventArgs e)
        {

            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
            sonuc = sayi1 / sayi2;
            lblSonuc.Text = "sonuç :" + sonuc;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
            sonuc = sayi1 + sayi2;
            lblSonuc.Text = "sonuç :" + sonuc;

        }

    }
}