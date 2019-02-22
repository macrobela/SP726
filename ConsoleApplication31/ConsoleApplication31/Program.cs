using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] sayigir = new int[10];

            //int[] say = new int[5];
            //int[] say1 = new int[5];


            //int i;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Sayi Girin :");
            //    sayigir[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //say[i] = sayigir[i];
            //say1[i] = sayigir[i];
            //if (sayigir[i] >= 50)
            //{
            //    Console.WriteLine(say[i]);
            //}
            //else if (sayigir[i] < 50)
            //{
            //    Console.WriteLine(say1[i]);
            //}


























            int[] sayigir = new int[10];

            int[] say = new int[10];
            int[] say2 = new int[10];
            int i;

            say[i] = sayigir[i];
            say2[i] = sayigir[i];




            for (i = 0; i < 10; i++)
            {
                Console.Write("Sayıyı giriniz..:");
                sayigir[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine("------------");

            for (i = 0; i <= 9; i++)
            {
                if (say[i] % 2 == 0)
                {
                    Console.WriteLine(say[i]);
                }
            } 
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine("-----------");
            for (i = 0; i <= 9; i++)
            {
                if (say2[i] % 2 == 1)
                {
                    Console.WriteLine(say2[i]);
                } 
            }
            Console.ReadKey();
































        }
    }
}
