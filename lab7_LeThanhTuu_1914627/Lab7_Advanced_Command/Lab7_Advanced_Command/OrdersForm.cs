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
	public partial class OrdersForm : Form
	{
		public OrdersForm()
		{
			InitializeComponent();
			LoadOrders();
		}

		public void LoadOrders()
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM Bills";

			conn.Open();

			string categoryName = cmd.ExecuteScalar().ToString();
			this.Text = "Danh sách hóa đơn";

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvOrder.DataSource = table;

			dgvOrder.Columns[0].ReadOnly = true;

			conn.Close();
		}

		private void dgvOrder_DoubleClick(object sender, EventArgs e)
		{
			OrderDetailsForm billsDetails = new OrderDetailsForm();
			string billID = dgvOrder.SelectedRows[0].Cells[0].Value.ToString();
			billsDetails.LoadOrderDetail(int.Parse(billID));
			billsDetails.Show();
		}

		private void OrdersForm_Load(object sender, EventArgs e)
		{

		}
	}
}
