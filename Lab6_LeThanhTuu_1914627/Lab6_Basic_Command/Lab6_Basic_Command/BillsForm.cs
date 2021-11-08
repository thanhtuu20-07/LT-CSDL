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
	public partial class BillsForm : Form
	{
		public BillsForm()
		{
			InitializeComponent();

			LoadBills();
		}

		public void LoadBills()
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM Bills";

			sqlConnection.Open();

			string categoryName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách toàn bộ hóa đơn";

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvHoaDon.DataSource = table;

			// Prevent user to edit ID
			dgvHoaDon.Columns[0].ReadOnly = true;

			sqlConnection.Close();
		}

		private void BillsForm_DoubleClick(object sender, EventArgs e)
		{
			BillDetailsForm billDetails = new BillDetailsForm();
			string billID = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
			billDetails.LoadBillDetails(int.Parse(billID));
			billDetails.Show();
		}
	}
}
