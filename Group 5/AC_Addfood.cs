using System;
using System.Data.Linq;
using System.Drawing;
using System.IO;
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

            pictureBox1.AllowDrop = true;
            pictureBox1.DragEnter += PictureBox1_DragEnter;
            pictureBox1.DragLeave += PictureBox1_DragLeave;
            pictureBox1.DragDrop += PictureBox1_DragDrop;
        }

        private void AC_Addfood_Load(object sender, EventArgs e)
        {
            try
            {

                // Đặt hình ảnh mặc định từ Resources
                pictureBox1.Image = Properties.Resources.dropfile; // "dropfile" là tên ảnh trong Resources
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Tag = "default";  // Đánh dấu là ảnh mặc định
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0])) // Chỉ cho phép file ảnh
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = AdjustBrightness(pictureBox1.Image, -0.3f); // Giảm độ sáng
            }
        }

        private void PictureBox1_DragLeave(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = AdjustBrightness(pictureBox1.Image, 0.3f); // Khôi phục độ sáng
            }
        }

        // Xử lý sự kiện thả file vào PictureBox
        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                if (IsImageFile(filePath)) // Kiểm tra file là ảnh
                {
                    try
                    {
                        // Kiểm tra ảnh cũ và giải phóng tài nguyên
                        if (pictureBox1.Image != null && pictureBox1.Image != Properties.Resources.dropfile)
                        {
                            pictureBox1.Image.Dispose(); // Giải phóng tài nguyên ảnh cũ
                        }

                        // Thay thế ảnh mặc định (dropfile.jpg) bằng ảnh mới được thả vào
                        pictureBox1.Image = Image.FromFile(filePath);
                        pictureBox1.Tag = filePath; // Lưu đường dẫn ảnh vào Tag
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng thả file ảnh hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool IsImageFile(string filePath)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string extension = Path.GetExtension(filePath).ToLower();
            return validExtensions.Contains(extension);
        }


        // Hàm điều chỉnh độ sáng
        private Image AdjustBrightness(Image image, float brightnessFactor)
        {
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(tempBitmap))
            {
                float[][] ptsArray ={
            new float[] {1, 0, 0, 0, 0},  // Red
            new float[] {0, 1, 0, 0, 0},  // Green
            new float[] {0, 0, 1, 0, 0},  // Blue
            new float[] {0, 0, 0, 1, 0},  // Alpha
            new float[] {brightnessFactor, brightnessFactor, brightnessFactor, 0, 1}
        };

                System.Drawing.Imaging.ColorMatrix clrMatrix = new System.Drawing.Imaging.ColorMatrix(ptsArray);
                System.Drawing.Imaging.ImageAttributes imgAttributes = new System.Drawing.Imaging.ImageAttributes();
                imgAttributes.SetColorMatrix(clrMatrix);

                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imgAttributes);
            }

            return tempBitmap;
        }



        private void Done_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string kind = comboBox1.SelectedItem?.ToString();
            string priceText = textBox3.Text;
            string description = richTextBox1.Text;
            string imageCover = pictureBox1.Tag?.ToString();

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(kind) ||
                string.IsNullOrEmpty(priceText) ||
                string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(imageCover) ||
                imageCover == "default")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn hình ảnh hợp lệ!");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal priceDecimal))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!");
                return;
            }

            int price = (int)priceDecimal;

            try
            {
                Menu newMenuItem = new Menu
                {
                    Name = name,
                    Kind = kind,
                    Price = price,
                    Description = description,
                    Imagecover = imageCover // Lưu URL của ảnh
                };

                db.Menus.InsertOnSubmit(newMenuItem);
                db.SubmitChanges();

                MessageBox.Show("Món ăn đã được thêm thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu vào cơ sở dữ liệu: " + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp", // Chỉ chọn file ảnh
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Giải phóng tài nguyên ảnh cũ (nếu không phải ảnh mặc định)
                    if (pictureBox1.Image != null && pictureBox1.Tag?.ToString() != "default")
                    {
                        pictureBox1.Image.Dispose();
                    }

                    // Gán ảnh mới
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Tag = openFileDialog.FileName; // Lưu đường dẫn vào Tag
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddName_Click(object sender, EventArgs e)
        {

        }
    }
}
