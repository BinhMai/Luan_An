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
    class DAL_TS : DBConnect
    {
        public bool addTS(DTO_TS ts)
        {
            System.Console.WriteLine(ts.MA_TRUONG);
            System.Console.ReadLine();
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("INSERT INTO TuyenSinh(MaTruong, Nam, ChiTieu) VALUES ('{0}','{1}','{2}')", ts.MA_TRUONG, ts.NAM, ts.CHITIEU);
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

        public bool addListTS(List<DTO_TS> ts)
        {                     
            try
            {
                // Ket noi
                _conn.Open();

                int n = ts.Count;
                Boolean check = false;
                for (int i = 0; i < n; i++) {
                    // Query string
                    string SQL = string.Format("INSERT INTO TuyenSinh(MaTruong, Nam, ChiTieu) VALUES ('{0}','{1}','{2}')", ts[i].MA_TRUONG, ts[i].NAM, ts[i].CHITIEU);
                    // Command                    
                    SqlCommand cmd = new SqlCommand(SQL, _conn);
                    // Query và kiểm tra
                    if (cmd.ExecuteNonQuery() > 0)
                        check = true;
                }
                if (check == true)
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
