using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Final.ConnectDB;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.IO;

namespace FinalProject
{
    class DAL_Truong : DBConnect
    {
        public DataTable getTruong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT cosodaotao.MaTruong as ma_truong,TenTruong,DiaChi,Website,DVChuquan,TinhThanh FROM cosodaotao", _conn);

            DataTable dtTruong = new DataTable();
            da.Fill(dtTruong);
            return dtTruong;
        }        
        public bool checkMatruong(string ma_truong)
        {
            _conn.Open();
            string sql = "SELECT * from cosodaotao where cosodaotao.MaTruong='" + ma_truong + "'";
            SqlCommand cmd = new SqlCommand(sql,_conn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows)
            {
                _conn.Close();
                return false;
            }
            else
            {
                _conn.Close();
                return true;
            }
        }        

        public List<string> getInfoTruong(string ma_truong)
        {
            List<string> data = new List<string>();
            _conn.Open();
            string sql = "SELECT * FROM cosodaotao where MaTruong=N'" + ma_truong + "'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                data.Add((string)dt[0]);
                data.Add((string)dt[1]);
                data.Add((string)dt[2]);
                data.Add((string)dt[3]);
                data.Add((string)dt[4]);
                data.Add((string)dt[5]);
            }
            _conn.Close();
            return data;
        }
        public bool delTruong_Csdt(string ma_truong) {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("DELETE FROM cosodaotao WHERE cosodaotao.MaTruong='"+ma_truong+"'");
                // Command                
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;               
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi xóa!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }        
        private int bptoithieu(List<DTO_CT> listCt, int n, int nam)
        {
            double X = 0, Y = 0, XY = 0, XX = 0;

            for (int j = 0; j < n; j++)
            {
                X += listCt[j].NAM;
                Y += listCt[j].CHITIEU;
                XX += listCt[j].NAM * listCt[j].NAM;
                XY += listCt[j].NAM * listCt[j].CHITIEU;
            }

            double X1 = X / n, Y1 = Y / n, XX1 = XX / n, XY1 = XY / n;

            double b1 = (XY1 - X1 * Y1) / (XX1 - X1 * X1);
            double b2 = Y1 - X1 * b1;

            int dubao = (int)(nam * b1 + b2);
            if (dubao < 0)
                return 0;
            return dubao;
        }                        
        public bool addTruong(DTO_Truong truong)
        {
            System.Console.WriteLine(truong.MA_TRUONG);
            System.Console.ReadLine();
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("INSERT INTO cosodaotao(MaTruong, TenTruong, DiaChi, Website, TinhThanh, DVChuquan) VALUES ('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", truong.MA_TRUONG, truong.TEN_TRUONG, truong.DIA_CHI, truong.WEBSITE, truong.TINH_THANH, truong.DV_CHU_QUAN);
                Console.WriteLine(SQL);
                // Command
                Console.WriteLine(SQL);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi thêm mới!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }        
    }
}
