using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int iValue = 100;   // 변수 선언 및 초기화
            lblResult.Text = iValue.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double fValue = 3.14;
            lblResult.Text = fValue.ToString();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string sValue = "잠수함";
            lblResult.Text = sValue;
        }
    }
}
