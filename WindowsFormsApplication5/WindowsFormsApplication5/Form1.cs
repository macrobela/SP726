using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=localhost;database=TEST;user=sa;password=1234");

        private void Form1_Load(object sender, EventArgs e)
        {
            ElemanListele();
        }

        private void ElemanListele()
        {
            //SQL Sorgusu
            string sorgu = "ElemanListele";
            //SQL bağlantısı ve tabloyu oldugu gibi cekmek için SQLDataAdapter kullandık.
            SqlDataAdapter tablocek = new SqlDataAdapter(sorgu, baglanti);
            tablocek.SelectCommand.CommandType = CommandType.StoredProcedure;
            //tablocek.InsertCommand.CommandType = CommandType.StoredProcedure;
            //Yukarı çektigimiz tabloyu C#'da tutmak için bir DataTable nesnesi tanımladık.
            DataTable elemanTable = new DataTable();
            //DataTable nesnesine SqlDataAdaptör ile cektiğimiz tabloyu aktardık.
            tablocek.Fill(elemanTable);
            //DataTAble nesnemizi GridView aracılığı ile ekrana gösterdik.
            dataGridView1.DataSource = elemanTable;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoluDizginYillar();

        }

        private void DoluDizginYillar()
        {
            string ad = textBox1_ad.Text;
            string soyad = textBox2_soyad.Text;
            string sehir = combobax_sehir.Text;
            // MessageBox.Show(combobax_sehir.Text);

            SqlCommand kaydetKomut = new SqlCommand("SP_Eleman_Kaydet", baglanti);
            kaydetKomut.CommandType = CommandType.StoredProcedure;
            kaydetKomut.Parameters.AddWithValue("@ad", ad);
            kaydetKomut.Parameters.AddWithValue("@soyad", soyad);
            kaydetKomut.Parameters.AddWithValue("@sehir", sehir);
            baglanti.Open();
            int etkilenenSatir = kaydetKomut.ExecuteNonQuery();
            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Kayit Basarili");
                ElemanListele();
            }
            else
            {
                MessageBox.Show("Kayit Sirasnda Hata olustu...!!!");
            }

            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ad = dataGridView1.CurrentRow.Cells["AD"].Value.ToString();
            string soyad = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            string sehir = dataGridView1.CurrentRow.Cells["Sehir"].Value.ToString();

            textBox1_ad.Text = ad;
            textBox2_soyad.Text = soyad;
            combobax_sehir.Text = sehir;

            //MessageBox.Show(dataGridView1.CurrentRow.Cells["AD"].Value.ToString());
            //MessageBox.Show(dataGridView1.CurrentRow.Cells["SOYAD"].Value.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            string AD = textBox1_ad.Text;
            string SOYAD = textBox2_soyad.Text;
            string sehir = combobax_sehir.Text;

            SqlCommand komutGuncelle = new SqlCommand("SP_Elaman_Guncelle", baglanti);
            komutGuncelle.CommandType = CommandType.StoredProcedure;
            komutGuncelle.Parameters.AddWithValue("@id", seciliID);
            komutGuncelle.Parameters.AddWithValue("@ad", AD);
            komutGuncelle.Parameters.AddWithValue("@soyad", SOYAD);
            komutGuncelle.Parameters.AddWithValue("@sehir", sehir);

            baglanti.Open();
            int etkilenenSatir = komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Güncelle Başarılı");
                ElemanListele();
            }
            else
            {
                MessageBox.Show("Güncelleme Hatali");
            }
        }
    }
}
