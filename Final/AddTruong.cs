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
    public partial class AddTruong : Form
    {        
        public AddTruong()
        {
            InitializeComponent();            
        }       
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            QuanLyTruong qlsv = new QuanLyTruong();
            qlsv.Show();
        }        

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string  ma_truong = txtMaTruong.Text ,
                    ten_truong = txtTenTruong.Text,
                    dia_chi=txtDiaChi.Text,
                    website=txtWebsite.Text,
                    tinh_thanh=txtTinhThanh.Text,
                    dv_chu_quan=txtDvChuQuan.Text;
            string  nb_2014 = txtNam2014.Text,
                    nb_2015 = txtNam2015.Text, 
                    nb_2016 = txtNam2016.Text,
                    nb_2017 = txtNam2017.Text;
            List<String> ls_nb = new List<string>();
            ls_nb.Add(nb_2014);
            ls_nb.Add(nb_2015);
            ls_nb.Add(nb_2016);
            ls_nb.Add(nb_2017);

            List<DTO_TS> ls_ts = new List<DTO_TS>();
            DTO_Truong truong = new DTO_Truong(ma_truong, ten_truong, dia_chi, website, tinh_thanh, dv_chu_quan);
            AC_Truong action = new AC_Truong();
            string token = action.checkListString(ls_nb);
            if ( token != "OK")
            {
                MessageBox.Show(token);
            }
            else {
                DAL_Truong dal = new DAL_Truong();
                if (dal.checkMatruong(ma_truong))
                {
                    DTO_TS ts_2014 = new DTO_TS(ma_truong, 2014, Int32.Parse(nb_2014));
                    DTO_TS ts_2015 = new DTO_TS(ma_truong, 2015, Int32.Parse(nb_2015));
                    DTO_TS ts_2016 = new DTO_TS(ma_truong, 2016, Int32.Parse(nb_2016));
                    DTO_TS ts_2017 = new DTO_TS(ma_truong, 2017, Int32.Parse(nb_2017));

                    ls_ts.Add(ts_2014);
                    ls_ts.Add(ts_2015);
                    ls_ts.Add(ts_2016);
                    ls_ts.Add(ts_2017);

                    if (action.add_Truong(truong, ls_ts))
                    {
                        MessageBox.Show("\t\t    Thêm thành công.\nVui lòng nhập tỉ lệ tốt nghiệp trong file TiLeTotNghiep.xlsx");
                        AddTruong view = new AddTruong();
                        view.Show();
                    }
                }
                else {
                    MessageBox.Show("Mã trường đã tồn tại");
                }                
            }                       
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }         
    }
}
