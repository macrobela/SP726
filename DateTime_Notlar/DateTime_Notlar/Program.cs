using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Notlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);

            DateTime tarihsaat = new DateTime();
            tarihsaat = DateTime.Now;

            Console.WriteLine("Ay : " + tarihsaat.Month);
            Console.WriteLine("Yıl : " + tarihsaat.Year);
            Console.WriteLine("Tarih : " + tarihsaat.Date);
            Console.WriteLine("Gün : " + tarihsaat.Day);

            Console.WriteLine("Haftanın Kaçıncı Günü : " + tarihsaat.DayOfWeek);
            Console.WriteLine("Yılın Kaçıncı Günü : " + tarihsaat.DayOfYear);
            Console.WriteLine("Günün Kaçıncı Saati : " + tarihsaat.TimeOfDay);
            Console.WriteLine();
            Console.WriteLine("Saat : " + tarihsaat.Hour);
            Console.WriteLine("Dakika : " + tarihsaat.Minute);
            Console.WriteLine("Saniye : " + tarihsaat.Second);
            Console.WriteLine("Milisaniye : " + tarihsaat.Millisecond);
            Console.WriteLine("Başlangıç tarihinden tutulan tarihe kadarki periyod sayısı : " + tarihsaat.Ticks);


            DateTime mddg = new DateTime(1988, 5, 5);
            DateTime bugun = DateTime.Now;

            TimeSpan gecenZaman = bugun - mddg;

            Console.WriteLine(gecenZaman.Days + " Gün");
            Console.WriteLine(mddg.DayOfWeek + " Doğduğunuz Gün");






            Console.ReadKey();



        }
    }
}
