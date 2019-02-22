using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {

        static void diziyaz(int[] dizi)
        {
            

            int sayi, kontrol = 0;
            int dizi[];
            Console.Write("Bir sayı giriniz :");
            dizi[] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < dizi[].Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    kontrol++;
                }
            }
            if (kontrol == 0)
            {
                Console.WriteLine("Sayı dizi içinde bulunamadı...");
            }
            else
            {
                Console.WriteLine("Bu sayı dizide {0} adet var", kontrol);
            }
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Sayi Girin :"+i);
            //    i = Convert.ToInt32(Console.ReadLine());
            //}


        }

    }
}
