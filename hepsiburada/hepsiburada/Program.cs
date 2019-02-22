using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace hepsiburada
{

    class Toshiba
    {
        static SqlConnection baglanti;
        static SqlCommand komut;
        static SqlDataReader reader;

        public  void Markalar()
        {
            int sayac = 0;
            Console.WriteLine("Marka :");
            string markaadi = Console.ReadLine();
            baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=Localhost;Database=markaa;user=sa;password=1234";
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Markalar where MarkaAdi='" + markaadi + "'";
            baglanti.Open();
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                sayac++;
                Console.WriteLine(reader[0]);
            }
            baglanti.Close();

            Console.WriteLine("Mevcut :"+sayac+ "kişi."); 
        }

        public  void UrunEkle()
        {
            Console.WriteLine("Ürün Adi Giriniz :");
            string ad = Console.ReadLine();
            Console.WriteLine("Urun Marka Giriniz :");
            string marka = Console.ReadLine();
            Console.WriteLine("Cözünürlük Giriniz :");
            string cozunurluk = Console.ReadLine();
            Console.WriteLine("Ekran Boyutu Giriniz :");
            string ekranboyutu = Console.ReadLine();
            Console.WriteLine("Uydu Alici Giriniz :");
            string uyduAlici = Console.ReadLine();

            baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=Localhost;Database=markaa;user=sa;password=1234";
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO Urun(urunadi,urunmarka,cozunurluk,ekranboyutu,uydualici) values ('" + ad + "','" + marka + "','" + cozunurluk + "','" + ekranboyutu + "','" + uyduAlici + "')";

            baglanti.Open();
           // komut.ExecuteNonQuery();
            baglanti.Close();
           
            
        }


        public void Güncelle()
        {
            Console.WriteLine("Urun Adi Girin");
            int urunad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cozunurluk girin");
            string cozunurluk = Console.ReadLine();

            baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=Localhost;Database=markaa;user=sa;password=1234";
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update  urun set urunad='"+urunad+"','"+cozunurluk+"'";
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();



        }






    }
    class Program
    {
        static void Main(string[] args)
        {
            Toshiba t = new Toshiba();

            t.Güncelle();
            

            Console.ReadKey();
        }
    }
}
