using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] marmara = newstring[] { "Kocaeli", "Bursa", "Yalova", "İstanbul", "Edirne", "Tekirdağ", "Kırklareli", "Çorlu", "Çanakkale", "Sakarya" };
            bool durum = true;
            Console.Write("Aradığınız İli Girin:");
            string aranan_il = Console.ReadLine();
            foreach (string il in marmara)
            {
                //ToLower küçük harf,ToUpper büyük har çevirmek
                if (aranan_il.ToUpper() == il.ToUpper()) durum = false;
            }

            if (durum == false)
                Console.Write("İl bulundu");
            else
                Console.Write("İl bulunamadı");
            Console.ReadKey();
           

        }
    }
}