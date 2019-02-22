using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_net
{
    class Program
    {
        public static object DataReaderOgretmenler { get; private set; }

        static void Main(string[] args)
        {
            SqlConnection balanti_OKUL_VT = new SqlConnection();
            balanti_OKUL_VT.ConnectionString = @"Server=Localhost;Database=OKUL_VT;USER=sa;Password=1234";
            {
                string ogretmenAdi2 = "Süleyman Avşar";
                SqlCommand komutInsert = new SqlCommand();
                komutInsert.CommandText = $"INSERT INTO Ogretmenler VALUES ('{ogretmenAdi2}',20)";
                komutInsert.Connection = balanti_OKUL_VT;
                balanti_OKUL_VT.Open();
                komutInsert.ExecuteNonQuery();
                balanti_OKUL_VT.Close();
            }
           

            Console.ReadKey();
        }
    }
}
