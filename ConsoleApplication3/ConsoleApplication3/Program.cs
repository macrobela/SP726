using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        //method overloading/aşırı metot yukleme
        static int topla(int a, int b)
        {
            return (a+b);
        }
        static int topla(int a, int b,int c)
        {
            return (a + b+c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(topla(6,7));
            Console.WriteLine(topla(3,2,4));
            Console.ReadLine();



        }
    }
}
