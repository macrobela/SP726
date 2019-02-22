using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

            Console.WriteLine("Sayi Giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=a; i++)
            {
                if (i == a/2)
                {
                    Console.WriteLine("SMART");
                    continue;
                }

                    Console.WriteLine("SMARTPRO");
                

            }
            Console.ReadLine();

        }
    }
}
