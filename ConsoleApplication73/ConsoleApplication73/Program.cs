using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication73
{

    enum Aylar : byte { Ocak=1, Şubat, Mart, Nisan, Mayıs, Haziraz, Temmuz, Agustos, Eylül, Ekim, Kasım, Aralık }


    //  ENUM  Sabit ifadelerin sayısal tiplerde liste gibi tutulmasına yarar.

    //enum Gunler : byte{Pazartesi,Salı,Çarsamba,Persembe,Cuma=255,Cumartesi=88,Pazar}






    //class OOPDevam
    //{
    //public const string Metin = "Süleyman";  //const sabit degismeyen özellik
    //public readonly int Sayi = 55;
    //public readonly int Sayi2;

    //public void Ata() { }

    //public OOPDevam()
    //{
    //    Sayi = 58;
    //    Sayi2 = 58;
    //    Console.WriteLine(Sayi);
    //    Console.WriteLine("Normal Yapıcı Çalıiştı");
    //    Sayi = 99; Sayi2 = 90;
    //}
    //static OOPDevam()
    //{


    //    Console.WriteLine("Static Yapıcı Çalıştır");
    //}
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //    string bugun = Gunler.Pazartesi.ToString();
            //    string[] sDizi = Enum.GetNames(typeof(Gunler));
            //    Console.WriteLine();
            //    //foreach (var item in sDizi)
            //    //{
            //    //    Console.WriteLine(item);
            //    //}

            //byte bugun1 = (byte)Gunler.Cuma();

            //Console.WriteLine(bugun1);


            Aylar a1 = new Aylar();
            bool varmı = Enum.IsDefined(typeof(Aylar), "Mayıs");
            string ay = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                bool varmi = Enum.IsDefined(typeof(Aylar),ay);
                if (varmi == false)
                {
                    Console.WriteLine("Ay Girermisiniz :");

                    i = 0;
                    Console.WriteLine("Tebrikler bildiniz:");
                }
                else if (varmi !=false)
                {
                    Console.WriteLine();
                    ay = Enum.GetValues(typeof(Aylar),"Ocak");
                }
                    
                
            }



            Console.ReadKey();























            //OOPDevam o1 = new OOPDevam();
            //OOPDevam o2 = new OOPDevam();
            //OOPDevam o3 = new OOPDevam();

            //Console.ReadLine();
        }

       

    }
}
