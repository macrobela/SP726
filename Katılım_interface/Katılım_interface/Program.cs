using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katılım_interface
{
    interface Arac
    {
        string arac { get; set; }
    }
    interface Teker4
    {
        int Agirlik { get; set; }
        int Fiyat { get; set; }
    }
    class Portakal : Arac, Teker4
    {
        private string PYolcuKapasitesi;
        private string PAracTipi;
        public string aracadi
        {
            get{ return PRenk; }
            set{ PRenk = value; }
        }
        public int Agirlik
        {
            get { return PAgirlik; }
            set { PAgirlik = value; }
        }
        public int Fiyat
        {
            get { return PFiyat; }
            set { PFiyat = value; }
        }
        public string Tat
        {
            get{ return PTat; }
            set{ PTat = value; }
        }

        public string arac
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Portakal pr1 = new Portakal();
            pr1.Renk = "Turuncu";
            pr1.Tat = "Bal Şeker";
            pr1.Agirlik = 5;
            pr1.Fiyat = 20;
            Console.WriteLine(pr1.Tat);
            Console.WriteLine(pr1.Agirlik);
            Console.WriteLine(pr1.Fiyat);
            Console.WriteLine(pr1.Renk);
            Console.ReadKey();
        }
    }
}
