using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTHLab4
{
	public partial class frmSinhVien : Form
	{
		QuanLySinhVien qlsv;
		public frmSinhVien()
		{
			InitializeComponent();
			qlsv = new QuanLySinhVien();
			qlsv.DocTuFile();
			LoadListView();
		}
		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			sv.MaSo = this.mtxtMaSo.Text;
			sv.HoTen = this.txtHoTen.Text;
			if (rdNu.Checked)
				gt = false;
			sv.GioiTinh = gt;
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.Lop = this.cboLop.Text;
			sv.SoDT = this.mtxtSoDT.Text;
			sv.Email = this.txtEmail.Text;
			sv.DiaChi = this.txtDiaChi.Text;
			sv.Hinh = this.txtHinh.Text;
			return sv;
		}
		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.MaSo = lvitem.SubItems[0].Text;
			sv.HoTen = lvitem.SubItems[1].Text;
			sv.GioiTinh = false;
			if (lvitem.SubItems[2].Text == "Nam")
				sv.GioiTinh = true;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
			sv.Lop = lvitem.SubItems[4].Text;
			sv.SoDT = lvitem.SubItems[5].Text;
			sv.Email = lvitem.SubItems[6].Text;
			sv.DiaChi = lvitem.SubItems[7].Text;
			sv.Hinh = lvitem.SubItems[8].Text;
			return sv;
		}
		private void ThietLapThongTin(SinhVien sv)
		{
			this.mtxtMaSo.Text = sv.MaSo;
			this.txtHoTen.Text = sv.HoTen;
			if (sv.GioiTinh)
				this.rdNam.Checked = true;
			else
				this.rdNu.Checked = true;
			this.dtpNgaySinh.Value = sv.NgaySinh;
			this.cboLop.Text = sv.Lop;
			this.mtxtSoDT.Text = sv.SoDT;
			this.txtEmail.Text = sv.Email;
			this.txtDiaChi.Text = sv.DiaChi;
			this.txtHinh.Text = sv.Hinh;
			this.pbHinh.ImageLocation = sv.Hinh;
			
		}
	

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void btnChonHinh_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = openFileDialog1;
			fileDialog.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
		+ "*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|"
		+ "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
		+ "GIF files (*.gif)|*.gif| BMP files (*.bmp) | *.bmp | "
		 + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
		+ "PNG files (*.png)|*.png| All files (*.*)|*.*";
			fileDialog.InitialDirectory = Environment.CurrentDirectory;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				var filename = fileDialog.FileName;
				txtHinh.Text = filename;
				pbHinh.Load(filename);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MaSo);
			lvitem.SubItems.Add(sv.HoTen);
			string gt = "Nữ";
			if (sv.GioiTinh)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(sv.Lop);
			lvitem.SubItems.Add(sv.SoDT);
			lvitem.SubItems.Add(sv.Email);
			lvitem.SubItems.Add(sv.DiaChi);
			lvitem.SubItems.Add(sv.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}
		private void LoadListView()
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in qlsv.DanhSach)
			{
				ThemSV(sv);
			}
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			this.mtxtMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.rdNam.Checked = true;
			this.dtpNgaySinh.Value = DateTime.Now;
			this.cboLop.Text = this.cboLop.Items[0].ToString();
			this.mtxtSoDT.Text = "";
			this.txtEmail.Text = "";
			this.txtDiaChi.Text = "";
			this.txtHinh.Text = "";
			this.pbHinh.ImageLocation = "";
		}

		private void btnChonHinh_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = openFileDialog1;
			fileDialog.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
		+ "*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|"
		+ "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
		+ "GIF files (*.gif)|*.gif| BMP files (*.bmp) | *.bmp | "
		 + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
		+ "PNG files (*.png)|*.png| All files (*.*)|*.*";
			fileDialog.InitialDirectory = Environment.CurrentDirectory;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				var filename = fileDialog.FileName;
				txtHinh.Text = filename;
				pbHinh.Load(filename);
			}
		}

		private int SoSanhTheoMa(object obj1, object obj2)
		{
			SinhVien sv = obj2 as SinhVien;
			return sv.MaSo.CompareTo(obj1);
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			//Sửa
			SinhVien sv = GetSinhVien();
			bool kqsua;
			kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
			if (kqsua)
			{
				this.LoadListView();
			}

			//Thêm
			try
			{
				SinhVien sinhVien = GetSinhVien();
				qlsv.Them(sinhVien);
				this.LoadListView();
				MessageBox.Show("Đã thêm sinh viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show("Đã chỉnh sửa sinh viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int count, i;
			ListViewItem lvitem;
			count = this.lvSinhVien.Items.Count - 1;
			for (i = count; i >= 0; i--)
			{
				lvitem = this.lvSinhVien.Items[i];
				if (lvitem.Checked)
					qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
			}
			this.LoadListView();
			this.btnMacDinh.PerformClick();
		}

		private void tảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			qlsv = new QuanLySinhVien();
			qlsv.DocTuFile();
			LoadListView();
		}

		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.lvSinhVien.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
				SinhVien sv = GetSinhVienLV(lvitem);
				ThietLapThongTin(sv);
			}
		}
	}
}
