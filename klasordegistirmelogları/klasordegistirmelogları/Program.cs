using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasordegistirmelogları
{


    class Program
    {
        static void Main(string[] args)
        {

            string[] dosya = Directory.GetFiles(@"C:\\TEST");

            foreach (string file in dosya)
            {
                if (File.GetLastWriteTime(file).Date < DateTime.Today.AddDays(-5).Date)
                    File.Delete(file);


                    if (File.GetLastWriteTime(file).ToShortDateString() == DateTime.Today.AddDays(-1).ToShortDateString())
                     { }
                    //Kopyalama işlemi

            }
                
            Console.ReadKey();

        }
    }
}
