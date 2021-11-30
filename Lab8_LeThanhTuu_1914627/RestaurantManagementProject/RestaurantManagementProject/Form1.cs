using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurantManagementProject
{
	public partial class frmFood : Form
	{
		
		List<Category> listCategory = new List<Category>();
		
		List<Food> listFood = new List<Food>();
		
		Food foodCurrent = new Food();
		public frmFood()
		{
			InitializeComponent();
		}

		private void cmdExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			
			txtName.Text = "";
			txtPrice.Text = "0";
			txtUnit.Text = "";
			txtNotes.Text = "";
			
			if (cbbCategory.Items.Count > 0)
				cbbCategory.SelectedIndex = 0;
		}

		private void frmFood_Load(object sender, EventArgs e)
		{
			
			LoadCategory();
			
			LoadFoodDataToListView();
		}
		private void LoadCategory()
		{
			
			CategoryBL categoryBL = new CategoryBL();
			
			listCategory = categoryBL.GetAll();
			
			cbbCategory.DataSource = listCategory;
			cbbCategory.ValueMember = "ID";
			cbbCategory.DisplayMember = "Name";
		}
		public void LoadFoodDataToListView()
		{
			
			FoodBL foodBL = new FoodBL();
			
			listFood = foodBL.GetAll();
			int count = 1; 
			lsvFood.Items.Clear();
			
			foreach (var food in listFood)
			{
			
				ListViewItem item = lsvFood.Items.Add(count.ToString());
				
				item.SubItems.Add(food.Name);
				item.SubItems.Add(food.Unit);
				item.SubItems.Add(food.Price.ToString());
				
				string foodName = listCategory
				.Find(x => x.ID == food.FoodCategoryID).Name;
				item.SubItems.Add(foodName);
				
				item.SubItems.Add(food.Notes);
				count++;
			}
		}

		private void lsvFood_Click(object sender, EventArgs e)
		{
			
			for (int i = 0; i < lsvFood.Items.Count; i++)
			{
				
				if (lsvFood.Items[i].Selected)
				{
					
					foodCurrent = listFood[i];
					txtName.Text = foodCurrent.Name;
					txtUnit.Text = foodCurrent.Unit;
					txtPrice.Text = foodCurrent.Price.ToString();
					txtNotes.Text = foodCurrent.Notes;
					
					cbbCategory.SelectedIndex = listCategory
				   .FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
				}
			}
		}

		/// <summary>
		/// Phương thức thêm dữ liệu cho bảng Food
		/// </summary>
		/// <returns>Trả về số dương nếu thành công, ngược lại trả về số âm</returns>
		public int InsertFood()
		{
			//Khai báo đối tượng Food từ tầng DataAccess
			Food food = new Food();
			food.ID = 0;
			// Kiểm tra nếu các ô nhập khác rỗng
			if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			else
			{
				//Nhận giá trị Name, Unit, và Notes từ người dùng nhập vào
				food.Name = txtName.Text;
				food.Unit = txtUnit.Text;
				food.Notes = txtNotes.Text;
				// Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
				int price = 0;
				try
				{
					// Cố gắng lấy giá trị
					price = int.Parse(txtPrice.Text);
				}
				catch
				{
					// Nếu sai, gán giá = 0
					price = 0;
				}
				food.Price = price;
				// Giá trị FoodCategoryID được lấy từ ComboBox
				food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
				// Khao báo đối tượng FoodBL từ tầng Business
				FoodBL foodBL = new FoodBL();
				// Chèn dữ liệu vào bảng
				return foodBL.Insert(food);
			}
			return -1;
		}
		private void cmdAdd_Click(object sender, EventArgs e)
		{
			// Gọi phương thức thêm dữ liệu
			int result = InsertFood();
			if (result > 0) // Nếu thêm thành công
			{
				// Thông báo kết quả
				MessageBox.Show("Thêm dữ liệu thành công");
				// Tải lại dữ liệu cho ListView
				LoadFoodDataToListView();
			}
			// Nếu thêm không thành công thì thông báo cho người dùng
			else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			// Hỏi người dùng có chắc chắn xoá hay không? Nếu đồng ý thì
			if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo",
			MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				// Khai báo đối tượng FoodBL từ BusinessLogic
				FoodBL foodBL = new FoodBL();
				if (foodBL.Delete(foodCurrent) > 0)// Nếu xoá thành công
				{
					MessageBox.Show("Xoá thực phẩm thành công");
					// Tải tữ liệu lên ListView
					LoadFoodDataToListView();
				}
				else MessageBox.Show("Xoá không thành công");
			}
		}


		
		/// Phương thức cập nhật dữ liệu cho bảng Food
		

		public int UpdateFood()
		{

			Food food = foodCurrent;

			if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			else
			{

				food.Name = txtName.Text;
				food.Unit = txtUnit.Text;
				food.Notes = txtNotes.Text;

				int price = 0;
				try
				{
					
					price = int.Parse(txtPrice.Text);
				}
				catch
				{
					
					price = 0;
				}
				food.Price = price;
				
				food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
				
				FoodBL foodBL = new FoodBL();
				
				return foodBL.Update(food);
			}
			return -1;
		}
		private void cmdUpdate_Click(object sender, EventArgs e)
		{
			
			int result = UpdateFood();
			if (result > 0) 
			{
				
				MessageBox.Show("Cập nhật dữ liệu thành công");
				
				LoadFoodDataToListView();
			}
			
			else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}
	}
}
