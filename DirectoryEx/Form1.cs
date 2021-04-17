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

namespace DirectoryEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirList_Click(object sender, EventArgs e)
        {
            lblDir.Items.Clear();
            string[] apaths = Directory.GetFiles(Environment.SystemDirectory);

            foreach(string s in apaths)
            {
                lblDir.Items.Add(s);
            }
        }

        private void btnFileList_Click(object sender, EventArgs e)
        {
            lblFiles.Items.Clear();
            string[] apaths = Directory.GetFiles(Environment.SystemDirectory, "*.exe");

            foreach (string s in apaths)
            {
                lblFiles.Items.Add(s);
                
            }
        }
    }
}
