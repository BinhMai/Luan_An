﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Final
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLyTruong Ql = new QuanLyTruong();
            this.Visible = false;
            Ql.ShowDialog();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            Introduction intro = new Introduction();
            this.Visible = false;
            intro.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnDbCung_Click(object sender, EventArgs e)
        {
            DuBaoCung Tv = new DuBaoCung();
            this.Visible = false;
            Tv.ShowDialog();           
        }        
    }
}
