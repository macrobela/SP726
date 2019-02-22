using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {

        private static void harfSay(string cumle)
        {
            if (!string.IsNullOrWhiteSpace(cumle))
            {
                int sayac = cumle.Length;
                string harf = cumle.Substring(0, 1);
                cumle = cumle.Replace(harf, "");
                sayac -= cumle.Length;
                Console.WriteLine($"{harf} -> {sayac} Adet");
                harfSay(cumle);
            }
        }




        static void Main(string[] args)
        {

            Console.ReadKey();
            Console.WriteLine("metin giriniz");
            string metin;
            int sayac = 1;
            metin = Console.ReadLine();
            harfSay(Console.ReadLine());
            string yenimetin = metin.Trim();
           
            for (int i = 0; i < yenimetin.Length; i++)
            {
                if (yenimetin.Substring(i, 1) == " ") sayac += 1;
            }
            Console.WriteLine("bu metinde {0} kelime kullanılmıştır.", sayac);

            harfSay(Console.ReadLine());

            Console.ReadLine();



            
                
            









            //string kucuk = "smartpro";
            //string buyuk = "SMARTPRO";
            //Console.WriteLine(kucuk.ToUpper());
            //Console.WriteLine(buyuk.ToLower());

            //Console.WriteLine(buyuk.Replace('P','B'));

            ////Console.WriteLine(buyuk.Remove(0,0));
            ////Console.WriteLine(buyuk.Insert(8,"_BRO"));


            //String str = "Merhaba 404";
            //Console.WriteLine(str.Substring(8)); //404
            //Console.WriteLine(str.Substring(0,7)); //Merhaba
            //Console.WriteLine(str.Substring(0,1)); //M

            //Console.WriteLine(str.Contains("aba"));  //true

            //Console.WriteLine(str[8]);


            //Klavyeden girilen harflarin ve boşlukların sayısını yazdıran (void) metotu tanımlayınız.





        }


    }
}
