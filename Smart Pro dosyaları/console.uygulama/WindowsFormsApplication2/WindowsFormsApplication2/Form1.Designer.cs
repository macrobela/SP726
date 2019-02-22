namespace WindowsFormsApplication2
{
    partial class Form_AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AnaEkran));
            this.Label_baslık = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label_Ad = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.buton_kaydet = new System.Windows.Forms.Button();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label_TC = new System.Windows.Forms.Label();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_dogum = new System.Windows.Forms.DateTimePicker();
            this.label_BT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_baslık
            // 
            this.Label_baslık.AutoSize = true;
            this.Label_baslık.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_baslık.Location = new System.Drawing.Point(133, 20);
            this.Label_baslık.Name = "Label_baslık";
            this.Label_baslık.Size = new System.Drawing.Size(313, 32);
            this.Label_baslık.TabIndex = 0;
            this.Label_baslık.Text = "Kullanici Kayit İşlemleri";
            this.Label_baslık.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(309, 132);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(8);
            this.txt_Ad.Multiline = true;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 30);
            this.txt_Ad.TabIndex = 4;
            // 
            // label_Ad
            // 
            this.label_Ad.AutoSize = true;
            this.label_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Ad.Location = new System.Drawing.Point(158, 142);
            this.label_Ad.Name = "label_Ad";
            this.label_Ad.Size = new System.Drawing.Size(31, 20);
            this.label_Ad.TabIndex = 3;
            this.label_Ad.Text = "Ad";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.Location = new System.Drawing.Point(158, 189);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 20);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Soyad";
            // 
            // buton_kaydet
            // 
            this.buton_kaydet.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton_kaydet.Location = new System.Drawing.Point(237, 321);
            this.buton_kaydet.Name = "buton_kaydet";
            this.buton_kaydet.Size = new System.Drawing.Size(136, 47);
            this.buton_kaydet.TabIndex = 9;
            this.buton_kaydet.Text = "KAYDET";
            this.buton_kaydet.UseVisualStyleBackColor = true;
            this.buton_kaydet.Click += new System.EventHandler(this.buton_kaydet_Click);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(309, 178);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(8);
            this.txt_Soyad.Multiline = true;
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(100, 31);
            this.txt_Soyad.TabIndex = 6;
            // 
            // label_TC
            // 
            this.label_TC.AutoSize = true;
            this.label_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_TC.Location = new System.Drawing.Point(158, 96);
            this.label_TC.Name = "label_TC";
            this.label_TC.Size = new System.Drawing.Size(119, 20);
            this.label_TC.TabIndex = 1;
            this.label_TC.Text = "TC Numarasi";
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(309, 86);
            this.txt_TC.Margin = new System.Windows.Forms.Padding(8);
            this.txt_TC.Multiline = true;
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(100, 30);
            this.txt_TC.TabIndex = 2;
            // 
            // dateTimePicker1_dogum
            // 
            this.dateTimePicker1_dogum.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1_dogum.Location = new System.Drawing.Point(309, 243);
            this.dateTimePicker1_dogum.Name = "dateTimePicker1_dogum";
            this.dateTimePicker1_dogum.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1_dogum.TabIndex = 8;
            // 
            // label_BT
            // 
            this.label_BT.AutoSize = true;
            this.label_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_BT.Location = new System.Drawing.Point(158, 245);
            this.label_BT.Name = "label_BT";
            this.label_BT.Size = new System.Drawing.Size(122, 20);
            this.label_BT.TabIndex = 7;
            this.label_BT.Text = "Dogum Tarihi";
            // 
            // Form_AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(779, 424);
            this.Controls.Add(this.label_BT);
            this.Controls.Add(this.dateTimePicker1_dogum);
            this.Controls.Add(this.label_TC);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.buton_kaydet);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label_Ad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.Label_baslık);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AnaEkran";
            this.Text = "404 İlk form uygulaması";
            this.Load += new System.EventHandler(this.Form_AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_baslık;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label_Ad;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button buton_kaydet;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label_TC;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_dogum;
        private System.Windows.Forms.Label label_BT;
    }
}

