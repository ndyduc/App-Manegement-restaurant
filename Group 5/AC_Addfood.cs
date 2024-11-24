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
using System.Xml.Linq;

namespace Group_5
{
    public partial class AC_Addfood : Form
    {
        public AC_Addfood()
        {
            InitializeComponent();
        }

        private void AC_Addfood_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddImage_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các control
            string name = textBox1.Text;
            string kind = comboBox1.SelectedItem?.ToString();  // ComboBox cho loại món ăn
            string price = textBox3.Text;
            string description = richTextBox1.Text;
            string imageCover = pictureBox1.Tag?.ToString();

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(kind) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(imageCover))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            // Kết nối với cơ sở dữ liệu và lưu thông tin món ăn mới
            string connectstring = @"Data Source=DESKTOP-HGURI53;Initial Catalog=ndyduc;Integrated Security=True";
            string query = "INSERT INTO Menu (Name, Kind, Price, Description, ImageCover) VALUES (@Name, @Kind, @Price, @Description, @ImageCover)";

            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Kind", kind);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@ImageCover", imageCover);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Food item added successfully!");
                        this.Close();  // Đóng form AddFood sau khi lưu thành công
                    }
                    else
                    {
                        MessageBox.Show("Error adding food item.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Close();// Gọi lại để hiển thị món ăn mới
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog để người dùng chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";  // Chỉ chọn file ảnh
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh
                string imagePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);

                // Lưu đường dẫn ảnh vào TextBox hoặc biến (tuỳ chọn)
                pictureBox1.Tag = imagePath;  // Dùng Tag để lưu đường dẫn ảnh
            }
        }
    }
}
