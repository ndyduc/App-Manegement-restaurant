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
        private string originalImagePath;
        private DataClasses1DataContext db = new DataClasses1DataContext();

        public AC_EditFood(string name, string price, string description, string imagePath, string kind)
        {
            InitializeComponent();
            originalImagePath = imagePath;

            textBoxName.Text = name;
            textBoxPrice.Text = price; // Thêm đơn vị VND khi hiển thị
            richTextBoxDescription.Text = description;
            comboBoxKind.Text = kind;

            // Cấu hình PictureBox cho Drag & Drop
            pictureBoxImage.AllowDrop = true;
            pictureBoxImage.DragEnter += PictureBoxImage_DragEnter;
            pictureBoxImage.DragLeave += PictureBoxImage_DragLeave;
            pictureBoxImage.DragDrop += PictureBoxImage_DragDrop;

            LoadImage(imagePath);
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

        private void LoadImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBoxImage.Image = Image.FromFile(imagePath);
                pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxImage.Tag = imagePath;
            }
            else
            {
                pictureBoxImage.Image = Properties.Resources.dropfile; // Ảnh mặc định
                pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxImage.Tag = "default";
            }
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
                pictureBoxImage.Image = Image.FromFile(imagePath);
                pictureBoxImage.Tag = imagePath;
            }
        }

        private void PictureBoxImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void PictureBoxImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                string filePath = files[0];
                pictureBoxImage.Image?.Dispose(); // Giải phóng ảnh cũ
                pictureBoxImage.Image = Image.FromFile(filePath);
                pictureBoxImage.Tag = filePath;
            }
            else
            {
                MessageBox.Show("Please drop a valid image file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxImage_DragLeave(object sender, EventArgs e)
        {
            // Không cần chỉnh sáng tối ở đây trừ khi bạn muốn
        }

        private bool IsImageFile(string filePath)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string extension = Path.GetExtension(filePath).ToLower();
            return validExtensions.Contains(extension);
        }

        private void EditDone_Click(object sender, EventArgs e)
        {
            string newName = textBoxName.Text;
            string newPrice = textBoxPrice.Text;
            string newKind = comboBoxKind.Text;
            string newDescription = richTextBoxDescription.Text;
            string newImagePath = pictureBoxImage.Tag?.ToString();

            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPrice) ||
                string.IsNullOrEmpty(newKind) || string.IsNullOrEmpty(newDescription) ||
                newImagePath == "default")
            {
                MessageBox.Show("Please fill in all fields and select a valid image.");
                return;
            }

            string cleanedPrice = newPrice.Replace("VND", "").Trim(); // Loại bỏ đơn vị VND
            if (!int.TryParse(cleanedPrice.Replace(",", ""), out int parsedPrice))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            try
            {
                var menuItem = db.Menus.FirstOrDefault(m => m.Name == newName);
                if (menuItem != null)
                {
                    menuItem.Name = newName;
                    menuItem.Price = parsedPrice;
                    menuItem.Kind = newKind;
                    menuItem.Description = newDescription;
                    menuItem.Imagecover = newImagePath;
                    db.SubmitChanges();
                    MessageBox.Show("Food updated successfully!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Food item not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating food: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
