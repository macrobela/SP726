using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            int ad, yas, i;
             
            Console.WriteLine("Adinizi giriniz:");
            ad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yasınızı giriniz:");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " +ad);

            for (i = 1; i <=yas; i++)
            {
                Console.WriteLine("İyiki Dogdun");
            }
            Console.ReadLine();
        }
    }
}
