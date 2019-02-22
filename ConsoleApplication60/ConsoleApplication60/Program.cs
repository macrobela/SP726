using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList aList1 = new ArrayList();
            //Console.WriteLine(aList1.Capacity);
            //aList1.Add("SmartPro");
            //aList1.Add(67);
            //aList1.Add("Elma");
            //aList1.Add(false);
            //aList1.Add('F');
            //aList1.Add(34.5F);
            //aList1.Add(23.10);
            //Console.WriteLine("Kapasitesi: " + aList1.Capacity);
            ////Console.WriteLine("Eleman Sayısı: " + aList1.Count);
            ////Console.WriteLine("Silmeden Önce");
            //aList1.Remove('F');

            ////foreach (object item in aList1)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //////  aList1.Add(8);

            //////Console.WriteLine("Kapasitesi: " + aList1.Capacity);
            ////Console.WriteLine("Eleman Sayısı: " + aList1.Count);
            //aList1.Add(8);

            // aList1.Insert("Armut");

            //aList1.TrimToSize(); // Boş kapasiteyi  sil...

            //aList1.Clear(); //diziyi temizleme
            //aList1.Add(54); //int tipinde deger ekledik
            //aList1.Add(41);
            //aList1.Add(17);
            //aList1.Sort(); //Dizi elemanlarını sıraladık.


            //foreach (object item in aList1)
            //{
            //    Console.WriteLine(item);
            //}

            //aList1.Reverse();
            //Console.WriteLine("REVERSE SONRA --------------------");
            //foreach (var item in aList1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(aList1.Contains(55));
            //Console.WriteLine(aList1.GetType());
            //Console.WriteLine(aList1.IndexOf(17));

            //Console.WriteLine();

            //aList1.Remove(2); // 2. İndisteki elemanı siler.


            //Console.WriteLine();

            //object[] odizi = aList1.ToArray();
            //{ 
            //aList1.CopyTo(odizi);
            //}
            //foreach (var item in odizi)
            //{
            //    Console.WriteLine(item);
            //}



            //ArrayList dizi1 = new ArrayList();

            //Console.WriteLine("Sayi Girin :");
            //dizi1.Add(Convert.ToInt32(Console.ReadLine()));
            //foreach (var item in dizi1)
            //{
            //    dizi1.Add(0);
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();





            //--------------------------------------------------------------

            //int toplam = 0;
            //ArrayList sayi = new ArrayList();
            //for (;;)
            //{
            //    Console.WriteLine("Girilen Sayi");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a == 0)
            //    {
            //        break; 
            //    }
            //    else
            //    {
            //        sayi.Add(a);
            //        toplam = toplam + a;
            //    }
            //}

            //foreach (var item in sayi)
            //{
            //    Console.WriteLine(item);
            //}
            //sayi.Sort();
            //foreach (var item in sayi)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Ortalama :" + (toplam/sayi.Count));
            //Console.WriteLine("Ortadaki sayi :" + sayi[sayi.Count/2]);

            //--------------------------------------------------------------

            //Deger atama için

            //ArrayList arr = new ArrayList { 5, 6, 7, 8 };
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            int yas;
            string adsoyad;
            int yasi;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Adinizi ve soyadinizi giriniz:");
                 adsoyad = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Yaşınızı giriniz:");
                yas = Convert.ToInt32(Console.ReadLine());

                yasi = 2019 - yas;
            }


          
























        }
    }
}
