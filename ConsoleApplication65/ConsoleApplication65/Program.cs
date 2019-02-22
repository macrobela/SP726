using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            char opt;
            

            Matematik araba1 = new Matematik();

            Console.Write(" Birinci Sayıyı Girin :");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" İkinci Sayıyı Girin :");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlem yapmak icin operatör secin:");
            opt = Convert.ToChar(Console.ReadLine());

            Console.WriteLine( araba1.sonuc(sayi1,sayi2,opt));
        


        Console.ReadKey();
        }
    }
}
