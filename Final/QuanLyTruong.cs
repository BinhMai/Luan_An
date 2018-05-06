using Final.ConnectDB;
using FinalProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
            dgvTruong.DataSource = dal_Truong.getTruong(); // get sinh vien
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
            if (action.del_Truong(ma_truong) && action.del_Truong_DuBaoCung(ma_truong))
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

            db._conn.Open();
            string sql = "SELECT * FROM cosodaotao where MaTruong=N'"+ma_truong+"'";
            SqlCommand cmd = new SqlCommand(sql, db._conn);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read()) {
                show.setMatruong((string)data[0]);
                show.setTentruong((string)data[1]);
                show.setDiaChi((string)data[2]);
                show.setWebsite((string)data[3]);
                show.setTinhthanh((string)data[4]);
                show.setDvChuQuan((string)data[5]);               
            }
            data.Close();

            string sql_1 = "SELECT * FROM tuyensinh where MaTruong=N'"+ma_truong+"'";
            SqlCommand cmd_1 = new SqlCommand(sql_1, db._conn);
            SqlDataReader data_1 = cmd_1.ExecuteReader();
            while (data_1.Read()) {
                if ((int)data_1[1] == 2014)
                {
                    show.setNb_2014((int)data_1[2]);
                }
                else if ((int)data_1[1] == 2015)
                {
                    show.setNb_2015((int)data_1[2]);
                }
                else if ((int)data_1[1] == 2016)
                {
                    show.setNb_2016((int)data_1[2]);
                }else {
                    show.setNb_2017((int)data_1[2]);
                }                
            }
            data_1.Close();
            db._conn.Close();
            show.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            editTruong show = new editTruong();
            DBConnect db = new DBConnect();
            int r = dgvTruong.CurrentCell.RowIndex;

            string ma_truong = dgvTruong.Rows[r].Cells[0].Value.ToString();

            db._conn.Open();
            string sql = "SELECT * FROM cosodaotao where MaTruong=N'" + ma_truong + "'";
            SqlCommand cmd = new SqlCommand(sql, db._conn);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                show.setMatruong((string)data[0]);
                show.setTentruong((string)data[1]);
                show.setDiaChi((string)data[2]);
                show.setWebsite((string)data[3]);
                show.setTinhthanh((string)data[4]);
                show.setDvChuQuan((string)data[5]);
            }
            data.Close();

            string sql_1 = "SELECT * FROM tuyensinh where MaTruong=N'" + ma_truong + "'";
            SqlCommand cmd_1 = new SqlCommand(sql_1, db._conn);
            SqlDataReader data_1 = cmd_1.ExecuteReader();
            while (data_1.Read())
            {
                if ((int)data_1[1] == 2014)
                {
                    show.setNb_2014((int)data_1[2]);
                }
                else if ((int)data_1[1] == 2015)
                {
                    show.setNb_2015((int)data_1[2]);
                }
                else if ((int)data_1[1] == 2016)
                {
                    show.setNb_2016((int)data_1[2]);
                }
                else
                {
                    show.setNb_2017((int)data_1[2]);
                }                
            }
            data_1.Close();
            db._conn.Close();
            show.Show();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
