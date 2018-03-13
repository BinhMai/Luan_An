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
            SqlDataAdapter da = new SqlDataAdapter("SELECT TenTruong, DiaChi FROM cosodaotao", _conn);
           
            DataTable dtTruong = new DataTable();
            da.Fill(dtTruong);
            return dtTruong;
        }
    }
}
