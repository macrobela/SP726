using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void intDegistir(int sayi)
        {
            sayi = 100;
        }
        static void intDegistir(out int sayi)
        {
            sayi = 100;
        }
        static void Main(ref string[] args)
        {
             int intsayi = 25;
            Console.WriteLine(intsayi);
            intDegistir(ref intsayi);
            Console.WriteLine(intsayi);
            Console.ReadKey();

        }
    }
}
