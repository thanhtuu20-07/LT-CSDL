
namespace Lab7_Advanced_Command
{
	partial class FoodInfoForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFoodID = new System.Windows.Forms.TextBox();
			this.cbbCatName = new System.Windows.Forms.ComboBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.btnUpdateFood = new System.Windows.Forms.Button();
			this.btnCanel = new System.Windows.Forms.Button();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "FoodID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Unit";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Category Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Notes";
			// 
			// txtFoodID
			// 
			this.txtFoodID.Location = new System.Drawing.Point(135, 32);
			this.txtFoodID.Name = "txtFoodID";
			this.txtFoodID.ReadOnly = true;
			this.txtFoodID.Size = new System.Drawing.Size(179, 22);
			this.txtFoodID.TabIndex = 6;
			// 
			// cbbCatName
			// 
			this.cbbCatName.FormattingEnabled = true;
			this.cbbCatName.Location = new System.Drawing.Point(135, 115);
			this.cbbCatName.Name = "cbbCatName";
			this.cbbCatName.Size = new System.Drawing.Size(314, 24);
			this.cbbCatName.TabIndex = 7;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(135, 58);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(413, 22);
			this.txtName.TabIndex = 8;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(135, 87);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(413, 22);
			this.txtUnit.TabIndex = 9;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(135, 173);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(413, 22);
			this.txtNotes.TabIndex = 11;
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(473, 115);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(75, 23);
			this.btnAddNew.TabIndex = 12;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(135, 212);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(106, 27);
			this.btnAddFood.TabIndex = 13;
			this.btnAddFood.Text = "Add";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// btnUpdateFood
			// 
			this.btnUpdateFood.Location = new System.Drawing.Point(290, 212);
			this.btnUpdateFood.Name = "btnUpdateFood";
			this.btnUpdateFood.Size = new System.Drawing.Size(106, 27);
			this.btnUpdateFood.TabIndex = 14;
			this.btnUpdateFood.Text = "Update";
			this.btnUpdateFood.UseVisualStyleBackColor = true;
			this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
			// 
			// btnCanel
			// 
			this.btnCanel.Location = new System.Drawing.Point(442, 212);
			this.btnCanel.Name = "btnCanel";
			this.btnCanel.Size = new System.Drawing.Size(106, 27);
			this.btnCanel.TabIndex = 15;
			this.btnCanel.Text = "Canel";
			this.btnCanel.UseVisualStyleBackColor = true;
			this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(135, 146);
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(413, 22);
			this.nudPrice.TabIndex = 16;
			// 
			// FoodInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 254);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.btnCanel);
			this.Controls.Add(this.btnUpdateFood);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cbbCatName);
			this.Controls.Add(this.txtFoodID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FoodInfoForm";
			this.Text = "FoodInfoForm";
			this.Load += new System.EventHandler(this.FoodInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFoodID;
		private System.Windows.Forms.ComboBox cbbCatName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Button btnUpdateFood;
		private System.Windows.Forms.Button btnCanel;
		private System.Windows.Forms.NumericUpDown nudPrice;
	}
}