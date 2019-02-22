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


namespace yenixml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDosyasi;
        XmlNodeList okulNodeList;
        XmlNode okulNode;
        string numarabul;

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlDosyasi = new XmlDocument();
            //xmlDosyasi.Load(@"C:\Users\suleyman.avsar\Desktop\console.uygulama\yenixml\yenixml\bin\Debug");
            xmlDosyasi.Load(@"..\..\XML.xml");
            okulNode = xmlDosyasi.SelectSingleNode("okul");
            label2.Text = $"{okulNode.SelectSingleNode("baslik").InnerText}";
            label3.Text = $"{okulNode.SelectSingleNode("baslik").Attributes["bilgi"].Value}";

            okulNodeList = okulNode.SelectNodes("ogrenci");
            foreach (XmlNode ogrenci in okulNodeList)
            {
                listBox1.Items.Add(ogrenci.Attributes["numara"].Value);//menu isimleri yazıyor                
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenogrenci = listBox1.SelectedItems.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            numarabul = textBox1.Text;

            foreach (XmlNode ogrenci in okulNodeList)
            {
               // listBox1.Items.Add(ogrenci.Attributes["numara"].Value);//menu isimleri yazıyor   

                if (numarabul == ogrenci.Attributes["numara"].Value)
                {
                    listBox1.Items.Add(ogrenci.SelectSingleNode("ad").InnerText);
                    listBox1.Items.Add(ogrenci.SelectSingleNode("soyad").InnerText);
                    listBox1.Items.Add(ogrenci.SelectSingleNode("sinif").InnerText);
                    listBox1.Items.Add(ogrenci.SelectSingleNode("dogumtarih").InnerText);
                }
            }
            

        }
    }
}
