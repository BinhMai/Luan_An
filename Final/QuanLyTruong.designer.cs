namespace Final
{
    partial class QuanLyTruong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTruong));
            this.label4 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbbDanToc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbViecLam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTruong = new System.Windows.Forms.DataGridView();
            this.ma_truong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVChuquan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chi_tieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNganh = new System.Windows.Forms.Panel();
            this.pnlHocLuc = new System.Windows.Forms.Panel();
            this.pnlKhoa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.quickFilter = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruong)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DisplayMember = "Nam";
            this.cbbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(78, 80);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(61, 21);
            this.cbbGioiTinh.TabIndex = 9;
            this.cbbGioiTinh.ValueMember = "Nam";
            // 
            // cbbDanToc
            // 
            this.cbbDanToc.DisplayMember = "Nam";
            this.cbbDanToc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbDanToc.FormattingEnabled = true;
            this.cbbDanToc.Items.AddRange(new object[] {
            "",
            "Kinh",
            "Tày",
            "Thái",
            "Mường",
            "Khơ-me",
            "H\'Mông",
            "Nugf",
            "Hoa",
            "Dao",
            "Gia Rai",
            "Ê Đê",
            "Ba Na",
            "Xơ Đăng",
            "Sán Đăng",
            "Cơ Ho",
            "Chăm",
            "Sán Dìu",
            "Hre",
            "Ra Giai",
            "M\'Nông",
            "X\'Tiêng",
            "Bru - Vân Kiều",
            "Thổ",
            "Khơ Mú",
            "Cơ Tu",
            "Giáy",
            "Giẻ Triêng",
            "Tà ôi",
            "Mạ",
            "Co",
            "Chơ Ro",
            "Xinh Mun",
            "Hà Nhì",
            "Chu Ru",
            "Lào",
            "Kháng",
            "La Chí",
            "Phù Lá",
            "La Hủ",
            "La Ha",
            "Pà Thẻn",
            "Chứt",
            "Lự",
            "Lô Lô",
            "Mảng",
            "Cờ Lao",
            "Bố Y",
            "Cống",
            "Ngái",
            "Si La",
            "Pu Péo",
            "Rơ măm",
            "Brâu",
            "Ơ Đu"});
            this.cbbDanToc.Location = new System.Drawing.Point(78, 130);
            this.cbbDanToc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDanToc.Name = "cbbDanToc";
            this.cbbDanToc.Size = new System.Drawing.Size(61, 21);
            this.cbbDanToc.TabIndex = 11;
            this.cbbDanToc.ValueMember = "Nam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dân tộc";
            // 
            // cbbViecLam
            // 
            this.cbbViecLam.DisplayMember = "Chọn...";
            this.cbbViecLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbViecLam.FormattingEnabled = true;
            this.cbbViecLam.Items.AddRange(new object[] {
            "",
            "Đã có việc làm",
            "Chưa có việc làm"});
            this.cbbViecLam.Location = new System.Drawing.Point(755, 78);
            this.cbbViecLam.Margin = new System.Windows.Forms.Padding(2);
            this.cbbViecLam.Name = "cbbViecLam";
            this.cbbViecLam.Size = new System.Drawing.Size(113, 21);
            this.cbbViecLam.TabIndex = 14;
            this.cbbViecLam.ValueMember = "Nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(698, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Việc làm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngành";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(162)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(163, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(639, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "QUẢN LÝ THÔNG TIN CÁC TRƯỜNG ĐẠI HỌC";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(568, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Khóa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(152, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Học lực";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTruong);
            this.panel2.Location = new System.Drawing.Point(15, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 353);
            this.panel2.TabIndex = 23;
            // 
            // dgvTruong
            // 
            this.dgvTruong.AllowUserToAddRows = false;
            this.dgvTruong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvTruong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTruong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_truong,
            this.TenTruong,
            this.DiaChi,
            this.Website,
            this.TinhThanh,
            this.DVChuquan,
            this.chi_tieu});
            this.dgvTruong.Location = new System.Drawing.Point(0, 0);
            this.dgvTruong.Name = "dgvTruong";
            this.dgvTruong.ReadOnly = true;
            this.dgvTruong.Size = new System.Drawing.Size(954, 353);
            this.dgvTruong.TabIndex = 0;
            // 
            // ma_truong
            // 
            this.ma_truong.DataPropertyName = "ma_truong";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma_truong.DefaultCellStyle = dataGridViewCellStyle10;
            this.ma_truong.HeaderText = "Mã Trường";
            this.ma_truong.Name = "ma_truong";
            this.ma_truong.ReadOnly = true;
            // 
            // TenTruong
            // 
            this.TenTruong.DataPropertyName = "TenTruong";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TenTruong.DefaultCellStyle = dataGridViewCellStyle11;
            this.TenTruong.HeaderText = "Tên Trường";
            this.TenTruong.Name = "TenTruong";
            this.TenTruong.ReadOnly = true;
            this.TenTruong.Width = 160;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle12;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 160;
            // 
            // Website
            // 
            this.Website.DataPropertyName = "Website";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Website.DefaultCellStyle = dataGridViewCellStyle13;
            this.Website.FillWeight = 70F;
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            this.Website.Width = 150;
            // 
            // TinhThanh
            // 
            this.TinhThanh.DataPropertyName = "TinhThanh";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TinhThanh.DefaultCellStyle = dataGridViewCellStyle14;
            this.TinhThanh.FillWeight = 70F;
            this.TinhThanh.HeaderText = "Tỉnh Thành";
            this.TinhThanh.Name = "TinhThanh";
            this.TinhThanh.ReadOnly = true;
            this.TinhThanh.Width = 150;
            // 
            // DVChuquan
            // 
            this.DVChuquan.DataPropertyName = "DVChuquan";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DVChuquan.DefaultCellStyle = dataGridViewCellStyle15;
            this.DVChuquan.HeaderText = "Đơn Vị Chủ Quản";
            this.DVChuquan.Name = "DVChuquan";
            this.DVChuquan.ReadOnly = true;
            // 
            // chi_tieu
            // 
            this.chi_tieu.DataPropertyName = "chi_tieu";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chi_tieu.DefaultCellStyle = dataGridViewCellStyle16;
            this.chi_tieu.FillWeight = 70F;
            this.chi_tieu.HeaderText = "Chỉ tiêu năm 2016";
            this.chi_tieu.Name = "chi_tieu";
            this.chi_tieu.ReadOnly = true;
            this.chi_tieu.Width = 80;
            // 
            // pnlNganh
            // 
            this.pnlNganh.AutoScroll = true;
            this.pnlNganh.BackColor = System.Drawing.Color.White;
            this.pnlNganh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNganh.Location = new System.Drawing.Point(377, 76);
            this.pnlNganh.Name = "pnlNganh";
            this.pnlNganh.Size = new System.Drawing.Size(181, 94);
            this.pnlNganh.TabIndex = 26;
            // 
            // pnlHocLuc
            // 
            this.pnlHocLuc.AutoScroll = true;
            this.pnlHocLuc.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlHocLuc.BackColor = System.Drawing.Color.White;
            this.pnlHocLuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHocLuc.Location = new System.Drawing.Point(202, 76);
            this.pnlHocLuc.Name = "pnlHocLuc";
            this.pnlHocLuc.Size = new System.Drawing.Size(125, 94);
            this.pnlHocLuc.TabIndex = 27;
            // 
            // pnlKhoa
            // 
            this.pnlKhoa.AutoScroll = true;
            this.pnlKhoa.BackColor = System.Drawing.Color.White;
            this.pnlKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKhoa.Location = new System.Drawing.Point(605, 77);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(80, 93);
            this.pnlKhoa.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(296, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "                                                                                 " +
                "                                    ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Final.Properties.Resources.import;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(877, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 96);
            this.button1.TabIndex = 31;
            this.button1.Text = "Import Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::Final.Properties.Resources.refresh;
            this.btnLamMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLamMoi.Location = new System.Drawing.Point(236, 560);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(109, 41);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Image = global::Final.Properties.Resources.view;
            this.btnXem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXem.Location = new System.Drawing.Point(739, 560);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(109, 41);
            this.btnXem.TabIndex = 29;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // quickFilter
            // 
            this.quickFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.quickFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quickFilter.ForeColor = System.Drawing.Color.White;
            this.quickFilter.Image = global::Final.Properties.Resources.look;
            this.quickFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quickFilter.Location = new System.Drawing.Point(755, 130);
            this.quickFilter.Margin = new System.Windows.Forms.Padding(2);
            this.quickFilter.Name = "quickFilter";
            this.quickFilter.Size = new System.Drawing.Size(113, 40);
            this.quickFilter.TabIndex = 22;
            this.quickFilter.Text = "Lọc nhanh";
            this.quickFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quickFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quickFilter.UseVisualStyleBackColor = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Image = global::Final.Properties.Resources._return;
            this.btnQuayLai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuayLai.Location = new System.Drawing.Point(97, 560);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(119, 41);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::Final.Properties.Resources.add;
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(362, 560);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 41);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::Final.Properties.Resources.edit;
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(497, 560);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 41);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::Final.Properties.Resources.delete;
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(620, 560);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // QuanLyTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources._8;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.pnlKhoa);
            this.Controls.Add(this.pnlHocLuc);
            this.Controls.Add(this.pnlNganh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.quickFilter);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbViecLam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbDanToc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "QuanLyTruong";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TRƯỜNG ĐẠI HỌC";
            this.Load += new System.EventHandler(this.GUI_Truong_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.ComboBox cbbDanToc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbViecLam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button quickFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTruong;
        private System.Windows.Forms.Panel pnlNganh;
        private System.Windows.Forms.Panel pnlHocLuc;
        private System.Windows.Forms.Panel pnlKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_truong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVChuquan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chi_tieu;
    }
}