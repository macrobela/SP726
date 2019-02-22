using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication74
{
    enum Aylar : byte { ocak=1,subat,mart,nisan,mayıs,haziran,temmuz,agustos,eylul,ekim,kasım}

    class Program
    {

        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("Ay bilgisi Giriniz :");
                string ay = Console.ReadLine();

                if (Enum.IsDefined(typeof(Aylar),ay))
                {
                    Console.WriteLine("Geçerli");
                    break;
                }
                i++;

            } while (i<4);
            Console.ReadKey();
        }
    }
}
