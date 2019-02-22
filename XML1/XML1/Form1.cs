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


namespace XML1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xmlDosyasi;
        XmlNodeList menuNodeList;
        XmlNode yemeklerNode;
        private void Form1_Load(object sender, EventArgs e)
        {
            //..\..\ yapınca dosya uzantısının icine girmiş oluyoruz.
            xmlDosyasi= new XmlDocument();
            xmlDosyasi.Load(@"..\..\yemekler.xml");
            yemeklerNode = xmlDosyasi.SelectSingleNode("yemeklistesi");
            label1.Text = $"{yemeklerNode.SelectSingleNode("baslik").InnerText}";
            label2.Text = $"{yemeklerNode.SelectSingleNode("baslik").Attributes["bilgi"].Value}";

            menuNodeList = yemeklerNode.SelectNodes("menu");
            foreach (XmlNode menu in menuNodeList)
            {
                listBox1.Items.Add(menu.Attributes["adi"].Value);//menu isimleri yazıyor
                //listBox1.Items.Add(menu.SelectSingleNode("corba").InnerText);
                ////menu'nün icindeki isimler yazıyor
                //listBox1.Items.Add(menu.SelectSingleNode("anayemek").InnerText);
                ////menu'nün icindeki isimler yazıyor
                //listBox1.Items.Add(menu.SelectSingleNode("tatli").InnerText);
                ////menu'nün icindeki isimler yazıyor
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string secilenmenu = listBox1.SelectedItems.ToString();

            foreach (XmlNode menu in menuNodeList)
            {
                if (secilenmenu == menu.Attributes["adi"].Value)
                {
                    listBox2.Items.Add(menu.SelectSingleNode("corba").Value);
                    listBox2.Items.Add(menu.SelectSingleNode("anayemek").Value);
                    listBox2.Items.Add(menu.SelectSingleNode("tatli").Value);
                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
