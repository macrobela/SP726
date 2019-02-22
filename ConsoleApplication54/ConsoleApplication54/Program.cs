using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        

        //static void harfGr()
        //{
        //    int bosluk = 0, harf = 0;
        //    Console.Write("Metin Giriniz:");
        //    string str = Console.ReadLine();
        //    string[] Y = str.Split();

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str.Substring(i, 1) != " ")
        //        {
        //            harf += 1;
        //            Console.WriteLine(str.Substring(i, 1));
        //        }
        //        else if (str.Substring(i, 1) == " ")
        //        {
        //            bosluk += 1;
        //            Console.WriteLine();
        //        }
        //    }
        //    for (int i = 0; i < Y.Length; i++)

        //        Console.WriteLine($"Harf Sayısı:{harf}\n\rBoşluk Sayısı:{bosluk}");


        //}



        static void Main(string[] args)
        {
            //----------------------------------------------------------------------
            //string kucuk = "smartpro";
            //string buyuk = "SMARTPRO";
            //Console.WriteLine(kucuk.ToUpper());
            //Console.WriteLine(buyuk.ToLower());

            //Console.WriteLine(buyuk.Remove(0,5));
            //Console.WriteLine(buyuk.Insert(8,"_BRO"));

            //Console.WriteLine(buyuk.Replace('P','B'));

            //string str = "Merhaba 404";
            //Console.WriteLine(str.Substring(8));
            //Console.WriteLine(str.Substring(0,7));
            //Console.WriteLine(str.Contains("aba"));

            //Console.WriteLine(str[6]);

            //Console.ReadKey();

            //harfGr();
            //Console.ReadKey();

            //----------------------------------------------------------------------



            Console.WriteLine("bir metin giriniz:");
            string metin;
            int sayac = 1;
            metin = Console.ReadLine();
            string yenimetin = metin.Trim();

            for (int i = 0; i < yenimetin.Length; i++)
            {
                {
                    if (yenimetin.Substring(i = 1) == " ")
                        sayac += 1;
                }
                Console.WriteLine("Bu metinde {0} kelime kullanılmıstır", sayac);
                Console.ReadKey();
            }

        }
    }
}