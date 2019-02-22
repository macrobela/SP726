using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._12._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0, sonuc=0;

            //for (int i = 1; i<=100; i++)
            //{
            //    sonuc = i * i;
            //    Console.WriteLine("sayilarin karesini:    " +sonuc);
            //    toplam = sonuc + toplam;
            //}
            //Console.WriteLine("karelerinin toplamı:   "+toplam);
            //Console.ReadLine();





            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();





            //int calısan =3, cocuk, toplamCocuk = 0;

            //for (int i = 1; i <= calısan; i++)
            //{
            //     Console.WriteLine("Çocuk sayisi giriniz:");
            //    cocuk = Convert.ToInt32(Console.ReadLine());

            //    for (int k =1; k <= cocuk; k++) 
            //    {
            //        Console.WriteLine("Tc kimlik no: ");
            //        Console.ReadLine();
            //        toplamCocuk = toplamCocuk + 1;
            //    }
            //}Console.WriteLine("Toplam Cocuk Sayısı :"+toplamCocuk);


            //Console.ReadKey();



            //string ad = "admin", sifre = "123";

            //Console.WriteLine("Adininizi Giriniz : ");
            //ad = Console.ReadLine();

            //Console.WriteLine("Sifresinizi Giriniz :");
            //sifre = Console.ReadLine();

            //if (ad=="admin" && sifre=="123")
            //{
            //    Console.WriteLine("Tebrikler Giris Yapıldı");
            //}
            //else if (ad!="admin" && sifre !="123")
            //{
            //    Console.WriteLine("Hatalı KullanıcıAdi Girildi");
            //}
            //else if (ad != "admin" && sifre != "123")
            //{
            //    Console.WriteLine("Hatalı sifre Girildi");
            //}

            //Console.ReadKey();








            /*
            for (int i = 1; i <= 15; i++)
            {
                for (int k = 1; k <=16; k++)
                {
                    if (i % 9 == 0)
                        Console.WriteLine($"{1}x{k}={i*k}");
                   
                    {
                        
                    }
                    
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
         
            */

            // ---------- 1x1 ,1x2 ,1x3 ,1x4 ,2x4 ,3x5 gibi sayıların carpımlarını isteyen program   ---------------

            //for (int o = 1; o < 16; o++)
            //{
            //    for (int b = 1; b < 16; b++)
            //    {
            //        Console.WriteLine($"{o}x{b}={o * b}");
            //    }

            //    Console.WriteLine();

            //}


            //for (int i = 1; i < 16; i++)
            //{
            //    for (int k = 1; k < 16; k++)
            //    {
            //        Console.WriteLine($"{k}x{k}={k * k}");
            //    }

            //    Console.WriteLine();

            //}
            //Console.ReadKey();

            //string  harf;

            //Console.WriteLine("Klavyeden girilen");
            //harf =Console.ReadLine();

            //while (harf != "K")
            //{
            //    Console.WriteLine("Klavyeden girilen");
            //    harf = Console.ReadLine();

            //    Console.WriteLine(harf);
            //}











            string sayi;
            object sayi1;
            int a = 1,sayi2;
            while (a >= 1)
            {
                sayi = Console.ReadLine();
                sayi2 = Convert.ToInt32(sayi);
                if (sayi2 == 0)
                    break;
                else if (sayi2 > 1024)
                {
                    sayi1 = Convert.ToInt64(sayi);
                    Console.WriteLine(sayi1.GetType());
                }
                else
                {
                    sayi1 = Convert.ToInt16(sayi);
                    Console.WriteLine(sayi1.GetType());
                }

                Console.ReadKey();























































                //while (harf=="K")
                //{
                //    Console.WriteLine(harf);

                //}


                Console.ReadKey();

                //-----------------------------------------------------------------------
                /*
                int sayi = 264;
                while (sayi >= 3)
                {
                    Console.Write(sayi + ",");
                    //sayi = sayi - 3;
                    sayi -= 3;
                }
                Console.WriteLine();
                Console.WriteLine("******************");
                for (int i = 264; i >= 3; i -= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;//yazı rengini değiştirdik
                    Console.Write(i + ",");
                }


        */
                //--------------------------------------------------------------------------------------------





































            }

        }
    }
}
