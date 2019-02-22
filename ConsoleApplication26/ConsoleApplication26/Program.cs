using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Random rastgele = new Random();

            int x;
            bool y = false;
            while (y)
            {
                x = rastgele.Next(20);
                Console.WriteLine(x);
                if (x == 11)
                    y = false;
            }
            Console.ReadLine();


        }
    }
}
