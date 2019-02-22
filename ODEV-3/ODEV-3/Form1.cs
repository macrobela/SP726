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
using ODEV3_IS;
using ODEV3_IS.Fascade;

namespace ODEV_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("server=localhost;database=odev3;user=sa;password=1234");
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == ""))
            {
                MessageBox.Show("** İle işaretli alanları doldurunuz.");
            }
            else
            {
                Ogrenci ogr = new Ogrenci();
                Ogrenci_VTI ogr1 = new Ogrenci_VTI();
                ogr.ogrenciNumara = textBox1.Text.ToString();
                ogr.ogrenciAdSoyad = textBox2.Text.ToString();
                ogr.ogrenciBolum = comboBox1.Text.ToString();
                ogr.ogrenciFakulte = comboBox2.Text.ToString();
                int etkilenen = Ogrenci_VTI.Insert(ogr);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ogrenci_VTI.OgrenciListele();
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.CurrentCell.Style.BackColor = Color.Aqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string no = textBox1.Text;
            string adsoyad = textBox2.Text;
            string bolum = comboBox1.Text;
            string fakulte = comboBox2.Text;

            SqlCommand komutguncelle = new SqlCommand("sp_guncelle",GenelIslemler.Baglanti);
            komutguncelle.CommandType = CommandType.StoredProcedure;
            komutguncelle.Parameters.AddWithValue("@ogrencinumara",no);
            komutguncelle.Parameters.AddWithValue("@ogrenciadsoyad",adsoyad);
            komutguncelle.Parameters.AddWithValue("@ogrencibolum",bolum);
            komutguncelle.Parameters.AddWithValue("@ogrencifakulte",fakulte);

            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            int etkilenensatir = komutguncelle.ExecuteNonQuery();
            if (etkilenensatir > 0)
            {
                MessageBox.Show("Güncellendi !!!");
            }
            else
            {
                MessageBox.Show("Güncellenmedi !!!");
            }
            dataGridView1.DataSource = Ogrenci_VTI.OgrenciListele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["OgrenciNumara"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["OgrenciAdSoyad"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["OgrenciBolum"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["OgrenciFakulte"].Value.ToString();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable table = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Ogrenci where OgrenciAdSoyad like '%" + textBox2.Text + "%'", baglanti);
            ara.Fill(table);
            baglanti.Close();
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Silmek İstiyormusunuz?", "Silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand komutguncelle = new SqlCommand("proc_sil",GenelIslemler.Baglanti);
                    komutguncelle.CommandType = CommandType.StoredProcedure;
                    komutguncelle.Parameters.AddWithValue("@ogrencinumara", Convert.ToInt32(dataGridView1.CurrentRow.Cells["OgrenciNumara"].Value.ToString()));
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    int etkilenensatir = komutguncelle.ExecuteNonQuery();
                    if (etkilenensatir > 0)
                    {
                        MessageBox.Show("Silindi");
                    }
                    else
                    {
                        MessageBox.Show("Silinmedi");
                    }
                }
            }
        }
    }
}
