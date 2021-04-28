using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"fs2.txt");
                sw.Write(tbText.Text);
                sw.Close();
                MessageBox.Show("텍스트가 파일에 저장되었음.");
            }
            catch (Exception)
            {
                MessageBox.Show("파일을 접근시 문제 발생.");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            char[] buf = new char[1024];
            int retCnt = 0;
            StreamReader sr = new StreamReader(@"fs2.txt");
            while(true)
            {
                retCnt = sr.Read(buf, 0, 1024);
                tbText.Text += new string(buf, 0, retCnt);
                if (retCnt < 1024)
                    break;
            }
            sr.Close();
        }
    }
}
