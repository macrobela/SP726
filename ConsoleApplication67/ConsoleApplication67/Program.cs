using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication67
{

    class Dortgen
    {
        private int Kenar1;
        private int Kenar2;
        private int Kenar3;

        public int pubKenar1
        {
            get { return Kenar1; }
            set
            {
                if (value < 0)
                { Kenar1 = 0; }
                else
                { Kenar1 = value; }
            }
        }
        public int pubKenar2
        {
            get { return Kenar2;}
            set
            {
                if (value < 0)
                { Kenar2 = 0; }
                else
                { Kenar2 = value; }

            }
        }
        
        public int pubKenar3
        {
            get { return Kenar3; }
            set
            {
                if (value < 0)
                { Kenar3 = 0; }

                else if (Kenar1 + Kenar2 > value)
                {
                    if (Math.Abs(Kenar1 - Kenar2) < value)
                    {
                        Kenar3 = value;
                    }
                    else
                    {
                        Console.WriteLine("Deger 3 tekrar giriniz :");
                        pubKenar3 = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Deger 3 tekrar giriniz :");
                    pubKenar3 = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void DegerGir()
        {
            Console.WriteLine("1. Kenarı Giriniz: ");
            pubKenar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Kenarı Giriniz: ");
            pubKenar2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. Kenarı Giriniz: ");
            pubKenar3 = Convert.ToInt32(Console.ReadLine());
        }

        public int cevre()
        {
            int sonuc = 0;
            sonuc = (Kenar1 + Kenar2 + Kenar3);
            Console.WriteLine(sonuc);
            return sonuc;
        }




    }





    class Program
    {
        static void Main(string[] args)
        {

            Dortgen frms=new Dortgen();

            frms.DegerGir();
            frms.cevre();
            Console.ReadKey();

        }
    }
}
