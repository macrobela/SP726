using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication101
{
    class Program
    {
        static void Main(string[] args)
        {
            string DosyaYolu = " C:\\SULEYMAN\\SULOFileIO.txt";
            FileStream fs = new FileStream(DosyaYolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            string adgir;
            string tcgir;

            while (true)
            {
                Console.WriteLine("Ögrenci Adi Giriniz :");
                adgir = Console.ReadLine();

                Console.WriteLine("Tc Kimlik No Giriniz :");
                tcgir = Convert.ToString(Console.ReadLine());

                if (adgir.ToLower()=="kapat" || tcgir.ToLower()=="kapat")
                {
                    break;
                }
                sw.WriteLine($"Ögrenci Adi :{adgir} Tc kimlik no : {tcgir}");
            }
            sw.Flush();
            sw.Close();

            Console.ReadKey();


            































            ////FileStream  StreamWriter
            //string DosyaYolu=" C:\\SULEYMAN\\SULOFileIO.txt";
            //FileStream fs = new FileStream(DosyaYolu,FileMode.Append,FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs,Encoding.Default);
            ////TRUNCATE DOSYADAKİLERİ SİLER YAZILAN DEGERİN YENİLERİNİ YAZAR.
            //while (true)
            //{
            //    Console.WriteLine("Yazi Giriniz :");
            //    string yazi = Console.ReadLine();
            //    if (yazi.ToLower()=="q")
            //    {
            //        break;             
            //    }
            //    sw.WriteLine(yazi);
            //}
            //sw.WriteLine("Merhaba C#");
            //sw.WriteLine("Fenerbahçe");
            //sw.WriteLine("Sarıyer");
            //sw.Flush();//BELLEKTEKİ VERİYİ DOSYAYA YAZ
            //sw.Close();//STREAMWRİTER I KAPAT
            //sw.Flush();//BELLEKTEKİ VERİYİ DOSYAYA YAZ
            //sw.Close();//STREAMWRİTER I KAPAT
            //Console.ReadKey();


























            ////FileStream

            //string DosyaYolu = "C:\\SULEYMAN\\SULOFileIO.txt";
            //FileStream fsa = new FileStream(DosyaYolu, FileMode.Open);
            //StreamReader sr = new StreamReader(fsa, Encoding.GetEncoding("windows-1254"));
            //string satir;
            //int i = 1;
            //while ((satir = sr.ReadLine()) != null)  //Dosyadaki bilgileri satır satır oku.
            //{
            //    Console.WriteLine($"Satir {i} :" + satir);
            //}
            //fsa.Close();

            //Console.ReadLine();









            //string dosyaYolu = "C:\\FileIO\\FileIO.txt";
            //string DestDosyaYolu = "C:\\SULEYMAN\\SULOFileIO.txt";
            //Console.WriteLine(File.Exists(dosyaYolu));
            //File.Move(dosyaYolu, DestDosyaYolu);

            //Console.WriteLine(File.GetAttributes(DestDosyaYolu));
            ////File.SetAttributes(DestDosyaYolu,fileAttributes.Hidden);
            //Console.WriteLine(File.GetAttributes(DestDosyaYolu));
            Console.ReadKey();





            


            //DateTime bg3 = DateTime.Now;
            //string BMW = bg3.ToShortDateString();
            //BMW = BMW.Replace(".","_");
            //string dosyaYolu = @"C:\" + BMW;
            //bool klasorVarmi = Directory.Exists(dosyaYolu);
            //if (klasorVarmi == false)
            //Directory.CreateDirectory(dosyaYolu);

            //string [] dosyayeri = Directory.GetDirectories(Directory.GetDirectoryRoot(dosyaYolu));
            ////Console.WriteLine(Directory.GetCurrentDirectory(dosyaYolu));
            //foreach (var item in dosyayeri)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(dosyaYolu);

         

            









            //string klasorAdi2 = @"C:\22_01_2019";   
            //Console.WriteLine(Directory.GetCurrentDirectory());  
            //Directory.CreateDirectory(klasorAdi2);

            //Console.WriteLine(Directory.GetCreationTime(klasorAdi2));
            //bool klasorVarmi2 = Directory.Exists(klasorAdi2);
            //if (klasorVarmi2)
            //{
            //    Console.WriteLine("Klasör Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Klasör Yok");
            //    Directory.CreateDirectory(klasorAdi2);
            //    Console.Write("Klasör  Oluşturuldu.");

            //}
            //Console.ReadKey();




















            //string klasorAdi = "ProjeDosyalari"; /// yeni klasörün adi:
            //string klasorAdi2 = @"D:\FiloIO";   // yeni olusturulan klasörün gidecegi adres
            //Console.WriteLine(Directory.GetCurrentDirectory());  //bilgisayardaki konumunu gösterir.
            //Directory.CreateDirectory(klasorAdi); // clasör olusturur.
            //Directory.CreateDirectory(klasorAdi2);// clasör2 olusturur.

            //Console.WriteLine(Directory.GetCreationTime(klasorAdi2));  // ne zaman klasör olusturuldugunu gösterir.
            //Directory.Delete(klasorAdi2, true); //olusturulan klasör'u siler.
            //bool klasorVarmi = Directory.Exists(klasorAdi2);
            //if (klasorVarmi)
            //{
            //    Console.WriteLine("Klasör Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Klasör Yok");
            //    Directory.CreateDirectory(klasorAdi2);
            //    Console.Write("Klasör  Oluşturuldu.");

            //}
            //Console.ReadKey();






            //string dosyaYolu = @"C:\FiloIO";
            //Directory.CreateDirectory(dosyaYolu);

            //Console.WriteLine(Directory.GetDirectoryRoot(dosyaYolu)); //C:\

            //Console.WriteLine(Directory.GetLastAccessTime(dosyaYolu));
            //Console.WriteLine(Directory.GetLastWriteTime(dosyaYolu));


            //string[] logicaşDrive = Directory.GetLogicalDrives();
            //foreach (var item in logicaşDrive)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()));
            //Get parant bir üst klasörü döndürür.

            //string KaynakDosyaYolu = @"C:\FiloIO";
            //string hedefDosyaYolu = @"C:\SÜLEYMAN\FiloIO";
            //Directory.Move(KaynakDosyaYolu, hedefDosyaYolu);



            //string dosyaYolu = @"C:\Süleyman\FileIO";

            //DateTime simdi = new DateTime();
            ////Directory.SetLastAccessTime(dosyaYolu, simdi);
            ////Directory.SetLastWriteTime(dosyaYolu, simdi);
            //Directory.SetCreationTime(dosyaYolu, simdi);



            //Console.WriteLine(Directory.GetLastAccessTime(dosyaYolu));
            //Console.WriteLine(Directory.GetCreationTime(dosyaYolu));
            //Console.WriteLine(Directory.GetLastWriteTime(dosyaYolu));


            //Console.WriteLine(Directory.GetCurrentDirectory());
            //string orjinalYol = @"C:\Users\suleyman.avsar\Desktop\console.uygulama\ConsoleApplication101\ConsoleApplication101\bin\Debug";
            //string yeniYol = @"C:\Süleyman";
            //Directory.SetCurrentDirectory(yeniYol);
            //Console.WriteLine(Directory.GetCurrentDirectory());


           

           
            


















        }
    }
}
