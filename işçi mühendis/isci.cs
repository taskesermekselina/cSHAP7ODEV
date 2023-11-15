using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace işçi_mühendis
{
    internal class isci:Personal
    {
        string tur;
        public string Tur
        { 
            get { return tur; }
            set =>  tur = value;
        }
        string ad;
        public string Ad
        {
            get => ad;
            set => ad = value;
        }
        int yas;
        public int Yas
        {
            get => yas;
            set => yas = value;
        }
        string adres;
        public string Adres
        {
            get => adres;
            set => adres = value;
        }
        int mesai;
        public int Mesai
        {
            get => mesai;
            set => mesai = value;
        }
        public override int ucretHesapla()
        {
            if (this.Tur == "Gündelik")
            { return this.Mesai * 1000; }
            return this.Mesai * 100 + 5000;


        }
    }
    
}
