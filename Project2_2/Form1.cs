using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = int.Parse(txtInput1.Text);
            num2 = int.Parse(txtInput2.Text);
            int num3;
            num3 = num1 + num2;
            lblResult.Text = num3.ToString();
        }

        private void ptnMultiple_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = int.Parse(txtInput1.Text);
            num2 = int.Parse(txtInput2.Text);
            int num3;
            num3 = num1 * num2;
            lblResult.Text = num3.ToString();
        }

        private void ptnMinus_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = int.Parse(txtInput1.Text);
            num2 = int.Parse(txtInput2.Text);
            int num3;
            num3 = num1 - num2;
            lblResult.Text = num3.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = int.Parse(txtInput1.Text);
            num2 = int.Parse(txtInput2.Text);
            int num3;
            num3 = num1 / num2;
            lblResult.Text = num3.ToString();
        }
    }
}
