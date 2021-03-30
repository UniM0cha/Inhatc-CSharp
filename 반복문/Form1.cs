using System;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // while 사용하기
            //int i = 0;
            //while (i < 5)
            //{
            //    lblResult.Text += "Programming" + "\r\n";
            //    i++;
            //}

            // do~while 사용하기
            //int i = 0;
            //do
            //{
            //    lblResult.Text += "Programming" + Environment.NewLine;
            //    i++;
            //} while (i < 5);

            // for 사용하기
            for(int i = 0; i < 5; i++)
            {
                lblResult.Text += "Programming" + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
