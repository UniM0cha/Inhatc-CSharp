using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시계
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now.ToLocalTime();
            int hour = t.Hour;
            int minute = t.Minute;
            int second = t.Second;

            if (hour < 12)
            {
                //label에 오전 표시
                label1.Text = "오전";
            }
            else
            {
                //label에 오후 표시
                label1.Text = "오후";
            }
            int fH = hour / 10;
            int rH = hour % 10;
            if (hour < 10)
            {
                //pictureBox1을 안보이게 하고
                //pictureBox2에 뒷자리 그림을 출력
                pictureBox1.Visible = false;
                Bitmap p2 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + rH + ".png");
                pictureBox2.Image = p2;
            }
            else
            {
                pictureBox1.Visible = true;
                Bitmap p1 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + fH + ".png");
                pictureBox1.Image = p1;
                Bitmap p2 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + rH + ".png");
                pictureBox2.Image = p2;
            }

            int fM = minute / 10;
            int rM = minute % 10;
            if (minute < 10)
            {
                //pictureBox3을 안보이게
                pictureBox3.Visible = false;
                //pictureBox4를 뒷자리.png 출력
                Bitmap p4 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + fM + ".png");
                pictureBox4.Image = p4;
            }
            else
            {
                pictureBox3.Visible = true;
                Bitmap p3 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + fM + ".png");
                pictureBox3.Image = p3;
                Bitmap p4 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + rM + ".png");
                pictureBox4.Image = p4;
            }

            int fS = second / 10;
            int rS = second % 10;
            if (second < 10)
            {
                //pictureBox3을 안보이게
                pictureBox5.Visible = false;
                //pictureBox4를 뒷자리.png 출력
                Bitmap p6 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + rS + ".png");
                pictureBox6.Image = p6;
            }
            else
            {
                pictureBox5.Visible = true;
                Bitmap p5 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + fS + ".png");
                pictureBox5.Image = p5;
                Bitmap p6 = new Bitmap(@"C:\Users\PC\Desktop\201845092_이정윤\이미지\" + rS + ".png");
                pictureBox6.Image = p6;
            }
        }
    }
}
