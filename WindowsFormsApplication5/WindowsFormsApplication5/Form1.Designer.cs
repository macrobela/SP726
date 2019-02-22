namespace WindowsFormsApplication5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1_ad = new System.Windows.Forms.TextBox();
            this.textBox2_soyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobax_sehir = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1_ad
            // 
            this.textBox1_ad.Location = new System.Drawing.Point(54, 358);
            this.textBox1_ad.Name = "textBox1_ad";
            this.textBox1_ad.Size = new System.Drawing.Size(100, 22);
            this.textBox1_ad.TabIndex = 1;
            // 
            // textBox2_soyad
            // 
            this.textBox2_soyad.Location = new System.Drawing.Point(245, 358);
            this.textBox2_soyad.Name = "textBox2_soyad";
            this.textBox2_soyad.Size = new System.Drawing.Size(100, 22);
            this.textBox2_soyad.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(250, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(428, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sehir";
            // 
            // combobax_sehir
            // 
            this.combobax_sehir.FormattingEnabled = true;
            this.combobax_sehir.Items.AddRange(new object[] {
            "Erzincan",
            "Igdır",
            "Sakarya",
            "Hatay",
            "Düzce",
            "Mus",
            "Sivas",
            "İstanbul",
            "Batman",
            "Hakkari",
            "Sinop",
            "Diyarbakır",
            "Mardin"});
            this.combobax_sehir.Location = new System.Drawing.Point(433, 358);
            this.combobax_sehir.Name = "combobax_sehir";
            this.combobax_sehir.Size = new System.Drawing.Size(121, 24);
            this.combobax_sehir.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 67);
            this.button3.TabIndex = 10;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 404);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combobax_sehir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_soyad);
            this.Controls.Add(this.textBox1_ad);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1_ad;
        private System.Windows.Forms.TextBox textBox2_soyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobax_sehir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

