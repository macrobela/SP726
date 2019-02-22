using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication100
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarihsaat = new DateTime();
            tarihsaat = DateTime.Now;
            Console.WriteLine("Ay :"+tarihsaat.Month);
            Console.WriteLine("Yıl :" + tarihsaat.Year);
            Console.WriteLine("Tarih :"+tarihsaat.Date);

            Console.Read();
        }
    }
}
