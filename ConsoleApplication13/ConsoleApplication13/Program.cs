using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            string islem;
            
            

            Console.WriteLine("Lütfen 1.sayıyı giriniz;");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayıyı giriniz;");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem Giriniz: ");
            islem = Console.ReadLine();
           
            Console.WriteLine("toplam: T");
            Console.WriteLine("carpma: Ç");
            Console.WriteLine("Bölme: B");
            Console.WriteLine("Cıkartma: C");


            if (islem=="T")
            {
                Console.WriteLine("sayilarin toplamı" + (sayi1+sayi2));
            }
            else if(islem=="Ç")
            {
                Console.WriteLine("sayilarin carpma" + (sayi1 * sayi2));
            }
            else if (islem=="C")
            {
                Console.WriteLine("sayilarin cakarma" + (sayi1 - sayi2));
            }
            else if (islem=="B")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bölen 0 olmaz");
                }
                else
                {
                    Console.WriteLine(sayi1/sayi2);
                }        

                Console.WriteLine("sayilarin bölme");
            }
            Console.ReadLine();


        }
    }
}
