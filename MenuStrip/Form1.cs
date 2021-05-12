using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새로 만들기를 실행했습니다.");
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("열기를 실행했습니다.");
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.ShowDialog();
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장을 실행했습니다.");
        }

        private void ToolStripSaveAs_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("다른이름으로 저장을 실행했습니다.");
            saveFileDialog1.Filter = "솔루션파일|*.sln|모든파일|*.*";
            //saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("저장하신 파일의 경로는 " + path + "입니다.(찡긋)");
            }
            else
            {
                MessageBox.Show("뭐시여 지금 저장을 취소한것이여? 장난혀?! 날 왜 부른 것이여!");
            }
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 모든 애플리케이션 창을 닫습니다.
        }

        private void ToolStripWordWrap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("자동 줄 바꿈을 실행했습니다.");
        }

        private void ToolStripFont_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("글꼴을 실행했습니다.");
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
            else
            {
                MessageBox.Show("이눔아! 장난전화 하지 말란말여! 혼나구시퍼?!");
            }
        }

        private void ToolStripColorTable_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("색상표를 실행했습니다.");
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("에잉~쯧쯔! 요즘 젊은 것들은 말여! 색깔을 고를줄 모른단 말여!\n" +
                    "너 이리 나와봐 내가 해볼게!\n" +
                    "어라 이거 어떻게 하는겨...");
            }
        }

        private void ContextRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ContextGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void ContextBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
