using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// XML işlemleri için gerekli olan kütüphaneler
using System.IO;
using System.Xml;

namespace Sinema_Linq_Pro
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }
          private void btn_YayinEkle_Click(object sender, EventArgs e)
          {
            //yayin ekle butonu

               // Context sınıfından nesne: Veri tabanı sorgu işlemleri için.
               SINEMA_DataContext sctx = new SINEMA_DataContext();

               // Yayin tablosuna bir nesne eklemek için bu sınıftan bir nesne oluşturduk.
               Yayin y1 = new Yayin();
               // Formdan aldığımız verileri nesneye atadık.
               y1.FilmID = (int)comboBox_FilmAdi.SelectedValue;
               y1.SalonID = (int)comboBox_SalonAdi.SelectedValue;
               y1.FYZaman = dateTP_YayinZamani.Value;

               // Context sınıfından nesne ile Yayins aracılığı ile Yayin tablosuna nesneyi kaydettik.
               sctx.Yayins.InsertOnSubmit(y1);

               // Context nesnemizdeki değişiklikleri kaydettik.
               sctx.SubmitChanges();


               // dataGridView'i 3 farklı şekilde güncelledik.

               // 1: Doğrudan Vt'deki tablo ile.
               //dataGV_YayinTablo.DataSource = sctx.Yayins;

               // 2: LINQ Inner Join Kullanımı ile (metotda)
               //YayinTabloGuncelle();
               
               // 3: Inner Join 'li View kullandık.
               dataGV_YayinTablo.DataSource = sctx.Yayin_Isimlis;

               // 2. gridView'i Inner Join'li Group'lu LINQ sorgusu ile güncelledik(metotda).
               TabloGrupByGuncelle();

               MessageBox.Show("Yayın Kaydedildi ID'si : " + y1.YayinID);
          }

          private void ComboFilmGuncelle()
          {
               SINEMA_DataContext sinema_ctx = new SINEMA_DataContext();
               //Filmler ComboBox ının veri kaynağını Film tablosundan çek.
               comboBox_FilmAdi.DataSource = sinema_ctx.Films;

               // comboBox'ta görülen eleman kolonunu : FilmAdi olarak ayarla.
               comboBox_FilmAdi.DisplayMember = "FilmAdi";

               //// comboBox'ın value eleman kolonunu : FilmID olarak ayarla.
               comboBox_FilmAdi.ValueMember = "FilmID";
          }

          private void ComboSalonGuncelle()
          {
               SINEMA_DataContext sinema_ctx = new SINEMA_DataContext();
               //Filmler ComboBox ının değerlerini veri tabanından çek.
               comboBox_SalonAdi.DataSource = sinema_ctx.Salons;
               comboBox_SalonAdi.DisplayMember = "SalonAdi";
               comboBox_SalonAdi.ValueMember = "SalonID";
               
               // ComboBox'tan kaydederken .SelectedValue'yu seçerseniz.
               // FilmYayın tablosuna direkt ID'lerini kaydetmiş olursunuz.
          }


          private void Form1_Load(object sender, EventArgs e)
          {

            //from ekrani

               ComboFilmGuncelle();
               ComboSalonGuncelle();
               SINEMA_DataContext sctx = new SINEMA_DataContext();

               // 3. Yöntem: View kullandık.
               dataGV_YayinTablo.DataSource = sctx.Yayin_Isimlis;
               TabloGrupByGuncelle();

               /*
                * SQL'de çalıştırdık.
                * 
                CREATE VIEW Yayin_Isimli
	               AS SELECT Film.FilmAdi,Salon.SalonAdi,Yayin.FYZaman FROM Yayin
	               INNER JOIN Film ON Yayin.FilmID = Film.FilmID
	               INNER JOIN Salon ON Yayin.SalonID = Salon.SalonID
                */
          }

          private void panel3_Paint(object sender, PaintEventArgs e)
          {

          }




          private void btn_FilmKaydet_Click(object sender, EventArgs e)
          {
            //film kodunu calıstırır
               SINEMA_DataContext sctx = new SINEMA_DataContext();
               Film f1 = new Film();

               f1.FilmAdi = textBox_FilmAdi_1.Text;
               f1.FilmFragmanLink = textBox_FilmFragman.Text;
               f1.FilmKisaBilgi = textBox_KisaBilgi.Text;

               // LINQ sorgu yöntemi ile kaydı işle.
               //sctx.Films.InsertOnSubmit(f1);


               // NULLABLE NULL olabilir. ? işareti ile sağlandı.
               int? ID=0;
               // LINQ ile Stored Proc Kullanma
               sctx.SP_FilmKaydet(ref ID,f1.FilmAdi,f1.FilmKisaBilgi,f1.FilmFragmanLink);
               f1.FilmID = int.Parse(ID.ToString());
               
               sctx.SubmitChanges();
               MessageBox.Show("Yeni Eklenen Filmn FilmID'si : " + f1.FilmID);

               // SCOPE IDENTITY

               ComboFilmGuncelle();
               FilmXmlKaydet(f1);
          }
          private void FilmXmlKaydet(Film f1)
          {
               XmlDocument xmlFilmDosya;
               XmlElement elmFilmlerNode;
               xmlFilmDosya = new XmlDocument();

               // Aşağıda IF Kontrolü ile Filmler.xml dosyası yoksa "filmler" kök elementi oluşturuluyor.
               // ve elemente atanıyor.
               // dosya varsa bu element oluşturulmayacak. Varolan "filmler" nodu elemente atanacak.
               if (!File.Exists(@"..\..\Filmler.xml"))
               {
                    elmFilmlerNode = xmlFilmDosya.CreateElement("filmler");
                    xmlFilmDosya.AppendChild(elmFilmlerNode);
               }
               else
               {
                    xmlFilmDosya.Load(@"..\..\Filmler.xml");
                    elmFilmlerNode = (XmlElement)xmlFilmDosya.SelectSingleNode("filmler");
               }
               // film nodunu oluştur filmler noduna bağla.
               XmlElement elmFilmNode = xmlFilmDosya.CreateElement("film");
               elmFilmlerNode.AppendChild(elmFilmNode);
                    // film nodununun altındaki nodları oluştur ve  bağla.
                    XmlElement elmFilmAdi = xmlFilmDosya.CreateElement("filmadi");
                    elmFilmAdi.InnerText = f1.FilmAdi;
                    elmFilmNode.AppendChild(elmFilmAdi);

                    XmlElement elmFilmKisaBilgi = xmlFilmDosya.CreateElement("filmkisabilgi");
                    elmFilmKisaBilgi.InnerText = f1.FilmKisaBilgi;
                    elmFilmNode.AppendChild(elmFilmKisaBilgi);

                    XmlElement elmFilmFragman = xmlFilmDosya.CreateElement("filmfragman");
                    elmFilmFragman.InnerText = f1.FilmFragmanLink;
                    elmFilmNode.AppendChild(elmFilmFragman);

               // Filmler.xml dosyasını kaydet.
               xmlFilmDosya.Save("..\\..\\Filmler.xml");
          }

          private void btn_SalonEkle_Click(object sender, EventArgs e)
          {
            //sinema kodunu calıstırır
               SINEMA_DataContext sdtx = new SINEMA_DataContext();
               Salon s1 = new Salon();
               s1.SalonAdi = textBox_SalonAdi_1.Text;
               sdtx.Salons.InsertOnSubmit(s1);
               sdtx.SubmitChanges();
               MessageBox.Show("Kayıt Başarı İle Eklendi. ID'si :" + s1.SalonID);
               ComboSalonGuncelle();
          }
          private void YayinTabloGuncelle()
          {
               SINEMA_DataContext sinema_ctx = new SINEMA_DataContext();
               // LINQ içinde inner join kullanımı
               var sorgu = from y1 in sinema_ctx.Yayins
                           join f1 in sinema_ctx.Films on y1.FilmID equals f1.FilmID
                           join s1 in sinema_ctx.Salons on y1.SalonID equals s1.SalonID
                           select new
                           {
                                f1.FilmAdi,
                                s1.SalonAdi,
                                y1.FYZaman
                           };
               dataGV_YayinTablo.DataSource = sorgu;
          }

          private void panel4_Paint(object sender, PaintEventArgs e)
          {

          }

          private void TabloGrupByGuncelle()
          {
               SINEMA_DataContext sinema_ctx = new SINEMA_DataContext();
               var sorgu = from y1 in sinema_ctx.Yayins
                           join f1 in sinema_ctx.Films on y1.FilmID equals f1.FilmID
                           join s1 in sinema_ctx.Salons on y1.SalonID equals s1.SalonID
                           group f1 by f1.FilmAdi into grup
                           select new
                           {
                                FilmAdı = grup.Key,
                                FilmAdet = grup.Count()
                           };
               dataGV_GroupBy.DataSource = sorgu;

          }

     }
}
