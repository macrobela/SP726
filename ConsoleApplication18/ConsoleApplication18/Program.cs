using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        { 

            // klavyeden adı ve yası girilecek girildiginde yası kadar adı ve yası yazılacak
            string ad;

            int i, yas;

            Console.WriteLine("Adinizi Girin");
            ad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Yasinizi Girin");
            yas = Convert.ToInt32(Console.ReadLine());

          //  Console.WriteLine("Hello " + ad);



            for (i = 1; i <= yas; i++)
            {
                Console.WriteLine($"İyiki Dogdun {ad}->" + i);
            }
            Console.ReadLine();
        }
    }
}
