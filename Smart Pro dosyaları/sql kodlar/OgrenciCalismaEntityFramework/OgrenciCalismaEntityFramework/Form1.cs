using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciCalismaEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Entity entity = new Entity();
        SqlConnection con;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=localhost;database=OrnekCalisma;user=sa;password=1234");
            if (con.State==ConnectionState.Closed)
                con.Open();
            listeleTemizle();
        }
        private void temizle() 
        {
            txtDoktorID.Text = "";
            txtHastaID.Text = "";
        }
        private void listeleTemizle() 
        {
            dgVTumListe.DataSource = null;
            dgVTumListe.Rows.Clear();

            cmd = new SqlCommand("proc_randevu_listele", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dgVTumListe.DataSource = dt;
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            listeleTemizle();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            entity.DoktorID = Convert.ToInt32(txtDoktorID.Text);
            entity.HastaID = Convert.ToInt32(txtHastaID.Text);
            entity.RandevuZaman = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            cmd = new SqlCommand("proc_randevu_kaydet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@randevuZaman", Convert.ToDateTime(entity.RandevuZaman));
            cmd.Parameters.AddWithValue("@hastaID", Convert.ToInt16(entity.HastaID));
            cmd.Parameters.AddWithValue("@doktorID", Convert.ToInt16(entity.DoktorID));
            try
            {
                cmd.ExecuteNonQuery();
                listeleTemizle();
                temizle();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption adding account. " + ex.Message);
            }
        }
        private void dgVTumListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili olanı silmek istiyormusunuz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                //MessageBox.Show(dgVTumListe.CurrentRow.Cells[2].Value.ToString());
                entity.RandevuID = Convert.ToInt16(dgVTumListe.CurrentRow.Cells[2].Value.ToString());
                cmd = new SqlCommand("proc_randevu_sil", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@randevuID", Convert.ToInt16(entity.RandevuID));
                try
                {
                    cmd.ExecuteNonQuery();
                    listeleTemizle();
                }
                catch (Exception ex)
                {
                    throw new Exception("Execption adding account. " + ex.Message);
                }
            }
        }
        
    }
}
