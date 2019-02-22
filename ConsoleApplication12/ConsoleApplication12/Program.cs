using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {

            double  vize=0, final=0, ort;

            Console.WriteLine("Final notu giriniz");
            final = double.Parse(Console.ReadLine());

            Console.WriteLine("Vize notu giriniz");
            vize = double.Parse(Console.ReadLine());

            ort = (vize * 0.40) + (final * 0.60);

            Console.WriteLine("Not Ortalamanız" + ort);

            if (final<55)
            {
                Console.WriteLine("kaldınız"+ort);
            }

           
            if (ort < 50)
            {
                Console.WriteLine("E");
                Console.WriteLine("kaldınız");


            }
            else if (ort < 69)
            {
                Console.WriteLine("D");
            }
            else if (ort < 79)
            {
                Console.WriteLine("C");
            }
            else if (ort < 89)
            {
                Console.WriteLine("B");
            }
            else if (ort <=100)
            {
                Console.WriteLine("A");
            }

           

            Console.ReadLine();




        }
    }
}
