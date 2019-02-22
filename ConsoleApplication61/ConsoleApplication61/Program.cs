using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();

            ht.Add(1, "Bir");
            ht.Add(2,"İki");
            ht.Add(3, "Üç");


            foreach (int item in ht.Keys) // İlk sutun anahtar değerler.
            {
                Console.WriteLine(item+ " => " +ht[item]);//anahtar ile cagır.
            }
            Console.ReadKey();





























            //int yas;
            //string adsoyad;
            //ArrayList sayi = new ArrayList();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Adinizi ve soyadinizi giriniz:");
            //    adsoyad = Convert.ToString(Console.ReadLine());

            //    Console.Write("Dogum yılınızı giriniz:");
            //    yas = Convert.ToInt32(Console.ReadLine());
            //    sayi.Add(adsoyad);
            //    sayi.Add(2019 - yas);
            //}
            //for (int i = 0; i < 10; i+=2)
            //{
            //    Console.WriteLine($"{sayi[i]}  {sayi[i+1]}");
            //}
            //Console.ReadKey();

            //Araba frm = new Araba();



            //List<int> Iistem = new List<int>();

            //Iistem.Add(88);
            //Iistem.Add(87);
            //Iistem.Add(86);
            //Iistem.Add(85);
            //Iistem.Add(84);


            ////ArrayListler sınıfının metotolar kullanılabilir.
            ////Örnek:Iistem.Sort,Iistem.Clear

            //Console.ReadKey();










        }

    }
           
}
