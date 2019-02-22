using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication87
{
    class EgitimKurumu
    {
        public string KurumAdi;
        public string KurumAdresi;
        public KurumTipleri KurumTipi;
        private KurumTipleri kurumtipi;
        private KurumTipleri kurumtipi1;

        public EgitimKurumu(string kurumadi, string kurumadresi, KurumTipleri kurumtipi1)
        {
            KurumAdi = kurumadi;
            KurumAdresi = kurumadresi;
            this.kurumtipi1 = kurumtipi1;
        }

        public EgitimKurumu(string kurumadi, string kurumadresi, KurumTipleri kurumtipi)
        {
            KurumAdi = kurumadi;
            KurumAdresi = kurumadresi;
            this.kurumtipi = kurumtipi;
        }

        public EgitimKurumu(string kurumadi, string kurumadresi, KurumTipleri kurumtipi)
        {
            KurumAdi = kurumadi;
            KurumAdresi = kurumadresi;
            KurumTipi = kurumtipi;
        }

    }
    class OzelKurs : EgitimKurumu
    {
        public string OzelKursSahibi;
        public OzelKursAlanlari OzelKursAlani;

        ArrayList EgitmenListesi = new ArrayList();

        public OzelKurs(string ozelkurssahibi, OzelKursAlanlari ozelkursalani, string kurumadi, string kurumadresi, KurumTipleri kurumtipi) : base(kurumadi, kurumadresi, kurumtipi)
        {
            OzelKursSahibi = ozelkurssahibi;
            OzelKursAlani = ozelkursalani;
            EgitmenEkle();
        }

        public void EgitmenEkle()
        {
            Console.Write("Eğitmen Sayısını Giriniz: ");
            int egitmenAdedi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= egitmenAdedi; i++)
            {
                Console.WriteLine(i + ". Eğitmenin TC Kimlik Numarası Giriniz: ");
                double tcNo = double.Parse(Console.ReadLine());
                EgitmenListesi.Add(tcNo);
                Console.WriteLine(i + ". Eğitmenin Ad ve Soyad Giriniz: ");
                string adSoy = Console.ReadLine();
                EgitmenListesi.Add(adSoy);
            }
            EgitmenListele();
        }
        public void EgitmenListele()
        {
            Console.WriteLine();
            Console.WriteLine("TC Kimlik Numarası".PadRight(30) + "Adı ve Soyadı");
            for (int i = 0; i < EgitmenListesi.Count; i += 2)
            {
                Console.Write(EgitmenListesi[i].ToString().PadRight(30));
                Console.WriteLine(EgitmenListesi[i + 1]);
            }
        }

        public string EgitmenBul(double tckimlik)
        {
            for (int i = 0; i < EgitmenListesi.Count; i += 2)
            {
                double kontrol = Convert.ToDouble(EgitmenListesi[i]);
                if (tckimlik == kontrol)
                {
                    return EgitmenListesi[i + 1].ToString();
                }
            }
            return "";
        }

        enum KurumTipleri : byte { Devlet, Özel, Vakıf }
        enum OzelKursAlanlari : byte { Yazılım, Muhasebe, YabancıDil, Ehliyet, Yüzme }


        class Program
    {
            static void Main(string[] args)
            {
                //Soru
                //SınıfAdı: EgitimKurumu
                //-----------------------
                //KurumAdi,
                //KurumAdresi,
                //KurumTipi, (enum:(Devlet, Ozel, Vakif)
                //Yapıcı metot 3 bilgiyi kaydedecek
                //
                //SınıfAdı: OzelKurs:EgitimKurumu
                //-------------------------------
                //OzelKursSahibi,
                //OzelKursAlani,    (enum:(Yazılım, Muhasebe, YabancıDil, Ehliyet, Yüzme)
                //ArrayList EgitmenListesi,
                //
                //Yapıcı metot 2+3 parametre alacak. İçinde EgitmenEkle() çağırılacak.
                //
                //public void EgitmenEkle(): Eğitmen sayısı kadar => TC Kimlik, Adı ve Soyad => EgitmenListesi
                //public void EgitmenListele(): Yukarıdaki bilgileri listelesin.
                //
                //public string EgitmenBul(int tckimlik): tc kimlik numarası verilen eğitmenin
                //                                          Ad ve Soyadını ekrana yazdıracak.
                //
                //Main: =>
                //OzelKurs SmartPro = new OzelKurs("Ahmet BÜYÜK",KursAlanlari.Yazılım,"SmartPro","Kadıköy",KurumTipleri.Ozel);

                Console.WriteLine("Kurs Sahibinin Adını Soyadını Giriniz: ");
                string sahip = Console.ReadLine();

                Console.WriteLine("Yazılım \nMuhasebe \nYabancıDil \nEhliyet \nYüzme");
                Console.WriteLine("Kurs Alanlarından Birini Giriniz: ");
                string kursAlani = Console.ReadLine();
                OzelKursAlanlari secim;
                for (;;)
                {
                    if (kursAlani.ToUpper() == OzelKursAlanlari.Yazılım.ToString().ToUpper() || kursAlani.ToUpper() == "yazilim".ToUpper() || kursAlani.ToUpper() == "yazılim".ToUpper() || kursAlani.ToUpper() == "yazilım".ToUpper())
                    {
                        secim = OzelKursAlanlari.Yazılım;
                        break;
                    }
                    else if (kursAlani.ToUpper() == OzelKursAlanlari.Muhasebe.ToString().ToUpper())
                    {
                        secim = OzelKursAlanlari.Muhasebe;
                        break;
                    }
                    else if (kursAlani.ToUpper() == OzelKursAlanlari.YabancıDil.ToString().ToUpper() || kursAlani.ToUpper() == "yabancı dil".ToUpper() || kursAlani.ToUpper() == "yabanci dil".ToUpper() || kursAlani.ToUpper() == "yabancidil".ToUpper())
                    {
                        secim = OzelKursAlanlari.YabancıDil;
                        break;
                    }
                    else if (kursAlani.ToUpper() == OzelKursAlanlari.Ehliyet.ToString().ToUpper())
                    {
                        secim = OzelKursAlanlari.Ehliyet;
                        break;
                    }
                    else if (kursAlani.ToUpper() == OzelKursAlanlari.Yüzme.ToString().ToUpper() || kursAlani.ToUpper() == "yuzme".ToUpper())
                    {
                        secim = OzelKursAlanlari.Yüzme;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış giriş yaptınız. Tekrar Deneyiniz: ");
                        kursAlani = Console.ReadLine();
                    }
                }

                Console.WriteLine("Kurum adını giriniz: ");
                string kurumAd = Console.ReadLine();

                Console.WriteLine("Kurum adresini giriniz: ");
                string kurAdres = Console.ReadLine();

                Console.WriteLine("Devlet \nÖzel \nVakıf");
                Console.WriteLine("Kurum Tiplerinden Birini Giriniz: ");
                string kurumTipi = Console.ReadLine();
                KurumTipleri tercih;

                for (;;)
                {
                    if (kurumTipi.ToUpper() == KurumTipleri.Devlet.ToString().ToUpper())
                    {
                        tercih = KurumTipleri.Devlet;
                        break;
                    }
                    else if (kurumTipi.ToUpper() == KurumTipleri.Özel.ToString().ToUpper() || kurumTipi.ToUpper() == "ozel".ToUpper())
                    {
                        tercih = KurumTipleri.Özel;
                        break;
                    }
                    else if (kurumTipi.ToUpper() == KurumTipleri.Vakıf.ToString().ToUpper() || kurumTipi.ToUpper() == "vakif".ToUpper())
                    {
                        tercih = KurumTipleri.Vakıf;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış giriş yaptınız. Tekrar Deneyiniz: ");
                        kurumTipi = Console.ReadLine();
                    }
                }

                OzelKurs SmartPro = new OzelKurs(sahip, secim, kurumAd, kurAdres, tercih);

                Console.WriteLine();
                Console.WriteLine("Kurs Sahibinin Adı: ".PadRight(30) + SmartPro.OzelKursSahibi);
                Console.WriteLine("Kurs Alanının Adı: ".PadRight(30) + SmartPro.OzelKursAlani);
                Console.WriteLine("Kurum Adı: ".PadRight(30) + SmartPro.KurumAdi);
                Console.WriteLine("Kurum Adresi: ".PadRight(30) + SmartPro.KurumAdresi);
                Console.WriteLine("Kurum Tipi: ".PadRight(30) + SmartPro.KurumTipi);

                Console.WriteLine("\nBulunacak Eğitmenin TC Kimlik Numarasını Giriniz: ");
                double bulTc = double.Parse(Console.ReadLine());
                Console.WriteLine("Eğitmen Adı: ");
                string egitmen = SmartPro.EgitmenBul(bulTc);
                Console.WriteLine(egitmen);

                Console.ReadKey();



            }   }
    }
}
