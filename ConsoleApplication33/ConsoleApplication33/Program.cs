using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rastgele = new Random();

            //int[] sayi = new int[3];
            //int[,] sayi1 = new int[3,2];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int k = 0; k <2; k++)
            //    {
            //         int rsayi = rastgele.Next(10,20);


            //        sayi1[0, 0] = rastgele.Next(10, 20);
            //        sayi1[0, 1] = rastgele.Next(10, 20);
            //        sayi1[0, 2] = rastgele.Next(10, 20);
            //        sayi1[1, 0] = rastgele.Next(10, 20);
            //        sayi1[1, 1] = rastgele.Next(10, 20);
            //        sayi1[1, 2] = rastgele.Next(10, 20);

            //        Console.WriteLine(sayi1[i, k]);

            //    }

            //}



            //-------------------------------------------------------------------------------------------

            //int toplam = 0;

            //int[,] dizi1 = new int[3, 2];

            //Random rastgele = new Random();

            //int rsayi = rastgele.Next(10, 20);




            //dizi1[0, 0] = rastgele.Next(10, 20);
            //dizi1[0, 1] = rastgele.Next(10, 20);
            //dizi1[1, 0] = rastgele.Next(10, 20);
            //dizi1[1, 1] = rastgele.Next(10, 20);
            //dizi1[2, 0] = rastgele.Next(10, 20);
            //dizi1[2, 1] = rastgele.Next(10, 20);


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        dizi1[i, j] = rastgele.Next(10, 20);

            //        Console.Write(" {0} ",dizi1[i,j]);
            //        if (i==1)
            //        {
            //            toplam = toplam + dizi1[i, j];

            //        }
            //    }

            //    Console.WriteLine();

            //}
            //Console.Write("Toplamları :" + toplam);
            //Console.Read();
















            // Klavyeden 3 adet tam sayı istiyoruz. Sırası X Y Z Her bir eleman 10 ile 90 arası deger aklacak (random).
            //Tablo alarak yazdıralacak Tablonun sol sutundaki  ilk sayıların toplamı ekrana yazdıralacak.


            //int toplam = 0;

            //int X, Y, Z;

            //Console.WriteLine("Sayi Giriniz :");
            //X = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Sayi Giriniz :");
            //Y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Sayi Giriniz :");
            //Z = Convert.ToInt32(Console.ReadLine());


            //int[,,] dizi1 = new int[X, Y, Z];

            //Random rastgele = new Random();



            //for (int i = 0; i < X; i++)
            //{
            //    Console.Write("[");
            //    for (int j = 0; j < Y; j++)
            //    {
            //        Console.Write("(");

            //        for (int l = 0; l < Z; l++)
            //        {
            //            int rsayi = rastgele.Next(10, 90);
            //            dizi1[i, j, l] = rsayi;

            //            Console.Write(" {0} ", dizi1[i, j, l]);


            //            if (j == 0)
            //            {
            //                if (l==0)
            //                {
            //                    toplam = toplam + rsayi;
            //                    //toplam = toplam + dizi1[i, j, l];
            //                }
            //            }
            //        }
            //        Console.Write(")");
            //    }
            //    Console.Write("]");
            //    Console.WriteLine();
            //}
            //Console.Write("Toplamları :" + toplam);


            //Console.Read();

            //object[,] dizi = new object[2, 2];

            //dizi[0, 0] = 5;
            //dizi[0, 1] = "SmratPro";
            //dizi[1, 0] = 'f';
            //dizi[1, 1] = 14F;
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine();

            //}


            //Sinif mevcudu kullanıcıdan işte Her bir ögrenci için: Ögrenci  No(int) Adı(string) No(int)  Not Karşılığı(string)

            int x;
            Console.Write("Sinif mevcudu :");
            x = Convert.ToInt32(Console.ReadLine());

            object[,] sinif = new object[x, 3];


            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < 3; k++)
                {

                    if (k == 0)
                    {
                        Console.WriteLine("İsim Giriniz :");
                        sinif[i, k] = Console.ReadLine();
                    }
                    if (k == 1)
                    {
                        Console.WriteLine("Notunu Giriniz :");
                        sinif[i, k] = Convert.ToInt32(Console.ReadLine());
                    }
                    if (k == 2)
                    {

                        if ((int)(sinif[i, (k - 1)]) >= 0 && (int)(sinif[i, (k - 1)]) < 30)
                            sinif[i, k] = "Cok Zayıf";

                        if ((int)(sinif[i, (k - 1)]) >= 30 && (int)(sinif[i, (k - 1)]) < 55)
                            sinif[i, k] = " Zayıf";

                        if ((int)(sinif[i, (k - 1)]) >= 55 && (int)(sinif[i, (k - 1)]) < 70)
                            sinif[i, k] = " Orta";

                        if ((int)(sinif[i, (k - 1)]) >= 70 && (int)(sinif[i, (k - 1)]) < 85)
                            sinif[i, k] = " İyi";

                        if ((int)(sinif[i, (k - 1)]) >= 85 && (int)(sinif[i, (k - 1)]) < 100)
                            sinif[i, k] = " Pekİyi";

                    }

                }
            
                foreach (var item in sinif)
                {
                    Console.Write($"{item} ");
                }
                Console.Read();
                
            }

        }
    }
}
