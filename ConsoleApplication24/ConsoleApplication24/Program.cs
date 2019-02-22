using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new Random();
            int i = 1, x = 1, z = 100, t = 0, k = 5;
            bool y = true;
            Console.WriteLine("bir sayi giriniz:");
            while (y)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 100 && x > 1)
                    y = false;
                else
                    Console.WriteLine("Tekrar Giriniz:");
            }
            do
            {
                int rsayi = rastgele.Next(t, z);

                if (x == rsayi)
                {
                    Console.WriteLine($"{i}.Deneme Buldun");
                    break;
                }
                else
                {
                    z = x + 25 - k;
                    t = x - 25 + k;
                    Console.WriteLine($"{i}.Deneme Basarısız.{rsayi}");
                }
                i++;
            } while (i <= 1000);
                
                    if (i == 16)
                    {
                        Console.WriteLine("Tutulan sayi:" + x);
                    }
                    Console.ReadKey();

                }


            
        
    }
}
