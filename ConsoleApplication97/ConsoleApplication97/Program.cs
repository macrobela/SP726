using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication97
{
    class AnaSinif
    {

        protected override void AdYaz()

        abstract protected void AdYaz();
        protected int a;
        protected void SoyadYaz()
        {
            Console.WriteLine("soyad");
        }
    }
    //class AltSinif:AnaSinif
    //{
    //    protected override void AdYaz()
    //    {
    //        base.AdYaz();
    //    }
    //    protected int b;
    //    protected new int a;
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //}
}
