namespace Final
{
    partial class DuBaoCung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuBaoCung));
            this.txtTitle = new System.Windows.Forms.Label();
            this.dgvTruong = new System.Windows.Forms.DataGridView();
            this.ma_truong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.du_bao_tuyen_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ti_le_do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_lao_dong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.tiLeMucLuong = new System.Windows.Forms.Label();
            this.db_cung = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.quickFilter = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(162)))));
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTitle.Location = new System.Drawing.Point(293, 19);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(296, 31);
            this.txtTitle.TabIndex = 17;
            this.txtTitle.Text = "DỰ BÁO CUNG NĂM ";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTruong
            // 
            this.dgvTruong.AllowUserToAddRows = false;
            this.dgvTruong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvTruong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTruong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_truong,
            this.TenTruong,
            this.DiaChi,
            this.Nam,
            this.du_bao_tuyen_sinh,
            this.ti_le_do,
            this.so_lao_dong});
            this.dgvTruong.Location = new System.Drawing.Point(18, 115);
            this.dgvTruong.Name = "dgvTruong";
            this.dgvTruong.ReadOnly = true;
            this.dgvTruong.Size = new System.Drawing.Size(954, 372);
            this.dgvTruong.TabIndex = 0;
            // 
            // ma_truong
            // 
            this.ma_truong.DataPropertyName = "ma_truong";
            this.ma_truong.HeaderText = "Mã Trường";
            this.ma_truong.Name = "ma_truong";
            this.ma_truong.ReadOnly = true;
            // 
            // TenTruong
            // 
            this.TenTruong.DataPropertyName = "TenTruong";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTruong.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenTruong.HeaderText = "Tên Trường";
            this.TenTruong.MinimumWidth = 10;
            this.TenTruong.Name = "TenTruong";
            this.TenTruong.ReadOnly = true;
            this.TenTruong.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 240;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            this.Nam.Width = 70;
            // 
            // du_bao_tuyen_sinh
            // 
            this.du_bao_tuyen_sinh.DataPropertyName = "du_bao_tuyen_sinh";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.du_bao_tuyen_sinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.du_bao_tuyen_sinh.FillWeight = 70F;
            this.du_bao_tuyen_sinh.HeaderText = "Dự báo tuyển sinh";
            this.du_bao_tuyen_sinh.Name = "du_bao_tuyen_sinh";
            this.du_bao_tuyen_sinh.ReadOnly = true;
            this.du_bao_tuyen_sinh.Width = 120;
            // 
            // ti_le_do
            // 
            this.ti_le_do.DataPropertyName = "ti_le_do";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ti_le_do.DefaultCellStyle = dataGridViewCellStyle5;
            this.ti_le_do.HeaderText = "Tỉ lệ đỗ";
            this.ti_le_do.Name = "ti_le_do";
            this.ti_le_do.ReadOnly = true;
            this.ti_le_do.Width = 70;
            // 
            // so_lao_dong
            // 
            this.so_lao_dong.DataPropertyName = "so_lao_dong";
            this.so_lao_dong.HeaderText = "Số lao động";
            this.so_lao_dong.Name = "so_lao_dong";
            this.so_lao_dong.ReadOnly = true;
            this.so_lao_dong.Width = 90;
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
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInput.ForeColor = System.Drawing.Color.White;
            this.btnInput.Image = global::Final.Properties.Resources.import;
            this.btnInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInput.Location = new System.Drawing.Point(593, 538);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(133, 63);
            this.btnInput.TabIndex = 30;
            this.btnInput.Text = "Input File";
            this.btnInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnDuBaoCung_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Image = global::Final.Properties.Resources._return;
            this.btnQuayLai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuayLai.Location = new System.Drawing.Point(305, 538);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(139, 63);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // tiLeMucLuong
            // 
            this.tiLeMucLuong.AutoSize = true;
            this.tiLeMucLuong.BackColor = System.Drawing.Color.Transparent;
            this.tiLeMucLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiLeMucLuong.Location = new System.Drawing.Point(671, 503);
            this.tiLeMucLuong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tiLeMucLuong.Name = "tiLeMucLuong";
            this.tiLeMucLuong.Size = new System.Drawing.Size(94, 24);
            this.tiLeMucLuong.TabIndex = 74;
            this.tiLeMucLuong.Text = "sinh viên";
            // 
            // db_cung
            // 
            this.db_cung.FormattingEnabled = true;
            this.db_cung.Location = new System.Drawing.Point(385, 503);
            this.db_cung.Name = "db_cung";
            this.db_cung.Size = new System.Drawing.Size(269, 21);
            this.db_cung.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(257, 503);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "Dự báo cung";
            // 
            // textSearch
            // 
            this.textSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textSearch.Location = new System.Drawing.Point(662, 73);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(255, 34);
            this.textSearch.TabIndex = 76;
            // 
            // quickFilter
            // 
            this.quickFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.quickFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quickFilter.ForeColor = System.Drawing.Color.White;
            this.quickFilter.Image = global::Final.Properties.Resources.look;
            this.quickFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quickFilter.Location = new System.Drawing.Point(916, 70);
            this.quickFilter.Margin = new System.Windows.Forms.Padding(2);
            this.quickFilter.Name = "quickFilter";
            this.quickFilter.Size = new System.Drawing.Size(56, 40);
            this.quickFilter.TabIndex = 75;
            this.quickFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quickFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quickFilter.UseVisualStyleBackColor = false;
            this.quickFilter.Click += new System.EventHandler(this.quickFilter_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::Final.Properties.Resources.refresh;
            this.btnLamMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLamMoi.Location = new System.Drawing.Point(448, 538);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(141, 63);
            this.btnLamMoi.TabIndex = 77;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // DuBaoCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources._7;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.ControlBox = false;
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.quickFilter);
            this.Controls.Add(this.tiLeMucLuong);
            this.Controls.Add(this.db_cung);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvTruong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DuBaoCung";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DỰ BÁO CUNG";
            this.Load += new System.EventHandler(this.GUI_Truong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dgvTruong;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label tiLeMucLuong;
        public System.Windows.Forms.ComboBox db_cung;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_truong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn du_bao_tuyen_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ti_le_do;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_lao_dong;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button quickFilter;
        private System.Windows.Forms.Button btnLamMoi;
    }
}