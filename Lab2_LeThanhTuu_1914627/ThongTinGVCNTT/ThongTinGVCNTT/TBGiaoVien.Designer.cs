﻿
namespace ThongTinGVCNTT
{
	partial class frmTBGiaoVien
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
			this.lblThongBao = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblThongBao
			// 
			this.lblThongBao.AutoSize = true;
			this.lblThongBao.Location = new System.Drawing.Point(45, 29);
			this.lblThongBao.Name = "lblThongBao";
			this.lblThongBao.Size = new System.Drawing.Size(46, 17);
			this.lblThongBao.TabIndex = 0;
			this.lblThongBao.Text = "label1";
			// 
			// frmTBGiaoVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 225);
			this.Controls.Add(this.lblThongBao);
			this.Name = "frmTBGiaoVien";
			this.Text = "Thông tin giáo viên nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblThongBao;
	}
}