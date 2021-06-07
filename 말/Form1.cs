using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 말
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + r.Next(1,80);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + r.Next(1, 80);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left + r.Next(1, 80);
        }
    }
}
