using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace bitti
{
    class Program
    {
        static void Main(string[] args)
        {
            markalar sınıf = new markalar("Audi","S4", DateTime.Parse("24.04.1995"),"2000");
            FileStream fs = new FileStream("Sinif.XML", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(markalar));
            xs.Serialize(fs,sınıf);
            Console.WriteLine("İşlem Basarili");
            Console.Read();

        }
    }
}
