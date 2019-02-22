using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random 15 tahmin ile bilmeye calısacak her seferinde 1.Deneme basarısız  5.deneme basarısız gibi

            //int sayi, x=0;
            //int tahmin = 0;

            //Console.WriteLine("Sayi Giriniz:");
            //tahmin = int.Parse(Console.ReadLine());

            //do
            //{

            //    Random rastgele = new Random();
            //    sayi = rastgele.Next(1, 10);


            //    if (tahmin==sayi)
            //    {
            //        Console.WriteLine($"{x}+Deneme Buldun");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{x}+Deneme bulunmadı");


            //    }


            //    x++;

            //} while (x<=15);

            //Console.ReadLine();







            //int sayac = 1, tahmin = 10;

            //Random rastgele = new Random();
            //int sayitut = rastgele.Next(1, 40);
            //do
            //{
            //  do
            //    {
            //        Console.Write(sayac + "tahmininizi giriniz: ");
            //        tahmin = Convert.ToInt32(Console.ReadLine());

            //        if (tahmin > sayitut && sayac <= 10)

            //            Console.WriteLine("Denemede buldun");

            //        else if (tahmin < sayitut && sayac <= 10)

            //            Console.WriteLine("Denemde Bulamadın");

            //        else if (tahmin == sayitut)
            //        {
            //            Console.WriteLine("tebrikler: denemede bildiniz:");
            //        }

            //        sayac++;

            //        if (sayac > 10)

            //            Console.WriteLine("hakkınız doldu!");
            //    }
            //    while (tahmin != sayitut && sayac <= 10);


            //}
            //while (tahmin != sayitut && sayac <= 10);

            //Console.ReadKey();









            ////her seferinde de ekrana üretilen sayı yazılsın. sayi=45  





            //Random rastgele = new Random();

            //int alt = 0, ust = 100, tahmin = 0,sayitut;
            //int a = rastgele.Next(alt,ust);


            //Console.Write("Sayi Giriniz: ");
            //sayitut = Convert.ToInt32(Console.ReadLine());

            //do
            //    {
            //    if (sayitut == a)

            //    {
            //        Console.WriteLine(tahmin + " .Denemede buldun" );
            //        break;
            //    }
            //    else if (sayitut != a)
            //    {
            //        Console.WriteLine(tahmin+ " .Denemede Bulamadın: ");
            //        if (sayitut > alt)
            //        {
            //            alt++;
            //            Console.WriteLine("Denemede buldun" + alt);
            //        }
            //        else
            //        {
            //            ust++;
            //            Console.WriteLine("Denemede bulamadın" + ust);
            //        }

            //    }
            //        tahmin++;
            //    }
            //    while (tahmin != sayitut);

            //Console.ReadKey();


            //Console.Write("Sayi Giriniz: " + alt);
            //sayitut = Convert.ToInt32(Console.ReadLine());











            Random rastgele = new Random();
            int i=1,x=1,z=100,t=0,k = 5;
            bool y = true;
            Console.WriteLine("bir sayi giriniz:");
            while (y)
            {
                x = Convert.ToInt16(Console.ReadLine());
                if (x < 100 && x > 1)
                    y = false;
                else
                    Console.WriteLine("Tekrar Giriniz:");  
            }
            do
            {
                int rsayi = rastgele.Next(t,z);

                if (x == rsayi)
                {
                    Console.WriteLine($"{i}.Deneme Buldun");
                    break;
                }
                else
                {
                    z = x + 25 - k;
                    t = x - 25 + k;
                    Console.WriteLine($"{i}Deneme Basarısız.{rsayi}");
                }
                i++;
                while (i <= 1000) ;
                {
                    if (i==16)
                    {
                        Console.WriteLine("Tutulan sayi:"+x);
                    }
                    Console.ReadKey();
                }

            }




        }
    }
}
