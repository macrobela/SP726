using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication84
{
    enum KurumTipi : byte { Devlet,Ozel,Vakıf}
    enum OzelKursAlani : byte { Yazılım,Muhasebe,YabancıDil,Ehliyet,Yüzme}

    class EgitimKurumu
    {
        public string Kurumadi;
        public string KurumAdresi;
        public  KurumTipi Kurumtipi;

        public EgitimKurumu(string kurumadi,string kurumAdresi)
        {
            this.Kurumadi = kurumadi;
            this.KurumAdresi = kurumAdresi;
        }
    }
    class OzelKurs:EgitimKurumu
    {
        public string OzelKursSahibi;
        private OzelKursAlani ozelkursalani;
        public ArrayList EgitmenListesi=new ArrayList();
        public OzelKurs(string ozelkurssahibi, OzelKursAlani ozelkursalani,string kurumadi, string kurumAdresi) : base(kurumadi, kurumAdresi)
        {
            this.OzelKursSahibi = ozelkurssahibi;
            this.ozelkursalani = ozelkursalani;
            EgitmenEkle();
        }
        public void  EgitmenEkle()
        {
            Console.Write("Eğitmen TC Giriniz:");
            int tc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ad ve Soyadi:");
            string adsoyad =Console.ReadLine();
           
            EgitmenListesi.Add(tc);
            EgitmenListesi.Add(adsoyad);

        }
        public void EgitmenListele()
        {
            for (int i = 0; i < EgitmenListesi.Count; i=i+2)
            {
                Console.WriteLine("Tc Kimlik No : " + EgitmenListesi[i]+"  Ad ve Soyad : "+EgitmenListesi[i+1]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OzelKurs sMartPro = new OzelKurs("Mehmet DEMİR", OzelKursAlani.Yazılım, "SmartPro", "KADIKÖY");
            sMartPro.EgitmenListele();
            Console.ReadKey();
        }
    }
}
