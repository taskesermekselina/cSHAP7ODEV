using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace işçi_mühendis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal prs2 = new Personal(adTxt.Text, Convert.ToInt32(yasTxt.Text), adresTxt.Text, comboBox1.Text, Convert.ToInt32(mesaiTxt.Text));
            if (comboBox1.Text == "işçi")
            {
                MessageBox.Show(prs2.ucretHesapla().ToString());
            }
            else
            {
                prs2.ucretHesapla(1000);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            muhendis muh = new muhendis();
            muh.Ad = adTxt2.Text;
            muh.Yas = Convert.ToInt32 (yasTxt2.Text);
            muh.Adres= adresTxt2.Text;
            muh.Unvan =comboBox2.Text;
            muh.Mesai = Convert.ToInt32(mesaiTxt2.Text);
            MessageBox.Show(muh.ucretHesapla().ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            isci isci = new isci();

            isci.Ad = adTxt3.Text;
            isci.Yas = Convert.ToInt32(yasTxt3.Text);
            isci.Adres = adresTxt3.Text;
            isci.Mesai = Convert.ToInt32(mesaiTxt3.Text);
            isci.Tur = comboBox4.Text;
            MessageBox.Show(isci.ucretHesapla().ToString());
        }
    }
}
