using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181209_1_Metotlar_devam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayı");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayı ");
            int sayi2 = int.Parse(Console.ReadLine());
            M1(sayi1, sayi2);
            Console.WriteLine("***************************");
            CiftTekMi(sayi1);
            CiftTekMi(sayi2);
        }

        static void M1(int s1, int s2)
        {
            Console.WriteLine("Girilen iki sayının toplamı:{0}", s1 + s2);
        }
        //metot alınacak bir sayının tek mi çift mi olduğunu bulsun
        static void CiftTekMi(int deger)
        {
            if (deger % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir:" + deger);
            }
            else
            {
                Console.WriteLine("Sayı tek:" + deger);
            }

            Console.ReadLine();
        }
       

    }
}
