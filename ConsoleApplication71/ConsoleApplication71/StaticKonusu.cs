using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication71
{
    class Ogrenci
    {
        public string OgrenciAdi;
        public string OgrenciNumarasi;
        public string Not1;
        public string Not2;
        public string ToplamOgrenciSayisi;


        public static void KayitEkle(ArrayList aList)
        {
            for (int i = 0; i < aList.Count - 1; i = i + 2)
            {
                Console.WriteLine("OgrenciAdi : " + aList[i]);
                Console.WriteLine("OgrenciNumarasi : " + aList[i + 1]);
                Console.WriteLine("OgrenciSinifi : " + aList[i + 1]);
                Console.WriteLine("Not1 : " + aList[i + 1]);
                Console.WriteLine("Not2 : " + aList[i + 1]);
                Console.WriteLine("ToplamOgrenciSayisi : " + aList[i + 1]);
            }
        }

       
              

        

    }




    }


