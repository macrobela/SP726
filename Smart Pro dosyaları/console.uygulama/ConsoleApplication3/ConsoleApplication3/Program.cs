﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                a=1 , b=1 , c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <8; i++)
            {
                c = a + b;

                a = b;
                b = c;
                

                Console.WriteLine(c);
                
            }
            Console.ReadLine();
        }
    }
}
