using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication82
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi > 0)
            {
                Console.WriteLine(sayi);
                sayi--;
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
