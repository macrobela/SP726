using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleApplication107
{

    class Personel
    {
        short PersonelID;
        string PersonelAdi;
        string PersonelSoyadi;
        DateTime PersoneliBT;
        public SqlConnection baglanti;

        public Personel()
        {
            baglanti = new SqlConnection(@"server=localhost;database=PERSONEL_VT;user=sa;password=1234");
        }

        public void PersonelEkle()
        {
            Console.WriteLine("Personel Adi: ");
            this.PersonelAdi = Console.ReadLine();
            Console.WriteLine("Personel Soyadi :");
            this.PersonelSoyadi = Console.ReadLine();
            Console.WriteLine("Personel İse Baslama Tarihi :");

            try
            {
                this.PersoneliBT = Convert.ToDateTime(DateTime.Now);
                Console.WriteLine("TRY Blogu Doğru Çalıştı.");
            }
            catch (Exception)
            {
                this.PersoneliBT = DateTime.Now;
                Console.WriteLine("CATCH Blogu Hatalı Çalıştı.");
            }
            SqlCommand komutekle = new SqlCommand();
            komutekle.CommandText = "INSERT INTO Personel(PersonelAdi,PersonelSoyadi,PersoneliBT) values ('" + this.PersonelAdi + "','" + this.PersonelSoyadi + "','" + PersoneliBT + "')";
            komutekle.Connection = baglanti;

            baglanti.Open();
            int eklenenSatir = komutekle.ExecuteNonQuery();
            if (eklenenSatir > 0)
            {
                Console.WriteLine("Veri Tabanına kayit işlemi Basarılı!");
                Console.WriteLine(eklenenSatir);
            }
            else
            {
                Console.WriteLine("Veri Tabanına Kayitta Sorun olustu.!!!");
            }
            baglanti.Close();
        }

        public void PersonelListele()
        {
            SqlCommand komutListele = new SqlCommand("Select * from Personel");
            komutListele.Connection = baglanti;
            baglanti.Open();
            SqlDataReader dataRListele = komutListele.ExecuteReader();
            while (dataRListele.Read())
            {
                Console.WriteLine("\t \t " + dataRListele[0] + " " + dataRListele[1] + " " + dataRListele[2] + " " + dataRListele["PersoneliBT"]);
            }
            baglanti.Close();
        }


        public void PersonelSil()
        {
            Console.WriteLine("Silinecek perosnel ID'sini Giriniz :");
            short silinenID = Convert.ToInt16(Console.ReadLine());

            SqlCommand komutSil = new SqlCommand("delete from Personel where PersonelID=" + silinenID);
            komutSil.Connection = baglanti;

            baglanti.Open();
            int etkilenenSatir = komutSil.ExecuteNonQuery();
            if (etkilenenSatir > 0)
            {
                Console.WriteLine("Silme İşlemi Basarili");
            }
            else
            {
                Console.WriteLine("Sime işlemi Sırasında bir hata olustu.!!!");
            }
            baglanti.Close();
        }

        public void Guncelle()
        {
            Console.WriteLine("Güncellenecek personel ID'sini Giriniz :");
            short GuncelleID = Convert.ToInt16(Console.ReadLine());
            string PersonelAdi = Console.ReadLine();
            SqlCommand komutGuncelle = new SqlCommand("Update Personel set PersonelAdi='" + PersonelAdi + "' where PersonelID=" + GuncelleID);
            komutGuncelle.Connection = baglanti;

            baglanti.Open();
            int etkilenenSatir = komutGuncelle.ExecuteNonQuery();
            if (etkilenenSatir > 0)
            {
                Console.WriteLine("Güncelle İşlemi Basarili");
            }
            else
            {
                Console.WriteLine("Güncelle işlemi sırasında bir hata olustu !!!");
            }
            baglanti.Close();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            p1.PersonelEkle();
            p1.PersonelListele();
            p1.PersonelSil();
            p1.Guncelle();


            Console.ReadKey();

        }
    }
}
