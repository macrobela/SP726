using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {

        //static void metin()
        //{
        //    Console.WriteLine("bir metin giriniz:");
        //    string metin;
        //    int sayac = 1;
        //    metin = Console.ReadLine();
        //    string yenimetin = metin.Trim();

        //    for (int i = 0; i < yenimetin.Length; i++)
        //    {
        //        {
        //            if (yenimetin.Substring(i , 1) == " ")
        //                sayac += 1;      
        //        }
        //    }
        //    Console.WriteLine("Bu metinde {0} kelime kullanılmıstır", sayac);
        //    Console.ReadLine();
        //}
        static void Main(string[] args)
        {
            //metin();
            //Console.ReadKey();


            string ad = "smartpro";
            for (int i = ad.Length-1; i >= 0; i--)
            {
                Console.WriteLine(ad[i]);
            }
            Array.Reverse(ad);
            Console.WriteLine(ad.Remove());
            Console.ReadKey();
        }
    }
}
