using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox_FilmAdi.Items.Add(textBox_FilmAdi_1.Text);

            string[] data = { "Blade", "Shooter", "Karanlıklar Ülkesi" };
            var veri = from d in data where d.Count() > 6 select d;
            foreach (var item in veri)
            {
                comboBox_FilmAdi.Items.Add(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox_SalonAdi.Items.Add(textBox3.Text);

            string[] salon = { "A1", "B1", "C1", "D1" };
            var gir = from d in salon where d.Count() > 6 select d;
            foreach (var item in gir)
            {
                comboBox_SalonAdi.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox_FilmAdi.Items.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                comboBox_FilmAdi.Items.Add(row.Cells[3].Value.ToString());
            }













            //int sayi = comboBox_FilmAdi.Items.Count;
            //string[] liste = new string[sayi];
            //for (int i = 0; i < comboBox_FilmAdi.Items.Count; i++)
            //{
            //    liste[i] = comboBox_FilmAdi.Items[i].ToString();
            //}

            //var liste_degeri = from c in liste where c.Count() > 5 select c;

            //for (int i = 0; i < sayi; i++)
            //{
            //    dataGridView1.Rows.Add(liste[i]);
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sinemaDataContext CTX = new sinemaDataContext();
            comboBox_FilmAdi.DataSource = CTX.Films;
            comboBox_FilmAdi.DisplayMember = "FilmAdi";
            comboBox_FilmAdi.ValueMember = "FilmID";
        }
    }
}
