using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.WriteLine("Bir sayi Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 99)
            {
                sayi %= 3;

                switch (sayi)
                {
                    case 0:
                        Console.WriteLine("3 ile bölümünden kalan: " + sayi);
                        break;
                    case 1:
                        Console.WriteLine("3 ile bölümünden kalan: " + sayi);
                        break;
                    case 2:
                        Console.WriteLine("3 ile bölümünden kalan: " + sayi);
                        break;

                    default:
                        Console.WriteLine("Hatalı Giris Yaptınız: ");
                        break;
                }

            }
            else if (sayi<100)
            {
                sayi %= 4;
                switch (sayi)
                {
                    case 0:
                        Console.WriteLine("4 ile bölümünden kalan: " + sayi);
                        break;
                    case 1:
                        Console.WriteLine("4 ile bölümünden kalan: " + sayi);
                        break;
                    case 2:
                        Console.WriteLine("4 ile bölümünden kalan: " + sayi);
                        break;
                    case 3:
                        Console.WriteLine("4 ile bölümünden kalan: " + sayi);
                        break;

                    default:
                        Console.WriteLine("Hatalı Giris Yaptınız: ");
                        break;
                }
            }
            Console.ReadLine();
            { 
}
            
            

            
        }
    }
}
