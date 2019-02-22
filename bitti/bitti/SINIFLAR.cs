using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitti
{

       
      class markalar
    {
        public string ad;
        public string model;
        public DateTime dogumtarihi;
        public string motorhacmi;


        public markalar(string a,string s,DateTime d,string m) { ad = a; model = s;dogumtarihi = d; motorhacmi = m; }

        public void BilgileriGöster()
        {
            Console.WriteLine("ad :"+ ad);
            Console.WriteLine("model :"+ model);
            Console.WriteLine("dogdugutarih :"+ dogumtarihi);
            Console.WriteLine("motorhacmi :"+ motorhacmi);
        }
        

    }
}
