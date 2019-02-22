using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OKUL_VTEntities okul = new OKUL_VTEntities();
            dataGridView1.DataSource = okul.Ogretmenlers.ToList();
            dataGridView2.DataSource = okul.Ogrencilers.ToList();
        }

        private void ogretmen_kaydet_Click(object sender, EventArgs e)
        {
            OKUL_VTEntities okul = new OKUL_VTEntities();
            Ogretmenler ogr = new Ogretmenler();
            ogr.OgretmenAdi = textBox1.Text;
            ogr.AktifCalisan = Convert.ToBoolean(checkBox2.Checked);

            okul.Ogretmenlers.Add(ogr);
            okul.SaveChanges();
            MessageBox.Show(ogr.OgretmenID.ToString());
        }

        private void ogretmen_guncelle_Click(object sender, EventArgs e)
        {
            var ctx = new OKUL_VTEntities();

            short OgretmenID = Convert.ToInt16(textBox3.Text);
            var f1 = ctx.Ogretmenlers.Find(OgretmenID);
            f1.OgretmenAdi = textBox1.Text;
            //ctx.SaveChanges();
            dataGridView1.DataSource = ctx.Ogretmenlers.ToList();
            MessageBox.Show(f1.OgretmenID.ToString());
        }

        private void ogretmen_sil_Click(object sender, EventArgs e)
        {
            OKUL_VTEntities ogr = new OKUL_VTEntities();
            Ogretmenler ogr2=new Ogretmenler();
            short OgretmenID = Convert.ToInt16(textBox3.Text);
            var okul = ogr.Ogretmenlers.Find(OgretmenID);
            ogr.Ogretmenlers.Remove(okul);
            ogr.SaveChanges();
            dataGridView1.DataSource = ogr.Ogretmenlers.ToList();
        }
    }
}
