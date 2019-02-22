using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {

        //Klavyeden girilen metin'i ekrana yazdıran ve string dizisinde dizi atama yapan metin programı...

        static void Main(string[] args)
        {
            Console.WriteLine("Metin Giriniz :");
            string str = Console.ReadLine();
            stringDizi(str);
            Console.ReadKey();
        }

        static void stringDizi(string a)
        {
            string[] str1 = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                str1[i] = Convert.ToString(a[i]);
            }
            chardiziyap(str1);
        }
        static void chardiziyap(string[] b)
        {
            char[] chr1 = new char[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                chr1[i] = Convert.ToChar(b[i]);
                Console.Write(chr1[i]);
            }

            
        }
    }
        
            

}
