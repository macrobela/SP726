using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] dizi2 = { 1, 2, 3, 4, 5, 6 };

            //foreach (int a in dizi2)
            //{
            //    Console.WriteLine(a);
            //}
            //char[] cDizi = { 'a', 'f', 'a', 'd' };

            //Console.ReadLine();



            // 10 elemanlı int tipinde bir dizi tanımlayın.Her elemanını (1-100 arası) rastgele sayi ile belirleyin.
            //Dizinin elemanlarını ekrana yazdırın...


            //int[] sayi = new int[10];

            //int rastsayi;

            //Random rastgele = new Random();


            //for (int i = 0; i < 10; i++)
            //{
            //    rastsayi = rastgele.Next(1, 100);
            //    sayi[i] = rastsayi;
            //    Console.WriteLine(sayi[i]);
            //}
            //Console.ReadLine();


            //int[] sayi = new int[8];

            //for (int i = 0; i <8 ; i++)
            //{
            //    Console.WriteLine($"{i}. Sayi Girin:");
            //    sayi[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //int ciftsayi;

            //foreach (int i in sayi)
            //{
            //    ciftsayi = i;

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("sayi Cifttir :"+ i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayi Tektir" + i);
            //    }

            //}
            //Console.ReadLine();


            // Sıralamayı gösteren komutlar



            //char[] cDizi = { 'c', 'b', 'z', 'a', 'b', 't', 'y', 'h' };
            //foreach (var item in cDizi)
            //{
            //    Console.Write(item);
            //}

            //Console.Write("\tSiralamadan sonra:        ");
            //Array.Sort(cDizi);
            //foreach (var item in cDizi)
            //{
            //    Console.Write(item);
            //}
            //Array.Reverse(cDizi);

            //foreach (var item in cDizi)
            //{
            //    Console.WriteLine(item);

            //    Console.WriteLine();

            //}

            //Array.Clear(cDizi,3,2);
            //Console.WriteLine("Clear sonrası");
            //foreach (var item in cDizi)
            //{

            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\tTerzine Sıralama Sonrası:");
            //Console.ReadLine();



            //string[] isimler = new string[5];

            //int[] tut = new int[5];


            //for (int i = 0; i <5; i++)
            //{
            //    Console.WriteLine($"İsim Giriniz :");
            //    isimler[i] = Console.ReadLine();

            //    Console.WriteLine();
            //}

            //Array.Sort(isimler);
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("--------Clear Sonra--------");
            ////Array.Clear(isimler,2,1);

            //foreach (var item in isimler)
            //{

            //    Console.WriteLine(item);
            //    Console.WriteLine();

            //}

            //Console.WriteLine("-----------------------------------------");

            //foreach (var item in isimler)
            //{

            //if (isimler.Length / 2!=0)
            //{
            //    Array.Clear(isimler, 2, 1);
            //    Console.WriteLine(item);
            //}
            //else
            //{

            //    Console.WriteLine(item);
            //}


            //int[] dizi1 = {5,6,43,875,42,90 };
            //int[] dizi2 = new int[10];
            //int[] dizi3 = new int[8];
            //dizi1.CopyTo(dizi2,3);

            //foreach (var item in dizi1)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Copy(dizi1,3,dizi3,5,3);
            //Console.WriteLine("-----------");
            //Console.WriteLine();
            //foreach (var item in dizi3)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------------------------------


            //int[] dizi1 = {5,66,34,75,97,54};

            //int index=Array.BinarySearch(dizi1,97);
            //// dizide 34 varmı? Hangi indis'te ?



            //if (index > 0)
            //{
            //    Console.WriteLine("34 Bulunan İndis: " + index);
            //}
            //else
            //{
            //    Console.WriteLine("34 yok");
            //}

            ////Console.ReadLine();

            ////----------------------------------------------------------------------------------------------------------------------------



            //int sayilar;
            //int[] sayi = new int[10];
            //int[] sayi2 = new int[10];



            //for (int i = 0; i < 10; i++)
            //{

            //    Console.Write("Sayi Giriniz :");
            //    sayilar = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Cift sayilar");
            //Console.WriteLine("----------");

            //for (int i = 0; i < 10; i++)
            //{
            //    if (sayi[i]%2==0)
            //    {
            //        Console.WriteLine(sayi[i]);
            //    }
            //}
            //Console.WriteLine("Tek sayilar");
            //Console.WriteLine("----------");

            //if (sayilar % 2 == 1)
            //    {
            //        sayi[i] = sayilar;

            //    }
            //    else
            //    {
            //        sayi2[i] = sayilar;


            //    }
            //}


            //Console.WriteLine();

            //foreach (int i in sayi)
            //{
            //        Console.WriteLine("Cift Sayilar:{0} " + i);
            //        Console.WriteLine();
            //}
            //foreach (int i in sayi2)
            //{
            //    Console.WriteLine("Tek Sayilar:{0} " + i);
            //    Console.WriteLine();
            //}
            //Console.ReadKey();




            //--------------------------------------------------------------------------------------------------


            int[] sayigir = new int[10];
            int i;
            
            for (i = 0; i < 10; i++)
            {
                Console.Write("Sayıyı giriniz..:");
                sayigir[i] = Convert.ToInt16(Console.ReadLine());
            }
            
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine("------------");

            for (i = 0; i <= 9; i++)
            {
                if (sayigir[i] % 2 == 0)
                {
                    Console.WriteLine(sayigir[i]);
                }
            } 
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine("-----------");
            for (i = 0; i <= 9; i++)
            {
                if (sayigir[i] % 2 == 1)
                {
                    Console.WriteLine(sayigir[i]);
                } 
            }
            Console.ReadKey();





















































        }
    }
}
