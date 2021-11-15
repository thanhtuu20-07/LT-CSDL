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

namespace Lab7_Advanced_Command
{
	public partial class OrderDetailsForm : Form
	{
		int billID;
		public OrderDetailsForm()
		{
			InitializeComponent();
		}
		public void LoadOrderDetail(int billID)
		{
			this.billID = billID;
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT Name FROM Bills WHERE ID = " + billID;

			conn.Open();

			string billName = cmd.ExecuteScalar().ToString();
			this.Text = billName + " ID + " + billID;

			string query = string.Format(
				"SELECT Name, Unit, Price, Quantity, Price * Quantity AS Total FROM BillDetails " +
				"JOIN Food ON BillDetails.FoodID = Food.ID " +
				"WHERE BillDetails.BillID = {0}", billID).ToString();
			cmd.CommandText = query;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable Table = new DataTable("Food");

			adapter.Fill(Table);

			dgvOrderDetail.DataSource = Table;

			// Prevent user to edit ID
			dgvOrderDetail.Columns[0].ReadOnly = true;

			conn.Close();
			conn.Dispose();
			adapter.Dispose();
		}
	}
}
