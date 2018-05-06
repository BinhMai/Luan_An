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
    class DAL_DuBao : DBConnect
    {
        public DataTable getDuBaoCung(int nam)
        {
            _conn.Open();
            SqlDataAdapter da;
            DataTable dtTruong = new DataTable();
            string sql = "SELECT * from dubaocung where dubaocung.Nam=" + nam;            
            string sql_1 = "SELECT cosodaotao.MaTruong as ma_truong,TenTruong,DiaChi FROM cosodaotao";
            string sql_2 = "SELECT * from TuyenSinh where TuyenSinh.Nam=" + nam;
            string sql_3 = "SELECT cosodaotao.MaTruong as ma_truong,TenTruong,DiaChi,dubaocung.Nam as Nam,dubaocung.ChiTieu as chi_tieu, dubaocung.TiLe as ti_le, dubaocung.DuBao as du_bao FROM cosodaotao Inner Join dubaocung on dubaocung.MaTruong = cosodaotao.MaTruong AND dubaocung.Nam=" + nam;
            string sql_4 = "SELECT cosodaotao.MaTruong as ma_truong,TenTruong,DiaChi,TuyenSinh.Nam as Nam,TuyenSinh.ChiTieu as chi_tieu FROM cosodaotao Inner Join TuyenSinh on TuyenSinh.MaTruong = cosodaotao.MaTruong AND TuyenSinh.Nam=" + nam;            
            SqlCommand cmd = new SqlCommand(sql, _conn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows){
                data.Close();                                                    
                da = new SqlDataAdapter(sql_3, _conn);
                da.Fill(dtTruong);                                                                   
            }else{
                data.Close();
                SqlCommand cmd_1 = new SqlCommand(sql_2, _conn);
                SqlDataReader data_1 = cmd_1.ExecuteReader();
                if (data_1.HasRows)
                {
                    data_1.Close();                                       
                    da = new SqlDataAdapter(sql_4, _conn);
                    da.Fill(dtTruong);              
                }
                else 
                {
                    data_1.Close();
                    dtTruong.Columns.Add("ma_truong", typeof(string));
                    dtTruong.Columns.Add("TenTruong", typeof(string));
                    dtTruong.Columns.Add("DiaChi", typeof(string));
                    dtTruong.Columns.Add("Nam", typeof(int));
                    dtTruong.Columns.Add("chi_tieu", typeof(int));

                    SqlCommand cmd_2 = new SqlCommand(sql_1, _conn);
                    SqlDataReader data_2 = cmd_2.ExecuteReader();

                    while (data_2.Read())
                    {
                        dtTruong.Rows.Add(data_2[0], data_2[1], data_2[2], nam, 0);
                    }                    
                }                
            }
           
            _conn.Close();           
            return dtTruong;
        }
        public void addDuBaoCung(DTO_DuBao dubao) {
            
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("INSERT INTO dubaocung(MaTruong, TiLe, DuBao,Nam,ChiTieu) VALUES ('{0}','{1}','{2}','{3}','{4}')", dubao.MA_TRUONG, dubao.TILE, dubao.DU_BAO, dubao.NAM,dubao.CHI_TIEU);                
                // Command    
                Console.WriteLine(SQL);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra 
                cmd.ExecuteNonQuery();                   
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi cập nhật dự báo cung!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }            
        }
        public void deleteDuBaoCung(int nam)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("DELETE from dubaocung where dubaocung.Nam=" + nam);
                Console.WriteLine(SQL);
                // Command                
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra 
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi xóa dự báo cung!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
        public void updateDuBaoCung(DTO_DuBao db)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("update dubaocung set DuBao='{0}', ChiTieu='{1}',TiLe='{2}' where dubaocung.Nam='{3}' AND dubaocung.MaTruong='{4}'", db.DU_BAO, db.CHI_TIEU,db.TILE,db.NAM,db.MA_TRUONG);
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
    }
}
