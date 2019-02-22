using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katılım_polimorfom
{
    class Hayvan
    {
        virtual public void SesCikar()//virtual (sanal) devre dışı bırakılabilir üzerinhe yazılabilir.
        {
            Console.WriteLine("Hayvanlar sesleri çeşitlidir.!");
        }
    }
    class Kedi:Hayvan
    {
        override public  void SesCikar()  //new olunca bilinçli olarak ses cıkar.//ezmek türevden sınıf-burada override olmazsa virtual devam eder.
        {
            Console.WriteLine("Miyav Miyav");
            //base.SesCikar();
        }
    }
    class Tavuk:Hayvan
    {
        public void SesCikar()
        {
            Console.WriteLine("Git Git Gidaaak");
        }
    }
    class Program
    {
        public static void SesCikar(Hayvan hyvn)
        {
            hyvn.SesCikar();
        }
        static void Main(string[] args)
        {
            Hayvan hayvan1 = new Hayvan();
            Kedi kedi1 = new Kedi();
            Tavuk tavuk1 = new Tavuk();
            //hayvan1.SesCikar();
            //kedi1.SesCikar();
            //tavuk1.SesCikar();
            Hayvan hyvn = kedi1;
            SesCikar(hayvan1);
            SesCikar(kedi1);
            SesCikar(tavuk1);

            Console.ReadKey();
        }
    }
}
