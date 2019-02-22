using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication86
{

    class Emlak
    {
        public string Adres;
        public string Belediye;
        public bool Mustakil;
        public int Metrekare;
        public ArrayList Odasayisi;
        public bool Mutfak;

        public void emlakEkle()
        {
            Console.WriteLine("Adres :");
            Adres = Console.ReadLine();
            Console.WriteLine("Belediye :");
            Belediye = Console.ReadLine();
            Console.WriteLine("Müstekil mi? :");
            if (Console.ReadLine()=="E")
            {
                Mustakil = true;
            }
            else if (Console.ReadLine()=="H")
            {
                Mustakil = false;
            }
            Console.WriteLine("metrekare : ");
            Metrekare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Oda Sayisi : ");
            Odasayisi.Add(Convert.ToInt32(Console.ReadLine()));
        }
        public void Listele()
        {

        }
    }
    class Ticari:Emlak
    {
        public Ticari()
        {
            Console.WriteLine("Metrekare :");
            Metrekare = Convert.ToInt32(Console.ReadLine());
            Odasayisi.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Banyo sayısı");
            Odasayisi.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Salon sayısı ");
            Odasayisi.Add(Convert.ToInt32(Console.ReadLine()));
        }
    }
    class Mustakil:Emlak
    {
        public Mustakil()
        {
            Console.WriteLine("Metrekare :");
            Metrekare = Convert.ToInt32(Console.ReadLine());
            Odasayisi.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Banyo sayısı");
            Odasayisi.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Salon sayısı ");
            Odasayisi.Add(Convert.ToInt32(Console.ReadLine()));

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool mustakil;
            int konutsayisi = 0;

            Console.WriteLine("Müstakil mi?");

            if (Console.ReadLine()=="E")
            {
                mustakil = true;
                string deg = "m" + Convert.ToString(konutsayisi);
                Mustakil m1 = new Mustakil();
                konutsayisi++;
            }
            else if (Console.ReadLine())
            {

            }


        




        }
    }
}
