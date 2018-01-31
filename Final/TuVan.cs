using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Final
{
    public partial class TuVan : Form
    {
        private string conn = "";

        public TuVan()
        {

            InitializeComponent();
            setUpConnect();
            addnganhhoc();
            //addkhoahoc();
            addHocLuc();
        }

        private void setUpConnect()
        {
            string[] lines = System.IO.File.ReadAllLines("../../ConnectDB/Config.txt", Encoding.UTF8);
            string datasource = ".\\" + lines[0];
            string database = lines[1];
            // string conn = @"Server=" + datasource + ";Database=" + database + ";Trusted_Connection=True;";

            //string[] lines = System.IO.File.ReadAllLines("../../ConnectDB/Config.txt", Encoding.UTF8);
            //conn = @"Data Source=DESKTOP-7NTAFPS\SQLEXPRESS;Initial Catalog=DSS;Integrated Security=True";
            // conn = @"Data Source=DESKTOP-7NTAFPS\" + lines[0] + ";Initial Catalog=" + lines[1] + ";Integrated Security=True";
            conn = @"Server=" + datasource + ";Database=" + database + ";Trusted_Connection=True;";

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;
        }

        private int left = 5;
        private int khoangcach = 20;
        private int top = 5;

        private void addnganhhoc()
        {
            string connString = conn;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from nganh_dao_tao", con);
            SqlDataReader data = cmd.ExecuteReader();
            int i = 0;
            while (data.Read())
            {
                System.Windows.Forms.CheckBox checkboxn = new System.Windows.Forms.CheckBox();
                checkboxn.AutoSize = true;
                checkboxn.Location = new System.Drawing.Point(left, top + khoangcach * i);
                i++;
                checkboxn.Name = data.GetString(1);
                Console.WriteLine(data.GetString(1));
                checkboxn.Size = new System.Drawing.Size(80, 17);
                checkboxn.TabIndex = 43;
                checkboxn.Text = data.GetString(1);
                checkboxn.UseVisualStyleBackColor = true;
                checkboxn.Font = new Font(checkboxn.Font.FontFamily, 10f);
                
                nganhhoc.Controls.Add(checkboxn);
            }
            con.Close();

        }


        private void addHocLuc()
        {
            String[] hl = new string[] { "Xuất Sắc", "Giỏi", "Khá", "Trung Bình" };
            int i = 0;
            while (i < hl.Length)
            {
                System.Windows.Forms.CheckBox checkboxn = new System.Windows.Forms.CheckBox();
                checkboxn.AutoSize = true;
                checkboxn.Location = new System.Drawing.Point(left, top + khoangcach * i);
                checkboxn.Name = hl[i];
                checkboxn.Size = new System.Drawing.Size(80, 17);
                checkboxn.TabIndex = 43;
                checkboxn.Text = hl[i];
                checkboxn.UseVisualStyleBackColor = true;
                checkboxn.Font = new Font(checkboxn.Font.FontFamily, 10f);
                thanghocluc.Controls.Add(checkboxn);
                i++;
            }


        }
        
        public Dictionary<int, string[]> top10SinhVien = new Dictionary<int, string[]>();
        public ICollection<KeyValuePair<int, String[]>> top10 = new Dictionary<int, String[]>();
        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            int intHocLuc = 0;
            
            String sql = "";

            String stringNganhHoc = "";
            foreach (Control c in nganhhoc.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    stringNganhHoc += " nganh_dao_tao.ten_nganh = N'" + c.Text + "' OR ";
                }
                    
            }

            String stringHocLuc = "";
            foreach (Control c in thanghocluc.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    if (c.Text.Trim()=="Xuất Sắc")
                    {
                        intHocLuc = 1;
                    }
                    if (c.Text.Trim() == "Giỏi"&& intHocLuc>=2)
                    {
                        intHocLuc = 2;
                    }
                    if (c.Text.Trim() == "Khá" && intHocLuc >= 3)
                    {
                        intHocLuc = 3;
                    }
                    if (c.Text.Trim() == "Trung Bình")
                    {
                        intHocLuc = 4;
                    }
                    stringHocLuc += " sinh_vien.hoc_luc = N'" + c.Text + "' OR ";
                }
            }

            string dan_toc = danToc.Text;
            string gioi_tinh = gioiTinh.Text;

            
            if (stringNganhHoc != "")
            {
                stringNganhHoc = stringNganhHoc.Substring(0, stringNganhHoc.Length - 3);
                sql += "( " + stringNganhHoc +" )";
            }

            if (sql != "")
            {
                sql += " AND ";
            }


            
            if (stringHocLuc != "")
            {
                stringHocLuc = stringHocLuc.Substring(0, stringHocLuc.Length - 3);
                sql += "( " + stringHocLuc +" )"+ " AND ";
            }

            if (sql == "")
            {
                MessageBox.Show("Hãy chọn thêm thông tin để hệ thống có thể trợ giúp cho bạn !");
                return;
            }
            this.Visible = false;


            sql = sql.Substring(0, sql.Length - 4);

            if (dan_toc != "")
            {
                sql += " and (sinh_vien.dan_toc = N'" + danToc.Text + "')";
            }

            if (gioi_tinh != "")
            {
                sql += " and (sinh_vien.gioi_tinh = N'" + gioiTinh.Text + "')";
            }

            String join = "Select top 10 sinh_vien.ten_co_quan,nganh_nghe.ten_nganh,luong_khoi_diem,dia_chi,tinh,co_quan_quan_li from sinh_vien join khoa_hoc on khoa_hoc.ma_khoa_hoc = sinh_vien.ma_khoa_hoc join nganh_dao_tao on nganh_dao_tao.ma_nganh_dao_tao = sinh_vien.ma_nganh_dao_tao join nganh_nghe on nganh_nghe.ma_nganh_nghe = sinh_vien.ma_nganh_nghe join co_quan on co_quan.ten_co_quan = sinh_vien.ten_co_quan";



            //LoiTuVan loitv = new LoiTuVan();
            //this.Visible = false;
            //loitv.ShowDialog();



            string connString = conn;
            SqlConnection con = new SqlConnection(connString);
            String order = " order by luong_khoi_diem desc";

            con.Open();
            SqlCommand cmd = new SqlCommand(join + " where " + sql + order, con);
            Console.WriteLine(join + " where " + sql + order);
            SqlDataReader data = cmd.ExecuteReader();

            string ten_co_quan = "";
            string ten_nganh = "";
            double luong_khoi_diem = -1;
            int i = 1;


            while (data.Read())
            {
                ten_co_quan = data.GetString(0);
                ten_nganh = data.GetString(1);
                luong_khoi_diem = data.GetDouble(2);

                string[] thongTin = new string[6];
                thongTin[0] = ten_co_quan;
                thongTin[1] = ten_nganh;
                thongTin[2] = luong_khoi_diem+"";

                if (ten_co_quan != "chưa rõ")
                {
                    string dia_chi = data.GetString(3);
                    string tinh = data.GetString(4);
                    string co_quan_quan_li = data.GetString(5);
                    thongTin[3] = dia_chi;
                    thongTin[4] = tinh;
                    thongTin[5] = co_quan_quan_li;
                }
                top10.Add(new KeyValuePair<int, String[]>(i, thongTin));
                i++;
                //Console.WriteLine(ten_co_quan + "-" + ten_nganh + "-" + luong_khoi_diem);
            }
          

            if (top10.Count == 0)   // khong co thong tin nao trong he thong
            {
                //if (stringHocLuc.IndexOf())   // lựa chọn vào ô xuất sắc
                //{
                    LoiTuVan loiTuVan1 = new LoiTuVan();
                    loiTuVan1.index = index;
                    loiTuVan1.topTen = top10;
                    loiTuVan1.tongNhoHon6 = 2;
                    loiTuVan1.tongNhoHon6_10 = 6;
                    loiTuVan1.tongLonHon10 = 2;
                    loiTuVan1.mucLuong.SelectedIndex = 2;
                    loiTuVan1.tiLeMucLuong.Text = "" + loiTuVan1.tongLonHon10*10 + " % sinh viên có mức lương này";
                    loiTuVan1.ngheNghiep.Text = "Lập trình viên hoặc Test tại FPT";
                    loiTuVan1.luongKhoiDiem.Text = "Lương khoảng 6.000.000-7.500.000 VNĐ/Tháng";
                    loiTuVan1.tenCoQuan.Text = "Tập đoàn FPT";
                    loiTuVan1.diaChiCoQuan.Text = "Hãy tìm việc tại một chi nhánh của tập đoàn FPT";
                    loiTuVan1.showMore.Visible = false;
                    loiTuVan1.Show();
                    return;
                //}
            }
            else
            {
                int tongNhoHon6 = 0;
                int tongNhoHon6_10 = 0;
                int tongLonHon10 = 0;
                foreach (KeyValuePair<int, string[]> element in top10)
                {
                    if (double.Parse(element.Value[2])<6000000)
                    {
                        tongNhoHon6++;
                    }

                    if (double.Parse(element.Value[2]) >= 6000000&& double.Parse(element.Value[2]) <= 10000000)
                    {
                        tongNhoHon6_10++;
                    }

                    if (double.Parse(element.Value[2]) > 10000000 )
                    {
                        tongLonHon10++;
                    }


                }

                foreach (KeyValuePair<int, string[]> element in top10)
                {
                    if (element.Value[0]!="chưa rõ")
                    {
                        index = element.Key;
                        LoiTuVan loiTuVan1 = new LoiTuVan();
                        loiTuVan1.tongNhoHon6 = tongNhoHon6;
                        loiTuVan1.tongNhoHon6_10 = tongNhoHon6_10;
                        loiTuVan1.tongLonHon10 = tongLonHon10;
                        loiTuVan1.mucLuong.SelectedIndex = 2;
                        double tile = tongLonHon10 * 10;
                        loiTuVan1.tiLeMucLuong.Text = "" + tile + " % sinh viên có mức lương này";

                        loiTuVan1.index = index;
                        loiTuVan1.topTen = top10;
                        loiTuVan1.ngheNghiep.Text = (element.Value[1]);
                        loiTuVan1.luongKhoiDiem.Text = element.Value[2]+" VNĐ";
                        loiTuVan1.tenCoQuan.Text = element.Value[0];
                        loiTuVan1.diaChiCoQuan.Text = element.Value[3];
                        loiTuVan1.coQuanTrucThuoc.Text = element.Value[5];
                        loiTuVan1.showMore.Enabled = true;
                        loiTuVan1.Show();
                        return;
                    }
                   
                }
            }



           
            //Console.WriteLine(top10.ElementAt(0).Value[0]);
   
            foreach (KeyValuePair<int, string[]> element in top10)
            {
                Console.WriteLine(element.Value[0]);
            }
            return;

            if (luong_khoi_diem==-1)  // khong co dl
            {
                LoiTuVan loiTuVanMacDinh = new LoiTuVan();
                //loiTuVanMacDinh.noiDungTuVan.Text = "Bạn nên lựa chọn làm việc tại: FPT \nCông việc lựa chọn: Lập trình viên, Test \nMức lương khởi điểm: 6000000 - 7500000 VNĐ";
                loiTuVanMacDinh.Show();
            }
            else
            { // trường hợp cơ quan không rõ
                LoiTuVan loiTuVanMacDinh = new LoiTuVan();
               // loiTuVanMacDinh.noiDungTuVan.Text = "Bạn nên làm công việc: " + ten_nganh + " tại Hà Nội.\nMức lương nhận được khoảng: " + luong_khoi_diem;
                loiTuVanMacDinh.Show();
            }

            con.Close();
        }
        public int index = -1;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbbViecLam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //Excel.Range range;

            //string str;
            //int rCnt;
            //int cCnt;
            //int rw = 0;
            //int cl = 0;

            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    xlApp = new Excel.Application();
            //    xlWorkBook = xlApp.Workbooks.Open(@"" + ofd.FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);

            //    range = xlWorkSheet.UsedRange;
            //    rw = range.Rows.Count;
            //    cl = range.Columns.Count;


            //    for (rCnt = 2; rCnt <= rw; rCnt++)
            //    {
            //        //for (cCnt = 1; cCnt <= cl; cCnt++)
            //        //{
            //        //    str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
            //        //    MessageBox.Show(str);
            //        //}
            //        //if((range.Cells[rCnt, 1] as Excel.Range).Value2.GetType().Equals(typeof(int)))
            //        //{
            //        //    int ma_sinh_vien = (int)(range.Cells[rCnt, 1] as Excel.Range).Value2;
            //        //}
            //        //else
            //        //{
            //        //    MessageBox.Show("Ma sinh vien khong dung dinh dang");
            //        //}
            //        int ma_sinh_vien = (int)(range.Cells[rCnt, 1] as Excel.Range).Value2;
            //        String ho_ten = (string)(range.Cells[rCnt, 2] as Excel.Range).Value2;
            //        String ngay_sinh = (string)(range.Cells[rCnt, 3] as Excel.Range).Value2;
            //        String gioi_tinh = (string)(range.Cells[rCnt, 4] as Excel.Range).Value2;
            //        String dan_toc = (string)(range.Cells[rCnt, 5] as Excel.Range).Value2;
            //        String que_quan = (string)(range.Cells[rCnt, 6] as Excel.Range).Value2;
            //        String hoc_luc = (string)(range.Cells[rCnt, 7] as Excel.Range).Value2;
            //        String khoa_hoc = (string)(range.Cells[rCnt, 8] as Excel.Range).Value2;
            //        int nam_vao = (int)(range.Cells[rCnt, 9] as Excel.Range).Value2;
            //        int nam_ra = (int)(range.Cells[rCnt, 10] as Excel.Range).Value2;
            //        String ma_nganh_dao_tao = (string)(range.Cells[rCnt, 11] as Excel.Range).Value2;
            //        String ten_nganh_dao_tao = (string)(range.Cells[rCnt, 12] as Excel.Range).Value2;
            //        String ma_nganh_nghe = (string)(range.Cells[rCnt, 13] as Excel.Range).Value2;
            //        String ten_nganh_nghe = (string)(range.Cells[rCnt, 14] as Excel.Range).Value2;
            //        float luong_khoi_diem = (float)(range.Cells[rCnt, 15] as Excel.Range).Value2;
            //        String ten_co_quan = (string)(range.Cells[rCnt, 16] as Excel.Range).Value2;
            //        String dia_diem = (string)(range.Cells[rCnt, 17] as Excel.Range).Value2;





            //        string connString = conn;
            //        SqlConnection con = new SqlConnection(connString);
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand("select * from sinh_vien where sinh_vien.ma_sinh_vien = " + ma_sinh_vien, con);
            //        Console.WriteLine("select * from sinh_vien where sinh_vien.ma_sinh_vien = " + ma_sinh_vien);
            //        SqlDataReader data = cmd.ExecuteReader();
            //        if (data.HasRows)
            //        {
            //            while (data.Read())
            //            {
            //                MessageBox.Show(data.GetInt32(0) + "");
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show("Khong co du lieu");
            //        }

            //        con.Close();

            //    }

            //    xlWorkBook.Close(true, null, null);
            //    xlApp.Quit();
            }





            //using (OpenFileDialog ofd = new OpenFileDialog() {Filter = "Excel Workbook|*.xls",ValidateNames=true })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        Application excel = new Excel.Application();
            //    }
            //}
        //}
    }
}
