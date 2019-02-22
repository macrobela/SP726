using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication88
{
    enum Enerjiler : byte { A, B, C, D, E }
    enum Fırınlar : byte {MiniFırın,NormalFırın }
    class BeyazEsya
    {
        public string Marka;
        public int Fiyat;
        public int GarantiSuresi;
        public Enerjiler Enerji;
        public Fırınlar fırınlar;
        public BeyazEsya (string marka,int fiyat,int garantisuresi,Enerjiler enerji)
        {
            this.Marka = marka;
            this.Fiyat = fiyat;
            this.GarantiSuresi = garantisuresi;
            this.Enerji = enerji;
        }
        virtual public void indirimliFiyatHesapla()
        {
            Console.WriteLine($"İndirim Yok: \nFiyat Bilgisi: {Fiyat}");
        }
    }
    class BulasıkMakinesi:BeyazEsya
    {
        public  int ProgramSayisi;
        public string Modeli;
        public int İndirimOrani;
        //public Arraylist aliste = new Arraylist();

        //public string marka;
        //public object Arraylist { get; private set; }
        public BulasıkMakinesi(int programsayisi,string modeli,int indirimorani, string marka, int fiyat, int garantisuresi,Enerjiler enerji) :base(marka,fiyat,garantisuresi,enerji)
        {
            this.ProgramSayisi = programsayisi;
            this.Modeli = modeli;
            this.İndirimOrani = indirimorani;
        }
        public override void indirimliFiyatHesapla()
        {
            int indirimliFiyat = this.Fiyat - ((Fiyat * this.İndirimOrani) / 100);
            Console.WriteLine("İndirim Orani: "+this.İndirimOrani+" \nFiyat Bilgisi : "+ indirimliFiyat);
        }
    }
    class Firin : BeyazEsya
    {
        public int IndırımOrani;
        public Firin(string marka,int indirimorani, int fiyat, int garantisuresi, Enerjiler enerji,Fırınlar fırınlar) : base(marka, fiyat, garantisuresi, enerji)
        {
            this.fırınlar = fırınlar;
            this.IndırımOrani = indirimorani;
        }
        override public void indirimliFiyatHesapla()
        {
            Console.WriteLine("İndirim oranı %"+ IndırımOrani);
            Fiyat = Fiyat - (Fiyat * IndırımOrani / 100);
            Console.WriteLine(Fiyat);
        }
    }

    class MiniFirin : Firin
    {
        public MiniFirin(string marka, int fiyat, int garantisuresi, Enerjiler enerji,Fırınlar fırınlar,int indirimorani) : base(marka,indirimorani, fiyat, garantisuresi, enerji,fırınlar)
        { 
        }
        override public void indirimliFiyatHesapla()
        {
            Console.WriteLine("İndirim oranı %" + IndırımOrani);
            Fiyat = Fiyat - (Fiyat * IndırımOrani / 100);
            Console.WriteLine(Fiyat);
        }
    }  
    class Program
    {
        static void indirimliFiyatHesapla(BeyazEsya be)
        {
            be.indirimliFiyatHesapla();
        }
        static void Main(string[] args)
        {
            BulasıkMakinesi bm = new BulasıkMakinesi(2, "X32" ,30,"Arcelik",1000,4,Enerjiler.A);
            Firin s = new Firin("Sony",30,5200,6,Enerjiler.E,Fırınlar.NormalFırın);
            MiniFirin dener = new MiniFirin("arcelik",1500,5,Enerjiler.B,Fırınlar.MiniFırın,6);
            indirimliFiyatHesapla(bm);
            indirimliFiyatHesapla(s);
            indirimliFiyatHesapla(dener);
            Console.ReadKey();
        }
    }
}
