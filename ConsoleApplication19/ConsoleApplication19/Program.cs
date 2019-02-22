using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            int isci, cocuk, i, maas=0;

            Console.WriteLine("isci sayısı");
            isci = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < isci; i++)
            {
                Console.WriteLine("cocuk sayısı giriniz");
                cocuk = Convert.ToInt32(Console.ReadLine());

                

                maas = 3000;

                if (cocuk == 0)
                {
                    Console.WriteLine("İscinin maaşı: " + maas);
                }
                else if (cocuk<0)
                {
                    Console.WriteLine("Hatalı giris yaptınız: "+maas);
                }
                else if (cocuk <= 2)
                {
                    Console.WriteLine(cocuk <= 2);
                    maas = maas + (cocuk * 100);
                }
                else
                {
                    maas = maas + (cocuk * 75);
                    Console.WriteLine("İscinin maaşı: " + maas);
                }


                Console.WriteLine($" {i}.iscinin {cocuk} cocugu var");
                
            }
            Console.ReadLine();
   
            //------------------------------------------------------------------
        
            Console.WriteLine("sayi giriniz :");
            string yazi = Console.ReadLine();

            for(int i = 0; i <=yazi.Length; i++)
            {
                Console.WriteLine(yazi);
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadLine();
                     
   



            int sayi, basamak = 1;
            Console.WriteLine("Sayi Giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(basamak + " basamak "+(sayi %10));
            for (; sayi>10;)
            {
                sayi = sayi / 10;
                int rakam = sayi % 10;
                basamak *= 10;
                Console.WriteLine(basamak + " basamağı " + rakam) ;
            }
            Console.ReadLine();


     */









            int sayi, i, j;

            Console.Write("bir sayı giriniz: ");
            sayi=Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= 5; i++) 

            {

                for (j = 0; j <=sayi; j++) 

                {

                    Console.Write(sayi); 

                }

                Console.WriteLine(""); 

            }

            Console.ReadKey(); // Bir tuşa basana kadar consolu kapatma





























        }
    }
}
