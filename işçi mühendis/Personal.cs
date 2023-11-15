using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace işçi_mühendis
{
    internal class Personal
    {
        public Personal() { }
        public Personal(string gAd, int gYas, string gAdres, string gUnvan, int gMesai)
        {
            this.Ad = gAd;
            this.Yas = gYas;
            this.Adres = gAdres;
            this.Unvan = gUnvan;
            this.Mesai = gMesai;
        }
        string unvan;
        public string Unvan { get => unvan; set => unvan = value; }

        string ad;
        public string Ad { get => ad; set => ad = value; }
        
        int yas;
        public int Yas { get => yas; set => yas = value; }
        int mesai;
        public int Mesai
        {
            get { return mesai; }
            set { mesai = value; }
        }

        

        
        public virtual int ucretHesapla()
        {
            return this.Mesai + 100;
        }
        public void  ucretHesapla(int ekUcret)
        {
            int odenecek = this.Mesai * 100 + ekUcret;
            MessageBox.Show(odenecek.ToString());

        }
        string adres;
        public string Adres { get => adres; set => adres = value; }
        
    } 
    
}
