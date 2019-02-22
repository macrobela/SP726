using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication108
{
    public class   HataliNotGirisi:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Not 0-100 arasında olmalıdır!!!.";
            }
        }
    }
    public class Notlar
    {
        public int Not
        {
            get { return Not; }
            set {
                if (value>100 || value<0)
                {
                    throw new HataliNotGirisi();
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {






            Notlar n1 = new Notlar();

            Console.Write("Not Giriniz :");
            n1.Not = Convert.ToInt32(Console.ReadLine());



            Console.ReadKey();





        }
    }
}
