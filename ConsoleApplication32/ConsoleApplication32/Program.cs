using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] sayigir = new int[5];
            //int i=0;
            //int[] tekdizi = new int[5];
            //int[] ciftdizi = new int[5];
            //int toplam =0;

            //tekdizi[i] = sayigir[i];
            //ciftdizi[i] = sayigir[i];



            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("Sayıyı giriniz..:");
            //    sayigir[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (i = 0; i <= 10; i++)
            //{
            //    if (tekdizi[i] >=50)
            //    {
            //        toplam = tekdizi[i] + ciftdizi[i];
            //        Console.WriteLine(tekdizi[i]);
            //    }
            //}

            //for (i = 0; i <= 9; i++)
            //{
            //    if (ciftdizi[i]<=50)
            //    {
            //        toplam = ciftdizi[i] + tekdizi[i];
            //        Console.WriteLine(ciftdizi[i]);
            //    }
            //}
            //Console.ReadKey();

            //-------------------------------------------------------------------------------------------------

            //int[] dizi1 = { 5, 77, 63, 12, 245, 645, 34, 7, 90, 76, 34, 23, 456, 734 };
            //int n = Array.IndexOf(dizi1, 34);
            //Console.WriteLine(n);
            //Console.WriteLine(dizi1[n]);



















            //string[] ad = new string[5];
            //int[] numara = new int[3];
            //int[] telefon = new int[3];
            //int[] email = new int[3];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("");
            //}




            string[] numara = { "101"," 102", "103", "104", "105" };
            string []isim = { "Ahmet", "Recep", "Mustafa", "Kenan", "Ayşe" };
            string []telefon = { "5252525", "2525252525", "7474747474", "321","588858885"};
            string[] email = { "asd@hotmail.com", "recepivedik321@hotmail.com", "mustafa321@hotmail.com", "kenanevran@hotmail.com", "aysetopuz@hotmail.com" };

            
            Console.WriteLine("Oda numaranız :");
            string klavye=Console.ReadLine();
            Console.WriteLine("numaranız :" + numara);
            int no = Array.IndexOf(numara,klavye.ToString());
            Console.WriteLine("İsim:{0} \tTelefonu :{1}\tE-mail:{2}",isim[no],telefon[no],email[no]);


            Console.ReadKey();









        }
    }
}
