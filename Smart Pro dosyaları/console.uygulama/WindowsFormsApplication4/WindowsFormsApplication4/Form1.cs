using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         
        

        private void button1_Click(object sender, EventArgs e)
        {

            

            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            SqlConnection con = new SqlConnection("server=localhost;database=kullanici;user=sa;password=1234");
            SqlCommand cmd = new SqlCommand();

            SqlDataReader dr;

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT COUNT(*) FROM Table_1 where kulaniciadi='{textBox1.Text}' AND kullanici_sifre= '{ textBox2.Text }'";
            //cmd.CommandText = "SELECT * FROM Table_1 where kulaniciadi='" + textBox1.Text + "' AND kullanici_sifre='" + textBox2.Text + "'";

            int sayi = Convert.ToInt32(cmd.ExecuteScalar());
            // ExecuteScalar: Sorgudan tek değer dönecekse. Kullanılabilir.
            
            if (sayi==1)
            {
                MessageBox.Show("dogru giris yapıldı");
            }
            else
            {
                MessageBox.Show("Hatali Giris Yapıldı");
            }

            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
               
            //    if (dr[0].Equals(textBox1.Text)==true && dr[1].Equals(textBox2.Text)==true)
            //    {
            //        MessageBox.Show("dogru giris yapıldı");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Hatali Giris Yapıldı");
            //}
            
            con.Close();



        }
    }
}
