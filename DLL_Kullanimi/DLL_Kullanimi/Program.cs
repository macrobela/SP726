using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rastgele;

namespace DLL_Kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Rastgele.Sayi rs1 = new Rastgele.Sayi();
            Console.WriteLine(rs1.RSayi);
            rs1.Degistir();
            Console.WriteLine(rs1.RSayi);


            Console.ReadKey();

        }
    }
}
