
namespace Lab7_Advanced_Command
{
	partial class OrdersForm
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
			this.dgvOrder = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvOrder
			// 
			this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrder.Location = new System.Drawing.Point(4, 12);
			this.dgvOrder.Name = "dgvOrder";
			this.dgvOrder.RowHeadersWidth = 51;
			this.dgvOrder.RowTemplate.Height = 24;
			this.dgvOrder.Size = new System.Drawing.Size(794, 439);
			this.dgvOrder.TabIndex = 0;
			this.dgvOrder.DoubleClick += new System.EventHandler(this.dgvOrder_DoubleClick);
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvOrder);
			this.Name = "OrdersForm";
			this.Text = "OrdersForm";
			this.Load += new System.EventHandler(this.OrdersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOrder;
	}
}