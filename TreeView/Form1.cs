using System;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("컴퓨터");
            treeView1.Nodes.Add("네트워크");

            treeView1.Nodes[0].Nodes.Add("C:");
            treeView1.Nodes[0].Nodes.Add("D:");

            treeView1.Nodes[1].Nodes.Add("학과사무실");
            treeView1.Nodes[1].Nodes.Add("실습실1");
            treeView1.Nodes[1].Nodes.Add("실습실2");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //treeView1.Nodes.Clear();

            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
