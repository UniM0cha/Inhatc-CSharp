using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요");
            }
            else
            {
                String[] strArray = new String[] { tbName.Text, tbPhone.Text, tbOrg.Text };
                ListViewItem lvt = new ListViewItem(strArray);
                listView1.Items.Add(lvt);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
