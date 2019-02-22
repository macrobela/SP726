using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Kullanıcı = "smartpro";
            const string Parola = "SmartKD";
            int i = 1;
            do
            {
                Console.Write("Kullanıcı adı giriniz: ");
                string username = Console.ReadLine();
                Console.Write("Şifre giriniz: ");
                string password = Console.ReadLine();
                if (username == Kullanıcı && password == Parola)
                {
                    Console.WriteLine("Giriş Başarılı");
                    break;
                }
                //else if(username != Kullanıcı || password != Parola)
                //    Console.WriteLine(i+". girişi hatalı yaptınız.");

                else if (i == 5)
                {
                    Console.WriteLine("Çok fazla hatalı giriş yaptınız.");
                }
                i++;
            } while (i <= 5);
            Console.ReadKey();





        }
    }
}
