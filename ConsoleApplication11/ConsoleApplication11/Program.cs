using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final, ort;

            Console.WriteLine("Final notu giriniz");
            final = double.Parse(Console.ReadLine());

            Console.WriteLine("Vize notu giriniz");
            vize = double.Parse(Console.ReadLine());

            ort = (vize * 0.4 + final * 0.6);
            Console.WriteLine("");

            Console.WriteLine("Not Ortalamanız" + ort);

            if (ort < 50)
            {
                Console.WriteLine("E");
            }
            else if (ort >=60)
            {
                Console.WriteLine("D");
            }
            else if (ort >= 70)
            {
                Console.WriteLine("C");
            }
            else if (ort >= 80)
            {
                Console.WriteLine("B");
            }
            else if (ort >= 90)
            {
                Console.WriteLine("A");

                Console.WriteLine("E");

            }


            Console.ReadLine();
        }
    }
}
