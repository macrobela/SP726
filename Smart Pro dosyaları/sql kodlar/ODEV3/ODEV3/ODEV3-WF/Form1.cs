using ODEV3_IS.Entity;
using ODEV3_IS.Facade;
// Ogrenci ve Ogrenci_VTI sınıf dosyalarına erişmek için ekledik.
// Bunlara erişmek için Formun bulunduğu projede Referanslar kısmında ODEV_IS projesini regerans olarak ekledik.
// (Projects menüsü altında.)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV3_WF
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }
          private void Form1_Load(object sender, EventArgs e)
          {
               dataGridView_OgrenciListele.DataSource = Ogrenci_VTI.OgrenciListele();
               // Form yüklenirken gridi Ogrenci tablosu ile doldur.
          }
          private void button_Kaydet_Click(object sender, EventArgs e)
          {
               if ((textBox_Numara.Text=="")||(textBox_AdSoyad.Text=="")||(comboBox_Fakulte.Text==""))
               {    // TextBox'lar boş mu kontrol ettik.
                    //TextBox'lar boşsa
                    MessageBox.Show("* ile işaretli alanları doldurmak zornludur.");
               }
               else
               {    // TextBox'lar boş değilse
                    
                    // Bu kısımda yanlışlıkla Primary Key olan OgrenciNumara kolonunun güncellenmesini engelledik.

                    if (textBox_Numara.Enabled==false)
                    {
                         textBox_Numara.Enabled = true;
                         FormTemizle();
                    }
                    else
                    {
                         // Öğrenci Kaydetme İşlemleri
                         Ogrenci ogr = new Ogrenci();
                         ogr.OgrenciNumara = textBox_Numara.Text;
                         ogr.OgrenciAdSoyad = textBox_AdSoyad.Text;
                         ogr.OgrenciBolum = comboBox_Bolum.Text;
                         ogr.OgrenciFakulte = comboBox_Fakulte.Text;

                         int etkilenenSatirSayisi = Ogrenci_VTI.Insert(ogr);

                         if (etkilenenSatirSayisi > 0)
                         {
                              MessageBox.Show("Kayıt Başarılı :" + etkilenenSatirSayisi);
                              dataGridView_OgrenciListele.DataSource = Ogrenci_VTI.OgrenciListele();
                              FormTemizle();
                         }
                         else
                         {
                              MessageBox.Show("Kayıt Hatalı :" + etkilenenSatirSayisi);
                              FormTemizle();
                         }
                    }
               }
          }
          private void FormTemizle()
          {
               textBox_Numara.Clear();
               textBox_AdSoyad.Clear();
               comboBox_Bolum.ResetText();
               comboBox_Fakulte.ResetText();
          }
          private void dataGridView_OgrenciListele_MouseHover(object sender, EventArgs e)
          {
               // Fare üzerine gelince renk değiştirsin gibi birşeydi.
               dataGridView_OgrenciListele.CurrentCell.Style.BackColor = Color.Aqua;
          }
          private void dataGridView_OgrenciListele_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               // Tabloda hücreye tıklandığında güncellemek için sol kısıma bilgileri aktarma.
               textBox_Numara.Text = dataGridView_OgrenciListele.CurrentRow.Cells["OgrenciNumara"].Value.ToString();
               textBox_AdSoyad.Text = dataGridView_OgrenciListele.CurrentRow.Cells["OgrenciAdSoyad"].Value.ToString();
               comboBox_Bolum.Text = dataGridView_OgrenciListele.CurrentRow.Cells["OgrenciBolum"].Value.ToString();
               comboBox_Fakulte.Text = dataGridView_OgrenciListele.CurrentRow.Cells["OgrenciFakulte"].Value.ToString();
               textBox_Numara.Enabled = false;
          }

          private void button_Guncelle_Click(object sender, EventArgs e)
          {
               if ((textBox_Numara.Text == "") || (textBox_AdSoyad.Text == "") || (comboBox_Fakulte.Text == ""))
               {
                    MessageBox.Show("* ile işaretli alanları doldurmak zornludur.");
               }
               else
               {
                    // Öğrenci Güncelleme İşlemleri
                    Ogrenci ogr = new Ogrenci();
                    ogr.OgrenciNumara = textBox_Numara.Text;
                    ogr.OgrenciAdSoyad = textBox_AdSoyad.Text;
                    ogr.OgrenciBolum = comboBox_Bolum.Text;
                    ogr.OgrenciFakulte = comboBox_Fakulte.Text;

                    int etkilenenSatirSayisi = Ogrenci_VTI.OgrenciGuncelle(ogr);

                    if (etkilenenSatirSayisi > 0)
                    {
                         MessageBox.Show("Güncelleme Başarılı" + etkilenenSatirSayisi);
                         dataGridView_OgrenciListele.DataSource = Ogrenci_VTI.OgrenciListele();
                    }
                    else
                    {
                         MessageBox.Show("Güncelleme Hatalı" + etkilenenSatirSayisi);
                    }

                    textBox_Numara.Enabled = true;
                    FormTemizle();
               }
               
          }
     }
}