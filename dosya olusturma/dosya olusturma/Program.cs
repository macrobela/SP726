using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dosya_olusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            //string klasorAdi = "ProjeDosyalari"; /// yeni klasörün adi:
            //string klasorAdi2 = @"C:\FiloIO";   // yeni olusturulan klasörün gidecegi adres
            //Console.WriteLine(Directory.GetCurrentDirectory());  //bilgisayardaki konumunu gösterir.
            //Directory.CreateDirectory(klasorAdi); // clasör olusturur.
            //Directory.CreateDirectory(klasorAdi2);// clasör2 olusturur.

            //Console.WriteLine(Directory.GetCreationTime(klasorAdi2));  // ne zaman klasör olusturuldugunu gösterir.
            //Directory.Delete(klasorAdi2,true); //olusturulan klasör'u siler.
            //bool klasorVarmi=Directory.Exists(klasorAdi2);
            //if (klasorVarmi)
            //{
            //    Console.WriteLine("Klasör Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Klasör Yok");
            //    Directory.CreateDirectory(klasorAdi2);
            //    Console.Write("Klasör  Oluşturuldu.");
            //}



            //string yolC = @"C:\";
            //string[] cdekiklasorler = Directory.GetDirectories(yolC);
            //foreach (var item in cdekiklasorler)
            //{
            //    Console.WriteLine(item);
            //}
            //string [] CdekiDosyalar = Directory.GetFiles(yolC);
            //string[] CdekiDosyalar = Directory.GetFiles(yolC,"*.sys");//uzantı filtreleme

            //foreach (var item in cdekiklasorler)
            //{
            //    Console.WriteLine(item);
            //}

            string yolC = @"D:\";
            string[] dosyaVeKlasorler = Directory.GetDirectories(yolC);
            foreach (var item in dosyaVeKlasorler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
