﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public partial class Form_AnaEkran : Form
    {
        public Form_AnaEkran()
        {
            InitializeComponent();
        }

        private void Form_AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Server=.;Database=form;user=sa;password=1234");
        private void buton_kaydet_Click(object sender, EventArgs e)
        {
            string ad = txt_Ad.Text;
            string soyad = txt_Soyad.Text;
            string tc = txt_TC.Text;
            DateTime dogtarihi = dateTimePicker1_dogum.Value;
            string strDogTar = dogtarihi.ToString("yyyy-MM-dd");

            
            SqlCommand komutekle = new SqlCommand($"insert into Kullanicilar(TC,Ad,Soyad,DogumTarihi) values ('{tc}','{ad}','{soyad}','{strDogTar}')",baglanti);
            baglanti.Open();
            int etkilenenSatirSayisi = komutekle.ExecuteNonQuery();
            if (etkilenenSatirSayisi>0)
            {
                MessageBox.Show("Kayit İşlemi Tamamlandi");
            }
            else
            {
                MessageBox.Show("Kayit Hatali");
            }
            baglanti.Close();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
