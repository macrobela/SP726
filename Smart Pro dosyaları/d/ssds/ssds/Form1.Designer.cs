namespace ssds
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ogretmen_sil = new System.Windows.Forms.Button();
            this.ogretmen_kaydet = new System.Windows.Forms.Button();
            this.ogretmen_guncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ogrenci_ekle = new System.Windows.Forms.Button();
            this.ogrenci_guncelle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.ogretmen_sil);
            this.panel1.Controls.Add(this.ogretmen_kaydet);
            this.panel1.Controls.Add(this.ogretmen_guncelle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 181);
            this.panel1.TabIndex = 0;
            // 
            // ogretmen_sil
            // 
            this.ogretmen_sil.Location = new System.Drawing.Point(87, 146);
            this.ogretmen_sil.Name = "ogretmen_sil";
            this.ogretmen_sil.Size = new System.Drawing.Size(96, 23);
            this.ogretmen_sil.TabIndex = 7;
            this.ogretmen_sil.Text = "SİL";
            this.ogretmen_sil.UseVisualStyleBackColor = true;
            this.ogretmen_sil.Click += new System.EventHandler(this.ogretmen_sil_Click);
            // 
            // ogretmen_kaydet
            // 
            this.ogretmen_kaydet.Location = new System.Drawing.Point(152, 119);
            this.ogretmen_kaydet.Name = "ogretmen_kaydet";
            this.ogretmen_kaydet.Size = new System.Drawing.Size(96, 24);
            this.ogretmen_kaydet.TabIndex = 6;
            this.ogretmen_kaydet.Text = "EKLE";
            this.ogretmen_kaydet.UseVisualStyleBackColor = true;
            this.ogretmen_kaydet.Click += new System.EventHandler(this.ogretmen_kaydet_Click);
            // 
            // ogretmen_guncelle
            // 
            this.ogretmen_guncelle.Location = new System.Drawing.Point(29, 119);
            this.ogretmen_guncelle.Name = "ogretmen_guncelle";
            this.ogretmen_guncelle.Size = new System.Drawing.Size(96, 24);
            this.ogretmen_guncelle.TabIndex = 5;
            this.ogretmen_guncelle.Text = "GÜNCELLE";
            this.ogretmen_guncelle.UseVisualStyleBackColor = true;
            this.ogretmen_guncelle.Click += new System.EventHandler(this.ogretmen_guncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "AktifCalisan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRETMEN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 172);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.ogrenci_ekle);
            this.panel2.Controls.Add(this.ogrenci_guncelle);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(17, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 161);
            this.panel2.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Mezun Mu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ogrenci_ekle
            // 
            this.ogrenci_ekle.Location = new System.Drawing.Point(119, 123);
            this.ogrenci_ekle.Name = "ogrenci_ekle";
            this.ogrenci_ekle.Size = new System.Drawing.Size(96, 26);
            this.ogrenci_ekle.TabIndex = 6;
            this.ogrenci_ekle.Text = "EKLE";
            this.ogrenci_ekle.UseVisualStyleBackColor = true;
            // 
            // ogrenci_guncelle
            // 
            this.ogrenci_guncelle.Location = new System.Drawing.Point(17, 123);
            this.ogrenci_guncelle.Name = "ogrenci_guncelle";
            this.ogrenci_guncelle.Size = new System.Drawing.Size(96, 26);
            this.ogrenci_guncelle.TabIndex = 5;
            this.ogrenci_guncelle.Text = "GÜNCELLE";
            this.ogrenci_guncelle.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(76, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ÖGRENCİ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(276, 197);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(528, 161);
            this.dataGridView2.TabIndex = 9;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(136, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 364);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ogretmen_sil;
        private System.Windows.Forms.Button ogretmen_kaydet;
        private System.Windows.Forms.Button ogretmen_guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ogrenci_ekle;
        private System.Windows.Forms.Button ogrenci_guncelle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}

