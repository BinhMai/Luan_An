using Final.ConnectDB;
using FinalProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Final
{
    public partial class QuanLySV : Form
    {
        DAL_SinhVien dal_sv = new DAL_SinhVien();
        public QuanLySV()
        {
            InitializeComponent();
            addBranchToListBox();
            addAbilityToListBox();
            addCourseToListBox();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;
        }
        public void GUI_SinhVien_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = dal_sv.getSinhVien(); // get sinh vien
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
            this.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EditStudent edit = new EditStudent();
            edit.Show();
            this.Visible = false;
            // Lấy thứ tự record hiện hành 
            int r = dgvStudent.CurrentCell.RowIndex; 
            // Lấy mã sinh viên của record hiện hành 
            string maSV = dgvStudent.Rows[r].Cells[0].Value.ToString();
            string hoten = dgvStudent.Rows[r].Cells[1].Value.ToString();
            string ngaysinh = dgvStudent.Rows[r].Cells[2].Value.ToString();
            string gioitinh = dgvStudent.Rows[r].Cells[3].Value.ToString();
            string dantoc = dgvStudent.Rows[r].Cells[4].Value.ToString();
            string quequan = dgvStudent.Rows[r].Cells[5].Value.ToString();
            string khoa = dgvStudent.Rows[r].Cells[6].Value.ToString();
            string hocluc = dgvStudent.Rows[r].Cells[7].Value.ToString();
            string nganh = dgvStudent.Rows[r].Cells[8].Value.ToString();
            string vieclam = dgvStudent.Rows[r].Cells[9].Value.ToString();
            string coquan = dgvStudent.Rows[r].Cells[10].Value.ToString();

            edit.setMaSV(maSV);
            edit.setHoTen(hoten);
            edit.setGioiTinh(gioitinh);
            edit.setDanToc(dantoc);
            edit.setNgaySinh(ngaysinh);
            edit.setKhoa(khoa);
            edit.setHocLuc(hocluc);
            edit.setNganh(nganh);
            edit.setViecLam(vieclam);
            edit.setQueQuan(quequan);
            edit.setCoQuan(coquan);

        }

        private int left = 3;
        private int top = 3;
        private int distance = 20;

        private void addBranchToListBox()
        {
            DBConnect db = new DBConnect();
            db._conn.Open();
            string SQL = string.Format("Select ten_nganh from nganh_dao_tao");
            // Command
            SqlCommand cmd = new SqlCommand(SQL, db._conn);
            SqlDataReader data = cmd.ExecuteReader();
            int i = 0;
            while (data.Read())
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(left, top + distance * i);
                checkBox.Name = data.GetString(0);
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 0;
                checkBox.Text = data.GetString(0);
                checkBox.UseVisualStyleBackColor = true;
                checkBox.Font = new Font(checkBox.Font.FontFamily, 10f);

                pnlNganh.Controls.Add(checkBox);
                i++;
            }
            db._conn.Close();
        }


        private void addAbilityToListBox()
        {
            string[] ability = new string[] { "Trung bình", "Khá", "Giỏi", "Xuất sắc" };
            for(int i = 0; i < ability.Length; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(left, top + distance * i);
                checkBox.Name = "checkBoxHL";
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 0;
                checkBox.Text = ability[i];
                checkBox.UseVisualStyleBackColor = true;
                checkBox.Font = new Font(checkBox.Font.FontFamily, 9.5f);

                pnlHocLuc.Controls.Add(checkBox);
            }
        }

        private void addCourseToListBox()
        {
            string[] course = new string[] { "K51", "K52", "K53", "K54", "K55", "K56" };
            for (int i = 0; i < course.Length; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(left, top + distance * i);
                checkBox.Name = "checkBoxHL";
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 0;
                checkBox.Text = course[i];
                checkBox.UseVisualStyleBackColor = true;
                checkBox.Font = new Font(checkBox.Font.FontFamily, 10f);

                pnlKhoa.Controls.Add(checkBox);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?.", "Xác nhận xóa", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                // Lấy thứ tự record hiện hành
                int r = dgvStudent.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string maSV = dgvStudent.Rows[r].Cells[0].Value.ToString();
                if (dal_sv.xoaSinhVien(maSV))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvStudent.DataSource = dal_sv.getSinhVien(); // load lại table
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
           
        }

        private void quickFilter_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db._conn.Open();
            //string union_sql = "SELECT ma_sinh_vien, ho_ten, ngay_sinh, dan_toc, gioi_tinh, hoc_luc, nganh_dao_tao.ten_nganh as ten_nganh_dao_tao, nganh_nghe as ten_nganh_lam_viec, khoa_hoc.khoa as khoa_hoc FROM sinh_vien Inner Join nganh_dao_tao on nganh_dao_tao.ma_nganh = sinh_vien.ma_nganh inner join khoa_hoc on khoa_hoc.khoa = sinh_vien.khoa where sinh_vien.nganh_nghe IS NULL";
            string sql = "SELECT ma_sinh_vien, ho_ten, ngay_sinh, gioi_tinh, dan_toc, que_quan, ma_khoa_hoc, hoc_luc, nganh_dao_tao.ten_nganh as ten_nganh_dao_tao, nganh_nghe.ten_nganh as ten_nganh_lam_viec, ten_co_quan FROM sinh_vien Inner Join nganh_dao_tao on nganh_dao_tao.ma_nganh_dao_tao = sinh_vien.ma_nganh_dao_tao inner join nganh_nghe on (nganh_nghe.ma_nganh_nghe = sinh_vien.ma_nganh_nghe) AND 1 = 1";
            string gioitinh = "";
            if(cbbGioiTinh.Text == ""){
                gioitinh = "";
            }
            else {
                gioitinh = cbbGioiTinh.SelectedItem.ToString();
            }

            if (gioitinh == "")
            {
                sql += " ";
            }
            else
            {
                if(gioitinh == "Cả hai")
                {
                    sql += " AND (gioi_tinh = 'Nam' OR gioi_tinh = N'Nữ')";
                }
                else
                {
                    sql += " AND gioi_tinh = N'" +gioitinh+"'";
                }
            }

            string dantoc = "";
            if(cbbDanToc.Text == "")
            {
                dantoc = "";
            }
            else
            {
                dantoc = cbbDanToc.SelectedItem.ToString();
            }

            if(dantoc == "")
            {
                sql += " ";
            }
            else
            {
                if (dantoc == "Cả hai")
                {
                    sql += " AND (dan_toc = 'Kinh' OR dan_toc = 'Khác')";
                }
                else
                {
                    sql += " AND dan_toc = '" + dantoc+"'";
                }
            }

            string vieclam = "";
            if(cbbViecLam.Text == "")
            {
                vieclam = "";
            }
            else
            {
                vieclam = cbbViecLam.SelectedItem.ToString();
            }

            if(vieclam == "")
            {
                sql += " ";
            }
            else
            {
                if(vieclam == "Cả hai")
                {
                    sql += " AND (nganh_nghe.ten_nganh IS NULL OR nganh_nghe.ten_nganh IS NOT NULL)";
                }
                else if(vieclam == "Đã có việc làm")
                {
                    sql += " AND nganh_nghe.ten_nganh IS NOT NULL";

                }
                else if(vieclam == "Chưa có việc làm")
                {
                    sql += " AND nganh_nghe.ten_nganh IS NULL";
                }
            }

            //get data nganh_dao_tao in listbox
            string s = "";
            foreach (Control c in pnlNganh.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    s += c.Text +",";
                }
            }

            char[] delimiterChars = { ',' };
            if(s == "")
            {
                sql += "";
            }
            else
            {
                string[] nganh_dao_tao = s.Split(delimiterChars);
                if (nganh_dao_tao.Length == 1)
                {
                    sql += " AND nganh_dao_tao.ten_nganh = N'" + nganh_dao_tao[0] + "'";
                }
                else
                {
                    sql += " AND (nganh_dao_tao.ten_nganh = N'" + nganh_dao_tao[0] + "'";
                    for (int i = 1; i < nganh_dao_tao.Length; i++)
                    {
                        sql += " OR nganh_dao_tao.ten_nganh = N'" + nganh_dao_tao[i] + "'";
                    }
                    sql += ")";
                }
            }
            

            //get data hoc_luc in listbox
            string str = "";
            foreach (Control c in pnlHocLuc.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    str += c.Text + ",";
                }
            }
            if (str == "")
            {
                sql += "";
            }
            else
            {
                string[] hoc_luc = str.Split(delimiterChars);
                if (hoc_luc.Length == 1)
                {
                    sql += " AND hoc_luc = N'" + hoc_luc[0] + "'";
                }
                else
                {
                    sql += " AND (hoc_luc = N'" + hoc_luc[0] + "'";
                    for (int i = 1; i < hoc_luc.Length; i++)
                    {
                        sql += " OR hoc_luc = N'" + hoc_luc[i] + "'";
                    }
                    sql += ")";
                }
            }

            //get data khoa hoc in listbox
            string strKH = "";
            foreach (Control c in pnlKhoa.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    if(c.Text == "K51")
                    {
                        strKH += "QH.2006.T.,";
                    }
                    else if (c.Text == "K52")
                    {
                        strKH += "QH.2007.T.,";
                    }
                    else if (c.Text == "K53")
                    {
                        strKH += "QH.2008.T.,";
                    }
                    else if (c.Text == "K54")
                    {
                        strKH += "QH.2009.T.,";
                    }
                    else if (c.Text == "K55")
                    {
                        strKH += "QH.2010.T.,";
                    }
                    else if (c.Text == "K56")
                    {
                        strKH += "QH.2011.T.,";
                    }
                }
            }

            if (strKH == "")
            {
                sql += "";
            }
            else
            {
                string[] khoa_hoc = strKH.Split(delimiterChars);
                if (khoa_hoc.Length == 1)
                {
                    sql += " AND ma_khoa_hoc = N'" + khoa_hoc[0] + "'";
                }
                else
                {
                    sql += " AND (ma_khoa_hoc = N'" + khoa_hoc[0] + "'";
                    for (int i = 1; i < khoa_hoc.Length; i++)
                    {
                        sql += "OR ma_khoa_hoc = N'" + khoa_hoc[i] + "'";
                    }
                    sql += ")";
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, db._conn);
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            dgvStudent.DataSource = dtSinhVien ;
            db._conn.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = dal_sv.getSinhVien(); // load lại table
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowStudent show = new ShowStudent();
            show.Show();
            this.Visible = false;
            // Lấy thứ tự record hiện hành 
            int r = dgvStudent.CurrentCell.RowIndex;
            // Lấy mã sinh viên của record hiện hành 
            string maSV = dgvStudent.Rows[r].Cells[0].Value.ToString();
            string hoten = dgvStudent.Rows[r].Cells[1].Value.ToString();
            string ngaysinh = dgvStudent.Rows[r].Cells[2].Value.ToString();
            string gioitinh = dgvStudent.Rows[r].Cells[3].Value.ToString();
            string dantoc = dgvStudent.Rows[r].Cells[4].Value.ToString();
            string quequan = dgvStudent.Rows[r].Cells[5].Value.ToString();
            string khoa = dgvStudent.Rows[r].Cells[6].Value.ToString();
            string hocluc = dgvStudent.Rows[r].Cells[7].Value.ToString();
            string nganh = dgvStudent.Rows[r].Cells[8].Value.ToString();
            string vieclam = dgvStudent.Rows[r].Cells[9].Value.ToString();
            string coquan = dgvStudent.Rows[r].Cells[10].Value.ToString();

            show.setMaSV(maSV);
            show.setHoTen(hoten);
            show.setGioiTinh(gioitinh);
            show.setDanToc(dantoc);
            show.setNgaySinh(ngaysinh);
            show.setKhoa(khoa);
            show.setHocLuc(hocluc);
            show.setNganh(nganh);
            show.setViecLam(vieclam);
            show.setQueQuan(quequan);
            show.setCoQuan(coquan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getExcelFile();
        }

        private void getExcelFile()
        {
            Console.WriteLine("Start");
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Excel.Application xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(@"" + ofd.FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;
                cl = range.Columns.Count;
                string confirm = "";
                //try
                //{
                    for (rCnt = 2; rCnt <= rw; rCnt++)
                    {

                        double ma_sinh_vien = (double)(range.Cells[rCnt, 1] as Excel.Range).Value2;
                        String ho_ten = (string)(range.Cells[rCnt, 2] as Excel.Range).Value2;
                        double ngay_sinh = (double)(range.Cells[rCnt, 3] as Excel.Range).Value2;
                        String gioi_tinh = (string)(range.Cells[rCnt, 4] as Excel.Range).Value2;
                        String dan_toc = (string)(range.Cells[rCnt, 5] as Excel.Range).Value2;
                        String que_quan = (string)(range.Cells[rCnt, 6] as Excel.Range).Value2;
                        String hoc_luc = (string)(range.Cells[rCnt, 7] as Excel.Range).Value2;
                        String ma_khoa_hoc = (string)(range.Cells[rCnt, 8] as Excel.Range).Value2;
                        double nam_vao = (double)(range.Cells[rCnt, 9] as Excel.Range).Value2;
                        double nam_ra = (double)(range.Cells[rCnt, 10] as Excel.Range).Value2;
                        double ma_nganh_dao_tao = (double)(range.Cells[rCnt, 11] as Excel.Range).Value2;
                        String ten_nganh_dao_tao = (string)(range.Cells[rCnt, 12] as Excel.Range).Value2;
                        String ma_nganh_nghe = (string)(range.Cells[rCnt, 13] as Excel.Range).Value2;
                        String ten_nganh_nghe = (string)(range.Cells[rCnt, 14] as Excel.Range).Value2;
                        double luong_khoi_diem = (double)(range.Cells[rCnt, 15] as Excel.Range).Value2;
                        String ten_co_quan = (string)(range.Cells[rCnt, 16] as Excel.Range).Value2;
                        String dia_chi = (string)(range.Cells[rCnt, 17] as Excel.Range).Value2;
                        String tinh = (string)(range.Cells[rCnt, 18] as Excel.Range).Value2;
                        String co_quan_quan_ly = (string)(range.Cells[rCnt, 19] as Excel.Range).Value2;
                        DateTime ngaySinh = DateTime.FromOADate(ngay_sinh);
                        String ngSinh = ngaySinh.ToString("MM/dd/yyyy");
                        Console.WriteLine(ngSinh);
                     
                        DBConnect connect = new DBConnect();
                        connect._conn.Open();

                        SqlCommand cmd = new SqlCommand("select * from sinh_vien where sinh_vien.ma_sinh_vien = " + ma_sinh_vien, connect._conn);
                        SqlDataReader dataMaSV = cmd.ExecuteReader();


                        if (dataMaSV.HasRows)
                        {
                            connect._conn.Close();
                            confirm += ma_sinh_vien + ", ";
                        }
                        else
                        {
                            connect._conn.Close();

                            connect._conn.Open();
                            SqlCommand khoaHoc = new SqlCommand("select * from khoa_hoc where khoa_hoc.ma_khoa_hoc = N'" + ma_khoa_hoc + "'", connect._conn);
                            SqlDataReader dataKH = khoaHoc.ExecuteReader();
                            if (dataKH.HasRows)
                            {
                                connect._conn.Close();
                            }
                            else
                            {
                                connect._conn.Close();
                                connect._conn.Open();
                                SqlCommand queryKH = new SqlCommand("Insert into khoa_hoc(ma_khoa_hoc, nam_vao, nam_ra) values('" + ma_khoa_hoc + "','" + nam_vao + "','" + nam_ra + "')", connect._conn);
                                queryKH.ExecuteNonQuery();
                                connect._conn.Close();
                            }


                            connect._conn.Open();
                            SqlCommand nganhDaoTao = new SqlCommand("select * from nganh_dao_tao where nganh_dao_tao.ma_nganh_dao_tao = N'" + ma_nganh_dao_tao + "'", connect._conn);
                            SqlDataReader dataNganhDT = nganhDaoTao.ExecuteReader();
                            if (dataNganhDT.HasRows)
                            {
                                connect._conn.Close();
                            }
                            else
                            {
                                connect._conn.Close();
                                connect._conn.Open();
                                SqlCommand queryDaoTao = new SqlCommand("Insert into nganh_dao_tao(ma_nganh_dao_tao, ten_nganh) values('" + ma_nganh_dao_tao + "',N'" + ten_nganh_dao_tao + "')", connect._conn);
                                queryDaoTao.ExecuteNonQuery();
                                connect._conn.Close();
                            }

                            connect._conn.Open();
                            SqlCommand nganhNghe = new SqlCommand("select * from nganh_nghe where nganh_nghe.ma_nganh_nghe = '" + ma_nganh_nghe + "'", connect._conn);
                            SqlDataReader dataNghe = nganhNghe.ExecuteReader();
                            if (dataNghe.HasRows)
                            {
                                connect._conn.Close();
                            }
                            else
                            {
                                connect._conn.Close();

                                connect._conn.Open();
                                SqlCommand queryNghe = new SqlCommand("Insert into nganh_nghe(ma_nganh_nghe, ten_nganh, luong_khoi_diem) values('" + ma_nganh_nghe + "',N'" + ten_nganh_nghe + "', '" + luong_khoi_diem + "')", connect._conn);
                                queryNghe.ExecuteNonQuery();
                                connect._conn.Close();
                            }

                            connect._conn.Open();
                            SqlCommand coQuan = new SqlCommand("select * from co_quan where co_quan.ten_co_quan = N'" + ten_co_quan + "'", connect._conn);
                            SqlDataReader dataCoQuan = coQuan.ExecuteReader();
                            if (dataCoQuan.HasRows)
                            {
                                connect._conn.Close();
                            }
                            else
                            {
                                connect._conn.Close();
                                connect._conn.Open();
                                SqlCommand queryCoQuan = new SqlCommand("Insert into co_quan(ten_co_quan, dia_chi, tinh, co_quan_quan_li) values(N'" + ten_co_quan + "',N'" + dia_chi + "', N'" + tinh + "', N'" + co_quan_quan_ly + "')", connect._conn);
                                queryCoQuan.ExecuteNonQuery();
                                connect._conn.Close();
                            }

                            connect._conn.Open();
                            SqlCommand querySV = new SqlCommand("INSERT INTO sinh_vien(ma_sinh_vien, ho_ten, ngay_sinh, gioi_tinh, dan_toc, que_quan, ma_khoa_hoc, hoc_luc, ma_nganh_dao_tao, ma_nganh_nghe, ten_co_quan) VALUES ('" + ma_sinh_vien + "',N'" + ho_ten + "','" + ngSinh + "',N'" + gioi_tinh + "',N'" + dan_toc + "',N'" + que_quan + "','" + ma_khoa_hoc + "',N'" + hoc_luc + "',N'" + ma_nganh_dao_tao + "',N'" + ma_nganh_nghe + "',N'" + ten_co_quan + "')", connect._conn);
                            querySV.ExecuteNonQuery();
                            connect._conn.Close();

                        }



                    }
                //}
                //catch
                //{
                //    MessageBox.Show("Đã xảy ra lỗi trong quá trình import! Vui lòng kiểm tra lại !");
                //}


                if (confirm != "")
                {
                    confirm = confirm.Substring(0, confirm.Length - 2);
                    Console.WriteLine("Các mã sinh viên đã tồn tại !\n" + confirm);
                    MessageBox.Show("Các mã sinh viên đã tồn tại !\n" + confirm);
                }

                MessageBox.Show("Hoàn thành quá trình import");



                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
            }



        }
    }
}
