﻿
namespace BTHLab4
{
	partial class frmSinhVien
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
			this.components = new System.ComponentModel.Container();
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
			this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
			this.btnMacDinh = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnChonHinh = new System.Windows.Forms.Button();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHinh = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tảiLạiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbHinh
			// 
			this.pbHinh.Location = new System.Drawing.Point(23, 13);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(182, 233);
			this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinh.TabIndex = 0;
			this.pbHinh.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mtxtSoDT);
			this.groupBox1.Controls.Add(this.mtxtMaSo);
			this.groupBox1.Controls.Add(this.btnMacDinh);
			this.groupBox1.Controls.Add(this.btnThoat);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.btnChonHinh);
			this.groupBox1.Controls.Add(this.rdNu);
			this.groupBox1.Controls.Add(this.rdNam);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.cboLop);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtHinh);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(222, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(674, 233);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin sinh viên ";
			// 
			// mtxtSoDT
			// 
			this.mtxtSoDT.Location = new System.Drawing.Point(463, 128);
			this.mtxtSoDT.Mask = "0000.000.000";
			this.mtxtSoDT.Name = "mtxtSoDT";
			this.mtxtSoDT.Size = new System.Drawing.Size(205, 22);
			this.mtxtSoDT.TabIndex = 8;
			// 
			// mtxtMaSo
			// 
			this.mtxtMaSo.Location = new System.Drawing.Point(86, 29);
			this.mtxtMaSo.Mask = "0000000";
			this.mtxtMaSo.Name = "mtxtMaSo";
			this.mtxtMaSo.Size = new System.Drawing.Size(249, 22);
			this.mtxtMaSo.TabIndex = 0;
			// 
			// btnMacDinh
			// 
			this.btnMacDinh.Location = new System.Drawing.Point(287, 202);
			this.btnMacDinh.Name = "btnMacDinh";
			this.btnMacDinh.Size = new System.Drawing.Size(101, 25);
			this.btnMacDinh.TabIndex = 10;
			this.btnMacDinh.Text = "Mặc định";
			this.btnMacDinh.UseVisualStyleBackColor = true;
			this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(567, 202);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 25);
			this.btnThoat.TabIndex = 12;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(434, 202);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(100, 25);
			this.btnLuu.TabIndex = 11;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnChonHinh
			// 
			this.btnChonHinh.Location = new System.Drawing.Point(567, 159);
			this.btnChonHinh.Name = "btnChonHinh";
			this.btnChonHinh.Size = new System.Drawing.Size(101, 25);
			this.btnChonHinh.TabIndex = 9;
			this.btnChonHinh.Text = "Chọn hình";
			this.btnChonHinh.UseVisualStyleBackColor = true;
			this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click_1);
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(580, 64);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(47, 21);
			this.rdNu.TabIndex = 6;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Location = new System.Drawing.Point(486, 64);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(58, 21);
			this.rdNam.TabIndex = 5;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Location = new System.Drawing.Point(463, 27);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(205, 22);
			this.dtpNgaySinh.TabIndex = 4;
			// 
			// cboLop
			// 
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
			this.cboLop.Location = new System.Drawing.Point(463, 95);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(205, 24);
			this.cboLop.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(352, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "Ngày sinh";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(352, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Phái";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(352, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Lớp";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(352, 131);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Số điện thoại";
			// 
			// txtHinh
			// 
			this.txtHinh.Location = new System.Drawing.Point(86, 160);
			this.txtHinh.Name = "txtHinh";
			this.txtHinh.Size = new System.Drawing.Size(469, 22);
			this.txtHinh.TabIndex = 13;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(86, 128);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(249, 22);
			this.txtDiaChi.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(86, 95);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(249, 22);
			this.txtEmail.TabIndex = 2;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(86, 63);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(249, 22);
			this.txtHoTen.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Hình";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Địa chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ và tên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lvSinhVien);
			this.groupBox2.Location = new System.Drawing.Point(23, 252);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(873, 223);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách sinh viên";
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.CheckBoxes = true;
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lvSinhVien.ContextMenuStrip = this.contextMenuStrip1;
			this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(3, 18);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(867, 202);
			this.lvSinhVien.TabIndex = 0;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ và tên";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Phái";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày sinh";
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Lớp";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Số điện thoại";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Email";
			this.columnHeader7.Width = 120;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Địa chỉ";
			this.columnHeader8.Width = 120;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Hình";
			this.columnHeader9.Width = 100;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáToolStripMenuItem,
            this.tảiLạiDanhSáchToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(189, 52);
			// 
			// xoáToolStripMenuItem
			// 
			this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
			this.xoáToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.xoáToolStripMenuItem.Text = "Xoá";
			this.xoáToolStripMenuItem.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
			// 
			// tảiLạiDanhSáchToolStripMenuItem
			// 
			this.tảiLạiDanhSáchToolStripMenuItem.Name = "tảiLạiDanhSáchToolStripMenuItem";
			this.tảiLạiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.tảiLạiDanhSáchToolStripMenuItem.Text = "Tải lại danh sách";
			this.tảiLạiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiDanhSáchToolStripMenuItem_Click);
			// 
			// frmSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 487);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pbHinh);
			this.Name = "frmSinhVien";
			this.Text = "Quản lý sinh viên khoa CNTT";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnChonHinh;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.ComboBox cboLop;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtHinh;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MaskedTextBox mtxtSoDT;
		private System.Windows.Forms.MaskedTextBox mtxtMaSo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tảiLạiDanhSáchToolStripMenuItem;
	}
}

