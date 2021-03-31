using System;
using System.Windows.Forms;

namespace StringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string str = tbInput.Text;  //ㅈㅈㅈ.daum.net
            string UpStr = str.ToUpper();
            string LowStr = str.ToLower();
            lblResult.Text = UpStr + "\n" + LowStr;





            //lblResult.Text = "";
            //string[] strArr = str.Split(new char[] { ',' });
            //foreach(string arr in strArr)
            //{
            //    lblResult.Text += "\n" + arr;
            //}


            //string newStr = str.Replace("ㅈㅈㅈ", "www");
            //lblResult.Text = newStr;


            //if (str.CompareTo("inha") == 0)
            //{
            //    lblResult.Text = "정확히 입력";
            //}
            //else if(str.CompareTo("inha") <0)
            //{
            //    lblResult.Text = "사전상 앞에 있음";
            //}
            //else
            //{
            //    lblResult.Text = "사전상 뒤에 있음";
            //}

        }
    }
}
