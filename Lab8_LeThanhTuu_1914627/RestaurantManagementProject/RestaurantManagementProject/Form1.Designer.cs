
namespace RestaurantManagementProject
{
	partial class frmFood
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
			this.grpLeft = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdUpdate = new System.Windows.Forms.Button();
			this.cmdAdd = new System.Windows.Forms.Button();
			this.cmdClear = new System.Windows.Forms.Button();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.grpRight = new System.Windows.Forms.GroupBox();
			this.cmdExit = new System.Windows.Forms.Button();
			this.lblStatistic = new System.Windows.Forms.Label();
			this.lsvFood = new System.Windows.Forms.ListView();
			this.ColumnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.grpLeft.SuspendLayout();
			this.grpRight.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpLeft
			// 
			this.grpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grpLeft.Controls.Add(this.label5);
			this.grpLeft.Controls.Add(this.label4);
			this.grpLeft.Controls.Add(this.label3);
			this.grpLeft.Controls.Add(this.label2);
			this.grpLeft.Controls.Add(this.label1);
			this.grpLeft.Controls.Add(this.txtNotes);
			this.grpLeft.Controls.Add(this.cmdDelete);
			this.grpLeft.Controls.Add(this.cmdUpdate);
			this.grpLeft.Controls.Add(this.cmdAdd);
			this.grpLeft.Controls.Add(this.cmdClear);
			this.grpLeft.Controls.Add(this.cbbCategory);
			this.grpLeft.Controls.Add(this.txtPrice);
			this.grpLeft.Controls.Add(this.txtUnit);
			this.grpLeft.Controls.Add(this.txtName);
			this.grpLeft.Location = new System.Drawing.Point(12, 12);
			this.grpLeft.Name = "grpLeft";
			this.grpLeft.Size = new System.Drawing.Size(414, 508);
			this.grpLeft.TabIndex = 0;
			this.grpLeft.TabStop = false;
			this.grpLeft.Text = "Chức năng";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "Ghi chú";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 217);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Loại thực phẩm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Đơn giá";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Đơn vị tính";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Tên thực phẩm";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(100, 269);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(303, 130);
			this.txtNotes.TabIndex = 8;
			// 
			// cmdDelete
			// 
			this.cmdDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdDelete.Location = new System.Drawing.Point(322, 468);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(86, 31);
			this.cmdDelete.TabIndex = 7;
			this.cmdDelete.Text = "Xóa";
			this.cmdDelete.UseVisualStyleBackColor = true;
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdUpdate.Location = new System.Drawing.Point(218, 468);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(86, 31);
			this.cmdUpdate.TabIndex = 6;
			this.cmdUpdate.Text = "Sửa";
			this.cmdUpdate.UseVisualStyleBackColor = true;
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// cmdAdd
			// 
			this.cmdAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdAdd.Location = new System.Drawing.Point(110, 468);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(86, 31);
			this.cmdAdd.TabIndex = 5;
			this.cmdAdd.Text = "Thêm";
			this.cmdAdd.UseVisualStyleBackColor = true;
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			// 
			// cmdClear
			// 
			this.cmdClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdClear.Location = new System.Drawing.Point(6, 468);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(86, 31);
			this.cmdClear.TabIndex = 4;
			this.cmdClear.Text = "Nhập lại";
			this.cmdClear.UseVisualStyleBackColor = true;
			this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(195, 214);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(208, 24);
			this.cbbCategory.TabIndex = 3;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(258, 156);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(145, 22);
			this.txtPrice.TabIndex = 2;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(258, 100);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(145, 22);
			this.txtUnit.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(165, 38);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(238, 22);
			this.txtName.TabIndex = 0;
			// 
			// grpRight
			// 
			this.grpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpRight.Controls.Add(this.cmdExit);
			this.grpRight.Controls.Add(this.lblStatistic);
			this.grpRight.Controls.Add(this.lsvFood);
			this.grpRight.Location = new System.Drawing.Point(432, 12);
			this.grpRight.Name = "grpRight";
			this.grpRight.Size = new System.Drawing.Size(755, 508);
			this.grpRight.TabIndex = 1;
			this.grpRight.TabStop = false;
			this.grpRight.Text = "Danh Mục Thức Ăn";
			// 
			// cmdExit
			// 
			this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExit.Location = new System.Drawing.Point(674, 472);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(75, 23);
			this.cmdExit.TabIndex = 15;
			this.cmdExit.Text = "Thoát";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// lblStatistic
			// 
			this.lblStatistic.AutoSize = true;
			this.lblStatistic.Location = new System.Drawing.Point(18, 475);
			this.lblStatistic.Name = "lblStatistic";
			this.lblStatistic.Size = new System.Drawing.Size(68, 17);
			this.lblStatistic.TabIndex = 14;
			this.lblStatistic.Text = "Thống kê";
			// 
			// lsvFood
			// 
			this.lsvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader0,
            this.ColumnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lsvFood.FullRowSelect = true;
			this.lsvFood.GridLines = true;
			this.lsvFood.HideSelection = false;
			this.lsvFood.Location = new System.Drawing.Point(6, 21);
			this.lsvFood.MultiSelect = false;
			this.lsvFood.Name = "lsvFood";
			this.lsvFood.Size = new System.Drawing.Size(743, 426);
			this.lsvFood.TabIndex = 0;
			this.lsvFood.UseCompatibleStateImageBehavior = false;
			this.lsvFood.View = System.Windows.Forms.View.Details;
			this.lsvFood.Click += new System.EventHandler(this.lsvFood_Click);
			// 
			// ColumnHeader0
			// 
			this.ColumnHeader0.Text = "STT";
			// 
			// ColumnHeader1
			// 
			this.ColumnHeader1.Text = "Tên thực phẩm";
			this.ColumnHeader1.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ĐVT";
			this.columnHeader3.Width = 70;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giá";
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Loại thực phẩm";
			this.columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ghi chú";
			this.columnHeader6.Width = 150;
			// 
			// frmFood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 523);
			this.Controls.Add(this.grpRight);
			this.Controls.Add(this.grpLeft);
			this.Name = "frmFood";
			this.Text = "Thêm - Xóa - Sửa Bảng Food";
			this.Load += new System.EventHandler(this.frmFood_Load);
			this.grpLeft.ResumeLayout(false);
			this.grpLeft.PerformLayout();
			this.grpRight.ResumeLayout(false);
			this.grpRight.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpLeft;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Button cmdDelete;
		private System.Windows.Forms.Button cmdUpdate;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.GroupBox grpRight;
		private System.Windows.Forms.ListView lsvFood;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Label lblStatistic;
		private System.Windows.Forms.ColumnHeader ColumnHeader0;
		private System.Windows.Forms.ColumnHeader ColumnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}

