using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sd
{
    public partial class salon : System.Web.UI.Page
    {
        protected void SalonEkle()
        {
            SINEMAEntities ctx = new SINEMAEntities();
            DataList_salon.DataSource=ctx.Salons.ToList();
            DataList_salon.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            SalonEkle();
            
        }

        protected void btn_SalonKaydet_Click(object sender, EventArgs e)
        {
            Salon s1 = new Salon();
            s1.SalonAdi = txt_salonAd.Text;

            SINEMAEntities ctx = new SINEMAEntities();
            ctx.Salons.Add(s1);
            ctx.SaveChanges();
            SalonEkle();
        }

        //protected void btn_SalonSil_Click(object sender, EventArgs e)
        //{
        //    Salon s1 = new Salon();
        //    s1.SalonAdi = txt_salonAd.Text;

        //    SINEMAEntities ctx = new SINEMAEntities();
        //    ctx.Salons.Add(s1);
        //    ctx.SaveChanges();
        //    SalonSil();
            
        //}

        protected void DataList_salon_EditCommand(object source, DataListCommandEventArgs e)
        {
            DataList_salon.EditItemIndex = e.Item.ItemIndex;
            SalonEkle();
        }

        protected void DataList_salon_CancelCommand(object source, DataListCommandEventArgs e)
        {
            DataList_salon.EditItemIndex = -1;
            SalonEkle();
        }

        protected void DataList_salon_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int txtSalonID = Convert.ToInt32(e.CommandArgument);
            SINEMAEntities ctx = new SINEMAEntities();
            Salon s1 = ctx.Salons.Find(txtSalonID);
            ctx.Salons.Remove(s1);
            ctx.SaveChanges();
            SalonEkle();
        }

        protected void DataList_salon_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            int salonID = Convert.ToInt32(e.CommandArgument);
            TextBox txtSalonAd = e.Item.FindControl("txt_Guncelle_SalonAdi") as TextBox;
            SINEMAEntities ctx = new SINEMAEntities();
            Salon f1 = ctx.Salons.Find(salonID);
            f1.SalonID = salonID;
            f1.SalonAdi = txtSalonAd.Text;
            ctx.SaveChanges();
            DataList_salon.EditItemIndex = -1;
            SalonEkle();
        }
    }
}