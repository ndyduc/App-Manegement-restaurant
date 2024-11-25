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
            textBox1.Text = name;
            textBox2.Text = price;
            comboBox1.Text = kind;
            richTextBox1.Text = description;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.Tag = imagePath;
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

            // Kết nối và cập nhật cơ sở dữ liệu
            string connectionString = @"Data Source=DESKTOP-HGURI53;Initial Catalog=ndyduc;Integrated Security=True";
            string query = "UPDATE Menu SET Name = @NewName, Price = @Price, Kind = @Kind, Description = @Description, ImageCover = @Image WHERE Name = @OldName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NewName", newName);
                    command.Parameters.AddWithValue("@Price", newPrice);
                    command.Parameters.AddWithValue("@Kind", newKind);
                    command.Parameters.AddWithValue("@Description", newDescription);
                    command.Parameters.AddWithValue("@Image", newImagePath ?? "");
                    command.Parameters.AddWithValue("@OldName", foodName);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Food updated successfully!");
                        this.DialogResult = DialogResult.OK; // Đóng form với kết quả OK
                    }
                    else
                    {
                        MessageBox.Show("Error updating food.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
