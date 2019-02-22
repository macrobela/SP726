using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
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
            Array.Sort(sayilar);
            Console.WriteLine("Toplamları :"+toplam);
            Console.WriteLine("Ortalama :"+ort);
        }
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Klavyeden {0}. sayıyı girin:", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Dizimi(sayilar);
            Console.ReadKey();
        }
    }
}
