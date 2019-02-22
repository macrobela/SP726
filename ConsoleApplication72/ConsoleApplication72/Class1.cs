﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication72
{
    class Araba
    {
        public double Fiyat;
        public double Motorhacmi;
        public string Plaka;
        public double OTV;
        public void aracekle(ArrayList aList)
        {
                Console.WriteLine("fiyatı");
                Fiyat = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("hacmi :");
                Motorhacmi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("plaka");
                Plaka = Console.ReadLine();

                aList.Add(Plaka);
                aList.Add(Fiyat);
                OTV = otvhesapla(Fiyat, Motorhacmi);
                aList.Add(OTV);
        }
        public double otvhesapla(double fiyat, double hacmi)
        {
            if (Motorhacmi > 1600 && fiyat <70)
            {
                OTV= this.Fiyat * 0.35;
            }
            else if (Motorhacmi > 1600 && fiyat <120)
            {
                OTV = this.Fiyat * 0.60;
            }
            else if (Motorhacmi > 2000 && fiyat <160)
            {
                OTV = this.Fiyat * 0.100;
            }
            else if (Motorhacmi > 2500 && fiyat <170)
            {
                OTV = this.Fiyat * 0.160;
            }
            return OTV;
        }
         static public void AracListeleme(ArrayList aList)
        {
            Console.WriteLine(aList[0]+"  "+aList[1]+"  "+aList[2]);
        }

        
    }
    
}