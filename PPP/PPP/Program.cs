using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace P
{
    class Program
    {
        static int ID = 0;

        static void Main(string[] args)
        {
            int personelAdet = 0;
            string adSoyad;
            double netMaas;

            Console.WriteLine("#################### PERSONEL BİLGİ SİSTEMİNE HOŞ GELDİNİZ ####################");

            while (true)
            {
                Console.Write("KAÇ PERSONEL KAYDI GİRİLECEK : ");
                personelAdet = Convert.ToInt16(Console.ReadLine());
                if (personelAdet > 0)
                {
                    break;
                }
            }
            Personel p = new Personel();
            ArrayList pListe = new ArrayList();
            for (int i = 0; i < personelAdet; i++)
            {
                if (p == null)
                    p = new Personel();
                ////////////////////////////////
                ID++;
                Console.Write("Ad Soyad Giriniz :");
                adSoyad = Console.ReadLine();
                Console.Write("Net Maaş Giriniz :");
                netMaas = Convert.ToDouble(Console.ReadLine());
                ////////////////////////////////

                p.PersonelNetMaas = netMaas;

                if (pListe == null)
                    pListe = new ArrayList();
                pListe.Add(ID);
                pListe.Add(adSoyad.Split(' ')[0]);
                pListe.Add(adSoyad.Split(' ')[1].ToUpper());
                pListe.Add(netMaas);
                pListe.Add(p.BrutMaasHesapla());
            }

            p.YeniKayit(pListe);
            Console.WriteLine("################################################################################");
            p.KayitListele(p.getTumListe());
            Console.WriteLine("################################################################################");

            Console.ReadLine();
        }
    }
    class Personel
    {
        private int PersonelID { get; set; }
        private string PersonelAdi { get; set; }
        private string PersonelSoyadi { get; set; }
        public double PersonelNetMaas { get; set; }
        private double PersonelMaas { get; set; }

        public double BrutMaasHesapla()
        {
            return this.PersonelNetMaas + this.PersonelNetMaas * 0.60;
        }

        public double DoubleToplam(short a, short b, short c)
        {
            return Convert.ToDouble(a + b + c);
        }

        ArrayList TumList;

        public void YeniKayit(ArrayList AListPersonelBilgi)
        {
            TumList = AListPersonelBilgi;
        }

        public ArrayList getTumListe()
        {
            return TumList;
        }

        public void KayitListele(ArrayList AListPersonelBilgi)
        {

            Console.Write("Personel ID\t\t Personel Adı\t\t Personel BrütMaaş(TL)\n");
            int index = 0;
            for (int i = 0; i < TumList.Count / 5; i++)
            {
                Console.WriteLine(TumList[index + 0] + "\t\t\t " + TumList[index + 1] + " " + TumList[index + 2] + "\t\t " + TumList[index + 4]);
                index += 5;
            }
        }

    }



















}