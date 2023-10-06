
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nutxt_MetinPunto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nutxt_XKonum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nutxt_YKonum = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_FontSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_MetinPunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_XKonum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_YKonum)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ResimSec
            // 
            this.btn_ResimSec.BackColor = System.Drawing.Color.Violet;
            this.btn_ResimSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ResimSec.Location = new System.Drawing.Point(154, 12);
            this.btn_ResimSec.Name = "btn_ResimSec";
            this.btn_ResimSec.Size = new System.Drawing.Size(136, 35);
            this.btn_ResimSec.TabIndex = 0;
            this.btn_ResimSec.Text = "Fotoğraf Seç";
            this.btn_ResimSec.UseVisualStyleBackColor = false;
            this.btn_ResimSec.Click += new System.EventHandler(this.btn_ResimSec_Click);
            // 
            // btn_RenkSec
            // 
            this.btn_RenkSec.BackColor = System.Drawing.Color.Violet;
            this.btn_RenkSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RenkSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RenkSec.Location = new System.Drawing.Point(296, 12);
            this.btn_RenkSec.Name = "btn_RenkSec";
            this.btn_RenkSec.Size = new System.Drawing.Size(136, 35);
            this.btn_RenkSec.TabIndex = 1;
            this.btn_RenkSec.Text = "Renk Seç";
            this.btn_RenkSec.UseVisualStyleBackColor = false;
            this.btn_RenkSec.Click += new System.EventHandler(this.btn_RenkSec_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Violet;
            this.btn_Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Kaydet.Location = new System.Drawing.Point(12, 12);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(136, 35);
            this.btn_Kaydet.TabIndex = 2;
            this.btn_Kaydet.Text = "Farklı Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.BackColor = System.Drawing.Color.Violet;
            this.btn_Yazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Yazdir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yazdir.Location = new System.Drawing.Point(36, 428);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.Size = new System.Drawing.Size(200, 48);
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
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birinci Satır:";
            // 
            // txt_BirinciSatir
            // 
            this.txt_BirinciSatir.Location = new System.Drawing.Point(12, 99);
            this.txt_BirinciSatir.Multiline = true;
            this.txt_BirinciSatir.Name = "txt_BirinciSatir";
            this.txt_BirinciSatir.Size = new System.Drawing.Size(238, 95);
            this.txt_BirinciSatir.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(298, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // nutxt_MetinPunto
            // 
            this.nutxt_MetinPunto.Location = new System.Drawing.Point(36, 234);
            this.nutxt_MetinPunto.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nutxt_MetinPunto.Name = "nutxt_MetinPunto";
            this.nutxt_MetinPunto.Size = new System.Drawing.Size(76, 25);
            this.nutxt_MetinPunto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 211);
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
            this.checkBox1.Location = new System.Drawing.Point(18, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Kalınlık";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // nutxt_XKonum
            // 
            this.nutxt_XKonum.Location = new System.Drawing.Point(36, 292);
            this.nutxt_XKonum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nutxt_XKonum.Name = "nutxt_XKonum";
            this.nutxt_XKonum.Size = new System.Drawing.Size(76, 25);
            this.nutxt_XKonum.TabIndex = 12;
            this.nutxt_XKonum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yatay Konum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(136, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dikey Konum:";
            // 
            // nutxt_YKonum
            // 
            this.nutxt_YKonum.Location = new System.Drawing.Point(140, 292);
            this.nutxt_YKonum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nutxt_YKonum.Name = "nutxt_YKonum";
            this.nutxt_YKonum.Size = new System.Drawing.Size(76, 25);
            this.nutxt_YKonum.TabIndex = 14;
            this.nutxt_YKonum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(100, 336);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 24);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "İtalik";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(166, 336);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 24);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Altı Çizili";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // btn_FontSec
            // 
            this.btn_FontSec.BackColor = System.Drawing.Color.Violet;
            this.btn_FontSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FontSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FontSec.Location = new System.Drawing.Point(438, 12);
            this.btn_FontSec.Name = "btn_FontSec";
            this.btn_FontSec.Size = new System.Drawing.Size(136, 35);
            this.btn_FontSec.TabIndex = 18;
            this.btn_FontSec.Text = "Yazı Tipi Seç";
            this.btn_FontSec.UseVisualStyleBackColor = false;
            this.btn_FontSec.Click += new System.EventHandler(this.btn_FontSec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1210, 634);
            this.Controls.Add(this.btn_FontSec);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nutxt_YKonum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nutxt_XKonum);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nutxt_MetinPunto);
            this.Controls.Add(this.pictureBox1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_MetinPunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_XKonum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutxt_YKonum)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nutxt_MetinPunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nutxt_XKonum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nutxt_YKonum;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_FontSec;
    }
}

