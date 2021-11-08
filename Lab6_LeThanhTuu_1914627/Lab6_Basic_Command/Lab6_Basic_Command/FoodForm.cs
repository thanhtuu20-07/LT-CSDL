using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
	public partial class frmFood : Form
	{
		int categoryID;
		public frmFood()
		{
			InitializeComponent();
		}

		public void LoadFood(int categoryID)
		{
			this.categoryID = categoryID;
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

			sqlConnection.Open();

			string categoryName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + categoryName;

			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvFood.DataSource = table;

			// chặn người dùng sửa ID
			//dgvFood.Columns[0].ReadOnly = true;

			sqlConnection.Close();
			sqlConnection.Dispose();
			adapter.Dispose();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvFood.SelectedRows.Count == 0) return;

			var selectedRow = dgvFood.SelectedRows[0];

			string foodID = selectedRow.Cells[0].Value.ToString();

			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string query = "DELETE FROM Food WHERE ID = " + foodID;
			sqlCommand.CommandText = query;

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Bạn đã xóa thành công");
				return;
			}

			dgvFood.Rows.Remove(selectedRow);

			sqlConnection.Close();
		}
	}
}
