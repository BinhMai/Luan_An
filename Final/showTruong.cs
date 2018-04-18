using FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Final.ConnectDB;
using System.Data.SqlClient;

namespace Final
{
    public partial class showTruong : Form
    {
        public showTruong()
        {
            InitializeComponent();            
        }       
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            QuanLyTruong qlsv = new QuanLyTruong();
            qlsv.Show();
        }        
        public void setMatruong(string ma_truong) {
            txtMaTruong.Text = ma_truong;
        }
        public void setTentruong(string ten_truong)
        {
            txtTenTruong.Text = ten_truong;
        }
        public void setDiaChi(string dia_chi)
        {
            txtDiaChi.Text = dia_chi;
        }
        public void setWebsite(string website)
        {
            txtWebsite.Text = website;            
        }
        public void setDvChuQuan(string chu_quan)
        {
            txtDvChuQuan.Text = chu_quan;
        }
        public void setTinhthanh(string tinh_thanh)
        {
            txtTinhThanh.Text = tinh_thanh;
        }
        public void setNb_2014(double nb_2014)
        {
            txtNam2014.Text = nb_2014.ToString();
        }
        public void setNb_2015(double nb_2015)
        {
            txtNam2015.Text = nb_2015.ToString();
        }
        public void setNb_2016(double nb_2016)
        {
            txtNam2016.Text = nb_2016.ToString();
        }
        public void setNb_2017(double nb_2017)
        {
            txtNam2017.Text = nb_2017.ToString();
        }
    }
}
