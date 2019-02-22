using ConsoleApplication92;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication92
{
    abstract class Kus
    {
        public string Cins { get; set; }
        public string Renk { get; set; }
        public string KanatUzunlugu { get; set; }

        public abstract void SeyehatHesabla(int hiz,int mesafe);
    }
    class Karga : Kus
    {
        public string karga;
        public override void SeyehatHesabla(int hiz, int mesafe);
        {
            
        }
    }
    class Kaz:Kus
    {
        private string kaz;
    public override void SeyehatHesabla(int hiz, int mesafe);
        {
            
                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
