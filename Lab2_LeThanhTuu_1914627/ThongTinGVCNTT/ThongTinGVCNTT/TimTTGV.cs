using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongTinGVCNTT
{
	public partial class TimTTGV : Form
	{
        private QuanLyGiaoVien quanlyGV;
        public TimTTGV()
		{
			InitializeComponent();
		}
        public TimTTGV(QuanLyGiaoVien qlgv) : this()
        {
            quanlyGV = qlgv;
        }

        private void button1_Click(object sender, EventArgs e)
		{
            var kieuTim = KieuTim.TheoHoTen;
            if (radioButton1.Checked)
            {
                kieuTim = KieuTim.TheoMa;
            }
            else if (radioButton2.Checked)
            {
                kieuTim = KieuTim.TheoHoTen;
            }
            else if (radioButton3.Checked)
            {
                kieuTim = KieuTim.TheoSDT;
            }

            var ketQua = quanlyGV.Tim(textBox1.Text, kieuTim);

            if (ketQua is null)
            {
                MessageBox.Show("Không tìm thấy thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmTBGiaoVien frm = new frmTBGiaoVien();
                frm.SetText(ketQua.ToString());
                frm.ShowDialog();
            }
        }

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
            if (radioButton1.Checked)
            {
                label1.Text = radioButton1.Text;
                textBox1.Text = "";
            }
        }

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
            if (radioButton2.Checked)
            {
                label1.Text = radioButton2.Text;
                textBox1.Text = "";
            }
        }

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
            if (radioButton3.Checked)
            {
                label1.Text = radioButton3.Text;
                textBox1.Text = "";
            }
        }
	}
}
