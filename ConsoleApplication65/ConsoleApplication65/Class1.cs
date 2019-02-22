using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Matematik
    {
        public char İslem;
        double sayi1, sayi2;

        
        public double sonuc(double sayi1,double sayi2,char opt)
        {
            if (opt == 'T')
            {
                return sayi1 + sayi2;
            }
            else if (opt == 'C')
            {
                return sayi1 - sayi2;
            }
            else if (opt == 'Ç')
            {
                return sayi1 * sayi2;
            }
            else if (opt == 'B')
            {
                return sayi1 / sayi2;
            }
            else
            {
                return 0;
            }
        }
    }
}