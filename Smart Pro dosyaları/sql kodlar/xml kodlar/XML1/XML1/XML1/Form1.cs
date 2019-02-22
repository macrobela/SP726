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
          XmlNode yemeklerNode;
          XmlNodeList menuNodeList;
          private void Form1_Load(object sender, EventArgs e)
          {
               xmlDosyasi = new XmlDocument();
               //xmlDosyasi.Load(@"C:\Users\mehmet.demir\Documents\
               //Visual Studio 2015\Projects\XML1\XML1\yemekler.xml");
               xmlDosyasi.Load(@"..\..\yemekler.xml");
               yemeklerNode = xmlDosyasi.SelectSingleNode("yemeklistesi");
               label_XML_Root_Label.Text = $"{yemeklerNode.SelectSingleNode("baslik").InnerText}";
               label_XML_Root_Att_Label.Text = $"{yemeklerNode.SelectSingleNode("baslik").Attributes["bilgi"].Value}";

               menuNodeList = yemeklerNode.SelectNodes("menu");
               foreach (XmlNode menu in menuNodeList)
               {
                    listBox_Menu_Adlari.Items.Add(menu.Attributes["adi"].Value);
               }
          }

          private void listBox_Menu_Adlari_SelectedIndexChanged(object sender, EventArgs e)
          {
               listBox_Menu_Detaylari.Items.Clear();

               string secilenMenu = listBox_Menu_Adlari.SelectedItem.ToString();

               foreach (XmlNode menu in menuNodeList)
               {
                    if (secilenMenu==menu.Attributes["adi"].Value)
                    {
                         listBox_Menu_Detaylari.Items.Add(menu.SelectSingleNode("corba").InnerText);
                         listBox_Menu_Detaylari.Items.Add(menu.SelectSingleNode("anayemek").InnerText);
                         listBox_Menu_Detaylari.Items.Add(menu.SelectSingleNode("tatlı").InnerText);
                    }
               }

          }
     }
}
