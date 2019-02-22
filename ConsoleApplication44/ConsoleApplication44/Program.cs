using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {

        static void int20arttir(ref int[] dizi)
        {
            int[] sayilar = new int[20];
            Random rnd = new Random();

            for (int i = 0; i <dizi.Length; i++)
            {
                dizi[i] = dizi[i] + 20;
                for (int b = 0; b < i; b++)
                {
                    if (sayilar[b] == sayilar[i])
                    {
                        Console.WriteLine("Sayi Girin :");
                        sayilar[b] = Convert.ToInt32(Console.ReadLine());
                        i+=20;
                        break;
                    }
                    foreach (var i in dizi)
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            Random rnd = new Random();
            Console.WriteLine("");
            for (int a = 0; a < 20; a++)
            {
                Console.WriteLine(sayilar[a]);     
            }

            Dizimi = sayilar;

           Console.WriteLine(Dizimi(sayi));

            Console.ReadKey();
        }
    }
}
