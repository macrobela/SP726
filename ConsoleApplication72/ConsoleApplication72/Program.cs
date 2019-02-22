using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication72
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList aList = new ArrayList();
            Araba arac = new Araba();
            arac.aracekle(aList);
            Araba.AracListeleme(aList);
            Console.ReadKey();
        }
    }
}
