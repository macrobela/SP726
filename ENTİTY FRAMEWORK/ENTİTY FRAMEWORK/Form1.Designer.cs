namespace ENTİTY_FRAMEWORK
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_KisaBilgi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FilmFragman = new System.Windows.Forms.TextBox();
            this.btn_FilmKaydet = new System.Windows.Forms.Button();
            this.textBox_FilmAdi_1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_SalonAdi = new System.Windows.Forms.ComboBox();
            this.comboBox_FilmAdi = new System.Windows.Forms.ComboBox();
            this.btn_YayinEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTP_YayinZamani = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SalonEkle = new System.Windows.Forms.Button();
            this.textBox_SalonAdi_1 = new System.Windows.Forms.TextBox();
            this.dataGV_GroupBy = new System.Windows.Forms.DataGridView();
            this.dataGV_YayinTablo = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_GroupBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_YayinTablo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_KisaBilgi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_FilmFragman);
            this.panel1.Controls.Add(this.btn_FilmKaydet);
            this.panel1.Controls.Add(this.textBox_FilmAdi_1);
            this.panel1.Location = new System.Drawing.Point(6, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 292);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Film Özeti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Film Fragmanı :";
            // 
            // textBox_KisaBilgi
            // 
            this.textBox_KisaBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KisaBilgi.Location = new System.Drawing.Point(157, 171);
            this.textBox_KisaBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KisaBilgi.Multiline = true;
            this.textBox_KisaBilgi.Name = "textBox_KisaBilgi";
            this.textBox_KisaBilgi.Size = new System.Drawing.Size(315, 105);
            this.textBox_KisaBilgi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Adı :";
            // 
            // textBox_FilmFragman
            // 
            this.textBox_FilmFragman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmFragman.Location = new System.Drawing.Point(157, 105);
            this.textBox_FilmFragman.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_FilmFragman.Name = "textBox_FilmFragman";
            this.textBox_FilmFragman.Size = new System.Drawing.Size(315, 30);
            this.textBox_FilmFragman.TabIndex = 6;
            // 
            // btn_FilmKaydet
            // 
            this.btn_FilmKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_FilmKaydet.Location = new System.Drawing.Point(343, 26);
            this.btn_FilmKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FilmKaydet.Name = "btn_FilmKaydet";
            this.btn_FilmKaydet.Size = new System.Drawing.Size(131, 36);
            this.btn_FilmKaydet.TabIndex = 1;
            this.btn_FilmKaydet.Text = "Film Ekle";
            this.btn_FilmKaydet.UseVisualStyleBackColor = true;
            // 
            // textBox_FilmAdi_1
            // 
            this.textBox_FilmAdi_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmAdi_1.Location = new System.Drawing.Point(157, 27);
            this.textBox_FilmAdi_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_FilmAdi_1.Name = "textBox_FilmAdi_1";
            this.textBox_FilmAdi_1.Size = new System.Drawing.Size(176, 30);
            this.textBox_FilmAdi_1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox_SalonAdi);
            this.panel3.Controls.Add(this.comboBox_FilmAdi);
            this.panel3.Controls.Add(this.btn_YayinEkle);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dateTP_YayinZamani);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(6, 398);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 250);
            this.panel3.TabIndex = 12;
            // 
            // comboBox_SalonAdi
            // 
            this.comboBox_SalonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_SalonAdi.FormattingEnabled = true;
            this.comboBox_SalonAdi.Location = new System.Drawing.Point(184, 86);
            this.comboBox_SalonAdi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_SalonAdi.Name = "comboBox_SalonAdi";
            this.comboBox_SalonAdi.Size = new System.Drawing.Size(176, 33);
            this.comboBox_SalonAdi.TabIndex = 9;
            // 
            // comboBox_FilmAdi
            // 
            this.comboBox_FilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_FilmAdi.FormattingEnabled = true;
            this.comboBox_FilmAdi.Location = new System.Drawing.Point(184, 31);
            this.comboBox_FilmAdi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_FilmAdi.Name = "comboBox_FilmAdi";
            this.comboBox_FilmAdi.Size = new System.Drawing.Size(176, 33);
            this.comboBox_FilmAdi.TabIndex = 8;
            // 
            // btn_YayinEkle
            // 
            this.btn_YayinEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YayinEkle.Location = new System.Drawing.Point(205, 180);
            this.btn_YayinEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_YayinEkle.Name = "btn_YayinEkle";
            this.btn_YayinEkle.Size = new System.Drawing.Size(131, 48);
            this.btn_YayinEkle.TabIndex = 3;
            this.btn_YayinEkle.Text = "Yayın Ekle";
            this.btn_YayinEkle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yayın Zamanı :";
            // 
            // dateTP_YayinZamani
            // 
            this.dateTP_YayinZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTP_YayinZamani.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTP_YayinZamani.Location = new System.Drawing.Point(184, 140);
            this.dateTP_YayinZamani.Margin = new System.Windows.Forms.Padding(4);
            this.dateTP_YayinZamani.Name = "dateTP_YayinZamani";
            this.dateTP_YayinZamani.Size = new System.Drawing.Size(176, 30);
            this.dateTP_YayinZamani.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salon Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Film Adı :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_SalonEkle);
            this.panel2.Controls.Add(this.textBox_SalonAdi_1);
            this.panel2.Location = new System.Drawing.Point(6, 306);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 74);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salon Adı :";
            // 
            // btn_SalonEkle
            // 
            this.btn_SalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SalonEkle.Location = new System.Drawing.Point(323, 22);
            this.btn_SalonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SalonEkle.Name = "btn_SalonEkle";
            this.btn_SalonEkle.Size = new System.Drawing.Size(131, 37);
            this.btn_SalonEkle.TabIndex = 1;
            this.btn_SalonEkle.Text = "Salon Ekle";
            this.btn_SalonEkle.UseVisualStyleBackColor = true;
            // 
            // textBox_SalonAdi_1
            // 
            this.textBox_SalonAdi_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_SalonAdi_1.Location = new System.Drawing.Point(137, 23);
            this.textBox_SalonAdi_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SalonAdi_1.Name = "textBox_SalonAdi_1";
            this.textBox_SalonAdi_1.Size = new System.Drawing.Size(176, 30);
            this.textBox_SalonAdi_1.TabIndex = 0;
            // 
            // dataGV_GroupBy
            // 
            this.dataGV_GroupBy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_GroupBy.BackgroundColor = System.Drawing.Color.White;
            this.dataGV_GroupBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_GroupBy.Location = new System.Drawing.Point(28, 401);
            this.dataGV_GroupBy.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_GroupBy.Name = "dataGV_GroupBy";
            this.dataGV_GroupBy.Size = new System.Drawing.Size(476, 228);
            this.dataGV_GroupBy.TabIndex = 1;
            // 
            // dataGV_YayinTablo
            // 
            this.dataGV_YayinTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_YayinTablo.BackgroundColor = System.Drawing.Color.White;
            this.dataGV_YayinTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_YayinTablo.Location = new System.Drawing.Point(28, 27);
            this.dataGV_YayinTablo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_YayinTablo.Name = "dataGV_YayinTablo";
            this.dataGV_YayinTablo.Size = new System.Drawing.Size(476, 348);
            this.dataGV_YayinTablo.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dataGV_GroupBy);
            this.panel4.Controls.Add(this.dataGV_YayinTablo);
            this.panel4.Location = new System.Drawing.Point(520, -3);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 634);
            this.panel4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_GroupBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_YayinTablo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_KisaBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FilmFragman;
        private System.Windows.Forms.Button btn_FilmKaydet;
        private System.Windows.Forms.TextBox textBox_FilmAdi_1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_SalonAdi;
        private System.Windows.Forms.ComboBox comboBox_FilmAdi;
        private System.Windows.Forms.Button btn_YayinEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTP_YayinZamani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SalonEkle;
        private System.Windows.Forms.TextBox textBox_SalonAdi_1;
        private System.Windows.Forms.DataGridView dataGV_GroupBy;
        private System.Windows.Forms.DataGridView dataGV_YayinTablo;
        private System.Windows.Forms.Panel panel4;
    }
}

