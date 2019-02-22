using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class Ogretmen
    {
        public string OgretmenAdiSoyadi;
        public string OgretmenYasi;

        public Sinif _yasBilgisi;

        public Ogretmen()
        {
            _yasBilgisi = new Sinif();
        }



        // Yukarıdaki nesne tanımlama sayesinde
        // YasBilgisi sınıfının üyelerine bu sınıf nesnesi aracılığı ile değer atayabiliriz.
        // Metotlarını kullanılabiliriz.

        public void BilgiYazdir()
        {
            Console.WriteLine(OgretmenAdiSoyadi + "\n"+OgretmenYasi);
           
        }
    }
    class Sinif
    {
        public int SinifAdi;
        public int DerslikNumarasi;
        public int SinifProgramı;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen kb1 = new Ogretmen();
            kb1.OgretmenAdiSoyadi ="ÖgretmenAdi ve Soyadi: Mehmet Demir";
            kb1.OgretmenYasi = " Ögretmen Yaşı : 30";
            
            kb1._yasBilgisi.SinifAdi = 723726;

            kb1.BilgiYazdir();
            Console.WriteLine("Derslik Numarası :"+ (kb1._yasBilgisi.SinifAdi));
            

           
            Console.ReadKey();
        }
    }
}
