namespace XML_Seralize_DeSerialize
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
               this.tbx_corba = new System.Windows.Forms.TextBox();
               this.tbx_anayemek = new System.Windows.Forms.TextBox();
               this.tbx_tatli = new System.Windows.Forms.TextBox();
               this.button_Kaydet = new System.Windows.Forms.Button();
               this.tbx_MenuAdi = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // tbx_corba
               // 
               this.tbx_corba.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.tbx_corba.Location = new System.Drawing.Point(712, 279);
               this.tbx_corba.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
               this.tbx_corba.Name = "tbx_corba";
               this.tbx_corba.Size = new System.Drawing.Size(356, 27);
               this.tbx_corba.TabIndex = 0;
               // 
               // tbx_anayemek
               // 
               this.tbx_anayemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.tbx_anayemek.Location = new System.Drawing.Point(712, 367);
               this.tbx_anayemek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
               this.tbx_anayemek.Name = "tbx_anayemek";
               this.tbx_anayemek.Size = new System.Drawing.Size(356, 27);
               this.tbx_anayemek.TabIndex = 1;
               // 
               // tbx_tatli
               // 
               this.tbx_tatli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.tbx_tatli.Location = new System.Drawing.Point(712, 463);
               this.tbx_tatli.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
               this.tbx_tatli.Name = "tbx_tatli";
               this.tbx_tatli.Size = new System.Drawing.Size(356, 27);
               this.tbx_tatli.TabIndex = 2;
               // 
               // button_Kaydet
               // 
               this.button_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button_Kaydet.Location = new System.Drawing.Point(754, 527);
               this.button_Kaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
               this.button_Kaydet.Name = "button_Kaydet";
               this.button_Kaydet.Size = new System.Drawing.Size(290, 175);
               this.button_Kaydet.TabIndex = 3;
               this.button_Kaydet.Text = "KAYDET";
               this.button_Kaydet.UseVisualStyleBackColor = true;
               this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
               // 
               // tbx_MenuAdi
               // 
               this.tbx_MenuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.tbx_MenuAdi.Location = new System.Drawing.Point(712, 194);
               this.tbx_MenuAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
               this.tbx_MenuAdi.Name = "tbx_MenuAdi";
               this.tbx_MenuAdi.Size = new System.Drawing.Size(356, 27);
               this.tbx_MenuAdi.TabIndex = 4;
               // 
               // label1
               // 
               this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label1.Location = new System.Drawing.Point(50, 37);
               this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(604, 717);
               this.label1.TabIndex = 5;
               this.label1.Text = "label1";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1256, 741);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.tbx_MenuAdi);
               this.Controls.Add(this.button_Kaydet);
               this.Controls.Add(this.tbx_tatli);
               this.Controls.Add(this.tbx_anayemek);
               this.Controls.Add(this.tbx_corba);
               this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox tbx_corba;
          private System.Windows.Forms.TextBox tbx_anayemek;
          private System.Windows.Forms.TextBox tbx_tatli;
          private System.Windows.Forms.Button button_Kaydet;
          private System.Windows.Forms.TextBox tbx_MenuAdi;
          private System.Windows.Forms.Label label1;
     }
}

