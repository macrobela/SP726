using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
     abstract class Birey
    {
        //abstract public string Soyad { get; set; } dogrudan nesne uretilmiyor.get ve set olmalı.
        abstract public string Ad { get; set; }
        abstract public void AdYaz();
        public int Yas;     
    }
    class Calisan : Birey
    {
        private string AD;
        public override string Ad
        {
            get
            {
                return AD;
            }
            set
            {
                AD = value;
            }
        }
        public override void AdYaz()
        {
            Console.WriteLine("Birey Adi : " + Ad);
            Console.WriteLine("Birey Yaş : " + Yas);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calisan cls1 = new Calisan();
            cls1.Ad = "Mehmet";
            //cls1.AdYaz();
            cls1.Yas = 70;

            Birey br2 = cls1;
            br2.AdYaz();
            Console.ReadLine();
        }
    }
}
