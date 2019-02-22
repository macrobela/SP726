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


namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument dosyam;
        XmlElement yemeklerNode1;

        private void button1_Click(object sender, EventArgs e)
        {
            XmlElement menu = dosyam.CreateElement("menu");
            menu.InnerText = TextBox_menuAdi.Text;
            
            yemeklerNode1.AppendChild(menu);//yukaridaki ata



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dosyam = new XmlDocument();
            if (!File.Exists(@"..\..\yemekler.xml"))
            {
                yemeklerNode1 = dosyam.CreateElement("yemekler");
                dosyam.AppendChild(yemeklerNode1);
            }
            else
            {
                dosyam.Load("Yemekler.xml");
                yemeklerNode1 = (XmlElement)dosyam.SelectSingleNode("yemekler");
            }
        }
    }
}
