using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, s, syc; s = int.Parse(textBox1.Text);
            syc = 0; for (i = 2; i <= s; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    { syc = syc + 1; }
                }
                if (syc < 3)
                {
                    label1.Text = "Asaldır"; listBox1.Items.Add(i.ToString());
                }
                syc = 0;
            }
        }
    }
}
