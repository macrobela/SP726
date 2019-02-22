using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {

        static int merhabayaz(int x)
        {
            return (x + 2) * (x + 2) - 12;
        }

        static void merhabayaz(string deger)                        
        {
            int deger2, sonuc=0;
            Console.WriteLine(deger);
            deger2 = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int deger;
            Console.WriteLine("Sayi Giriniz :");
            deger = Convert.ToInt32(Console.ReadLine());
            int sonuc = merhabayaz(deger);
            Console.WriteLine(sonuc);
            Console.ReadKey();
          
        }
    }
}
