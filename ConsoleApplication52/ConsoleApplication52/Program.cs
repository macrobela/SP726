using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Program
    {
        static void harfvar()
        {
            Console.WriteLine("Bir metin giriniz :");
            string metin;
            int sayac = 1;
            metin = Console.ReadLine();
            string yenimetin = metin.Trim();
            for (int i = 0; i < yenimetin.Length; i++)
            {
                if (yenimetin.Substring(i, 0) == "")
                    sayac += 1;

                Console.WriteLine(metin.Remove(0, 6));
                Console.WriteLine();
                Console.WriteLine("Bu metotda {0} kelime kullanılmıstır.", sayac);
                Console.WriteLine();
                Console.WriteLine(metin.Insert(30, "Buraya giris yapılmaz..."));
                Console.WriteLine();
                Console.WriteLine(metin.Substring(8));
                Console.WriteLine();
                Console.WriteLine(metin.Substring(0, 7));
                Console.WriteLine();

            }


        }

        static void Main(string[] args)
        {

            harfvar();
            Console.ReadKey();






        }
    }
}
