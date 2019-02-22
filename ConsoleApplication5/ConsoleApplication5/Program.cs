using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {


        static int fatoriyel(int sayi)
        {
            if (sayi == 1)
                return 1;
            else
                return sayi * fatoriyel(sayi - 1);
        }
    }
        static void Main(string[] args)
        {
        Console.WriteLine("sayıyı gir");
        int sayi = int.Parse(Console.ReadLine());
        Console.WriteLine("Fotoriyel:{0}", fatoriyel(sayi));
        Console.ReadKey();
    }
    }
}
