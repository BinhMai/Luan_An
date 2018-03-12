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
    public partial class DuBaoCung : Form
    {
        DAL_SinhVien dal_sv = new DAL_SinhVien();
        public DuBaoCung()
        {
            InitializeComponent();
        }
        public void GUI_Truong_Load(object sender, EventArgs e)
        {
            dgvSchools.DataSource = dal_sv.getSinhVien(); // get sinh vien
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;
        }
    }
}
