namespace XML1
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
               this.label_XML_Root_Label = new System.Windows.Forms.Label();
               this.label_XML_Root_Att_Label = new System.Windows.Forms.Label();
               this.listBox_Menu_Adlari = new System.Windows.Forms.ListBox();
               this.listBox_Menu_Detaylari = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // label_XML_Root_Label
               // 
               this.label_XML_Root_Label.AutoSize = true;
               this.label_XML_Root_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label_XML_Root_Label.Location = new System.Drawing.Point(250, 9);
               this.label_XML_Root_Label.Name = "label_XML_Root_Label";
               this.label_XML_Root_Label.Size = new System.Drawing.Size(148, 22);
               this.label_XML_Root_Label.TabIndex = 0;
               this.label_XML_Root_Label.Text = "XML_Root_Label";
               // 
               // label_XML_Root_Att_Label
               // 
               this.label_XML_Root_Att_Label.AutoSize = true;
               this.label_XML_Root_Att_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label_XML_Root_Att_Label.Location = new System.Drawing.Point(36, 338);
               this.label_XML_Root_Att_Label.Name = "label_XML_Root_Att_Label";
               this.label_XML_Root_Att_Label.Size = new System.Drawing.Size(180, 22);
               this.label_XML_Root_Att_Label.TabIndex = 1;
               this.label_XML_Root_Att_Label.Text = "XML_Root_Att_Label";
               // 
               // listBox_Menu_Adlari
               // 
               this.listBox_Menu_Adlari.FormattingEnabled = true;
               this.listBox_Menu_Adlari.Location = new System.Drawing.Point(40, 90);
               this.listBox_Menu_Adlari.Name = "listBox_Menu_Adlari";
               this.listBox_Menu_Adlari.Size = new System.Drawing.Size(120, 199);
               this.listBox_Menu_Adlari.TabIndex = 2;
               this.listBox_Menu_Adlari.SelectedIndexChanged += new System.EventHandler(this.listBox_Menu_Adlari_SelectedIndexChanged);
               // 
               // listBox_Menu_Detaylari
               // 
               this.listBox_Menu_Detaylari.FormattingEnabled = true;
               this.listBox_Menu_Detaylari.Location = new System.Drawing.Point(254, 90);
               this.listBox_Menu_Detaylari.Name = "listBox_Menu_Detaylari";
               this.listBox_Menu_Detaylari.Size = new System.Drawing.Size(120, 199);
               this.listBox_Menu_Detaylari.TabIndex = 3;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(620, 369);
               this.Controls.Add(this.listBox_Menu_Detaylari);
               this.Controls.Add(this.listBox_Menu_Adlari);
               this.Controls.Add(this.label_XML_Root_Att_Label);
               this.Controls.Add(this.label_XML_Root_Label);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label_XML_Root_Label;
          private System.Windows.Forms.Label label_XML_Root_Att_Label;
          private System.Windows.Forms.ListBox listBox_Menu_Adlari;
          private System.Windows.Forms.ListBox listBox_Menu_Detaylari;
     }
}

