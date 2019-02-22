using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication71
{
    class Program
    {
        static void Main(string[] args)
        {

            int ogrenciAdedi = 0;

            while (true)
            {
                Console.Write("KAÇ PERSONEL KAYDI GİRİLECEK : ");
                ogrenciAdedi = Convert.ToInt32(Console.ReadLine());
                if (ogrenciAdedi > 0)
                {
                    break;
                }
            }
            ArrayList aList = new ArrayList();


            Ogrenci s1 = new Ogrenci();
            Console.WriteLine("Adinizi Giriniz :");
            s1.OgrenciAdi = Console.ReadLine();
            aList.Add(s1.OgrenciAdi);


            Ogrenci s2 = new Ogrenci();
            Console.WriteLine("Ogrenci Numarası");
            s2.OgrenciNumarasi = Console.ReadLine();
            aList.Add(s2.OgrenciNumarasi);

            Ogrenci s = new Ogrenci();
            Console.WriteLine("Ogrencinin 1 Notunu Giriniz :");
            s.Not1 = Console.ReadLine();

            Console.WriteLine("Ogrencinin 2 Notunu Giriniz: ");
            s.Not2 = Console.ReadLine();
            aList.Add(s.Not1);
            aList.Add(s.Not2);


            Ogrenci.KayitEkle(aList);

            Console.WriteLine($"Okulun Ortalaması :{ogrenciAdedi/2}" );
              
            Console.ReadKey();

        }
    }
}
