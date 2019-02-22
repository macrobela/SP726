using katılım_abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katılım_abstract
{
    abstract class Kus
    {
        abstract public string Ozellikler { get; set; }
        abstract public string Renk { get; set; }
        abstract public int KanatUzunlugu { get; set; }
        //public string KusTurAdi;
        //abstract public void Mesafe();
        abstract public void[] Ozellik{}
        abstract public void MesefaHesabla { int hiz,int uzaklik}

    }

    class Karga : Kus
    {
        private string cins;
        private string Kanatuzunlugu;
        private string renk;
        public override string Ozellikler
        {
            get
            {
                return Ozellik{ cins,Kanatuzunlugu,renk}
            }

            set
            {
                cins = "karga";
                KanatUzunlugu = "uc metre";
                renk = "SiyahBeyaz";
            }
        }
        public override int KanatUzunlugu
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Renk
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        

        public override void Mesafe()
        {
            Console.WriteLine($"Saatteki hizi 20 km ise 100 km yi 5 saatte alır.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
