using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sd
{

    public partial class Sinema : System.Web.UI.Page
    {
      protected void TabloGuncelle()
        {
            SINEMAEntities ctx = new SINEMAEntities();
            DataList_Filmler.DataSource = ctx.Films.ToList();

            DataList_Filmler.DataBind();
        }
       

        protected void Page_Load(object sender, EventArgs e)
        {
            //açıklamaya bak

            if (IsPostBack)//tıklamadan sonra load işlemi gerceklesiyorsa çık.
                return;

            TabloGuncelle();
        }

        protected void btn_FilmKaydet_Click(object sender,EventArgs e)
        {
            Film f1 = new Film();
            f1.FilmAdi = txt_filmAd.Text;
            f1.FilmFragmanLink = txt_FilmFragman.Text;
            f1.FilmKisaBilgi = txt_Filmkisabilgi.Text;

            SINEMAEntities ctx = new SINEMAEntities();
            ctx.Films.Add(f1);
            ctx.SaveChanges();
            TabloGuncelle();
        }

        protected void DataList_Filmler_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int txtFilmID = Convert.ToInt32(e.CommandArgument);
            SINEMAEntities ctx = new SINEMAEntities();
            Film f1 = ctx.Films.Find(txtFilmID);

            ctx.Films.Remove(f1);
            
            ctx.SaveChanges();
            TabloGuncelle();

        }

        protected void DataList_Filmler_CancelCommand(object source, DataListCommandEventArgs e)
        {
            //Editleme ekranını kapatir
            DataList_Filmler.EditItemIndex = -1;
            TabloGuncelle();
        }

        protected void DataList_Filmler_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            int txtID = Convert.ToInt32(e.CommandArgument);
            TextBox txtFilmAd = e.Item.FindControl("txt_Guncelle_FilmAdi") as TextBox;
            TextBox txtFilmFragmanLink = e.Item.FindControl("txt_Guncelle_FilmFragmanLink") as TextBox;
            TextBox txtFilmBilgi = e.Item.FindControl("txt_Guncelle_FilmKisaBilgi") as TextBox;
            SINEMAEntities ctx = new SINEMAEntities();
            Film f1 = ctx.Films.Find(txtID);
            f1.FilmID = txtID;
            f1.FilmAdi = txtFilmAd.Text;
            f1.FilmFragmanLink = txtFilmFragmanLink.Text;
            f1.FilmKisaBilgi = txtFilmBilgi.Text;
            ctx.SaveChanges();
            DataList_Filmler.EditItemIndex = -1;
            TabloGuncelle();

        }

        protected void DataList_Filmler_EditCommand(object source, DataListCommandEventArgs e)
        {
            DataList_Filmler.EditItemIndex = e.Item.ItemIndex;
            TabloGuncelle();
        }
    }
}