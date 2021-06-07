using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        int shape;
        Point ptStart;
        Point ptEnd;
        Pen myPen;
        int rtWidth;
        int rtHeight;
        Boolean bPress;
        Graphics g;
        Rectangle rect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shape = 0;
            ptStart = new Point(0, 0);
            ptEnd = new Point(0, 0);
            myPen = new Pen(Color.Black, 1);
            rtWidth = 0;
            rtHeight = 0;
            bPress = false;
            g = Graphics.FromHwnd(this.Handle);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bPress = true;
            ptStart.X = e.X;
            ptStart.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(shape == 0)
            {
                if(bPress)
                {
                    g.Clear(Color.White);
                    ptEnd = new Point(e.X, e.Y);
                    g.DrawLine(myPen, ptStart, ptEnd);
                }
            }
            else if(shape == 1)
            {
                if(bPress)
                {
                    g.Clear(Color.White);
                    rtWidth = Math.Abs(e.X - ptStart.X);
                    rtHeight = Math.Abs(e.Y - ptStart.Y);

                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                    g.DrawRectangle(myPen, rect);
                }
            }
            else if (shape == 2)
            {
                if (bPress)
                {
                    g.Clear(Color.White);
                    rtWidth = Math.Abs(e.X - ptStart.X);
                    rtHeight = Math.Abs(e.Y - ptStart.Y);

                    if (rtWidth == 0)
                        rtWidth = 1;

                    if (rtHeight == 0)
                        rtHeight = 1;

                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                    g.DrawArc(myPen, rect, 0, 365);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(shape == 0)
            {
                ptEnd = new Point(e.X, e.Y);
                g.DrawLine(myPen, ptStart, ptEnd);
            }
            else if (shape == 1)
            {
                rtWidth = Math.Abs(e.X - ptStart.X);
                rtHeight = Math.Abs(e.Y - ptStart.Y);

                rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                g.DrawRectangle(myPen, rect);
            }
            else if (shape == 2)
            {
                rtWidth = Math.Abs(e.X - ptStart.X);
                rtHeight = Math.Abs(e.Y - ptStart.Y);

                rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                g.DrawArc(myPen, rect, 0, 365);
            }
            bPress = false;
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripLine_Click(object sender, EventArgs e)
        {
            this.shape = 0;
        }

        private void ToolStripRect_Click(object sender, EventArgs e)
        {
            this.shape = 1;
        }

        private void ToolStripCircle_Click(object sender, EventArgs e)
        {
            this.shape = 2;
        }

        private void ToolStripColor_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == this.colorDialog1.ShowDialog())
            {
                this.myPen.Color = this.colorDialog1.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.shape = 0;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.shape = 1;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.shape = 2;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.myPen.Color = Color.Black;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.myPen.Color = Color.Red;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.myPen.Color = Color.Green;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.myPen.Color = Color.Blue;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.myPen.Width = int.Parse(toolStripComboBox1.SelectedItem.ToString())*2;
        }
    }
}
