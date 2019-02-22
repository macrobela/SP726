using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {

            Kenar frms = new Kenar();
           
            {
                frms.KenarGir = 160;
                Console.WriteLine(frms.KenarGir);
                Console.ReadKey();

            }






            //Ucgen ucg1 = new Ucgen();
            //ucg1.publicKenari1 = 50;
            //ucg1.publicKenari2 = 40;
            //ucg1.publicKenari3 = -5;
            //ucg1.kenaryazdır();
            //Console.ReadKey();
        }
    }
    class Ucgen
    {
        private int Kenar1; 
        private int Kenar2;
        private int Kenar3;
        private int Yukseklik;

        public int publicKenari1  
        {
            get { return Kenar1; }  //Kontrollü alma
            set                     //private  Kenari e kontollü atama
            {
                if (value < 0 || value == 99)
                    Kenar1 = 10;
                else
                    Kenar1 = value;
            }
        }
        public int publicKenari2
        {
            get { return Kenar2; }  //Kontrollü alma
            set                     //private  Kenari e kontollü atama
            {
                if (value < 0 || value == 99)

                    Kenar2 = 10;
                else
                    Kenar2 = value;
            }
        }
        public int publicKenari3
        {
            get { return Kenar3; }  //Kontrollü alma
            set                     //private  Kenari e kontollü atama
            {
                if (value < 0 || value == 99)

                    Kenar3 = 10;
                else
                    Kenar3 = value;
            }
        }
        public void kenaryazdır()
        {
            Console.WriteLine($"Kenar1 = {Kenar1} \nKenar2 = {Kenar2} \nKenar3 = {Kenar3}");
        }
    }

    class Kenar
    {
        int sayi;
        public int KenarGir
        {
            set
            {
                if (value < 100 || value>=0)
                    sayi = 0;
                else
                    sayi = value;
            }
            get
            {
                if (sayi > 100)
                    return sayi % 100;
                else
                    return sayi;
            }

        }

        public int CevreHesapla()
        {

        }
        
    }
}
