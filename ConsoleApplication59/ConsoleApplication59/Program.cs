using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 10;
            do
            {
                --sayac;
                Console.WriteLine("sayac"+sayac);

            } while (sayac>=10);
            Console.WriteLine("Sayac sonu");

            Console.ReadKey();
        }
    }
}
