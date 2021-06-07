using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image oriImage;
        private Bitmap bmp;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            oriImage = pictureBox1.Image.Clone() as Image;
            pictureBox2.Image = oriImage;
        }
        private Bitmap ImageApply()
        {
            pictureBox1.Image.Dispose();
            pictureBox2.Image = oriImage.Clone() as Image;
            bmp = pictureBox2.Image as Bitmap;
            return bmp;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            bmp = ImageApply();
            int width = bmp.Width;
            int height = bmp.Height;

            Color colorData;
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    colorData = bmp.GetPixel(i, j);
                    int res = (colorData.R + colorData.G + colorData.B) / 3;
                    colorData = Color.FromArgb(res, res, res);
                    bmp.SetPixel(i, j, colorData);
                }
            }
        }
    }
}
