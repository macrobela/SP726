using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,y;
            Console.WriteLine("SAyi giriniz");
            Console.ReadLine();
            if (m>50)
            {
                for (int i = 0; i < m; i++)
                {
                    Console.WriteLine('y');
                }
                for (int i = 0; i < y; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("*");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("#");
                        Console.ReadLine();
                    }
                }
            }
                     
        }
    }
}
