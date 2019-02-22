using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Dizimi(int[] sayi)
        {
            int[] sayilar = new int[10];
            double toplam = 0, ort = 0;
            foreach (var i in sayi)
            {
                toplam += i;
                ort = toplam / i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Klavyeden girilen sayi :",i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(sayilar);
            Console.WriteLine("Toplamları :"+toplam);
            Console.WriteLine("Ortalamaları :"+ort);
        }

        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            Dizimi(sayilar);
            Console.ReadKey();

        }
    }
}
