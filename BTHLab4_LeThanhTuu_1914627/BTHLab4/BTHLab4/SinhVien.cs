using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTHLab4
{
	public class SinhVien
	{
		public string MaSo { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Lop { get; set; }
		public bool GioiTinh { get; set; }
		public string  SoDT { get; set; }
		public string Email { get; set; }
		public string DiaChi { get; set; }
		public string Hinh { get; set; }
		public SinhVien()
		{

		}

		public SinhVien(string ms, string ht, DateTime ngay, string lop, bool gt, string sdt, string email, string dc, string hinh )
		{
			this.MaSo = ms;
			this.HoTen = ht;
			this.NgaySinh = ngay;
			this.Lop = lop;
			this.GioiTinh = gt;
			this.SoDT = sdt;
			this.Email = email;
			this.DiaChi = dc;
			this.Hinh = hinh;
		}
	}
}
