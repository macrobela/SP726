using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication80
{
    //Sabit Veri Tipleri:
    enum Marka : byte { Honda=1, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş, Lamborghini, Ferrari, Scania, Volvo }
    enum Vites : byte { Manuel, Otomatik, Yarı_Otomatik }
    enum Renk : byte { Kırmızı, Beyaz, Siyah, Turuncu, Yeşil, Mav, Mor }

    //Arac Sınıfı:
    class Arac
    {
        /*
        public Marka marka;  //Enumdan değişken tanımlama
        public Vites vites;  
        public Renk renk;
        */
        public string marka;
        public string vites;
        public string renk;
        protected double MotorHacmi;
    }

    class Otomobil : Arac
    {
        public int KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        public void OtomobilBilgiYaz()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("Otomobil Bilgileri :");
            Console.WriteLine("Marka :" + marka + " Vites :" + vites + " Renk :" + renk +
                "MotorHacmi :" + MotorHacmi);
            Console.WriteLine("Kapi Sayisi :" + KapiSayisi + " Model :" + Model + " Ceker4 :" + Ceker4 + " ParkSensörü :" + ParkSensoru);
            Console.WriteLine("********************************************************");
        }
    }
    class Ticari : Arac
    {
        public int TasimaKapasitesi;
        public bool Ceker4;
        public int YolcuKapasitesi;

        public void TicariBilgiYaz()
        {

            Console.WriteLine("Ticari Bilgileri :");
            Console.WriteLine("Marka :" + marka + " Vites :" + vites + " Renk :" + renk +
                "MotoHacmi :" + MotorHacmi);
            Console.WriteLine("Taşima Kapasitesi :" + TasimaKapasitesi + " Ceker4 :" + Ceker4 + " Yolcu Kapasitesi :" + YolcuKapasitesi);
            Console.WriteLine("********************************************************");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil o = new Otomobil();
            o.marka = "Honda";
            o.vites = "Manuel";
            o.renk = "Kırmızı";
            o.Ceker4 = true;
            o.ParkSensoru = true;
            o.KapiSayisi = 2;
            o.Model = "C150";
            o.OtomobilBilgiYaz();
            //////////////////////////////////////////
            Ticari t = new Ticari();
            t.marka = "Ford";
            t.vites = "Otomatik";
            t.renk = "Mavi";
            t.Ceker4 = false;
            t.TasimaKapasitesi = 500;
            t.YolcuKapasitesi = 4;
            t.TicariBilgiYaz();

            Console.ReadLine();


        }
    }
}
