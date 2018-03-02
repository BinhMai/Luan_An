namespace Final
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnDbCung = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(169)))));
            this.btnQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnQuanLy, "btnQuanLy");
            this.btnQuanLy.ForeColor = System.Drawing.Color.White;
            this.btnQuanLy.Image = global::Final.Properties.Resources.student;
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnDbCung
            // 
            this.btnDbCung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(169)))));
            this.btnDbCung.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDbCung, "btnDbCung");
            this.btnDbCung.ForeColor = System.Drawing.Color.White;
            this.btnDbCung.Image = global::Final.Properties.Resources.mentor1;
            this.btnDbCung.Name = "btnDbCung";
            this.btnDbCung.UseVisualStyleBackColor = false;
            this.btnDbCung.Click += new System.EventHandler(this.btnDbCung_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(169)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::Final.Properties.Resources.exit;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Final.Properties.Resources.LOGO;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Final.Properties.Resources.title;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(169)))));
            this.btnHuongDan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHuongDan, "btnHuongDan");
            this.btnHuongDan.ForeColor = System.Drawing.Color.White;
            this.btnHuongDan.Image = global::Final.Properties.Resources.introdce;
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources._4;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnQuanLy);
            this.Controls.Add(this.btnDbCung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnDbCung;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCung;
    }
}

