using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group_5
{
    public partial class AC_EditFood : Form
    {
        private string foodName;

        public AC_EditFood(string name, string price, string kind, string description, string imagePath)
        {
            InitializeComponent();

            // Gán giá trị ban đầu vào các control
            foodName = name; // Lưu tên món cũ để cập nhật
            textBox1.Text = name;  // Hiển thị tên món ăn
            textBox2.Text = price;  // Hiển thị giá
            comboBox1.Text = kind;  // Hiển thị loại món ăn
            richTextBox1.Text = description;  // Hiển thị mô tả món ăn

            // Kiểm tra nếu có đường dẫn hình ảnh hợp lệ
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);  // Hiển thị hình ảnh nếu đường dẫn hợp lệ
                pictureBox1.Tag = imagePath;  // Lưu đường dẫn hình ảnh vào Tag của PictureBox
            }
            else
            {
                pictureBox1.Image = Properties.Resources.noimg;  // Nếu không có ảnh, hiển thị ảnh mặc định
                pictureBox1.Tag = null;  // Đặt lại Tag nếu không có hình ảnh
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AC_EditFood_Load(object sender, EventArgs e)
        {
            // Đây là nơi bạn có thể thực hiện các thao tác khi form được tải (nếu cần)
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.Tag = imagePath;
            }
        }

        private void EditDone_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mới từ các control
            string newName = textBox1.Text;
            string newPrice = textBox2.Text;
            string newKind = comboBox1.Text;
            string newDescription = richTextBox1.Text;
            string newImagePath = pictureBox1.Tag?.ToString();

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPrice) ||
                string.IsNullOrEmpty(newKind) || string.IsNullOrEmpty(newDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Kiểm tra và chuyển đổi giá trị Price sang int
            int parsedPrice;
            if (!int.TryParse(newPrice, out parsedPrice))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            // Sử dụng LINQ để cập nhật món ăn
            using (var context = new DataClasses1DataContext())
            {
                // Tìm món ăn trong cơ sở dữ liệu
                var menuItem = context.Menus.FirstOrDefault(m => m.Name == foodName);
                if (menuItem != null)
                {
                    // Cập nhật thông tin món ăn
                    menuItem.Name = newName;
                    menuItem.Price = parsedPrice;
                    menuItem.Kind = newKind;
                    menuItem.Description = newDescription;
                    menuItem.Imagecover = newImagePath ?? ""; // Cập nhật đường dẫn ảnh, nếu có

                    // Lưu thay đổi vào cơ sở dữ liệu
                    try
                    {
                        context.SubmitChanges(); // Lưu thay đổi
                        MessageBox.Show("Food updated successfully!");
                        this.DialogResult = DialogResult.OK; // Đóng form với kết quả OK
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating food: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Food item not found.");
                }
            }
        }

        private void AC_EditFood_Load_1(object sender, EventArgs e)
        {

        }

    }
}
