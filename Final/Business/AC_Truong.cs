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
    class AC_Truong : DBConnect
    {
        private bool checkTextInput(DTO_Truong truong) {
            Boolean check = true;

            if (truong.MA_TRUONG == "" || truong.TEN_TRUONG == "" || truong.TINH_THANH == "" || truong.DIA_CHI == "" || truong.DV_CHU_QUAN == "")
            {
                check = false;
            }            
            return check;
        }

        public string checkListString(List<String> ls_nb) {
            Boolean check = true;
            int n = ls_nb.Count;
            int count = 0;

            for (int i = 0; i < n; i++) {
                if (ls_nb[i] == "")
                    count++;
                try{
                    int nb = Int32.Parse(ls_nb[i]);
                }catch{
                    check = false;
                }
            }
            if (count == n) {
                return "Vui lòng điền đầy đủ thông tin";
            }else{
                if (check == false) {
                    return "Vui lòng nhập 0 nếu không có thông tin chỉ tiêu qua các năm";
                }else{
                    return "OK";
                }
            }            
        }
        public bool del_Truong(string ma_truong) {
            DAL_Truong dal_truong = new DAL_Truong();
            DAL_TS tuyensinh = new DAL_TS();
            if (dal_truong.delTruong_Csdt(ma_truong) && tuyensinh.delTruong_Ts(ma_truong)) 
            {               
                return true;
            }
            return false;
        }        
        public bool add_Truong(DTO_Truong truong, List<DTO_TS> ls_ts)
        {                        
            if (!checkTextInput(truong))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            else
            {
                DAL_Truong dal_truong = new DAL_Truong();                                                                                                   
                DAL_TS ts = new DAL_TS();
                if (dal_truong.addTruong(truong) && ts.addListTS(ls_ts))
                {                        
                    return true;
                }
                else 
                {
                    return false;
                }                                    
            }
        }       
        public void getExcel() { 
        }
    }
}
