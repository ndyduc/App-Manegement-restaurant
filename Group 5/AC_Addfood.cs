using System;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Group_5
{
    public partial class AC_Addfood : Form
    {
        // Đường dẫn kết nối tới DataContext
        private DataClasses1DataContext db = new DataClasses1DataContext(); // Khởi tạo DataContext

        public AC_Addfood()
        {
            InitializeComponent();
        }

        private void AC_Addfood_Load(object sender, EventArgs e)
        {
            // Load các loại món ăn vào ComboBox từ cơ sở dữ liệu
            var kinds = db.Menus.Select(m => m.Kind).Distinct().ToList();
            comboBox1.Items.AddRange(kinds.ToArray());
        }

        private void Done_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các control
            string name = textBox1.Text;
            string kind = comboBox1.SelectedItem?.ToString(); // ComboBox cho loại món ăn
            string priceText = textBox3.Text;
            string description = richTextBox1.Text;
            string imageCover = pictureBox1.Tag?.ToString();

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(kind) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(imageCover))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }


            if (!decimal.TryParse(priceText, out decimal priceDecimal))
            {
                MessageBox.Show("Price must be a valid number!");
                return;
            }

            // Ép kiểu sang int nếu cột Price trong cơ sở dữ liệu là int
            int price = (int)priceDecimal;

            try
            {
                // Thêm món ăn mới vào cơ sở dữ liệu
                Menu newMenuItem = new Menu
                {
                    Name = name,
                    Kind = kind,
                    Price = price,
                    Description = description,
                    Imagecover = imageCover
                };

                db.Menus.InsertOnSubmit(newMenuItem); // Đưa vào hàng đợi thêm
                db.SubmitChanges(); // Áp dụng thay đổi vào DB

                MessageBox.Show("Food item added successfully!");
                this.Close(); // Đóng form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog để người dùng chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Chỉ chọn file ảnh
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh
                string imagePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);

                // Lưu đường dẫn ảnh vào Tag của PictureBox
                pictureBox1.Tag = imagePath;
            }
        }
    }
}
