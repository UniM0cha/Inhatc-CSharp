using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirectoryInfoEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirInfo_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Windows");
            if (dirInfo.Exists)
            {
                lblDirInfo.Items.Add("전체경로 : " + dirInfo.FullName);
                lblDirInfo.Items.Add("디렉토리 이름 : " + dirInfo.Name);
                lblDirInfo.Items.Add("생성일 : " + dirInfo.CreationTime);
                lblDirInfo.Items.Add("속성 : " + dirInfo.Attributes);
                lblDirInfo.Items.Add("루트 : " + dirInfo.Root);
            }
        }
    }
}
