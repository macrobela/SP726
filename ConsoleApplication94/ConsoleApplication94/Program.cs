using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication94
{
    interface IArac
    {
        string araba { get; set; }
        string ucak { get; set; }
        string panzer { get; set; }
    }
    interface ITeker4: IArac
    {
        string AracTipi { get; set; }
        void tip();
    }
    class IAudi : ITeker4
    {
        private string PAraba;
        private string PUcak;
        private string PPanzer;
        private string PAracTipi;
        public string araba
        {
            get{ return PAraba; }

            set{ PAraba = value; }
        }

        public string AracTipi
        {
            get{ return PUcak; }

            set{ PUcak = value; }
        }

        public string panzer
        {
            get{ return PPanzer; }

            set{ PPanzer = value; }
        }

        public string ucak
        {
            get{ return PAracTipi; }

            set{ PAracTipi = value; }
        }

        public void tip()
        {
                 
        }
    }
    class Program
    {
        private static bool araba;
        private static bool panzer;
        private static bool ucak;

        public static bool AracTipi { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(araba);
            Console.WriteLine(AracTipi);
            Console.WriteLine(panzer);
            Console.WriteLine(ucak);

            IAudi au = new IAudi();
            au.araba = "Jaguar";
            au.AracTipi = "Volvo";
            au.panzer = "Au";
            au.ucak = "THY";

         
            ITeker4 br2 = au;
            //br2.ucak;
            
            Console.ReadKey();
        }
    }
}
