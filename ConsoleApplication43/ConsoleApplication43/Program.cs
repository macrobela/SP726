using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
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
        static void Main(string[] args)
        {
            int intsayi = 25;
            Console.WriteLine(intsayi);
            intDegistir(out intsayi);
            Console.WriteLine(intsayi);
            Console.ReadLine();}
    }
}
