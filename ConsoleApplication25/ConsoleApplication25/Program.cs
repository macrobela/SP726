using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.İfade");
            ifade2:
            Console.WriteLine("2.ifade");
            goto ifade2;
            Console.WriteLine("3.ifade");
            Console.ReadKey();
            //TODO:Diziler anlatılacak.

            int a;

            Random rastgele = new Random();
             int  sayi = rastgele.Next(1, 20);

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}
