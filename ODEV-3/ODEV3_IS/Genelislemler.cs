using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ODEV_3
{
    public static class GenelIslemler
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_ODEV3"].ConnectionString);
        public static SqlConnection Baglanti
        {
            get { return baglanti; }
        }
    }
}
