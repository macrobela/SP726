using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    enum Markalar : byte { Honda,Mazda,Toyota }
    //Kapsülleme (Encapsulation) // Kontrolü saglama
    class arac
    {
        private string Marka;

        public void GetMarka()
        {
            return Marka;
        }
        public void SetMarka(string marka)
        {
            this.Marka = marka;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
