using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblOrder.Text = "";
            if(ckbSoon.Checked == true)
            {
                strOrder += ckbSoon.Text + "\n";
            }
            if (ckbPasta.Checked == true)
            {
                strOrder += ckbPasta.Text + "\n";
            }
            if (ckbSteak.Checked == true)
            {
                strOrder += ckbSteak.Text + "\n";
            }
            if (ckbTang.Checked == true)
            {
                strOrder += ckbTang.Text + "\n";
            }
            lblOrder.Text = strOrder + "메뉴를 요청했습니다.";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(radioAgree.Checked == true)
            {
                MessageBox.Show("개인정보 동의 하셨습니다.");
            }
            else
            {
                MessageBox.Show("개인정보 동의하지 않으셨습니다.");
            }
        }

        private void btnRecipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "\n라고 요구 사항이 접수되었습니다.");
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArea.Items.Clear();
            if(cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("하루은행");
                lbArea.Items.Add("신용은행");
                lbArea.Items.Add("국물은행");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("N포인트");
                lbArea.Items.Add("주유포인트");
                lbArea.Items.Add("레이저포인트");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Files|*.*|Text Files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName + "파일을 저장합니다.";
            }
        }
    }
}
