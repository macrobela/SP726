using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Şubat15_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xmlDosyasi;
        XmlNode OgrenciNode;
        XmlNodeList OgrenciNodeList;
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlOku();
            foreach (XmlNode ogrenci in OgrenciNodeList)
            {
                listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciNumara").InnerText);
                listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciAdSoyad").InnerText);
                listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciSinif").InnerText);
                listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciDogTar").InnerText);
            }
        }

        private void XmlOku()
        {
            xmlDosyasi = new XmlDocument();
            //xmlDosyasi.Load(@"C:\Users\yakup.bilgen\Documents\
            //Visual Studio 2015\Projects\XML1\XML1\okul.xml");
            xmlDosyasi.Load(@"..\..\okul.xml");
            OgrenciNode = xmlDosyasi.SelectSingleNode("okul");
            OgrenciNodeList = OgrenciNode.SelectNodes("Ogrenciler");
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string ArananOgrenci = txtOgrenciNo.Text;
            XmlOku();

            listOgrenciBilgileri.Items.Clear();
            bool varMi = false;
            foreach (XmlNode ogrenci in OgrenciNodeList)
            {
                if (ArananOgrenci == ogrenci.SelectSingleNode("OgrenciNumara").InnerText)
                {
                    listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciNumara").InnerText);
                    listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciAdSoyad").InnerText);
                    listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciSinif").InnerText);
                    listOgrenciBilgileri.Items.Add(ogrenci.SelectSingleNode("OgrenciDogTar").InnerText);
                    varMi = true;
                }
            }
            if (!varMi)
            {
                MessageBox.Show("Kayıt YOk");
            }
        }
    }
}