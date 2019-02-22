﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication78
{
    class AnaSinif
    {
        public int Sayi;
        public string Yazi;
        //private char c;  // alt sınıftan ve dışarıdan erişilemez...!!!!
        protected char cProtected; // alt sınıftan erişilebilir.Dısarıdan değil.

        public void Yazdir()
        {
            Console.WriteLine("Sayi  :"+Sayi+" Yazi : "+Yazi);
        }
    }
     
    class AltSinif :AnaSinif   // AnaSinif tan AltSinif i türettik.
    {
        public int AltSayi;
        public string AltYazi;

        public char CProAta    //Mainden dolaylı erişim sağlar.
        {
            get { return cProtected; }
            set { cProtected = value; }
        }
        public void AltYazdir()
        {
           //Console.WriteLine("Merhaba"+AltSayi+ "  "+AltYazi);
            Console.WriteLine(cProtected);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AltSinif alt1 = new AltSinif();

            alt1.Sayi = 55;
            alt1.Yazi = "Merhaba";
            alt1.AltYazi = "Dünya";
            alt1.AltSayi = 44;

            alt1.CProAta = 'F';

            alt1.Yazdir();
            alt1.AltYazdir();
           

            Console.ReadKey();

        }
    }
}
