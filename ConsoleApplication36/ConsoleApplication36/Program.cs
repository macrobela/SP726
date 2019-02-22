using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
         static void Toplama(int s1, int s2)
        {
            Console.WriteLine("Sayıların Toplamı \t: {0}", (s1 + s2));
        }
         static void Cikarma(int s1, int s2)
        {
            Console.WriteLine("Sayıların Farkı \t: {0}", (s1 - s2));
        }
         static void Carpma(int s1, int s2)
        {
            Console.WriteLine("Sayıların Çarpımı \t: {0}", (s1 * s2));
        }
         static void Bolme(int s1, int s2)
        {
            Console.WriteLine("Sayıların Bölümü \t: {0}", (s1 / s2));
        }
        static void Main(string[] args)
        {

            Console.Write("Birinci Sayı : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayı : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Toplama(sayi1, sayi2);
            Cikarma(sayi1, sayi2);
            Carpma(sayi1, sayi2);
            Bolme(sayi1, sayi2);

            Console.ReadKey();
        }
    }
}
