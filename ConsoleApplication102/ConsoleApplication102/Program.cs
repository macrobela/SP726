using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication102
{

    interface ISahipBilgiler
    {
        string Sahibi { get; set; }
        int VergiNumarası { get; set; }

        void SahipKaydet(string dosyaYolu);
    }

    interface IDukkanBilgiler
    {
        string Adi { get; set; }
        int ID { get; set; }
        string Ulke { get; set; }
        string Sehir { get; set; }
        string Ilce { get; set; }

        void DukkanKaydet(string dosyaYolu);
    }
    class BroBurger : ISahipBilgiler,IDukkanBilgiler
    {
        public string Sahibi { get; set; }
        public int VergiNumarası { get; set; }
        public string Adi { get; set; }
        public int ID { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
 
        public void SahipKaydet(string dosyaYolu)
        {
            
            FileStream fs = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

                sw.Write($"Sahibi: {Sahibi}");
                sw.Write($"VergiNumarasi :{VergiNumarası}");
            
            sw.Flush();
            fs.Close();
            
        }

        public  void DukkanKaydet(string dosyaYolu)
        {
            FileStream fs = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            sw.Write($"Sirket Adi : {Adi}");
            sw.Write($"Sirket ID :{ID}");
            sw.Write($"Ülke: {Ulke}");
            sw.Write($"Sehir :{Sehir}");
            sw.WriteLine($"İlcesi : {Ilce}");

            sw.Flush();
            fs.Close();
        }
        public static void BilgiYaz(string dosyaYolu)
        {
            FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs, Encoding.Default);
            string satir;
            int i = 1;

            while ((satir = sw.ReadLine()) != null)
            {
                Console.WriteLine( satir);
                i++;
            }
            fs.Flush();
            sw.Close();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string dosyayolu = @"C:\\SULEYMAN\\SULOFileIO.txt";
            BroBurger bro = new BroBurger();
           
            
            bro.Adi = "Ateş Burger";
            bro.ID = 54152;
            bro.Ilce = "Şişli";
            bro.Sahibi = "Hakikat ";
            bro.Sehir = "Erzincan";
           
            bro.Ulke = "TÜRKİYE";
            bro.VergiNumarası = 00000;
            bro.SahipKaydet(dosyayolu);
            bro.DukkanKaydet(dosyayolu);
            BroBurger.BilgiYaz(dosyayolu);
            Console.ReadKey();
        }

       
    }
}
