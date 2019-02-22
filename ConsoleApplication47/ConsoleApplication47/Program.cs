using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    class Program
    {

        static void Topla(int[] b)
        {
            int toplam = 0;
            for (int i = 0; i < b.Length; i++)
            {
                toplam = toplam+b[i];
                Console.WriteLine("Sayilarin Toplamı"+toplam);        
            }
        }

        static void topla(int a, int b, int c = 4)
        {
            int toplam = 0;
            toplam = toplam + (a+b+c);
            Console.WriteLine("İlk 3 sayının toplamı"+toplam);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Giriniz :");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[a];
            Random rastgele = new Random();
            for (int i = 0; i < a; i++)
            {
                int rsayi = rastgele.Next(75,125);
                dizi[i] = rsayi;
                Console.WriteLine("Dizinin"+i+".terimi"+dizi[i]); 
            }
            Topla(dizi);
            topla(dizi[0], dizi[1], dizi[2]);
            Console.ReadKey();


            
           
            




        }
    }
}
