using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication93
{
    abstract class Kus
    {
        public string KusTuru;
        abstract  public string renk { get; set; }
        abstract public string cins { get; set; }
        abstract public void SeyahatHesapla(int hiz,int mesafe);
        }
    class Karga : Kus
    {
        public new string Kusturu = "Alaca";
        private string KCins;
        public override string cins
        {
            get
            {
                return KCins;
            }
            set
            {
                KCins = value;
            }
        }
        private string KRenk;
        public override string renk
        {
            get
            {
                return KRenk;
            }
            set
            {
                KRenk = value;
            }
        }
        public override void SeyahatHesapla(int hiz, int mesafe)
        {
            Console.WriteLine($"{KRenk} {KusTuru}  {KCins}  Kuşu {mesafe} km mesafe {mesafe/hiz} saatte uçar");      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Karga krl = new Karga();
            krl.cins = "Erzincan ";
            krl.renk = "Siyah";
            krl.KusTuru = "Alaca";
            krl.SeyahatHesapla(20,100);
            Console.ReadKey();
            
        }
    }
}
