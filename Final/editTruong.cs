using FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Final.ConnectDB;
using System.Data.SqlClient;

namespace Final
{
    public partial class editTruong : Form
    {
        static string matruong = "";
        static string value_2014 = "", value_2015 = "", value_2016 = "", value_2017 = "";
        public editTruong()
        {
            InitializeComponent();            
        }       
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            QuanLyTruong qlsv = new QuanLyTruong();
            qlsv.Show();
        }        
        public void setMatruong(string ma_truong) {
            txtMaTruong.Text = ma_truong;
            matruong = ma_truong;
        }
        public void setTentruong(string ten_truong)
        {
            txtTenTruong.Text = ten_truong;
        }
        public void setDiaChi(string dia_chi)
        {
            txtDiaChi.Text = dia_chi;
        }
        public void setWebsite(string website)
        {
            txtWebsite.Text = website;            
        }
        public void setDvChuQuan(string chu_quan)
        {
            txtDvChuQuan.Text = chu_quan;
        }
        public void setTinhthanh(string tinh_thanh)
        {
            txtTinhThanh.Text = tinh_thanh;
        }
        public void setNb_2014(double nb_2014)
        {
            txtNam2014.Text = nb_2014.ToString();
            value_2014 = nb_2014.ToString();
        }
        public void setNb_2015(double nb_2015)
        {
            txtNam2015.Text = nb_2015.ToString();
            value_2015 = nb_2015.ToString();
        }
        public void setNb_2016(double nb_2016)
        {
            txtNam2016.Text = nb_2016.ToString();
            value_2016 = nb_2016.ToString();
        }
        public void setNb_2017(double nb_2017)
        {
            txtNam2017.Text = nb_2017.ToString();
            value_2017 = nb_2017.ToString();
        }
        private bool checkChangeValueNam() {
            string nb_2014 = txtNam2014.Text,
                    nb_2015 = txtNam2015.Text,
                    nb_2016 = txtNam2016.Text,
                    nb_2017 = txtNam2017.Text;
            if (nb_2014 != value_2014 || nb_2015 != value_2015 || nb_2016 != value_2016 || nb_2017 != value_2017)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma_truong = txtMaTruong.Text,
                    ten_truong = txtTenTruong.Text,
                    dia_chi = txtDiaChi.Text,
                    website = txtWebsite.Text,
                    tinh_thanh = txtTinhThanh.Text,
                    dv_chu_quan = txtDvChuQuan.Text;
            string nb_2014 = txtNam2014.Text,
                    nb_2015 = txtNam2015.Text,
                    nb_2016 = txtNam2016.Text,
                    nb_2017 = txtNam2017.Text;
            List<String> ls_nb = new List<string>();
            ls_nb.Add(nb_2014);
            ls_nb.Add(nb_2015);
            ls_nb.Add(nb_2016);
            ls_nb.Add(nb_2017);

            List<DTO_TS> ls_ts = new List<DTO_TS>();
            DAL_Truong dal = new DAL_Truong();
            DAL_DuBao dubao = new DAL_DuBao();
            DTO_Truong truong = new DTO_Truong(ma_truong, ten_truong, dia_chi, website, tinh_thanh, dv_chu_quan);
            AC_Truong action = new AC_Truong();
            string token = action.checkListString(ls_nb);
            if (token != "OK")
            {
                MessageBox.Show(token);
            }
            else
            {
                DTO_TS ts_2014 = new DTO_TS(ma_truong, 2014, Int32.Parse(nb_2014));
                DTO_TS ts_2015 = new DTO_TS(ma_truong, 2015, Int32.Parse(nb_2015));
                DTO_TS ts_2016 = new DTO_TS(ma_truong, 2016, Int32.Parse(nb_2016));
                DTO_TS ts_2017 = new DTO_TS(ma_truong, 2017, Int32.Parse(nb_2017));

                ls_ts.Add(ts_2014);
                ls_ts.Add(ts_2015);
                ls_ts.Add(ts_2016);
                ls_ts.Add(ts_2017);

                if (matruong == ma_truong){
                    if (action.del_Truong(matruong) && action.add_Truong(truong, ls_ts))
                    {
                        if (checkChangeValueNam() && dubao.updateTruong_Dubaocung(ma_truong))
                        {

                            MessageBox.Show("Sửa thành công");
                        }                        

                    } else {
                        MessageBox.Show("Có lỗi trong khi sửa");
                    }                    
                } else {
                    if (dal.checkMatruong(ma_truong)) {
                        if (action.del_Truong(matruong) && action.add_Truong(truong, ls_ts)) {
                            MessageBox.Show("Sửa thành công");
                        } else {
                            MessageBox.Show("Có lỗi trong khi sửa");
                        }  
                    } else {
                        MessageBox.Show("Mã trường đã tồn tại");
                    }
                }                
            }            
        }
    }
}
