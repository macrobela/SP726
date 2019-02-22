using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication125
{
    public class Ogrenci
    {
        public ArrayList notlar = new ArrayList();
        public string okulAdi = "Açıktan Egitim";
        public string AdSoyad { get; set; }
        public int OkulNo { get; set; }
        public string OkulBolum = "Yonetim Bilisim Sistemleri MİS ";
        public enum ogretimDuzeyi { IlkÖgretim, OrtaÖgretim, Lise, Lisans }
        private ogretimDuzeyi OgrDuzey;

        public Ogrenci()
        {

        }

        public Ogrenci(string okulAdi, int Not1, int Not2, string okulbolum)
        {
            this.okulAdi = okulAdi;
            notlar.Clear();
            this.notlar.Add(Not1);
            this.notlar.Add(Not2);
        }


        public Ogrenci(string Fakulte, double vizeNotu, double FinalNotu)
        {
            this.okulAdi = Fakulte;
            notlar.Clear();
            notlar.Add(vizeNotu);
            notlar.Add(FinalNotu);
        }

        public string OkulAdi
        {
            get
            {
                return OkulAdi;
            }
            set
            {
                if (!value.Equals(okulAdi))
                    okulAdi = value;
            }
        }

        public ogretimDuzeyi OgretimDuzeyi
        {
            get { return OgrDuzey; }
            set { OgrDuzey = value; }
        }

        public virtual string NotHesapla(double not1, double not2)
        {
            string notDurum = "";
            double notOrt = (not1 + not2) / 2;
            if (notOrt >= 85 && notOrt <= 100)
                notDurum = "Pekiyi";
            else if (notOrt >= 70 && notOrt <= 84.99)
                notDurum = "İyi";
            else if (notOrt >= 60 && notOrt <= 69.99)
                notDurum = "Orta";
            else if (notOrt >= 50 && notOrt <= 59.99)
                notDurum = "Geçer";
            else if (notOrt >= 0 && notOrt <= 49.99)
                notDurum = "Tekrar";

            return notDurum;
        }
    }

    public class LiseOgrencisi : Ogrenci
    {
        public LiseOgrencisi(string okulAdi, int not1, int not2) : base(okulAdi, not1, not2)
        {

        }

        public override string NotHesapla(double not1, double not2)
        {
            string notDurum = "";
            double notOrt = (not1 + not2) / 2;
            if (notOrt >= 85 && notOrt <= 100)
                notDurum = "Pekiyi";
            else if (notOrt >= 70 && notOrt <= 84.99)
                notDurum = "İyi";
            else if (notOrt >= 60 && notOrt <= 69.99)
                notDurum = "Orta";
            else if (notOrt >= 50 && notOrt <= 59.99)
                notDurum = "Geçer";
            else if (notOrt >= 0 && notOrt <= 49.99)
                notDurum = "Tekrar";

            return notDurum;
        }
    }
    class LisansOgrencisi : Ogrenci
    {

        public LisansOgrencisi(string Fakulte, double vizeNotu, double FinalNotu) : base(Fakulte, vizeNotu, FinalNotu)
        {

        }
        public override string NotHesapla(double vizeNotu, double FinalNotu)
        {
            string notDurum = "";
            double notOrt = (vizeNotu * 0.40 + FinalNotu * 0.60);
            if (notOrt >= 85 && notOrt <= 100)
                notDurum = "A";
            else if (notOrt >= 70 && notOrt <= 84.99)
                notDurum = "B";
            else if (notOrt >= 60 && notOrt <= 69.99)
                notDurum = "C";
            else if (notOrt >= 50 && notOrt <= 59.99)
                notDurum = "D";
            else if (notOrt >= 45 && notOrt <= 49.99)
                notDurum = "E";
            else if (notOrt >= 0 && notOrt <= 44.99)
                notDurum = "F";

            return notDurum;
        }
    }
    class Program
    {
        public void OgrenciNotHesabla(Ogrenci ogr)
        {
            Double[] notlar = new Double[2];
            int index = 0;
            foreach (var item in ogr.notlar)
            {
                notlar[index] = Convert.ToDouble(item);
                index++;
            }
            Console.WriteLine(ogr.NotHesapla(Convert.ToDouble(notlar[0]), Convert.ToDouble(notlar[1])));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            LiseOgrencisi liseOgr = new LiseOgrencisi("Şişli Endüstri Meslek Lisesi", 80, 75);
            liseOgr.AdSoyad = "Süleyman Beytullah Avşar";
            liseOgr.OkulNo = 9315;
            Console.WriteLine(liseOgr.AdSoyad);
           // Console.WriteLine("Şişli Endüstri Meslek Lisesi");
            //Console.WriteLine("Web Tasarım");
            liseOgr.OgretimDuzeyi = Ogrenci.ogretimDuzeyi.Lise;

            Console.WriteLine(liseOgr.OkulNo);

            p.OgrenciNotHesabla(liseOgr);

            Console.WriteLine("**********************************");
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            LisansOgrencisi lisansOgr = new LisansOgrencisi("Acık Ögretim Fakültesi", 55, 75);
            lisansOgr.AdSoyad = "Süleyman Beytullah Avşar";
           // lisansOgr.okulAdi = "Anadolu Üniversitesi";

            lisansOgr.OkulNo = 132600038;
            Console.WriteLine(lisansOgr.AdSoyad);
            Console.WriteLine(lisansOgr.okulAdi);
           // Console.WriteLine("Yönetim Bilisim Sistemleri MİS");
            Console.WriteLine(lisansOgr.OkulNo);
            //Console.WriteLine("Acık Ögretim Fakültesi");

            p.OgrenciNotHesabla(lisansOgr);
            Console.WriteLine("**********************************");

            Console.ReadKey();
        }
    }
}