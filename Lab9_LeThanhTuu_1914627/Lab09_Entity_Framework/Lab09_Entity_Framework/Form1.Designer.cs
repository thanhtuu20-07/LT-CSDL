﻿
namespace Lab09_Entity_Framework
{
	partial class Form1
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
			this.btnReloadCategory = new System.Windows.Forms.Button();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.btnReloadFood = new System.Windows.Forms.Button();
			this.btnDeleteFood = new System.Windows.Forms.Button();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.tvwCategory = new System.Windows.Forms.TreeView();
			this.lvwFood = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReloadCategory
			// 
			this.btnReloadCategory.Location = new System.Drawing.Point(146, 13);
			this.btnReloadCategory.Margin = new System.Windows.Forms.Padding(4);
			this.btnReloadCategory.Name = "btnReloadCategory";
			this.btnReloadCategory.Size = new System.Drawing.Size(67, 28);
			this.btnReloadCategory.TabIndex = 3;
			this.btnReloadCategory.Text = "R";
			this.btnReloadCategory.UseVisualStyleBackColor = true;
			this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Location = new System.Drawing.Point(238, 13);
			this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(67, 28);
			this.btnAddCategory.TabIndex = 4;
			this.btnAddCategory.Text = "+";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// btnReloadFood
			// 
			this.btnReloadFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReloadFood.Location = new System.Drawing.Point(739, 13);
			this.btnReloadFood.Margin = new System.Windows.Forms.Padding(4);
			this.btnReloadFood.Name = "btnReloadFood";
			this.btnReloadFood.Size = new System.Drawing.Size(67, 28);
			this.btnReloadFood.TabIndex = 7;
			this.btnReloadFood.Text = "R";
			this.btnReloadFood.UseVisualStyleBackColor = true;
			this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
			// 
			// btnDeleteFood
			// 
			this.btnDeleteFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteFood.Location = new System.Drawing.Point(839, 13);
			this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(4);
			this.btnDeleteFood.Name = "btnDeleteFood";
			this.btnDeleteFood.Size = new System.Drawing.Size(67, 28);
			this.btnDeleteFood.TabIndex = 8;
			this.btnDeleteFood.Text = "-";
			this.btnDeleteFood.UseVisualStyleBackColor = true;
			this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
			// 
			// btnAddFood
			// 
			this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddFood.Location = new System.Drawing.Point(935, 13);
			this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(67, 28);
			this.btnAddFood.TabIndex = 9;
			this.btnAddFood.Text = "+";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// tvwCategory
			// 
			this.tvwCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tvwCategory.Location = new System.Drawing.Point(4, 49);
			this.tvwCategory.Margin = new System.Windows.Forms.Padding(4);
			this.tvwCategory.Name = "tvwCategory";
			this.tvwCategory.Size = new System.Drawing.Size(301, 523);
			this.tvwCategory.TabIndex = 10;
			this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
			this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
			// 
			// lvwFood
			// 
			this.lvwFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvwFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvwFood.FullRowSelect = true;
			this.lvwFood.GridLines = true;
			this.lvwFood.HideSelection = false;
			this.lvwFood.Location = new System.Drawing.Point(313, 49);
			this.lvwFood.Margin = new System.Windows.Forms.Padding(4);
			this.lvwFood.MultiSelect = false;
			this.lvwFood.Name = "lvwFood";
			this.lvwFood.Size = new System.Drawing.Size(689, 523);
			this.lvwFood.TabIndex = 11;
			this.lvwFood.UseCompatibleStateImageBehavior = false;
			this.lvwFood.View = System.Windows.Forms.View.Details;
			this.lvwFood.DoubleClick += new System.EventHandler(this.lvwFood_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã số";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên đồ ăn/ thức uống";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ĐV Tính";
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giá bán";
			this.columnHeader4.Width = 120;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Nhóm mặt hàng";
			this.columnHeader5.Width = 110;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ghi chú";
			this.columnHeader6.Width = 160;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "Danh mục";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(324, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "Thực đơn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 577);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvwFood);
			this.Controls.Add(this.tvwCategory);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.btnDeleteFood);
			this.Controls.Add(this.btnReloadFood);
			this.Controls.Add(this.btnAddCategory);
			this.Controls.Add(this.btnReloadCategory);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReloadCategory;
		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.Button btnReloadFood;
		private System.Windows.Forms.Button btnDeleteFood;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.TreeView tvwCategory;
		private System.Windows.Forms.ListView lvwFood;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

