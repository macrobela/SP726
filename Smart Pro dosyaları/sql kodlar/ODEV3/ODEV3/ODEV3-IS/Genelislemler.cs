using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ODEV3_IS
{
     public static class Genelislemler
     {
          private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_ODEV3"].ConnectionString);
          // App.Config dosyasından okuma işlemi yapan satır. Name değeri "CS_ODEV3" olan connectionstring'i getirir.
          // Bu yapıyı kullanmak için ODEV_IS projesinin Referanslar kısmında System.Configuration kütüphanesini ekledik.
          // Using System.Configuration; dedik.

          public static SqlConnection Baglanti { get { return baglanti; }  }
          // Encapsülasyon için aşağıdaki oluşturuldu.
          // Sadece okuma yapılacağı için set tanımlanmadı.
          public static int KomutCalistir(SqlCommand komut)
          {
               baglanti.Open();
               int etkilenenSatirSayisi = komut.ExecuteNonQuery();
               baglanti.Close();
               return etkilenenSatirSayisi;
          }
     }
}
