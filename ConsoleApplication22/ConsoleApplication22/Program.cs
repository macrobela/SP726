using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayac = 1,tahmin=10;

            Random rastgele = new Random();
            int sayitut = rastgele.Next(1, 40);
            do
            {
                do
                {
                    Console.Write(sayac + "Tahmininizi giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());

                    if (tahmin > sayitut && sayac <= 10)

                        Console.WriteLine("Kücük Sayi  Girin");

                    else if (tahmin < sayitut && sayac <= 10)

                        Console.WriteLine("Büyük Sayi Girin");

                    else if (tahmin == sayitut)
                    {
                        Console.WriteLine("Tebrikler: Denemede bildiniz:");
                    }

                    sayac++;

                    if (sayac > 10)
                    
                        Console.WriteLine("Hakkınız doldu!");
                }
                while (tahmin != sayitut && sayac <= 10);
                

            }
            while (tahmin != sayitut && sayac <= 10);

            Console.ReadKey();





        }
    }
}
