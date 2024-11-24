using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Group_5
{
    public partial class AC_Menus : Form
    {
        

        public AC_Menus()
        {
            InitializeComponent();

            flowLayoutPanel1.AutoScroll = true;
        }

        private void AC_Menus_Load(object sender, EventArgs e)
        {
            // Kết nối và lấy dữ liệu từ cơ sở dữ liệu
            DisplayMenuItems();
        }

        public void DisplayMenuItems()
        {
            string connectstring = @"Data Source=DESKTOP-HGURI53;Initial Catalog=ndyduc;Integrated Security=True";
            string query = "SELECT Name, Price, Kind, Description, ImageCover FROM Menu";

            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Lấy thông tin từ từng món ăn trong cơ sở dữ liệu
                        string name = reader["Name"].ToString();
                        string price = reader["Price"].ToString();
                        string kind = reader["Kind"].ToString();
                        string description = reader["Description"].ToString();
                        string imageCover = reader["ImageCover"].ToString(); // Đảm bảo là đường dẫn hợp lệ

                        // Tạo đối tượng MenuItem từ dữ liệu
                        MenuItem item = new MenuItem
                        {
                            Name = name,
                            Price = price,
                            Kind = kind,
                            Description = description,
                            ImageCover = imageCover
                        };

                        // Gọi phương thức DisplayMenuItem để hiển thị món ăn
                        CreateMenuItemPanel(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void CreateMenuItemPanel(MenuItem item)
        {
            // Tạo một Panel cho món ăn
            Panel menuItemPanel = new Panel();
            menuItemPanel.Size = new Size(250, 0);  // Khởi tạo chiều cao panel là 0, sẽ tính toán sau
            menuItemPanel.BorderStyle = BorderStyle.FixedSingle;
            menuItemPanel.Margin = new Padding(10);

            // Tạo PictureBox cho ảnh món ăn (ở trên cùng)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(230, 130); // Kích thước ảnh
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (!string.IsNullOrEmpty(item.ImageCover) && File.Exists(item.ImageCover))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(item.ImageCover);  // Hiển thị ảnh
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            else
            {
                pictureBox.Image = null;  // Hoặc sử dụng ảnh mặc định nếu không có ảnh
            }

            // Tạo Label cho tên món ăn
            Label nameLabel = new Label();
            nameLabel.Text = item.Name;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Location = new Point(10, 150);  // Dưới ảnh
            nameLabel.Size = new Size(230, 20);

            // Tạo Label cho giá món ăn
            Label priceLabel = new Label();
            priceLabel.Text = "Price: " + item.Price;
            priceLabel.Location = new Point(10, 180);  // Dưới tên món ăn
            priceLabel.Size = new Size(230, 20);

            // Tạo Label cho loại món ăn
            Label kindLabel = new Label();
            kindLabel.Text = "Kind: " + item.Kind;
            kindLabel.Location = new Point(10, 210);  // Dưới giá món ăn
            kindLabel.Size = new Size(230, 20);

            // Tạo Label cho mô tả món ăn
            Label descriptionLabel = new Label();
            descriptionLabel.Text = item.Description;
            descriptionLabel.Location = new Point(10, 240);  // Dưới loại món ăn
            descriptionLabel.Size = new Size(230, 40);

            // Tạo Button Edit
            Button editButton = new Button();
            editButton.Text = "Edit";
            editButton.Size = new Size(100, 30);
            editButton.Location = new Point(10, 280);  // Dưới mô tả món ăn
            editButton.Click += Edit_Click;  // Gọi sự kiện khi nhấn nút Edit

            // Tạo Button Delete
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Size = new Size(100, 30);
            deleteButton.Location = new Point(120, 280);  // Cạnh nút Edit
            deleteButton.Click += Delete_Click;  // Gọi sự kiện khi nhấn nút Delete

            // Thêm các điều khiển vào Panel
            menuItemPanel.Controls.Add(pictureBox);
            menuItemPanel.Controls.Add(nameLabel);
            menuItemPanel.Controls.Add(priceLabel);
            menuItemPanel.Controls.Add(kindLabel);
            menuItemPanel.Controls.Add(descriptionLabel);
            menuItemPanel.Controls.Add(editButton);
            menuItemPanel.Controls.Add(deleteButton);

            // Tính toán chiều cao của Panel để phù hợp với các điều khiển
            int totalHeight = 10 + pictureBox.Height + 10 + nameLabel.Height + 10 + priceLabel.Height + 10 + kindLabel.Height + 10 + descriptionLabel.Height + 10 + editButton.Height + 10;
            menuItemPanel.Height = totalHeight;  // Cập nhật chiều cao của Panel

            // Thêm Panel vào FlowLayoutPanel
            this.flowLayoutPanel1.Controls.Add(menuItemPanel);
        }


        public class MenuItem
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Kind { get; set; }
            public string Description { get; set; }
            public string ImageCover { get; set; } // Đây là đường dẫn hoặc URL đến ảnh
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Kind_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Xác định Button nào được nhấn
            Button deleteButton = sender as Button;
            if (deleteButton == null)
                return;

            // Lấy Panel chứa Button này
            Panel menuItemPanel = deleteButton.Parent as Panel;
            if (menuItemPanel == null)
                return;

            // Tìm Label chứa tên món ăn trong Panel
            Label nameLabel = menuItemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold); // Tên món ăn là Label in đậm
            if (nameLabel == null)
                return;

            string name = nameLabel.Text; // Lấy tên món ăn từ Label

            // Hiện hộp thoại xác nhận xóa
            DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete '{name}'?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            // Kết nối cơ sở dữ liệu để xóa món ăn
            string connectstring = @"Data Source=DESKTOP-HGURI53;Initial Catalog=ndyduc;Integrated Security=True";
            string query = "DELETE FROM Menu WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Food item deleted successfully!");

                        // Xóa Panel khỏi giao diện
                        flowLayoutPanel1.Controls.Remove(menuItemPanel);
                    }
                    else
                    {
                        MessageBox.Show("Error: Food item not found or could not be deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddNewFood_Click(object sender, EventArgs e)
        {
            AC_Addfood addFoodForm = new AC_Addfood();
            addFoodForm.Show();
        }
    }
}
