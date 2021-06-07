using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);
            Point start = new Point(50, 50);
            Point end = new Point(250, 250);
            g.DrawLine(p, start, end);

            start = new Point(250, 50);
            end = new Point(50, 250);
            g.DrawLine(p, start, end);
        }
    }
}
