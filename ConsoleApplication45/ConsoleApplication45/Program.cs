using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {

        static void Carp(int kontrol,params int[] dizi)
        {
            
            if (kontrol == 0)
            {
                foreach (int item in dizi)
                {
                    Console.Write(item+" ");
                }
            }
            else
            {
                foreach (int item in dizi)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {

            Carp(8, 5, 4, 3, 2, 5, 3);
            Carp(0, 6, 6, 6, 6, 6, 6, 6);

            

            
            Console.ReadLine(); 


        }
    }
}
