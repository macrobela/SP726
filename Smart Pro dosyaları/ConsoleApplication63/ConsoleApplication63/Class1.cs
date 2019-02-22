using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Kurs
    {
        public int sınıf_no;
        public string ogretmen_Adi;
        public int kursiyerSayisi;
        private ArrayList kursiyer_bilgileri = new ArrayList();

        private void KursiyerKayit()
        {
            for (int i = 0; i < kursiyerSayisi; i++)
            {
                Console.WriteLine("Kursiyer Adi Giriniz:");
                string kursiyerAdi = Console.ReadLine();
                kursiyer_bilgileri.Add(kursiyerAdi);
            }
            kursiyer_Listele();
        }
        private void kursiyer_Listele()
        {
            for (int a = 0; a < kursiyer_bilgileri.Count; a++)
            {
                Console.WriteLine("Tüm kursiyerler :"+kursiyer_bilgileri[a]);
            }
        }
        public void KursAc()
        {
            Console.WriteLine("Sinif no giriniz :");
            sınıf_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ögretmen Adi Giriniz");
            ogretmen_Adi = Convert.ToString(Console.ReadLine());

            Console.WriteLine("kursiyer Sayisi");
            kursiyerSayisi = Convert.ToInt32(Console.ReadLine());

            KursiyerKayit();
        }
        
        


    }
}
