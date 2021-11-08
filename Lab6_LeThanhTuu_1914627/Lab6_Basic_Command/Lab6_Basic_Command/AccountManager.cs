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
	public partial class AccountManager : Form
	{
		public AccountManager()
		{
			InitializeComponent();		  

			LoadAccount();
		}
		public void LoadAccount()
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM Account";

			sqlConnection.Open();

			string categoryName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách toàn bộ tài khoản";

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvAccount.DataSource = table;

			// Prevent user to edit ID
			dgvAccount.Columns[0].ReadOnly = true;

			sqlConnection.Close();
		}
	}
}
