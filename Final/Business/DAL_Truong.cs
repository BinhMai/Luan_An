using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Final.ConnectDB;

namespace FinalProject
{
    class DAL_Truong : DBConnect
    {
        public DataTable getTruong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT cosodaotao.MaTruong as ma_truong,TenTruong,DiaChi,Website,DVChuquan,TinhThanh,TuyenSinh.Nam as Nam,TuyenSinh.ChiTieu as chi_tieu FROM cosodaotao Inner Join TuyenSinh on TuyenSinh.MaTruong = cosodaotao.MaTruong AND TuyenSinh.Nam=2016", _conn);
           
            DataTable dtTruong = new DataTable();
            da.Fill(dtTruong);
            return dtTruong;
        }
    }
}
