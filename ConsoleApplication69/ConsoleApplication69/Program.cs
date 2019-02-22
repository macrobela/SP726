using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication69
{

    class Sirket
    {
        public string SirketAdi;
        public string VergiDairesi;
        public string VergiNumarasi;
        public byte SirketTuru;
        ArrayList SirketTurleri = new ArrayList () {"Anonim","Limited","Şahıs" };


        public Sirket()
        {
            SirketAdi = "Bilgi Eksik";
            VergiDairesi = "Bilgi Eksik";
            VergiNumarasi = "Bilgi Eksik";
            SirketTuru = 2;
        }
        public void Sirket()
        {
            Console.WriteLine("Sirket Adi Giriniz :");
            SirketAdi = Console.ReadLine();
            Console.WriteLine("Vergi Daire");
            VergiDairesi=Console.ReadLine();
            Console.WriteLine("Vergi Numarası :");
            VergiNumarasi = Console.ReadLine();
        }
        public Sirket(string SirketAdi, string VergiDairesi, string VergiNumarasi,string SirketTuru)
        {
            SirketAdi = SirketAdi;
            VergiDairesi = VergiDairesi;
            VergiNumarasi = VergiNumarasi;
            SirketTuru = (byte)SirketTurleri.IndexOf(SirketTuru);

            //for (int i = 0; i < 3; i++)
            //{
            //    if (this.SirketTurleri[i]==SirketTuru)
            //    {
            //        this.SirketTuru = i;

            //    }
            //}




        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Sirket frms=new Sirket();
            Sirket
            



        }
    }
}
