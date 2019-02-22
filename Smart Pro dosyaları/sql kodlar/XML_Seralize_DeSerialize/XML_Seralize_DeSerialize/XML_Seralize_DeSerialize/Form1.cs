using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XML_Seralize_DeSerialize
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button_Kaydet_Click(object sender, EventArgs e)
          {
               //// SERİLEŞTİRME(Serialization)
               //menu m1 = new menu();
               //m1.corba = tbx_corba.Text;
               //m1.anayemek = tbx_anayemek.Text;
               //m1.tatli = tbx_tatli.Text;
               //FileStream fs = new FileStream(@"..\..\menuler.xml", FileMode.Create);
               //XmlSerializer xs = new XmlSerializer(typeof(menu));
               //xs.Serialize(fs, m1);
               //fs.Close();



               // SERİLEŞTİRME Listeli(Serialization)
               //menu m1 = new menu();
               //m1.corba = tbx_corba.Text;
               //m1.anayemek = tbx_anayemek.Text;
               //m1.tatli = tbx_tatli.Text;
               //m1.menuAdi = tbx_MenuAdi.Text;

               //menu m2 = new menu();
               //m2.corba = "FFF";
               //m2.anayemek = "FFF";
               //m2.tatli = "FFF";
               //m2.menuAdi = "FFF";

               //menu m3 = new menu();
               //m3.corba = "GGG";
               //m3.anayemek = "GGG";
               //m3.tatli = "GGG";
               //m3.menuAdi = "GGG";

               //List<menu> listem = new List<menu>();
               //listem.Add(m2);
               //listem.Add(m3);



               //yemeklistesi y1 = new yemeklistesi();
               //y1.menuList = listem;
               ////y1.menu1 = m1;

               //FileStream fs = new FileStream(@"..\..\yemeklistesi.xml", FileMode.Create);
               //XmlSerializer xs = new XmlSerializer(typeof(yemeklistesi));
               //xs.Serialize(fs, y1);
               //fs.Close();

          }

          private void Form1_Load(object sender, EventArgs e)
          {
               //// SERİLEŞTİRME TERSİ(DeSerialization)
               //FileStream fs = new FileStream(@"..\..\menuler.xml", FileMode.Open);
               //XmlSerializer dxs = new XmlSerializer(typeof(menu));
               //menu m2 = new menu();

               //m2 = (menu)dxs.Deserialize(fs);

               //tbx_corba.Text = m2.corba;
               //tbx_anayemek.Text = m2.anayemek;
               //tbx_tatli.Text = m2.tatli;



               // SERİLEŞTİRME TERSİ(DeSerialization)
               FileStream fs = new FileStream(@"..\..\yemeklistesi.xml", FileMode.Open);
               XmlSerializer dxs = new XmlSerializer(typeof(yemeklistesi));
               yemeklistesi y2 = new yemeklistesi();

               y2 = (yemeklistesi)dxs.Deserialize(fs);
               label1.Text = "";
               y2.menuList.ForEach(menuTek => label1.Text += menuTek.menuAdi + "\n" + menuTek.corba + " \t " + menuTek.anayemek + " \t " + menuTek.tatli + " \n ");


          }
     }
}
