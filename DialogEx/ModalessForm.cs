﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEx
{
    public partial class ModalessForm : Form
    {
        public String str;

        public ModalessForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (str.Contains(tbSearch.Text))
            {
                MessageBox.Show("문자열을 찾았습니다.");
            }
            else
            {
                MessageBox.Show("문자열을 찾지 못했습니다.");
            }
        }
    }
}
