using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication85
{
   }

    class Emlak
    {
        public string Adres;
        public string Belediye;
        public bool Mustakil;
        public int Metrekaresi;
        public ArrayList Odasayisi;
        public bool Mutfak;


        public int yillikVergi(int metrekare)
    {
        if (Mustakil == true)
            return Mustakil * 2;
        else
            return Mustakil * 5;
    }
    public void listele()
        {
            
            

        }

    }
        class Ev:Emlak
{

}


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
