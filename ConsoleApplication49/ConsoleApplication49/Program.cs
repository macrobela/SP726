using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Cümle Giriniz");
            string cc =(Console.ReadLine());



            Console.WriteLine("Soldaki boşlukları sil=" + cc.TrimStart());
            Console.WriteLine("Sağdaki boşlukları sil=" + cc.TrimEnd());
            Console.WriteLine("Sağ ve Sol boşlukları sil=" + cc.Trim());


            string temiz = "";
            int uzunluk = cc.Length;
            for (int i = 0; i <= uzunluk - 1; i++)
            {
                if (cc.Substring(i, 1) != " ")
                {
                    temiz += cc.Substring(i, 1);
                }
            }
            Console.WriteLine("Tüm Boşlukların temizi=" + temiz);
            Console.ReadKey();





        }
    }
}
