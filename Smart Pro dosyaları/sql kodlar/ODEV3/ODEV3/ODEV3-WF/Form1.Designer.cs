namespace ODEV3_WF
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
               this.button_Guncelle = new System.Windows.Forms.Button();
               this.button_Kaydet = new System.Windows.Forms.Button();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.comboBox_Fakulte = new System.Windows.Forms.ComboBox();
               this.comboBox_Bolum = new System.Windows.Forms.ComboBox();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.textBox_AdSoyad = new System.Windows.Forms.TextBox();
               this.textBox_Numara = new System.Windows.Forms.TextBox();
               this.dataGridView_OgrenciListele = new System.Windows.Forms.DataGridView();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OgrenciListele)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.button_Guncelle);
               this.panel1.Controls.Add(this.button_Kaydet);
               this.panel1.Controls.Add(this.label4);
               this.panel1.Controls.Add(this.label3);
               this.panel1.Controls.Add(this.comboBox_Fakulte);
               this.panel1.Controls.Add(this.comboBox_Bolum);
               this.panel1.Controls.Add(this.label2);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Controls.Add(this.textBox_AdSoyad);
               this.panel1.Controls.Add(this.textBox_Numara);
               this.panel1.Location = new System.Drawing.Point(12, 50);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(220, 313);
               this.panel1.TabIndex = 0;
               // 
               // button_Guncelle
               // 
               this.button_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button_Guncelle.Location = new System.Drawing.Point(59, 249);
               this.button_Guncelle.Name = "button_Guncelle";
               this.button_Guncelle.Size = new System.Drawing.Size(86, 23);
               this.button_Guncelle.TabIndex = 9;
               this.button_Guncelle.Text = "GÜNCELLE";
               this.button_Guncelle.UseVisualStyleBackColor = true;
               this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
               // 
               // button_Kaydet
               // 
               this.button_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button_Kaydet.Location = new System.Drawing.Point(17, 220);
               this.button_Kaydet.Name = "button_Kaydet";
               this.button_Kaydet.Size = new System.Drawing.Size(180, 23);
               this.button_Kaydet.TabIndex = 8;
               this.button_Kaydet.Text = "TEMİZLE / KAYDET";
               this.button_Kaydet.UseVisualStyleBackColor = true;
               this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label4.Location = new System.Drawing.Point(13, 174);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(72, 20);
               this.label4.TabIndex = 7;
               this.label4.Text = "* Fakülte";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label3.Location = new System.Drawing.Point(29, 125);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(54, 20);
               this.label3.TabIndex = 6;
               this.label3.Text = "Bölüm";
               // 
               // comboBox_Fakulte
               // 
               this.comboBox_Fakulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.comboBox_Fakulte.FormattingEnabled = true;
               this.comboBox_Fakulte.Location = new System.Drawing.Point(89, 171);
               this.comboBox_Fakulte.Name = "comboBox_Fakulte";
               this.comboBox_Fakulte.Size = new System.Drawing.Size(108, 28);
               this.comboBox_Fakulte.TabIndex = 5;
               this.comboBox_Fakulte.Text = "Fakülte Seçiniz";
               // 
               // comboBox_Bolum
               // 
               this.comboBox_Bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.comboBox_Bolum.FormattingEnabled = true;
               this.comboBox_Bolum.Location = new System.Drawing.Point(89, 122);
               this.comboBox_Bolum.Name = "comboBox_Bolum";
               this.comboBox_Bolum.Size = new System.Drawing.Size(108, 28);
               this.comboBox_Bolum.TabIndex = 4;
               this.comboBox_Bolum.Text = "Bölüm Seçiniz";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label2.Location = new System.Drawing.Point(0, 79);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(88, 20);
               this.label2.TabIndex = 3;
               this.label2.Text = "* Ad Soyad";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label1.Location = new System.Drawing.Point(13, 36);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(75, 20);
               this.label1.TabIndex = 2;
               this.label1.Text = "* Numara";
               // 
               // textBox_AdSoyad
               // 
               this.textBox_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox_AdSoyad.Location = new System.Drawing.Point(89, 77);
               this.textBox_AdSoyad.Name = "textBox_AdSoyad";
               this.textBox_AdSoyad.Size = new System.Drawing.Size(108, 26);
               this.textBox_AdSoyad.TabIndex = 1;
               // 
               // textBox_Numara
               // 
               this.textBox_Numara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox_Numara.Location = new System.Drawing.Point(89, 33);
               this.textBox_Numara.Name = "textBox_Numara";
               this.textBox_Numara.Size = new System.Drawing.Size(108, 26);
               this.textBox_Numara.TabIndex = 0;
               // 
               // dataGridView_OgrenciListele
               // 
               this.dataGridView_OgrenciListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView_OgrenciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView_OgrenciListele.Location = new System.Drawing.Point(267, 50);
               this.dataGridView_OgrenciListele.Name = "dataGridView_OgrenciListele";
               this.dataGridView_OgrenciListele.Size = new System.Drawing.Size(308, 263);
               this.dataGridView_OgrenciListele.TabIndex = 1;
               this.dataGridView_OgrenciListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OgrenciListele_CellClick);
               this.dataGridView_OgrenciListele.MouseHover += new System.EventHandler(this.dataGridView_OgrenciListele_MouseHover);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(708, 375);
               this.Controls.Add(this.dataGridView_OgrenciListele);
               this.Controls.Add(this.panel1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OgrenciListele)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Button button_Guncelle;
          private System.Windows.Forms.Button button_Kaydet;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.ComboBox comboBox_Fakulte;
          private System.Windows.Forms.ComboBox comboBox_Bolum;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBox_AdSoyad;
          private System.Windows.Forms.TextBox textBox_Numara;
          private System.Windows.Forms.DataGridView dataGridView_OgrenciListele;
     }
}

