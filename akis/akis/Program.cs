using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int toplom = 0, karekter, a;

            Console.WriteLine("Sayi giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Karekter giriniz");
            karekter = Console.Read();

            //Console.Read();      //Girilen tek karekterin ASCII kodunu getirir.
            //Console.ReadLine(); //Girilen tam satır ifadeyi string tipinde getirir.

            toplom = a + karekter;

            Console.WriteLine("Sayilarin toplamı" + toplom);
            Console.WriteLine(toplom.GetType());

            double btoplam = (double)toplom;  //toplam degerini double tipine dönüstürüp ekrana yazdıralım.
            Console.WriteLine(btoplam.GetType());

            string stoplam = btoplam.ToString(); //double tipini stringe dönüstürüp.Ekrana yazdıralım.
            Console.WriteLine(stoplam.GetType());

            Console.ReadKey();

    */

            //---------------------------------------------------------------------------------------------------------

            //ifadce:(a+b) deyim:Console.WriteLine(a+b);

            /*
            int a = 3;

            if (a == 8)
            {
                Console.WriteLine("sayi esittir");
            }
            else
            {
                Console.WriteLine("sayi esit degil");
                Console.WriteLine("kosul dısı");
            }
                Console.ReadKey();

    */

            int a, b;

            Console.WriteLine("1.sayi giriniz");
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("2.sayi giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("1.sayi büyüktür");
            }
            else if(a==b)
                {
                Console.WriteLine("sayi esitdir");       
            }
            else
            {
                Console.WriteLine("2.sayi büyüktür");
            }

            Console.ReadLine();


















        }
    }
}
