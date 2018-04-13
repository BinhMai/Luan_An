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
        DAL_Truong dal_truong = new DAL_Truong();
        static string dictionary = System.IO.Path.GetFullPath(@"..\..\..\");
        static string pathFile = dictionary + "TiLeTotNghiep.xlsx"; 
        public DuBaoCung()
        {
            InitializeComponent();
        }
        public void GUI_Truong_Load(object sender, EventArgs e)
        {
            dgvSchools.DataSource = dal_truong.getDuBaoCung();
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
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
            int cung = 0;
            List<DTO_CT> listCt = new List<DTO_CT>();

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName == pathFile)
            {
                //Excel.Application xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(@"" + ofd.FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;
                cl = range.Columns.Count;

                for (rCnt = 2; rCnt <= rw; rCnt++)
                {
                    String MaTruong = (String)(range.Cells[rCnt, 1] as Excel.Range).Value2;
                    double TiLe = (double)(range.Cells[rCnt, 2] as Excel.Range).Value2;

                    for (int i = 0; i < dgvSchools.RowCount; i++)
                    {
                        String ma_truong = dgvSchools.Rows[i].Cells["ma_truong"].Value.ToString();
                        if (ma_truong.Equals(MaTruong))
                        {
                            double chi_tieu = Convert.ToDouble(dgvSchools.Rows[i].Cells["chi_tieu"].Value.ToString());
                            int dubao = (int)(chi_tieu * TiLe) / 100;
                            cung += dubao;

                            dgvSchools.Rows[i].Cells["ti_le"].Value = TiLe;
                            dgvSchools.Rows[i].Cells["du_bao"].Value = dubao;
                        }
                    }
                }
                for (int i = 0; i < dgvSchools.RowCount; i++)
                {
                    String matruong = dgvSchools.Rows[i].Cells["ma_truong"].Value.ToString();
                    if (dgvSchools.Rows[i].Cells["chi_tieu"].Value.ToString() == "0")
                    {
                        DBConnect db = new DBConnect();
                        db._conn.Open();
                        string SQL = string.Format("Select Nam,ChiTieu from TuyenSinh where MaTruong = '" + matruong + "'");
                        Console.WriteLine(SQL);
                        // Command
                        SqlCommand cmd = new SqlCommand(SQL, db._conn);
                        SqlDataReader data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            DTO_CT ct = new DTO_CT(Int32.Parse(data[0].ToString()), Int32.Parse(data[1].ToString()));
                            listCt.Add(ct);
                        }

                        db._conn.Close();

                        double X = 0, Y = 0, XY = 0, XX = 0;
                        int n = listCt.Count;

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

                        int dubao_ts = (int)(2016 * b1 + b2);
                        dgvSchools.Rows[i].Cells["chi_tieu"].Value = dubao_ts;

                        double tile = Convert.ToDouble(dgvSchools.Rows[i].Cells["ti_le"].Value.ToString());
                        int dubao = (int)(dubao_ts * tile) / 100;
                        dgvSchools.Rows[i].Cells["du_bao"].Value = dubao;

                        cung += dubao;
                    }
                }
                db_cung.Text = cung.ToString();
            }
            else 
            {
                MessageBox.Show("Vui long chon file TiLeTotNghiep.xlsx");
            }            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }        
    }
}
