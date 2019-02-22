using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_fremework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.Click += Button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = TextBox1.Text;
            var password = TextBox2.Text;
            var errorMessage = "";
            var isError = false;

            var loginState = Login(username,password);

            if (string.IsNullOrEmpty(username))
            {
                errorMessage +=("Kullanici Adini Bos Gecemezsiniz :\r\n");
                isError=true;
            }

            if (string.IsNullOrEmpty(password))
            {
                errorMessage +=("\r\nSifreyi Bos Gecemezsiniz :");
               isError=true;
            }

            if (isError)
            {
                MessageBox.Show(errorMessage,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }



            if (loginState)
                MessageBox.Show("Başarili");
            else
                MessageBox.Show("Başarisiz");
        }

        public  bool  Login(string username,string password)
        {

           

            return false;
        }


        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
