﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication89
{
   class Bilgisayar
    {
        public string Marka;
        public string CPU;
        public string Ram;
        
        public Bilgisayar(string marka,string cpu,string ram)
        {
            this.Marka = marka;
            this.CPU = cpu;
            this.Ram = ram;
        }
        virtual public void OzellikGoster()
        {
            Console.WriteLine($"Marka\n : {Marka} İşlemci\n : {CPU} Ram\n : {Ram}");
        } 
    }
    class Dizustu:Bilgisayar
    {
        private static string cpu;
        private static string marka;
        private static string ram;
        public bool Bluetooth;
        public Dizustu(bool bluetooth, string marka, string cpu, string ram) :base(marka,cpu,ram)
        {
            this.Bluetooth = bluetooth;
        }
        public override void OzellikGoster()
        {
            Console.WriteLine("Marka : "+Marka);
            Console.WriteLine("İşlemci : "+CPU);
            Console.WriteLine("Ram Bilgisi : "+Ram);
            Console.WriteLine("Blutooth :"+Bluetooth);
        }
    }
    class Program
    {
        static void OzellikGoster(Dizustu be)
        {
            be.OzellikGoster();
        }
        static void Main(string[] args)
        {
            Dizustu diz = new Dizustu(true,"SHOW","CPU","512" );
            OzellikGoster(diz);
            Console.ReadKey();
        }
    }
}
