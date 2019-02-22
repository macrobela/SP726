using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        static int fibonacci(int sayi)
        {
            if (sayi == 0)
            return 0;
            else if(sayi == 1)
           return 1;
    else
        return fibonacci(sayi - 1) + fibonacci(sayi - 2);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("değeri girin : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            Console.WriteLine(fibonacci(i));
            Console.ReadKey();
        }
    }
}
