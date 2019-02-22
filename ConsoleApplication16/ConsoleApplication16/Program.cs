using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Bir Sayi Giriniz:");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=a; i++)
            {
                Console.WriteLine( a );
            }
            Console.ReadLine();
        }
        
    }
}
