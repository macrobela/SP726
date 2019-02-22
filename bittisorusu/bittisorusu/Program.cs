using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bittisorusu
{
    enum UretilenYer : byte { Antalya, Tekirdağ, Muğla, Mersin, Adana, Tokat, Çanakkale, Manisa, İzmir, Aydın, Ankara }
    enum Renk : byte { Sarı, LAcivert, Beyaz, Siyah, Kırmızı }

    class Bitki
    {
        public string bitkiadi;
        public string BitkiBölgeleri;
        public bool Endemik;
        public static int i = 0;
        private bool endemik;

        public Bitki(string bitkiadi, bool endemik)
        {
            this.bitkiadi = bitkiadi;
            this.endemik = Endemik;
        }
    }
    class Cicek : Bitki
    {
        public int Fiyat;
        Renk renk;
        public ArrayList saticilar;
        public Cicek(string renk1, int fiyat, string bitkiadi, bool endemik) : base(bitkiadi, endemik)
        {
            this.renk1 = renk1;
            Fiyat = fiyat;
            this.bitkiadi = bitkiadi;
            Endemik = endemik;
        }

        public Cicek(string bitkiadi, bool endemik) : base(bitkiadi, endemik)
        {
        }

        public string Renk;
        private string renk1;
        private int renk2;
        public void SaticiEkle(ArrayList saticilar)
        {
            string sat;
            Console.WriteLine("Adinizi Giriniz : ");
            sat = Console.ReadLine();
            Console.WriteLine("Adres Bilgilerini Yazarmısınız : ");
            sat = Console.ReadLine();
        }
        public void SaticiListele()
        {
            for (int a = 0; a < saticilar.Count; a+=2)
            {
                Console.WriteLine("Ad Bilgisi : "+saticilar[i]);
                Console.WriteLine("Adres Bilgisi : "+saticilar[i+1]);
            }
        }
        public void CicekBilgiListele()
        {
            Console.WriteLine("Renk : " + Renk);
            Console.WriteLine("Fiyat : " + Fiyat);
            Console.WriteLine("Satılar : ");
            SaticiListele();
        }
        internal void SaticiEkle()
        {
            ////throw new NotImplementedException();
        }
    }
    class Program
    {
        private static int renk;
        public static bool Endemik { get; private set; }
        static void Main(string[] args)
        {
            string bitkiadi;
            string bitkibolgeleri;
            bool endemik;
            string renk1;
            int fiyat;
            Console.WriteLine("Bitki Adi Giriniz : ");
            bitkiadi = Console.ReadLine();
            Console.WriteLine("Bölgeleri  Giriniz : ");
            bitkibolgeleri = Console.ReadLine();
            Console.WriteLine("renk  Giriniz : ");
            renk1 = Console.ReadLine();
            Console.WriteLine("Fiyat Giriniz :");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Cicek c = new Cicek(renk1,fiyat,bitkiadi,Endemik);

           



            Console.ReadKey();
        }
    }
}
