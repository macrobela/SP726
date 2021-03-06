﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"server=AAA2016\SA;database=ogrencikayit;user=sa;password=1234");
        SqlCommand kayit = new SqlCommand();

        private void button2_Click(object sender, EventArgs e)
        {
            if(baglanti.State==ConnectionState.Closed)
                baglanti.Open();
            
            kayit.Connection = baglanti;
            kayit.CommandType = CommandType.StoredProcedure;
            kayit.CommandText = "proc_ogrencikayit";
            kayit.Parameters.AddWithValue("@numara", textBox1.Text);
            kayit.Parameters.AddWithValue("@adsoyad",textBox2.Text);
            kayit.Parameters.AddWithValue("@bolum",comboBox1.Text);
            kayit.Parameters.AddWithValue("@fakulte",comboBox2.Text);
            ogrencilistele();

            int etkilenenSatir = kayit.ExecuteNonQuery();

            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Eklendi");
                ogrencilistele();
            }
            else
            {
                MessageBox.Show("Eklenmedi");
            }
        }

        private void ogrencilistele()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            string sorgu = "proc_liste";
            SqlDataAdapter tabloCek = new SqlDataAdapter(sorgu, baglanti);
            tabloCek.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable elemanTable = new DataTable();
            tabloCek.Fill(elemanTable);
            dataGridView1.DataSource = elemanTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrencilistele();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string no = dataGridView1.CurrentRow.Cells["ogrencino"].Value.ToString();
            string adsoyad = dataGridView1.CurrentRow.Cells["ogrenciadsoyad"].Value.ToString();
            string bolum = dataGridView1.CurrentRow.Cells["ogrencibolum"].Value.ToString();
            string fakulte = dataGridView1.CurrentRow.Cells["ogrenifakulte"].Value.ToString();

            textBox1.Text = no;
            textBox2.Text = adsoyad;
            comboBox1.Text = bolum;
            comboBox2.Text = fakulte;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string no = textBox1.Text;
            string adsoyad = textBox2.Text;
            string bolum = comboBox1.Text;
            string fakulte = comboBox2.Text;

            SqlCommand komutGuncelle = new SqlCommand("proc_guncelle", baglanti);
            komutGuncelle.CommandType = CommandType.StoredProcedure;
            komutGuncelle.Parameters.AddWithValue("@numara", no);
            komutGuncelle.Parameters.AddWithValue("@adsoyad",adsoyad);
            komutGuncelle.Parameters.AddWithValue("@bolum",bolum);
            komutGuncelle.Parameters.AddWithValue("@fakulte",fakulte);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            int etkilenenSatir = komutGuncelle.ExecuteNonQuery();
     
            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Güncellendi");
                ogrencilistele();
            }
            else
            {
                MessageBox.Show("Güncellenmedi");
            }




            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                DialogResult result = MessageBox.Show("Silmek istiyormusunuz?","Silmek",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    SqlCommand komutGuncelle = new SqlCommand("proc_sil", baglanti);
                    komutGuncelle.CommandType = CommandType.StoredProcedure;
                    komutGuncelle.Parameters.AddWithValue("@numara", Convert.ToInt32(dataGridView1.CurrentRow.Cells["ogrencino"].Value.ToString()));


                    if (baglanti.State==ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    int etkilenenSatir = komutGuncelle.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Silindi");
                        ogrencilistele();
                    }
                    else
                    {
                        MessageBox.Show("silinmedi");
                    }
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from yenikayit where ogrencino like '%"+textBox3.Text+"%'",baglanti);
            ara.Fill(dt);
            dataGridView1.DataSource = dt;

           


        }
    }
}
