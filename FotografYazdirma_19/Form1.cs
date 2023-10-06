using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FotografYazdirma_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim;
        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resim = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(resim);
            }
        }

        Color renk;
        private void btn_RenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Font font;
        private void btn_FontSec_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            font = fontDialog1.Font;
        }

        Bitmap bmp;
        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            try
            {
                bmp = new Bitmap(resim);
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawString(txt_BirinciSatir.Text, new Font(font.ToString(), Convert.ToInt16(nutxt_MetinPunto.Value)), new SolidBrush(renk), Convert.ToInt16(nutxt_XKonum.Value), Convert.ToInt16(nutxt_YKonum.Value));

                //switch (checkBox2.Checked) // Fontu italik ayarlama
                //{
                //    case true:
                //        gr.DrawString(txt_BirinciSatir.Text, new Font("SEGOE UI", Convert.ToInt16(nutxt_MetinPunto.Value), FontStyle.Italic), new SolidBrush(renk), Convert.ToInt16(nutxt_XKonum.Value), Convert.ToInt16(nutxt_YKonum.Value));
                //        break;
                //    case false:
                //        gr.DrawString(txt_BirinciSatir.Text, new Font("SEGOE UI", Convert.ToInt16(nutxt_MetinPunto.Value)), new SolidBrush(renk), Convert.ToInt16(nutxt_XKonum.Value), Convert.ToInt16(nutxt_YKonum.Value));
                //        break;
                //}
                pictureBox1.Image = bmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Fotoğraf çıktı alınırken bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.Title = "Fotoğrafı Farklı Kaydet";
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Dosyası|.png | JPEG Dosyası|.jpg";
            
        }
    }
}
