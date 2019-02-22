using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace ODEV3_IS.Fascade
{
     public class  Ogrenci_VTI
    {
        //public static SqlConnection baglanti = new SqlConnection("server=localhost;database=odev3;user=sa;password=1234");
        public static int Insert(Ogrenci ogr)
        {
            SqlCommand komut = new SqlCommand("sp_Ogrenci_Kaydet");
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ogrenciNumara",ogr.ogrenciNumara);
            komut.Parameters.AddWithValue("@ogrenciadsoyad", ogr.ogrenciAdSoyad);
            komut.Parameters.AddWithValue("@ogrencibolum", ogr.ogrenciBolum);
            komut.Parameters.AddWithValue("@ogrencifakulte", ogr.ogrenciFakulte);
            komut.Connection.Open();
            int etkilenensatir = komut.ExecuteNonQuery();
            if (etkilenensatir > 0)
            {
                MessageBox.Show("Eklendi");
                OgrenciListele();
            }
            else
            {
                MessageBox.Show("Eklenmedi");
                OgrenciListele();
            }
            komut.Connection.Close();
            return etkilenensatir;
        }
        public static DataTable OgrenciListele()
        {
            SqlDataAdapter alp = new SqlDataAdapter("sp_Ogrenci_Listele",baglanti);
            alp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable ogrenciTablosu = new DataTable();
            alp.Fill(ogrenciTablosu);
            return ogrenciTablosu;
        }
    }
}
