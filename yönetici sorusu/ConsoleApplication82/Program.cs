using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication82
{
    enum Bolumler: byte {Muhasebe,Yazılım_Birimi,IT_Birimi,IK,Satın_Alma,Hukuk,Satış }

    class Personel
    {
        public string AdSoyad;
        public int Yas;
        public Bolumler bolum;
        public void CalısanBilgiYaz()
        {
            Console.WriteLine("Ad Soyad :" + AdSoyad + "Yas :" + Yas + "Bölümler :" + bolum);
            Console.WriteLine("********************************************************");
        }
    }
    class Yonetici:Personel
    {
        public int AltPersonelSayisi;


        public void PersonelBilgiYaz()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("Personel Bilgileri :");
            Console.WriteLine("Ad Soyad :"+AdSoyad+"Yas :"+Yas+"Bölümler :"+ bolum);
            Console.WriteLine("AltPersonelSayisi :"+ AltPersonelSayisi); ;
            Console.WriteLine("********************************************************");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Yonetici p = new Yonetici();
            p.AdSoyad = "MEHMET DEMİR\n";
            p.AltPersonelSayisi = 15;
            Console.WriteLine();
            p.Yas = 30;
            p.bolum = Bolumler.IT_Birimi;
            p.PersonelBilgiYaz();

            

            Console.ReadKey();
            
           


        }
    }
}
