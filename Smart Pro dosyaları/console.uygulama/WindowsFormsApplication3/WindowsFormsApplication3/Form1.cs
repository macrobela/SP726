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


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=form;user=sa;password=1234");

        private void button1_Click(object sender, EventArgs e)
        {

            int vize, final, ort;
            vize = Convert.ToInt32(textBox3.Text);
            final = Convert.ToInt32(textBox4.Text);
            ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            if (ort <50)
            {
                label6.Text=("Kaldiniz :");
            }

            else if (ort < 60)
            {
                label6.Text = "Gectiniz :D";
                    
            }
            else if(ort<70)

            {
                label6.Text = "Gectiniz C ";

            }
            else if (ort <80)

            {
                label6.Text = "Gectiniz B ";

            }
            else if (ort >=80)

            {
                label6.Text = "Gectiniz A ";

            }

            string no = textBox1.Text;
            string dersadi = textBox2.Text;

            string durum = label6.Text;

            SqlCommand komutekle = new SqlCommand($"insert into Table_1(OgrenciNo,DersAdi,Vize,Final,Durum) values ('{no}','{dersadi}','{vize}','{final}','{durum}')",baglanti);
            baglanti.Open();
            int etkilenenSatirSayisi = komutekle.ExecuteNonQuery();
            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayit İşlemi Tamamlandi");
            }
            else
            {
                MessageBox.Show("Kayit Hatali");
            }
            baglanti.Close();


        }
    }
}
