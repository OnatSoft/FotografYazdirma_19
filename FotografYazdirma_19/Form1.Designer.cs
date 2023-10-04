
namespace FotografYazdirma_19
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
            this.btn_ResimSec = new System.Windows.Forms.Button();
            this.btn_RenkSec = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Yazdir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BirinciSatir = new System.Windows.Forms.TextBox();
            this.txt_İkinciSatir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nutxt_MetinPunto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_MetinPunto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ResimSec
            // 
            this.btn_ResimSec.BackColor = System.Drawing.Color.Gold;
            this.btn_ResimSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ResimSec.Location = new System.Drawing.Point(154, 24);
            this.btn_ResimSec.Name = "btn_ResimSec";
            this.btn_ResimSec.Size = new System.Drawing.Size(136, 35);
            this.btn_ResimSec.TabIndex = 0;
            this.btn_ResimSec.Text = "Fotoğraf Seç";
            this.btn_ResimSec.UseVisualStyleBackColor = false;
            this.btn_ResimSec.Click += new System.EventHandler(this.btn_ResimSec_Click);
            // 
            // btn_RenkSec
            // 
            this.btn_RenkSec.BackColor = System.Drawing.Color.Gold;
            this.btn_RenkSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RenkSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RenkSec.Location = new System.Drawing.Point(296, 24);
            this.btn_RenkSec.Name = "btn_RenkSec";
            this.btn_RenkSec.Size = new System.Drawing.Size(136, 35);
            this.btn_RenkSec.TabIndex = 1;
            this.btn_RenkSec.Text = "Renk Seç";
            this.btn_RenkSec.UseVisualStyleBackColor = false;
            this.btn_RenkSec.Click += new System.EventHandler(this.btn_RenkSec_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Gold;
            this.btn_Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Kaydet.Location = new System.Drawing.Point(12, 24);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(136, 35);
            this.btn_Kaydet.TabIndex = 2;
            this.btn_Kaydet.Text = "Farklı Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.BackColor = System.Drawing.Color.Gold;
            this.btn_Yazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Yazdir.Location = new System.Drawing.Point(12, 306);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.Size = new System.Drawing.Size(186, 35);
            this.btn_Yazdir.TabIndex = 3;
            this.btn_Yazdir.Text = "Yazdır";
            this.btn_Yazdir.UseVisualStyleBackColor = false;
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birinci Satır:";
            // 
            // txt_BirinciSatir
            // 
            this.txt_BirinciSatir.Location = new System.Drawing.Point(12, 109);
            this.txt_BirinciSatir.Name = "txt_BirinciSatir";
            this.txt_BirinciSatir.Size = new System.Drawing.Size(186, 25);
            this.txt_BirinciSatir.TabIndex = 5;
            // 
            // txt_İkinciSatir
            // 
            this.txt_İkinciSatir.Location = new System.Drawing.Point(12, 160);
            this.txt_İkinciSatir.Name = "txt_İkinciSatir";
            this.txt_İkinciSatir.Size = new System.Drawing.Size(186, 25);
            this.txt_İkinciSatir.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "İkinci Satır (İsteğe bağlı):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(223, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // nutxt_MetinPunto
            // 
            this.nutxt_MetinPunto.Location = new System.Drawing.Point(12, 221);
            this.nutxt_MetinPunto.Name = "nutxt_MetinPunto";
            this.nutxt_MetinPunto.Size = new System.Drawing.Size(136, 25);
            this.nutxt_MetinPunto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Punto:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Kalınlık";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(990, 494);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nutxt_MetinPunto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_İkinciSatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BirinciSatir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Yazdir);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_RenkSec);
            this.Controls.Add(this.btn_ResimSec);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotoğraf Üzerine Yazı Yazdırma - V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_MetinPunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ResimSec;
        private System.Windows.Forms.Button btn_RenkSec;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Yazdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BirinciSatir;
        private System.Windows.Forms.TextBox txt_İkinciSatir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nutxt_MetinPunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

