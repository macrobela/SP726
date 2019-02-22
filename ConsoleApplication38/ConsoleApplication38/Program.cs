using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalmı
{
    class Program
    {

        // Klavyeden girilen sayıyı asal olup olmadıgını bulan program


        static bool Asalmi(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Asalmi(sayi));

            Console.ReadKey();

        }
    }
}
