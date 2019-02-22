using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte b = (byte)12.5f;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            Console.ReadLine();
            */



            //float a;
            //byte b;
            //unchecked
            //{                             //"unchecked"//    veri kaybı yasanacagı için 0 yazar cıktıya

            //    a = 256.5f;
            //    b = (byte)a; 
            //}

            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType());
            //Console.ReadLine();



            //int a, b;
            //{
            //    a = 5;
            //    b = 6;  
            //}
            //Console.WriteLine(a+b);
            //Console.ReadLine();


            //string b = 3.ToString();
            //Console.WriteLine(b);
            //Console.ReadLine();

            //int a = 5;
            //float b = Convert.ToSingle(a);

            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType());

            //Console.ReadLine();


            //int a = 256;
            //byte b = (byte)a;

            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType());
            //Console.ReadLine();



            //-----------------------------------------------------------------------------------


            /*
            int sayi, toplam = 0;
            int karekter;

            Console.Write("sayi giriniz : ");
            sayi = Convert.ToInt16(Console.ReadLine());

            Console.Write("Karekter Giriniz : ");
            karekter = Console.Read();   //  ASCII kodunu direk alıyor

            toplam = sayi + karekter;   //ikisinin toplamını alıyor

            Console.WriteLine("Sayilarin Toplamı : "+toplam);
            Console.WriteLine(toplam.GetType());      //intger ve double yazdırıyor

            double bToplam = (double)toplam;       //int double ceviyoruz.

            Console.WriteLine(bToplam.GetType());  //ekrana double ve string yazdırıoyoruz.


            string stoplam = bToplam.ToString();  
            Console.WriteLine(stoplam.GetType());   //ekrana double ve string yazdırıoyoruz.



            Console.ReadKey();

    */
            //----------------------------------------------------------------------------------------------------


            /*
           Klşavyeden 1 sayi ve 1 karekter alacagız.
           1:karekterin ASCII degeri ile sayıtyı toplayıp eklrana yazdıralım.
           2:toplam degerini double tipine dönüstürüp ekrana yazdıralım.
           3:double tipini stringe dönüstürüp.Ekrana yazdıralım.

               1.İslem Int tipine toplam
               2.İslem Double İfade doubleToplam
               3.İslem string Toplam:StringToplam
           */


            int toplom = 0, karekter, a;

            Console.WriteLine("Sayi giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Karekter giriniz");
            karekter = Console.Read();

            //Console.Read();      //Girilen tek karekterin ASCII kodunu getirir.
            //Console.ReadLine(); //Girilen tam satır ifadeyi string tipinde getirir.

            toplom = a + karekter;

            Console.WriteLine("Sayilarin toplamı"+toplom);
            Console.WriteLine(toplom.GetType());

            double btoplam = (double)toplom;  //toplam degerini double tipine dönüstürüp ekrana yazdıralım.
            Console.WriteLine(btoplam.GetType());

           string stoplam = btoplam.ToString(); //double tipini stringe dönüstürüp.Ekrana yazdıralım.
            Console.WriteLine(stoplam.GetType());

            Console.ReadKey();

           


        }
    }
}
