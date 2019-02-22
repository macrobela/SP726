using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 ile 20 arasında sürekli sayı uretecek. 11 üretilirse söngü bitecek.


            Random rast = new Random();

            int a;
            bool b = true;
            while (b)
            {
                a = rast.Next(20);
                Console.WriteLine(a);
                if (a == 11)
                    b = false;
            }
            Console.ReadLine();




        }
    }
}
