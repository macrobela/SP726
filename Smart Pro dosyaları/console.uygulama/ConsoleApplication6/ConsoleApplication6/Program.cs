using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            //karsılastırma operatörü


            //bool kDeg1 = 34 > 24; //true
            //bool kDEg2 = 34 < 24; //false
            //bool kDeg3 = 74.7F > 74.6F; //true

            //Console.Write($"{kDeg1} {kDEg2} {kDeg3}");
            //Console.ReadKey();


            //bool kDeg4 = 25 >= 45;
            //int sayi1 = 30;
            //int sayi2 = 20;
            //bool sayiKarsilastırma = sayi1 <= sayi2; //ture
            //bool sayiKarsilastırma2 = sayi1 >= sayi2; //ture
            //Console.WriteLine(sayiKarsilastırma+ " = "+sayiKarsilastırma2);
            //Console.ReadKey();



            //bool bDeg = 5 == 6;

            //int i = 6;
            //int k = 58;
            //bool a = i == k;             //esit mi == mi?
            //Console.WriteLine(a);


            //bool b = i == k;
            //bool b2 = i != k;           //esit degil mi?
            //Console.WriteLine(b);
            //Console.WriteLine(b2);

            //Console.ReadKey();





            // is ve as operatörleri

            //int test = 55;
            //bool bTest = test is Double;//false
            //bool bTest2 = test is int;  //true
            //bool bTEst3 = test is object;
            //Console.WriteLine(bTest);
            //Console.WriteLine(bTest2);
            //Console.WriteLine(bTEst3);
            //Console.ReadKey();


            //string text = "Merhaba";                 //object string dönüstürdük sonra string object dönüstürdük...
            ////bool sText = text is object;
            ////Console.WriteLine(sText);
            //object obStr = (object)text;

            //string text2 = (string)text;

            //Console.WriteLine(text2.GetType());
            //Console.ReadKey();



            //object intDeg1 = "785";
            //string strDeg1 = intDeg1 as string;
            //Console.WriteLine(strDeg1);

            // as null degeri alabilen tipler arasında kullanılır. string ve object 




            //Mantıksal operatörler
            //           &&           //

            //bool bDeg1 = (8 < 9) && (5 == 5); // true
            //bool bDeg2 = (8 > 9) && (5 == 5);  //false
            //bool bDeg3 = (8 > 9) && (5 != 5); //false
            //bool bDeg4 = (8 < 9) && (5 != 5); //false
            //Console.WriteLine($"{bDeg1} {bDeg2} {bDeg3} {bDeg4}");
            //Console.ReadLine();




            //bool bDeg11 = (8 < 9) || (5 == 5); // true
            //bool bDeg22 = (8 > 9) || (5 == 5);  //true
            //bool bDeg33 = (8 > 9) || (5 != 5); //false
            //bool bDeg44 = (8 < 9) || (5 != 5); //true
            //bool bDeg111 = !((8 < 9) || (5 == 5)); // false
            //bool bDeg222 = !((8 > 9) || (5 == 5));  //false
            //bool bDeg333 = !((8 > 9) || (5 != 5)); //true
            //bool bDeg444 = !((8 < 9) || (5 != 5)); //false
            //Console.WriteLine($"{bDeg11} {bDeg22} {bDeg33} {bDeg44}");
            //Console.WriteLine($"{bDeg111} {bDeg222} {bDeg333} {bDeg444}");


            //Console.ReadLine();


            //int sayi = 20;
            //sayi += 20;
            //sayi -= 10;
            //sayi *= 5;
            //sayi /= 10;

            //Console.WriteLine(sayi+"\n");
            //Console.ReadLine();






            ////  & (bitsel ve) opetörü

            //byte a = 5;        // 0000  0101
            //byte b = 10;      //  0000  1010 
            //int c = a & b;   //   0000  0000 
            ////  |   (bitsel veya ) opetörü

            //int d = a | b;   //   0000 1111

            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.ReadKey();


            // ^ (Bitsel özel veya) Operatörü

            // Degerler aynıysa 0 farklıysa 1 //

            //byte a = 21;        // 0000  0101
            //byte b = 26;      //  0000  1010 
            //int  c = a ^ b;   //  0000  1111


            //Console.WriteLine(c);
            //Console.ReadKey();




            //// >> (Bitsel saga kaydırma Operatörü)
            //// 2 üzeri saga kaydırılan bit kadar katlanır. Aşagısı için 2 üzeri 1

            //byte sayi = 8;                     //1000 1000
            //byte sayi2 = (byte)(sayi<< 1) ;   // 0001 0000
            //Console.WriteLine(sayi2);



            //Console.ReadKey();




            //int a, b, c;
            //int sonuc;
            //Console.WriteLine("1.sayi girin");
            //a = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("2.sayi girin");
            //b = Convert.ToInt16(Console.ReadLine());
            //c = a * b;
            //Console.WriteLine("2 sayinin carpimi:"+c);
            //Console.ReadLine();
            //sonuc = c % 17;
            //Console.WriteLine($"ekrana {a} ve {b} sayılarının 17 ile bölümünden kalan sayi "+sonuc);
            //float fsonuc = (float)sonuc;
            //Console.WriteLine(fsonuc);
            //Console.ReadLine();

            /*
            int a, b=0, c=0;
            bool sayi1, sayi2;

            Console.WriteLine("1.sayi giriniz");
            a = Convert.ToInt16(Console.ReadLine());

            if (sayi1 = (a < 34))
            {
                Console.WriteLine(sayi1);
            }
            else
            {
                Console.WriteLine(sayi2);
            }

    *


            Console.ReadKey();

            //bool bDeg1 = (8 < 9) && (5 == 5); // true
            //bool bDeg2 = (8 > 9) && (5 == 5);  //false
            //bool bDeg3 = (8 > 9) && (5 != 5); //false
            //bool bDeg4 = (8 < 9) && (5 != 5); //false
            //Console.WriteLine($"{bDeg1} {bDeg2} {bDeg3} {bDeg4}");
            //Console.ReadLine();

    */



            //byte sayi1, sayi2, sayi3;

            //Console.WriteLine("1.sayi giriniz");
            //sayi1 = Convert.ToByte((Convert.ToInt32(Console.ReadLine()))>34);
            //Console.WriteLine($"1.sayi sonucu={(sayi1 |= 0xFF)}");


            //Console.Write("2.sayi giriniz");
            //sayi2 = Convert.ToByte((Convert.ToInt32(Console.ReadLine())) > 34);
            //Console.WriteLine($"2.sayi sonucu={(sayi2 |=0xFF)}");


            //Console.Write("3.sayi giriniz");
            //sayi3 = Convert.ToByte((Convert.ToInt32(Console.ReadLine())) > 34);
            //Console.WriteLine($"3.sayi sonucu={(sayi3 |= 0xFF)}");


            //Console.ReadLine();

            int a = 10;
            a++;
                a+= 5;
            --a;
            Console.WriteLine(a);
            Console.ReadKey();
            















        }
    }
}
