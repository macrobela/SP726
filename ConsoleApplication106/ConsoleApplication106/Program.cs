﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ConsoleApplication106
{
    class Program
    { 
    
    static SqlConnection baglanti;
    static SqlCommand komut;
    static SqlDataReader reader;

       // public static string tarih { get; private set; }

        public  static void Listele()
    {
        int sayac = 0;
        Console.WriteLine("Sinif :");
        string sinif = Console.ReadLine();
        baglanti = new SqlConnection();
            baglanti.ConnectionString= @"Server=Localhost;Database=kutuphane;USER=sa;Password=1234";
            komut = new SqlCommand();
        komut.Connection = baglanti;
        komut.CommandText = "SELECT * FROM ogrenci WHERE sinif='" + sinif + "'";
        baglanti.Open();
        reader = komut.ExecuteReader();
        while (reader.Read())
        {
            sayac++;
            Console.WriteLine(reader[0] + ":" + reader[1] + " " + reader[2] + " " + reader[3]+ " "+reader[4]);

        }
        baglanti.Close();

        Console.WriteLine("Mevcut :" + sayac + " kişi.");
    }
        public static void Guncelle()
        {
            Console.WriteLine("Numara Girin");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adinizi Girin:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadını Girin:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Sınıfinizi Girin:");
            string sinif = Console.ReadLine();
            Console.WriteLine("Tarih Giriniz :");
            DateTime tarih = Convert.ToDateTime(Console.ReadLine());

            baglanti = new SqlConnection();
            baglanti.ConnectionString= @"Server=Localhost;Database=kutuphane;USER=sa;Password=1234";
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE ogrenci SET ograd='" + ad + "',ogrsoyad='" + soyad + "',sinif='" + sinif + "',tarih='" + tarih + "' WHERE ogrno=" + no.ToString();
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Güncellenmedi");
            }
        }
    public static void Ekle()
    {
        Console.WriteLine("Adinizi Girin:");
        string ad = Console.ReadLine();
        Console.WriteLine("Soyadinizi Girin:");
        string soyad = Console.ReadLine();
        Console.WriteLine("Sınıfinizi Girin:");
        string sinif = Console.ReadLine();
        Console.WriteLine("Tarih Griniz :");
        DateTime tarih = Convert.ToDateTime(Console.ReadLine());
            try
            {// Asagıdaki komut calıstırmayı dene
                //hata almazsan calıstır.
               
            }
            catch (Exception)//TYukarı hata varsa bu kısmı calıstır.
            {

                
            }




        baglanti = new SqlConnection();
       baglanti.ConnectionString=@"Server=Localhost;Database=kutuphane;USER=sa;Password=1234";
        komut = new SqlCommand();
        komut.Connection = baglanti;
        komut.CommandText = "INSERT INTO ogrenci (ograd,ogrsoyad,sinif,tarih) VALUES ('" + ad + "','" + soyad + "','" + sinif + "','"+tarih+"')";

        baglanti.Open();
        int sonuc = komut.ExecuteNonQuery();
        baglanti.Close();
        if (sonuc > 0)
        {
            Console.WriteLine("Eklendi");
        }
        else
        {
            Console.WriteLine("Eklenmedi");
        }

    }
    public static void Sil()
    {
        Console.WriteLine("Numara Giriniz :");
        int no = Convert.ToInt32(Console.ReadLine());

        baglanti = new SqlConnection();
        baglanti.ConnectionString = @"Server=Localhost;Database=kutuphane;USER=sa;Password=1234";
            komut = new SqlCommand();
        komut.Connection = baglanti;
        komut.CommandText = "DELETE FROM ogrenci WHERE ogrno=" + no + "";

        baglanti.Open();
        int sonuc = komut.ExecuteNonQuery();
        baglanti.Close();
        if (sonuc > 0)
        {
            Console.WriteLine("Silindi.");
        }
        else
        {
            Console.WriteLine("Silinmedi");
        }
    }
        static void Main(string[] args)
        {

            Console.WriteLine("1.Listele");
            Console.WriteLine("2.Ekle");
            Console.WriteLine("3.Güncelle");
            Console.WriteLine("4.Sil");
            Console.WriteLine("Seçiminiz:");
            string sec = Console.ReadLine();
            if (sec == "1")
            {
                Listele();
            }
            else if (sec == "2")
            {
                Ekle();
                Listele();
            }
            else if (sec == "3")
            {
                Guncelle();
                Listele();
            }
            else if (sec == "4")
            {
                Sil();
                Listele();
            }
            Console.ReadLine();
        }


    }
}
