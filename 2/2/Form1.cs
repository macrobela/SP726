using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument dosyam;
        XmlElement ogrenciNode1;
        private void Form1_Load(object sender, EventArgs e)
        {
            dosyam = new XmlDocument();
               if (!File.Exists(@"..\..\XMLFile1.xml"))
               {
                ogrenciNode1 = dosyam.CreateElement("OgrenciListesi");
                dosyam.AppendChild(ogrenciNode1);
               }
               else
               {
                dosyam.Load(@"..\..\XMLFile1.xml");
                ogrenciNode1 = (XmlElement)dosyam.SelectSingleNode("OgrenciListesi");
               }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlElement ogrenci = dosyam.CreateElement("ogrenci");
            ogrenciNode1.AppendChild(ogrenci);

            XmlElement numara = dosyam.CreateElement("Numara");
            numara.InnerText = textBox1.Text;
            ogrenci.AppendChild(numara);
            
            XmlElement AdSoyad = dosyam.CreateElement("AdSoyad");
            AdSoyad.InnerText = textBox2.Text;
            ogrenci.AppendChild(AdSoyad);

            XmlElement Sinif = dosyam.CreateElement("Sinif");
            Sinif.InnerText = textBox3.Text;
            ogrenci.AppendChild(Sinif);

            XmlElement dogumtarihi = dosyam.CreateElement("DogumTarihi");
            dogumtarihi.InnerText = textBox4.Text;
            ogrenci.AppendChild(dogumtarihi);

            dosyam.Save(@"..\..\XMLFile1.xml");
            MessageBox.Show("Ogrenci kayit edildi");

        }

       

    }
}
