using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastgele
{
    public class Sayi
    {
        private Random Rast = new Random();
        public int RSayi;
        public Sayi()
        {
            RSayi = Rast.Next(1,101);
        }
        public  void Degistir()
        {
            RSayi = Rast.Next(1,101);
        }

    }
}
