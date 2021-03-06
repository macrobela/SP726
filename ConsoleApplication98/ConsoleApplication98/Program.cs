﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication98
{
    class Program
    {

        interface ISesGoruntuSistemleri
        {
            string Marka { get; set; }
            int Fiyat { get; set; }
            int Puan { get; set; }
            int PuanToplami { get; set; }
            int PuanciToplami { get; set; }

            void PuanVer(byte puan);
        }

        interface ITelevizyon:ISesGoruntuSistemleri
        {
            string Cozunurluk { get; set;}
            byte EkranBoyutu { get; set; }
            bool UyduAlici { get; set; }
            void OzellikYazdır();
        }
        class Toshiba : ITelevizyon
        {
            //---------------------------------------------------------------
            //Burada bir şey tanımlamayacağiz.
            //Bir nesne olusturarak OzellikYazdir(); metodunu cagırınız;
            //---------------------------------------------------------------
            
            public string Cozunurluk { get; set; }
            public byte EkranBoyutu { get; set; }
            public int Fiyat { get; set; }
            public string Marka { get; set; }
            public int Puan { get; set; }
            public int PuanciToplami { get; set; }
            public int PuanToplami { get; set; }
            public bool UyduAlici { get; set; }

            public void OzellikYazdır()
            {
                Console.WriteLine("Marka :" + Marka);
                Console.WriteLine("Fiyat :" + Fiyat);
                Console.WriteLine("Cözünürlük :" + Cozunurluk);
                Console.WriteLine("EkranBoyutu :" + EkranBoyutu);
                Console.WriteLine("UyduAlici :" + UyduAlici);
            }


            public void PuanVer(byte puan)
            {
                Console.WriteLine("1 ila 5 arasında puan veriniz :");
                puan = Convert.ToByte(Console.ReadLine());
                if (puan==1)
                {
                    PuanToplami += 1;
                }
                else if (puan==2)
                {
                    PuanToplami += 2;
                }
                else if (puan==3)
                {
                    PuanToplami += 3;
                }
                else if (puan==4)
                {
                    PuanToplami += 4;
                }
                else if (Puan==5)
                {
                    PuanToplami += 5;
                } 
            }
            
            public void puangoster()
            {
                Console.WriteLine("Puan Toplami :"+PuanToplami);
            }

            //bool Bluetooth = true;
            //string strBluetooth = bluetooth? "Var" : "yok";  // if else yapmak yerine bu şekilde yapabiliriz.
            //private static bool bluetooth;
        }
        static void Main(string[] args)
        {
            byte puan=3;

            Toshiba ts = new Toshiba();
            ts.Marka = "Toshiba";
            ts.Fiyat = 2500;
            ts.Cozunurluk = "1024 768";
            ts.UyduAlici = false;
            ts.EkranBoyutu = 15;
            ts.UyduAlici = true;
            ts.OzellikYazdır();
            ts.PuanVer(puan);
            ts.puangoster();
            
            Console.ReadKey();
        }
    }
}
