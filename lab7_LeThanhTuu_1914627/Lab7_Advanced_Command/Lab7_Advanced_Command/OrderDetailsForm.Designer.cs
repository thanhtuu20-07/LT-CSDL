﻿
namespace Lab7_Advanced_Command
{
	partial class OrderDetailsForm
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
			this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvOrderDetail
			// 
			this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetail.Location = new System.Drawing.Point(3, 5);
			this.dgvOrderDetail.Name = "dgvOrderDetail";
			this.dgvOrderDetail.RowHeadersWidth = 51;
			this.dgvOrderDetail.RowTemplate.Height = 24;
			this.dgvOrderDetail.Size = new System.Drawing.Size(796, 442);
			this.dgvOrderDetail.TabIndex = 0;
			// 
			// OrderDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvOrderDetail);
			this.Name = "OrderDetailsForm";
			this.Text = "OrderDetailsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOrderDetail;
	}
}