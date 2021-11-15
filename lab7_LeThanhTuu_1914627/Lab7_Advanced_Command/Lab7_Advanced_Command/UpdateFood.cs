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
	public partial class UpdateFood : Form
	{
		public UpdateFood()
		{
			InitializeComponent();
		}

		

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string connecticonString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection conn = new SqlConnection(connecticonString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "execute InsertCategory @ID OUTPUT,@name,@type;";
				// thêm tham số vào đói tượng
				cmd.Parameters.Add("@ID", SqlDbType.Int);
				cmd.Parameters.Add("@name", SqlDbType.NVarChar, 300);
				cmd.Parameters.Add("@type", SqlDbType.Int);

				cmd.Parameters["@id"].Direction = ParameterDirection.Output;
				//truyền giá trị thủ tục qua tham số

				cmd.Parameters["@name"].Value = txtName.Text;
				cmd.Parameters["@type"].Value = txtType.Text;

				//mở kết nối đến csdl

				conn.Open();
				int numRowAffected = cmd.ExecuteNonQuery();
				//thông báo kết quả

				if (numRowAffected > 0)
                {
					string foodID = cmd.Parameters["@id"].Value.ToString();
					MessageBox.Show("thêm nhóm món ăn thành công.Mã nhóm = " +foodID, "Message");
					this.ResetText();
				}

				else
				{
					MessageBox.Show("thêm thất bại");
				}
				conn.Close();
				conn.Dispose();
			}
			//bắt lỗi sql và các lỗi khác

			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}
	}
}
