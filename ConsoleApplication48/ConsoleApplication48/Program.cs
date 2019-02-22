using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {

            //string str1 = "Z";  // Tersine karsılastırma
            //string str2 = "A";  // Tersine karsılastırma
            //string str3 = string.Concat(str1, str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(String.Compare(str1, str2));
            ////Alfabetirk sıralamaya karsılastırma
            //Console.WriteLine(String.Compare(str1, str2, true));
            ////büyük kücük eşit
            //str1 = "SmartPro";

            //Console.WriteLine(str1.IndexOf("r"));
            //Console.WriteLine(str1.LastIndexOf("r"));
            //Console.WriteLine("---------------------");
            //Console.WriteLine(str1.StartsWith("P"));
            //Console.WriteLine(str1.StartsWith("S")); //true
            //Console.WriteLine(str1.StartsWith("P"));  //false
            //Console.WriteLine(str1.EndsWith("o"));  //false



            //string str4 = " SmartPro ";
            //Console.WriteLine(str4);
            //Console.WriteLine(str4.Trim());
            ////Boşlukları Sil
            //char[] cDizi = { '0', 'p', 'r' };
            //Console.WriteLine(str4.Trim(cDizi));


            ////Dizide belirtilen elemanları veyaz başta varsa budanır.

            //string str6 = "PRO";
            //Console.WriteLine(str6.PadLeft(5));
            //Console.WriteLine(str6.PadLeft(5,'F'));
            //Console.WriteLine(str6.PadRight(5, 'F'));
            //// sola saga boşluk veyaz karekter ekleme  ( var olan harfler de sayilır.)


            //string str7 = "Merhaba Süleyman Ayse Sevgi,Serdar,Sezgin";
            //Console.WriteLine(str7);
            //String[] strDizi = str7.Split(' ');
            //foreach (var item in strDizi)
            //{
            //    item.Trim();
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------");
            //string strJoined = string.Join("S", strDizi);
            //Console.WriteLine(strJoined);









            //Klavyeden girilen tek cümleyi; Basındaki ve sonundaki boşlukları sil.
            //Kelime kelime diziye ata.
            //Daha sonra bu elemnaları araya virgül koyarak birleştir...



            Console.WriteLine("Cümle Giriniz");
            string cc = Convert.ToString(Console.ReadLine());

            

            Console.WriteLine("Soldaki boşlukları sil=" + cc.TrimStart());
            Console.WriteLine("Sağdaki boşlukları sil=" + cc.TrimEnd());
            Console.WriteLine("Sağ ve Sol boşlukları sil=" + cc.Trim());


            string temiz = "";
            int uzunluk = cc.Length;
            for (int i = 0; i <= uzunluk - 1; i++)
            {
                if (cc.Substring(i, 1) != " ")
                {
                    temiz += cc.Substring(i, 1);
                }
            }
            Console.WriteLine("Tüm Boşlukların temizi=" + temiz);
            Console.ReadKey();


            //cc = string.Concat();


            //string a = "Yönetim";
            //string b = "Bilişim";
            //string c = "Sistemleri";
            //string d = string.Concat(a, b, c);
            //Console.WriteLine(d);






























            Console.ReadKey();



        }
    }
}
