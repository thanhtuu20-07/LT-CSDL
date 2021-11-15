
namespace Lab7_Advanced_Command
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
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvFoodList = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblCatName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSearchByName = new System.Windows.Forms.TextBox();
			this.btnOrder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(153, 12);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(287, 24);
			this.cbbCategory.TabIndex = 0;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Chọn nhóm món ăn:";
			// 
			// dgvFoodList
			// 
			this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvFoodList.Location = new System.Drawing.Point(2, 92);
			this.dgvFoodList.MultiSelect = false;
			this.dgvFoodList.Name = "dgvFoodList";
			this.dgvFoodList.RowHeadersWidth = 51;
			this.dgvFoodList.RowTemplate.Height = 24;
			this.dgvFoodList.Size = new System.Drawing.Size(675, 416);
			this.dgvFoodList.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmAddFood,
            this.tsmUpdateFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(225, 76);
			// 
			// tsmCalculateQuantity
			// 
			this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
			this.tsmCalculateQuantity.Size = new System.Drawing.Size(224, 24);
			this.tsmCalculateQuantity.Text = "Tổng số lượng đã bán";
			this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
			// 
			// tsmAddFood
			// 
			this.tsmAddFood.Name = "tsmAddFood";
			this.tsmAddFood.Size = new System.Drawing.Size(224, 24);
			this.tsmAddFood.Text = "Thêm món ăn";
			this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
			// 
			// tsmUpdateFood
			// 
			this.tsmUpdateFood.Name = "tsmUpdateFood";
			this.tsmUpdateFood.Size = new System.Drawing.Size(224, 24);
			this.tsmUpdateFood.Text = "Cập nhật món ăn";
			this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(92, 520);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(80, 17);
			this.lblQuantity.TabIndex = 3;
			this.lblQuantity.Text = "Có tất cả ...";
			// 
			// lblCatName
			// 
			this.lblCatName.AutoSize = true;
			this.lblCatName.Location = new System.Drawing.Point(333, 520);
			this.lblCatName.Name = "lblCatName";
			this.lblCatName.Size = new System.Drawing.Size(149, 17);
			this.lblCatName.TabIndex = 4;
			this.lblCatName.Text = "món ăn thuộc nhóm ...";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tìm kiếm theo tên:";
			// 
			// txtSearchByName
			// 
			this.txtSearchByName.Location = new System.Drawing.Point(153, 49);
			this.txtSearchByName.Name = "txtSearchByName";
			this.txtSearchByName.Size = new System.Drawing.Size(287, 22);
			this.txtSearchByName.TabIndex = 6;
			this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
			// 
			// btnOrder
			// 
			this.btnOrder.Location = new System.Drawing.Point(480, 12);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(189, 23);
			this.btnOrder.TabIndex = 7;
			this.btnOrder.Text = "Danh Sách Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 544);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.txtSearchByName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblCatName);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.dgvFoodList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbCategory);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblCatName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
		private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
		private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSearchByName;
		private System.Windows.Forms.Button btnOrder;
	}
}

