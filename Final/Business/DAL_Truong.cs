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
        public DataTable getDuBaoCung(int nam)
        {
            _conn.Open();
            SqlDataAdapter da;
            DataTable dtTruong = new DataTable();
            string sql = "SELECT * from TuyenSinh where TuyenSinh.Nam=" + nam;
            string sql_2 = "SELECT cosodaotao.MaTruong as ma_truong,TenTruong,DiaChi,TuyenSinh.Nam as Nam,TuyenSinh.ChiTieu as chi_tieu FROM cosodaotao Inner Join TuyenSinh on TuyenSinh.MaTruong = cosodaotao.MaTruong AND TuyenSinh.Nam=" + nam;
            string sql_1 = "SELECT cosodaotao.MaTruong as ma_truong,TenTruong,DiaChi FROM cosodaotao";           
            SqlCommand cmd = new SqlCommand(sql, _conn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows){
                data.Close();
                da = new SqlDataAdapter(sql_2, _conn);
                da.Fill(dtTruong);
            }else{
                data.Close();
                dtTruong.Columns.Add("ma_truong", typeof(string));
                dtTruong.Columns.Add("TenTruong", typeof(string));
                dtTruong.Columns.Add("DiaChi", typeof(string));
                dtTruong.Columns.Add("Nam", typeof(int));
                dtTruong.Columns.Add("chi_tieu", typeof(int));

                SqlCommand cmd_1 = new SqlCommand(sql_1, _conn);
                SqlDataReader data_1 = cmd_1.ExecuteReader();

                while (data_1.Read())
                {
                    dtTruong.Rows.Add(data_1[0], data_1[1], data_1[2], nam, 0);
                }                
            }
           
            _conn.Close();           
            return dtTruong;
        }
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
        public bool delTruong_Ts(string ma_truong) {
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
        public bool updateTruong_Dubaocung(string matruong) {
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

            int n = listCt.Count;            
            if (n != 0)
            {
                try
                {
                    _conn.Open();
                    string SQL_1 = string.Format("Select TuyenSinh.MaTruong,TiLe,DuBao,TuyenSinh.Nam as ts_nam,TuyenSinh.ChiTieu as ts_chitieu,dubaocung.Nam as dbc_nam from dubaocung Inner Join TuyenSinh on TuyenSinh.MaTruong = dubaocung.MaTruong where dubaocung.MaTruong = '" + matruong + "'");
                    Console.WriteLine(SQL_1);
                    // Command
                    SqlCommand cmd_1 = new SqlCommand(SQL_1, _conn);
                    SqlDataReader data_1 = cmd_1.ExecuteReader();
                    while (data_1.Read())
                    {
                        int dbc_nam = Int32.Parse(data_1[5].ToString());
                        int ts_nam = Int32.Parse(data_1[3].ToString());                        
                        double tile = Convert.ToDouble(data_1[1].ToString());
                        int chitieu = 0;
                        if (dbc_nam > 2017)
                        {
                            chitieu = bptoithieu(listCt, n, dbc_nam);
                            int dubao = (int)(chitieu * tile) / 100;
                            DTO_DuBao db = new DTO_DuBao(matruong, (float)tile, dubao, dbc_nam, chitieu);
                            DAL_DuBao dal_db = new DAL_DuBao();
                            dal_db.updateDuBaoCung(db);
                        }
                        else
                        {
                            if(dbc_nam == ts_nam){
                                chitieu = Int32.Parse(data_1[4].ToString());
                                int dubao = (int)(chitieu * tile) / 100;
                                DTO_DuBao db = new DTO_DuBao(matruong, (float)tile, dubao, dbc_nam, chitieu);
                                DAL_DuBao dal_db = new DAL_DuBao();
                                dal_db.updateDuBaoCung(db);
                            }
                        }                                                                                                                  
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Có lỗi trong khi update!");
                }
                finally
                {
                    // Dong ket noi
                    _conn.Close();
                }                                                  
            }
            return false;
        }        
        public bool delTruong_Dubaocung(string ma_truong)
        {
            try
            {
                // Ket noi
                _conn.Open();

                Boolean check = false;
                // Query string
                string SQL = string.Format("DELETE FROM dubaocung WHERE dubaocung.MaTruong='" + ma_truong + "'");
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
