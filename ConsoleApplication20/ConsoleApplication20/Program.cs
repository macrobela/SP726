using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {

            string ka = "smartpro";
            string sifre = "SmartKD";
            string kka, ssıfre;

            int sayac = 0;
            sayac++;

            do
            {
                Console.WriteLine("Kullanıcı adı giriniz :");
                kka = Console.ReadLine();


                Console.WriteLine("Sifre giriniz :");
                ssıfre = Console.ReadLine();

                
                if (ka == kka && sifre == ssıfre)
                {
                    Console.WriteLine("Ekrana giriş basarılı yapıldı");
                    break;
                }
                else if (sayac == 5)
                {
                    Console.WriteLine("Hakkınız Doldu");
                }
                else
                {
                    Console.WriteLine("Yanlış Girildi");
                }
                
                sayac++;

            } while (sayac<=5);
            
            Console.ReadLine();
          

          

        }
    }
}
