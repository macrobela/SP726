namespace Şubat15_XML
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
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.gBoxOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.listOgrenciBilgileri = new System.Windows.Forms.ListBox();
            this.gBoxOgrenciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciNo.Location = new System.Drawing.Point(21, 36);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(92, 20);
            this.lblOgrenciNo.TabIndex = 0;
            this.lblOgrenciNo.Text = "Öğrenci No:";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciNo.Location = new System.Drawing.Point(119, 33);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(100, 26);
            this.txtOgrenciNo.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(238, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 36);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // gBoxOgrenciBilgileri
            // 
            this.gBoxOgrenciBilgileri.Controls.Add(this.listOgrenciBilgileri);
            this.gBoxOgrenciBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxOgrenciBilgileri.Location = new System.Drawing.Point(12, 78);
            this.gBoxOgrenciBilgileri.Name = "gBoxOgrenciBilgileri";
            this.gBoxOgrenciBilgileri.Size = new System.Drawing.Size(288, 240);
            this.gBoxOgrenciBilgileri.TabIndex = 3;
            this.gBoxOgrenciBilgileri.TabStop = false;
            this.gBoxOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // listOgrenciBilgileri
            // 
            this.listOgrenciBilgileri.FormattingEnabled = true;
            this.listOgrenciBilgileri.ItemHeight = 20;
            this.listOgrenciBilgileri.Location = new System.Drawing.Point(15, 25);
            this.listOgrenciBilgileri.Name = "listOgrenciBilgileri";
            this.listOgrenciBilgileri.Size = new System.Drawing.Size(273, 184);
            this.listOgrenciBilgileri.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 318);
            this.Controls.Add(this.gBoxOgrenciBilgileri);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.lblOgrenciNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxOgrenciBilgileri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox gBoxOgrenciBilgileri;
        private System.Windows.Forms.ListBox listOgrenciBilgileri;
    }
}

