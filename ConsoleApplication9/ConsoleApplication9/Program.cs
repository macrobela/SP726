using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("1.sayi giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            if (65>=a)
            {
                Console.WriteLine("sınıftan gectin tebrikler");
            }
            else 
            {
                if (a >= 45)
                {
                    Console.WriteLine("bütünlemeye kaldınız");
                }
                else
                {
                    Console.WriteLine("dersten kaldınız");
                }
            }
            Console.ReadLine();


        }
    }
}
