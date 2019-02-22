using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleApplication105
{
    class PersonelListeleme
    {
        SqlConnection baglanti_OKUL_VT = new SqlConnection();
        baglanti_OKUL_VT.ConnectionString = @"Server=Localhost;Database=OKUL_VT;USER=sa;Password=1234";
        SqlCommand komut1 = new SqlCommand();
        komut1.CommandText = "SELECT * FROM Ogretmenler";
        komut1.Connection = baglanti_OKUL_VT;
        baglanti_OKUL_VT.Open();

            SqlDataReader dataReaderOgretmenler = komut1.ExecuteReader();
            while (dataReaderOgretmenler.Read())
            {
               string ogretmenID = dataReaderOgretmenler[0].ToString();
        string ogretmenAdi = dataReaderOgretmenler["OgretmenAdi"].ToString();
        Console.WriteLine($1ÖğretmenID'si {ogretmenID} ÖğretmenAdi {ogretmenAdi}");

            baglanti_OKUL_VT.Close();

    }

    class Program
    {

        static void Main(string[] args)
        {
            SqlConnection baglanti_Personel = new SqlConnection();
            baglanti_Personel.ConnectionString = @"Server=Localhost;Database=ogrenciler;USER=sa;Password=1234";
            {
                string PersonelAdi = "Elma";
                string PersonelSoyadi = "Tırrık";
                DateTime PersoneIIBT = DateTime.Now;
                SqlCommand komutInsert = new SqlCommand();
                komutInsert.CommandText = $"INSERT INTO Ogretmenler VALUES ('{PersonelAdi} {PersonelSoyadi} {PersoneIIBT},20')";
                komutInsert.Connection = baglanti_Personel;
                baglanti_Personel.Open();
                komutInsert.ExecuteNonQuery();
                baglanti_Personel.Close();
  
            }
            Console.ReadKey();



        }
    }
}
