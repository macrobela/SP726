using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static object islem(int x, int y, string t)
        {
            if (t == "T")
                return (x + y);

            else if (t == "B")
            {
                if (y==0)
                {
                    return "Hatalı Giris yapıldı.";
                }
                return (x / y);
            }
            else if (t == "C")
            return (x * y);

            else if (t == "R")
                return (x - y);
            return "Hatalı Giris yapıldı";                               
        }

        static void Main(string[] args)
        {
            int a, b;
            string deger2;
            object sonuc;

            Console.WriteLine("1.sayiyi giriniz :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayiyi giriniz :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İslem sonucu");
            deger2 = Console.ReadLine();
            sonuc = islem(a, b,deger2);
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
