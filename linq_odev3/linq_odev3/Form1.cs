﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq_odev3
{
    public partial class Form1 : Form
    {
        odev3DataContext odev3 = new odev3DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            odev3DataContext odev3 = new odev3DataContext();
            dataGridView1.DataSource = odev3.Ogrencis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciNumara = textBox1.Text;
            ogrenci.OgrenciAdSoyad = textBox2.Text;
            ogrenci.OgrenciBolum = textBox3.Text;
            ogrenci.OgrenciFakulte = textBox4.Text;

            odev3.Ogrencis.InsertOnSubmit(ogrenci);

            odev3.SubmitChanges();

            dataGridView1.DataSource = odev3.Ogrencis;
            MessageBox.Show("Kayit İşlemi Basarili.");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["OgrenciNumara"].Value;
            textBox1.Text = satir.Cells["OgrenciNumara"].Value.ToString();
            textBox2.Text = satir.Cells["OgrenciAdSoyad"].Value.ToString();
            textBox3.Text = satir.Cells["OgrenciBolum"].Value.ToString();
            textBox4.Text = satir.Cells["OgrenciFakulte"].Value.ToString();
             textBox1.Enabled = false;

            MessageBox.Show(textBox1.Tag.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odev3DataContext odev3 = new odev3DataContext();
            string NUMARA = (string)textBox1.Tag;
            Ogrenci ogrenci = odev3.Ogrencis.SingleOrDefault(Ogrenci => Ogrenci.OgrenciNumara == NUMARA);
            //ogrenci.OgrenciNumara = textBox1.Text;
            ogrenci.OgrenciAdSoyad = textBox2.Text;
            ogrenci.OgrenciBolum = textBox3.Text;
            ogrenci.OgrenciFakulte = textBox4.Text;
            odev3.SubmitChanges();

            dataGridView1.DataSource = odev3.Ogrencis;
            MessageBox.Show("Güncelleme Basarili...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odev3DataContext odev3 = new odev3DataContext();
            string Numara = (string)textBox1.Tag;//aşasındakide olur yanımdakide olur.
            //string Numara = (string)dataGridView1.CurrentRow.Cells["OgrenciNumara"].Value;
            Ogrenci ogrencis = odev3.Ogrencis.SingleOrDefault(Ogrenci => Ogrenci.OgrenciNumara == Numara);
            odev3.Ogrencis.DeleteOnSubmit(ogrencis);
            odev3.SubmitChanges();

            dataGridView1.DataSource = odev3.Ogrencis;
            MessageBox.Show("Silme İşlmi Başarılı ...");

        }
    }
}
