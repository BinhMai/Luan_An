using Final.ConnectDB;
using FinalProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.IO;

namespace Final
{
    public partial class QuanLyTruong : Form
    {
        DAL_Truong dal_Truong = new DAL_Truong();
        public QuanLyTruong()
        {
            InitializeComponent();
        }
        public void GUI_Truong_Load(object sender, EventArgs e)
        {
            dgvTruong.DataSource = dal_Truong.getTruong();
        }        
        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            dgvTruong.DataSource = dal_Truong.getTruong(); // load lại table
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            AddTruong add = new AddTruong();
            add.Show();
            this.Visible = false;
        }
        private void returnListSchoolSearch(string name)
        {
            if (name.Length < 5)
            {
                (dgvTruong.DataSource as DataTable).DefaultView.RowFilter = string.Format("ma_truong='{0}'", name);
            }
            else
            {
                (dgvTruong.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenTruong like '%{0}%'", name);
            }
        } 

        private void quickFilter_Click_1(object sender, EventArgs e)
        {            
            string search = "";
            if (textSearch.Text != "")
            {
                search = textSearch.Text;
                returnListSchoolSearch(search);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm kiếm");
            }                        
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int r = dgvTruong.CurrentCell.RowIndex;            
            string ma_truong = dgvTruong.Rows[r].Cells[0].Value.ToString();
            AC_Truong action = new AC_Truong();
            DAL_DuBao dubao = new DAL_DuBao();
            if (action.del_Truong(ma_truong) && dubao.del_Truong_DuBaoCung(ma_truong))
            {
                MessageBox.Show("Xóa thành công");
                dgvTruong.DataSource = dal_Truong.getTruong(); // load lại table
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showTruong show = new showTruong();
            DBConnect db = new DBConnect();
            int r = dgvTruong.CurrentCell.RowIndex;            

            string ma_truong = dgvTruong.Rows[r].Cells[0].Value.ToString();
            DAL_Truong dal_truong = new DAL_Truong();
            DAL_TS tuyensinh = new DAL_TS();
            List<string> data = dal_Truong.getInfoTruong(ma_truong);
            show.setMatruong(data[0]);
            show.setTentruong(data[1]);
            show.setDiaChi(data[2]);
            show.setWebsite(data[3]);
            show.setTinhthanh(data[4]);
            show.setDvChuQuan(data[5]);

            List<int> data_1 = tuyensinh.getInfoTuyenSinh(ma_truong);
            show.setNb_2014((int)data_1[0]);
            show.setNb_2015((int)data_1[1]);
            show.setNb_2016((int)data_1[2]);
            show.setNb_2017((int)data_1[3]);
            show.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            editTruong show = new editTruong();
            DBConnect db = new DBConnect();
            int r = dgvTruong.CurrentCell.RowIndex;

            string ma_truong = dgvTruong.Rows[r].Cells[0].Value.ToString();

            DAL_Truong dal_truong = new DAL_Truong();
            DAL_TS tuyensinh = new DAL_TS();
            List<string> data = dal_Truong.getInfoTruong(ma_truong);
            show.setMatruong(data[0]);
            show.setTentruong(data[1]);
            show.setDiaChi(data[2]);
            show.setWebsite(data[3]);
            show.setTinhthanh(data[4]);
            show.setDvChuQuan(data[5]);

            List<int> data_1 = tuyensinh.getInfoTuyenSinh(ma_truong);
            show.setNb_2014((int)data_1[0]);
            show.setNb_2015((int)data_1[1]);
            show.setNb_2016((int)data_1[2]);
            show.setNb_2017((int)data_1[3]);
            
            show.Show();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
