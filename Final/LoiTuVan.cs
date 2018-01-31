using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class LoiTuVan : Form
    {
        public LoiTuVan()
        {
            
            InitializeComponent();
        }

        private void LoiTuVan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TuVan tv = new TuVan();
            this.Visible = false;
            tv.ShowDialog();
        }
        public int tongNhoHon6;
        public int tongNhoHon6_10;
        public int tongLonHon10;

        public int index = -1;
        public ICollection<KeyValuePair<int, String[]>> topTen;
        public void showMore_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+ topTen.Select(index));

            foreach (KeyValuePair<int, string[]> element in topTen)
            {
                if ((index + 1) % topTen.Count == element.Key|| (index + 1) % topTen.Count == 0)
                {
                    Console.WriteLine(element.Key);
                    index++;
                    if(index> topTen.Count)
                    {
                        index = 1;
                    }
                    if (element.Value[0] == "chưa rõ")
                    {
                        if (ngheNghiep.Text!= element.Value[1])
                        {
                            ngheNghiep.Text = (element.Value[1]);
                            luongKhoiDiem.Text = element.Value[2] + " VNĐ";
                            tenCoQuan.Text = "Tập đoàn FPT Hà Nội";
                            diaChiCoQuan.Text = "Bạn nên tìm một công việc tại một chi nhánh FPT Hà Nội";
                            coQuanTrucThuoc.Text = "Bộ khoa học và công nghệ ";
                            return;
                        }
                        
                    }
                    else
                    {
                        if (ngheNghiep.Text != element.Value[1])
                        {
                            ngheNghiep.Text = (element.Value[1]);
                            luongKhoiDiem.Text = element.Value[2] + " VNĐ";
                            tenCoQuan.Text = element.Value[0];
                            diaChiCoQuan.Text = element.Value[3];
                            coQuanTrucThuoc.Text = element.Value[5];
                            return;
                        }
                    }
                }
            }

        }

        private void mucLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mucLuong.SelectedIndex == 2)
            {
                tiLeMucLuong.Text = "" + tongLonHon10 * 10 + " % sinh viên có mức lương này";
            }
            if (mucLuong.SelectedIndex == 1)
            {
                tiLeMucLuong.Text = "" + tongNhoHon6_10 * 10 + " % sinh viên có mức lương này";
            }
            if (mucLuong.SelectedIndex == 0)
            {
                tiLeMucLuong.Text = "" + tongNhoHon6 * 10 + " % sinh viên có mức lương này";
            }
        }
    }
}
