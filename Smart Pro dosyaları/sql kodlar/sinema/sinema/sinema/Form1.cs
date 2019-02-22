using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class Form1 : Form
    {
        sinemaDataContext film = new sinemaDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //combobox'taki veriyi textbox atamak
            //ekliyor
            comboBox_FilmAdi.Items.Add(textBox_FilmAdi_1.Text);

            string[] data = { "blade", "Shooter", "Karanlıklar Ülkesi" };
            var veri = from d in data where d.Count() > 8 select d;
            foreach (var item in veri)
            {
                comboBox_FilmAdi.Items.Add(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //combobox'taki veriyi textbox atamak

            comboBox_SalonAdi.Items.Add(textBox3.Text);

            string[] salon = { "A1", "B1", "C1", "D1" };
            var gir = from d in salon where d.Count() > 8 select d;
            foreach (var item in gir)
            {
                comboBox_SalonAdi.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sinemaDataContext film = new sinemaDataContext();
            dataGridView1.DataSource = film.FilmYayins;
        }
    }
}
