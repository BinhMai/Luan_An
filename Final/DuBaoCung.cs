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
    }
}
