using Final.ConnectDB;
using FinalProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.IO;

namespace Final
{
    public partial class DuBaoCung : Form
    {        
        DAL_DuBao dal_dubao = new DAL_DuBao();
        static string dictionary = System.IO.Path.GetFullPath(@"..\..\..\");
        static string pathFile = dictionary + "TiLeTotNghiep.xlsx";
        static int nam;        
        public DuBaoCung()
        {
            InitializeComponent();
            int nam_db = DuBaoCung.ShowDialog("Nhập Năm Cần Dự Báo", "Nhập Năm");
            setTitle(nam_db);
            nam = nam_db - 4;
        }
        public void setTitle(int nam) {
            txtTitle.Text = txtTitle.Text + nam.ToString();
        }
        public void GUI_Truong_Load(object sender, EventArgs e)
        {
            dgvTruong.DataSource = dal_dubao.getDuBaoCung(nam);
            updateDuBaoCung();            
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;            
        }
        private List<int> getIdSelected() {
            List<int> id_selected = new List<int>();
            foreach (DataGridViewRow row in dgvTruong.SelectedRows)
            {
                int index = row.Index;
                id_selected.Add(index);
            }
            return id_selected;
        }

        private void getSoLaoDong(int i, string MaTruong, double TiLe, int check)
        {            
            String ma_truong = dgvTruong.Rows[i].Cells["ma_truong"].Value.ToString();
            if (ma_truong.Equals(MaTruong))
            {
                double chi_tieu = Convert.ToDouble(dgvTruong.Rows[i].Cells["du_bao_tuyen_sinh"].Value.ToString());
                int dubao = (int)(chi_tieu * TiLe) / 100;

                if (check == 1)
                {
                    DAL_DuBao dbcung = new DAL_DuBao();

                    object tile = dgvTruong.Rows[i].Cells["ti_le_do"].Value;
                    object db = dgvTruong.Rows[i].Cells["so_lao_dong"].Value;

                    if (tile == null && db == null)
                    {
                        dgvTruong.Rows[i].Cells["ti_le_do"].Value = TiLe;
                        dgvTruong.Rows[i].Cells["so_lao_dong"].Value = dubao;

                        DTO_DuBao dbao = new DTO_DuBao(ma_truong, (float)TiLe, dubao, nam, (int)chi_tieu);
                        dbcung.addDuBaoCung(dbao);
                    }
                    else
                    {
                        dgvTruong.Rows[i].Cells["ti_le_do"].Value = TiLe;
                        dgvTruong.Rows[i].Cells["so_lao_dong"].Value = dubao;

                        DTO_DuBao dbao = new DTO_DuBao(ma_truong, (float)TiLe, dubao, nam, (int)chi_tieu);
                        dbcung.updateDuBaoCung(dbao);
                    }
                }else {
                    dgvTruong.Rows[i].Cells["ti_le_do"].Value = TiLe;
                    dgvTruong.Rows[i].Cells["so_lao_dong"].Value = dubao;
                }                
            }            
        }

        private void getSoLaoDongDuBao(int i, int check)
        {            
            String matruong = dgvTruong.Rows[i].Cells["ma_truong"].Value.ToString();            
            if (dgvTruong.Rows[i].Cells["du_bao_tuyen_sinh"].Value.ToString() == "0")
            {
                DAL_TS ts = new DAL_TS();
                List<DTO_CT> listCt = ts.getListTS(matruong);
                int n = listCt.Count;
                int dubao_ts = 0;
                if (n != 0)
                {
                    dubao_ts = bptoithieu(listCt, n, nam);
                }

                dgvTruong.Rows[i].Cells["du_bao_tuyen_sinh"].Value = dubao_ts;

                double tile = 0;
                if (dgvTruong.Rows[i].Cells["ti_le_do"].Value != null)
                {
                    tile = Convert.ToDouble(dgvTruong.Rows[i].Cells["ti_le_do"].Value.ToString());
                }
                else
                {
                    dgvTruong.Rows[i].Cells["ti_le_do"].Value = 0;
                }
                int dubao = (int)(dubao_ts * tile) / 100;

                if (check == 1)
                {
                    object du_bao = dgvTruong.Rows[i].Cells["so_lao_dong"].Value;
                    if (du_bao != null)
                    {
                        dgvTruong.Rows[i].Cells["so_lao_dong"].Value = dubao;
                        DAL_DuBao dbcung = new DAL_DuBao();
                        DTO_DuBao dbao = new DTO_DuBao(matruong, (float)tile, dubao, nam, (int)dubao_ts);
                        dbcung.updateDuBaoCung(dbao);
                    }
                    else
                    {
                        dgvTruong.Rows[i].Cells["so_lao_dong"].Value = dubao;
                        DAL_DuBao dbcung = new DAL_DuBao();
                        DTO_DuBao dbao = new DTO_DuBao(matruong, (float)tile, dubao, nam, (int)dubao_ts);
                        dbcung.addDuBaoCung(dbao);
                    }
                }
                else 
                {
                    dgvTruong.Rows[i].Cells["so_lao_dong"].Value = dubao;
                }                
            }            
        }
        private void hideTruong(List<int> id_selected) {
            for (int i = 0; i < dgvTruong.RowCount; i++)
            {
                if (id_selected.IndexOf(i) == -1)
                {
                    dgvTruong.Rows[i].Visible = false;
                }
            }            
        }
        private void updateDuBaoCung() {
            int cung = 0;
            for (int i = 0; i < dgvTruong.RowCount; i++)
            {
                object du_bao = dgvTruong.Rows[i].Cells["so_lao_dong"].Value;
                if(du_bao != null) {
                    int db = (int)du_bao;
                    cung+= db;
                }                
            }
            db_cung.Text = cung.ToString();
        }
        private List<string> checkTiLeDo() {
            List<string> ls_truong = new List<string>();
            for (int i = 0; i < dgvTruong.RowCount; i++)
            {
                object du_bao = dgvTruong.Rows[i].Cells["so_lao_dong"].Value;
                if (du_bao == null)
                {
                    string ma_truong = dgvTruong.Rows[i].Cells["ma_truong"].Value.ToString();
                    int chi_tieu = (int)dgvTruong.Rows[i].Cells["du_bao_tuyen_sinh"].Value;
                    ls_truong.Add(ma_truong);
                    dgvTruong.Rows[i].Cells["ti_le_do"].Value = 0;
                    dgvTruong.Rows[i].Cells["so_lao_dong"].Value = 0;
                    DAL_DuBao dbcung = new DAL_DuBao();
                    DTO_DuBao dbao = new DTO_DuBao(ma_truong, 0, 0, nam, chi_tieu);
                    dbcung.addDuBaoCung(dbao);
                }
                else
                {
                    if ((int)du_bao == 0) {
                        string ma_truong = dgvTruong.Rows[i].Cells["ma_truong"].Value.ToString();
                        ls_truong.Add(ma_truong);
                    }
                }
            }
            return ls_truong;
        }
        private void btnDuBaoCung_Click(object sender, EventArgs e)
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
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName == pathFile)
            {                
                //Excel.Application xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(@"" + ofd.FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;
                cl = range.Columns.Count;
                //xoa data dubaocung cu                
                List<int> id_selected = getIdSelected();                
                if (id_selected.Count > 0) {                    
                    hideTruong(id_selected);
                }                
                for (rCnt = 2; rCnt <= rw; rCnt++)
                {   
                    Object col_1 = (range.Cells[rCnt, 1] as Excel.Range).Value2;
                    Object col_2 = (range.Cells[rCnt, 2] as Excel.Range).Value2;
                    if (col_1 != null && col_2 != null)
                    {
                        String MaTruong = (String)col_1;
                        double TiLe = (double)col_2;
                        if (id_selected.Count > 0)
                        {                            
                            foreach (int i in id_selected)
                            {
                                getSoLaoDong(i, MaTruong, TiLe,0);                                
                            }
                        }
                        else
                        {                            
                            for (int i = 0; i < dgvTruong.RowCount; i++)
                            {
                                if (textSearch.Text == "")
                                {
                                    getSoLaoDong(i, MaTruong, TiLe, 1);
                                }
                                else
                                {
                                    getSoLaoDong(i, MaTruong, TiLe, 0);
                                }                                
                            }
                        }                    
                    }                                    
                }

                //get dubaocung neu k co so lieu tuyen sinh nam do
                if (id_selected.Count > 0)
                    {
                        foreach(int i in id_selected) {
                        {
                            getSoLaoDongDuBao(i,0);                                                        
                        }                        
                    }
                }
                else
                {
                    for (int i = 0; i < dgvTruong.RowCount; i++)
                    {
                        getSoLaoDongDuBao(i,1);                            
                    }                    
                }
                List<string> ls_truong_null = checkTiLeDo();
                if (ls_truong_null.Count > 0) {
                    string mess = "Danh sách mã trường cần cập nhật thông tin Tỉ lệ đỗ:\n";
                    foreach (string truong in ls_truong_null)
                    {
                        mess += "           + " + truong + "\n";
                    }
                    MessageBox.Show(mess);
                }
                updateDuBaoCung();                
                xlApp.Workbooks.Close();
            }
            else 
            {
                MessageBox.Show("Vui long chon file TiLeTotNghiep.xlsx");
            }            
        }
        
        private int bptoithieu(List<DTO_CT> listCt,int n, int nam)
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

        public static int ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            prompt.ControlBox = false;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            textLabel.AutoSize = true;
            NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 400};
            inputBox.Maximum = 2500;
            inputBox.Minimum = 2018;
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();            
            return (int)inputBox.Value;
        }       
        private void returnListSchoolSearch(string name)
        {
            if (name.Length < 5)
            {
                (dgvTruong.DataSource as DataTable).DefaultView.RowFilter = string.Format("ma_truong='{0}'", name);
            }
            else
            {
                (dgvTruong.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenTruong like '%{0}%'", name);
            }
        } 
            
        private void quickFilter_Click(object sender, EventArgs e)
        {
            db_cung.Text = "0";                    
            string search = "";
            if (textSearch.Text != "")
            {
                search = textSearch.Text;
                returnListSchoolSearch(search);
                updateDuBaoCung();
            }
            else
            {
                dgvTruong.DataSource = dal_dubao.getDuBaoCung(nam);
                updateDuBaoCung();
            }            
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            dgvTruong.DataSource = dal_dubao.getDuBaoCung(nam);
            textSearch.Text = "";
            updateDuBaoCung();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
