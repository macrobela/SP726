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


namespace kaydet_load
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnToKaydet.Click += BtnToKaydet_Click;
        }

        private void BtnToKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text=="")
                    {
                        return;
                    }
                }
            }
            XmlDocument xdoc = new XmlDocument();
            XmlNode root = xdoc.CreateElement("Ögrenciler");
            xdoc.AppendChild(root);
            for (int i = 0; i < 5; i++)
            {
                XmlNode Kullanici = xdoc.CreateElement("Kullanici");
                XmlAttribute ID = xdoc.CreateAttribute("ID");
                XmlNode NUMARA = xdoc.CreateElement("NUMARA");
                XmlNode ADSOYAD = xdoc.CreateElement("ADSOYAD");
                XmlNode SİNİF = xdoc.CreateElement("SİNİF");
                XmlNode DOGUMTARİHİ = xdoc.CreateElement("DOGUMTARİHİ");

                ID.Value = i.ToString();
                NUMARA.InnerText = textBox1.Text;
                ADSOYAD.InnerText = textBox2.Text;
                SİNİF.InnerText = textBox3.Text;
                DOGUMTARİHİ.InnerText = textBox4.Text;

                Kullanici.Attributes.Append(ID);
                Kullanici.AppendChild(NUMARA);
                Kullanici.AppendChild(ADSOYAD);
                Kullanici.AppendChild(SİNİF);
                Kullanici.AppendChild(DOGUMTARİHİ);    
            }
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "XML Dosyası|*.xml";
                if (sf.ShowDialog()==DialogResult.OK)
                {
                    xdoc.Save(sf.FileName);
                    MessageBox.Show($"{sf.FileName}dosyasi olusturuldu...");
                }

            }

        }

       
    }
    
}
