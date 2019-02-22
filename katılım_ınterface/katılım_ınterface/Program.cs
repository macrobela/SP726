using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katılım_ınterface
{
    class Program
    {
        interface ISesGoruntuSistemleri
        {
            string Marka { get; set; }
            int Fiyat { get; set; }
            int Puan { get; set; }
            int PuanToplami { get; set; }
            int PuanciToplami { get; set; }

            void PuanVer(int puan);
        }
        interface ITelevizyon: ISesGoruntuSistemleri
        {
            string Cozunurluk { get; set; }
            void TipYazdir();
        }
        class Audi: ITelevizyon
        {
            public string Marka { get; set; }
            
            public string AracTipi { get; set; }
            public void TipYazdir()
            {
                Console.WriteLine("Arac Tipi :"+AracTipi );
                Console.WriteLine("Aracım :"+ Marka);
            }
        }
        static void Main(string[] args)
        {
            Audi a1 = new Audi();
            a1.Marka = "Yeni Audim";
            a1.AracTipi = "Otomobil";
            a1.TipYazdir();
            
            Console.ReadKey();
        }
    }
}
