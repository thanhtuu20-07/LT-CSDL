using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTHLab4
{
	public delegate int SoSanh(object sv1, object sv2);
	public class QuanLySinhVien
	{
		public List<SinhVien> DanhSach;
		public QuanLySinhVien()
		{
			DanhSach = new List<SinhVien>();
		}
		public SinhVien this[int index]
		{
			get { return DanhSach[index]; }
			set { DanhSach[index] = value; }
		}

		public void Them(SinhVien sinhVien)
		{
			var isExists = DanhSach.Exists(sv => sv.MaSo == sinhVien.MaSo);
			if (isExists)
				throw new ArgumentException("Sinh viên có mã: " + sinhVien.MaSo + " đã tồn tại");
			DanhSach.Add(sinhVien);
		}

		public void Xoa(object obj, SoSanh ss)
		{
			int i = DanhSach.Count - 1;
			for (; i >= 0; i--)
				if (ss(obj, this[i]) == 0)
					this.DanhSach.RemoveAt(i);
		}
		
		public bool Sua(SinhVien svsua, object obj, SoSanh ss)
		{
			int i, count;
			bool kq = false;
			count = this.DanhSach.Count - 1;
			for (i = 0; i < count; i++)
				if (ss(obj, this[i]) == 0)
				{
					this[i] = svsua;
					kq = true;
					break;
				}
			return kq;
		}
		public void DocTuFile()
		{
			string filename = "DanhSachSV.txt", t;
			string[] s;
			SinhVien sv;
			StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
			while ((t = sr.ReadLine()) != null)
			{
				s = t.Split('_');
				sv = new SinhVien();
				sv.MaSo = s[0];
				sv.HoTen = s[1];
				sv.GioiTinh = false;
				if (s[2] == "1")
					sv.GioiTinh = true;
				sv.NgaySinh = DateTime.Parse(s[3]);
				sv.Lop = s[4];
				sv.SoDT = s[5];
				sv.Email = s[6];
				sv.DiaChi = s[7];
				sv.Hinh = s[8];
				this.Them(sv);
			}
		}
	}
}
