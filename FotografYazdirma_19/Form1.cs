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
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }

        Color renk;
        private void btn_RenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp;
        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_BirinciSatir.Text != "" && nutxt_MetinPunto.Value != null)
                {
                    //Font = new Font("SEGOE UI", Convert.ToInt16(nutxt_MetinPunto.Value), FontStyle.Bold);

                    bmp = new Bitmap(resim);
                    Graphics gr = Graphics.FromImage(bmp);
                    gr.DrawString(txt_BirinciSatir.Text + "\n" + txt_İkinciSatir.Text, new Font("SEGOE UI", Convert.ToInt16(nutxt_MetinPunto.Value)), new SolidBrush(renk), 650, 250);
                    pictureBox1.Image = bmp;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Metin fotoğraf üzerine yazdırılamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.png";
            saveFileDialog1.ShowDialog();
            saveFileDialog1.Title = "Fotoğrafı Farklı Kaydet";
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
