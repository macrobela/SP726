using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODEV3_IS.Entity;

namespace ODEV3_IS.Facade
{
     public static class Ogrenci_VTI
     {

          //public static SqlConnection baglanti = new SqlConnection("SERVER=localhost;DATABASE=ODEV3;USER=sa;PWD=1234");
          //App.Config SqlConnection tanımlaması yaptık. Üstteki satıra gerek kalmadı.

          public static int Insert(Ogrenci ogr)
          {
               SqlCommand komut = new SqlCommand("SP_OgrenciKaydet",Genelislemler.Baglanti);
               // Genelislemler.Baglanti özelliği Genelislemler.cs sınıfında tanımlandı. App.Config dosyasındaki SqlConnection ı kullandık.
               komut.CommandType = CommandType.StoredProcedure;
               // Komut tipinin Stored Procedure olduğunu belirtmek zorundayız. Update,select.. gibi temel komutlarda tip belirtmiyoruz.
               komut.Parameters.AddWithValue("@OgrenciNumara",ogr.OgrenciNumara);
               komut.Parameters.AddWithValue("@OgrenciAdSoyad",ogr.OgrenciAdSoyad);
               komut.Parameters.AddWithValue("@OgrenciBolum",ogr.OgrenciBolum);
               komut.Parameters.AddWithValue("@OgrenciFakulte",ogr.OgrenciFakulte);
               // @ile başlayan ifadeler  Bunlar Stored procedure'deki değişkenlerdir. Aynı olmak zorundadırlar.
               return Genelislemler.KomutCalistir(komut);
               // Genelislemler.KomutCalistir metodundan dönen int değeri bu metodun çağırıldığı yere döndürür.
          }
          public static DataTable OgrenciListele()
          {
               // Bu metod veri tabanından tabloyu çeker ve çektiği tabloyu DataTable olarak döndürür.
               SqlDataAdapter adp = new SqlDataAdapter("SP_Ogrenci_Listele", Genelislemler.Baglanti);
               adp.SelectCommand.CommandType = CommandType.StoredProcedure;
               DataTable ogrenciTablosu = new DataTable();
               adp.Fill(ogrenciTablosu);
               return ogrenciTablosu;
          }
          public static int OgrenciGuncelle(Ogrenci ogr)
          {
               // Gelen öğrenci nesnesine ait bilgileri vt'de günceller.
               SqlCommand komut = new SqlCommand("SP_OgrenciGuncelle", Genelislemler.Baglanti);
               komut.CommandType = CommandType.StoredProcedure;
               komut.Parameters.AddWithValue("@OgrenciNumara", ogr.OgrenciNumara);
               komut.Parameters.AddWithValue("@OgrenciAdSoyad",ogr.OgrenciAdSoyad);
               komut.Parameters.AddWithValue("@OgrenciBolum",ogr.OgrenciBolum);
               komut.Parameters.AddWithValue("@OgrenciFakulte",ogr.OgrenciFakulte);
               return Genelislemler.KomutCalistir(komut);
          }

     }
}
