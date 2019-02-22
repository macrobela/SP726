using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{

    class Sirket
    {
        public int Vergidaire;
        public int VergiNumarası;
        public int Turu;
        public int SirketAdi;
        public Sirket()     //Yapıcı Metot(Constructor)
        {
            ArrayList SirketTurleri(Anonim,Limited,Sahıs) ArrayList
            SirketAdi = BilgiEksik;
            Vergidaire = Bilgi Eksik;
            VergiNumarası = Bilgi Eksik;
           
            Console.WriteLine("Yapıcı (Constructor) Çalıştı");
        }
        
        
        //Yapıcı Metot (Constructor) Parametreli
        public Sirket(int Vergidaire, int VergiNumarası, int Turu)
        {
            this.Vergidaire = Vergidaire;
            this.VergiNumarası = VergiNumarası;
            this.Turu = Turu;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Sirket ucg1 = new Sirket();
                Console.WriteLine(ucg1.Vergidaire);
                Console.WriteLine(ucg1.VergiNumarası);
                Console.WriteLine(ucg1.Turu);
                Console.WriteLine();

                Sirket ucg2 = new Sirket(6, 8, 10);

                Console.WriteLine(ucg2.Vergidaire);
                Console.WriteLine(ucg2.VergiNumarası);
                Console.WriteLine(ucg2.Turu);



                Console.ReadKey();
            }
        }
    }
}
