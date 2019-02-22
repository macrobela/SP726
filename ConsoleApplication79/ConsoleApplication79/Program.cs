using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication79
{
    enum Marka :byte { Honda,Mazda,Ford,Mercedes,Renault,Toyota,Tofaş,Lamborghini,Ferrari,Scania,Volvo}
    enum Vites : byte { Manuel,Otomatik,Yarı_Otomatik}
    enum Renk : byte { Kırmızı,Beyaz,Siyah,Turuncu,Yeşil,Mav,Mor}

    class Arac
    {
        public string Marka;
        public string Vites;
        public string Renk;
        protected  char MotorHacmi;
    }


    class Otomobil
    {
        public Enum KapiSayisi;
        public Enum Model;
        public Enum Ceker4;
        public Enum ParkSesorü;

        public void OtomabilYaz()
        {

        }
    }
    class Ticari
    {
        public Enum TasimaKapasitesi;
        public Enum Ceker4;
        public Enum YolcuKapasitesi;
    }




    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
