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
        public void updateTuyenSinh(DTO_TS ts)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("update TuyenSinh set ChiTieu='{0}' where TuyenSinh.Nam='{1}'",ts.CHITIEU,ts.NAM);
                Console.WriteLine(SQL);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra 
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi update dữ liệu tuyển sinh!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
        public bool delTruong_Ts(string ma_truong)
        {
            try
            {
                // Ket noi
                _conn.Open();

                Boolean check = false;
                // Query string
                string SQL = string.Format("DELETE FROM TuyenSinh WHERE TuyenSinh.MaTruong='" + ma_truong + "'");
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

        public void deleteTuyenSinh(int nam)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("DELETE from TuyenSinh where TuyenSinh.Nam=" + nam);
                Console.WriteLine(SQL);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra 
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi xóa dữ liệu tuyển sinh!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
        public List<DTO_CT> getListTS(string matruong)
        {            
            _conn.Open();
            string SQL = string.Format("Select Nam,ChiTieu from TuyenSinh where ChiTieu > 0 AND MaTruong = '" + matruong + "'");
            Console.WriteLine(SQL);
            // Command
            SqlCommand cmd = new SqlCommand(SQL, _conn);
            SqlDataReader data = cmd.ExecuteReader();
            List<DTO_CT> listCt = new List<DTO_CT>();

            while (data.Read())
            {
                DTO_CT ct = new DTO_CT(Int32.Parse(data[0].ToString()), Int32.Parse(data[1].ToString()));
                listCt.Add(ct);
            }

            _conn.Close();
            return listCt;
        }

        public List<int> getInfoTuyenSinh(string ma_truong)
        {
            List<int> data = new List<int>();
            _conn.Open();
            string sql_1 = "SELECT * FROM tuyensinh where MaTruong=N'" + ma_truong + "'";
            SqlCommand cmd_1 = new SqlCommand(sql_1, _conn);
            SqlDataReader data_1 = cmd_1.ExecuteReader();
            while (data_1.Read())
            {
                data.Add((int)data_1[2]);
            }
            data_1.Close();
            _conn.Close();
            return data;
        }
    }
}
