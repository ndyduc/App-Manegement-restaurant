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
using Group_5.Model;

namespace Group_5
{
    public partial class AC_Menus : Form
    {
        private string selectedKind = null;
        private AC_Home home;

        public AC_Menus(AC_Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        public AC_Menus(string kind, AC_Home home)
        {
            InitializeComponent();
            selectedKind = kind; // Set kind parameter
            this.home = home;
        }

        private void AC_Menus_Load(object sender, EventArgs e)
        {
            LoadMenuItems(false);
        }

        private void LoadMenuItems(Boolean edit)
        {
            flowLayoutPanel1.Controls.Clear();
            using (var context = new DataClasses1DataContext())
            {
                var menuItems = edit ?
                    context.Menus.ToList() : // Chuyển thành danh sách
                    context.Menus.Where(item => item.Kind == selectedKind).ToList(); // Chuyển thành danh sách

                for (int i = 0; i < menuItems.Count; i++) // Dùng vòng lặp for
                {
                    var item = menuItems[i];
                    CreateMenuPanel(new Menui
                    {
                        Id = item.ID,
                        Name = item.Name,
                        Price = item.Price.ToString() + " VND",
                        Kind = item.Kind,
                        Description = item.Description,
                        ImageCover = item.Imagecover
                    }, edit);
                }
            }
        }


        public void RefreshFullMenu()
        {
            addbtn.Visible = true;
            LoadMenuItems(true);
        }

        public void RefreshMenuItems(string kind, bool isManage)
        {
            addbtn.Visible = false;
            selectedKind = kind;
            LoadMenuItems(false);
        }

        private async void CreateMenuPanel(Menui item, Boolean edit)
        {
            Panel menuPanel = new Panel
            {
                Size = new Size(200, 0),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10, 5, 10, 5)
            };

            PictureBox pictureBox = await CreatePictureBox(item.ImageCover);
            pictureBox.Tag = item.ImageCover; // Gán đường dẫn ảnh vào Tag
            Label nameLabel = CreateLabel(item.Name, new Point(10, 210));
            Label priceLabel = CreateLabel($"Price: {item.Price}", new Point(50, 230));
            Label descriptionLabel = CreateLabel(item.Description, new Point(10, 250));
              // Cập nhật vị trí để không tràn

            menuPanel.Controls.Add(pictureBox);
            menuPanel.Controls.Add(nameLabel);
            menuPanel.Controls.Add(priceLabel);
            menuPanel.Controls.Add(descriptionLabel);


            if (edit)
            {
                Label kindLabel = CreateLabel($"Kind: {item.Kind}", new Point(10, 270));
                Button editButton = CreateButton("Edit", new Point(10, 300), Edit_Click);
                Button deleteButton = CreateButton("Delete", new Point(100, 300), Delete_Click);

                menuPanel.Controls.Add(kindLabel);  // Thêm label loại món ăn
                menuPanel.Controls.Add(editButton);
                menuPanel.Controls.Add(deleteButton);

                int totalHeight = pictureBox.Height + nameLabel.Height + 10 + priceLabel.Height + 10 + descriptionLabel.Height + 50; // Cộng thêm khoảng cách cho nút
                menuPanel.Height = totalHeight; 
                
            }
            else
            {
                descriptionLabel.Size = new Size(180, 50);
                int totalHeight = pictureBox.Height + nameLabel.Height + 10 + priceLabel.Height + 10 + descriptionLabel.Height + 10; // Cộng thêm khoảng cách cho nút
                menuPanel.Height = totalHeight;
                menuPanel.Click += (sender, e) =>
                {
                    AC_AddtoBill addToBillForm = new AC_AddtoBill(item.Id, home);
                    addToBillForm.Show();
                };
            }



            flowLayoutPanel1.Controls.Add(menuPanel);
        }



        private async Task<PictureBox> CreatePictureBox(string imageUrl)
        {
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(200, 200),  // Giảm kích thước để vừa vặn
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            await LoadImageFromUrl(imageUrl, pictureBox);  // Tải hình ảnh từ URL bất đồng bộ
            return pictureBox;
        }

        public async Task LoadImageFromUrl(string imageUrl, PictureBox pictureBox)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    using (var httpClient = new System.Net.Http.HttpClient())
                    {
                        var imageData = await httpClient.GetByteArrayAsync(imageUrl); // Tải dữ liệu ảnh bất đồng bộ
                        using (var stream = new System.IO.MemoryStream(imageData))
                        {
                            Image originalImage = Image.FromStream(stream); // Tạo ảnh từ dữ liệu
                            Image croppedImage = CropImageToSquare(originalImage); // Cắt ảnh thành hình vuông
                            pictureBox.Image = croppedImage; // Gán ảnh đã cắt vào PictureBox
                        }
                    }
                }
                catch (Exception)
                {
                    pictureBox.Image = Properties.Resources.noimg; // Nếu tải ảnh lỗi, hiển thị ảnh mặc định
                }
            }
            else
            {
                pictureBox.Image = Properties.Resources.noimg; // Nếu không có URL, hiển thị ảnh mặc định
            }
        }

        private Image CropImageToSquare(Image originalImage)
        {
            int squareSize = Math.Min(originalImage.Width, originalImage.Height);
            int cropX = (originalImage.Width - squareSize) / 2;
            int cropY = (originalImage.Height - squareSize) / 2;
            Bitmap squareImage = new Bitmap(squareSize, squareSize);
            using (Graphics g = Graphics.FromImage(squareImage))
            {
                g.DrawImage(originalImage,
                    new Rectangle(0, 0, squareSize, squareSize),
                    new Rectangle(cropX, cropY, squareSize, squareSize),
                    GraphicsUnit.Pixel);
            }
            return squareImage;
        }



        private Label CreateLabel(string text, Point location)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Arial", 10, FontStyle.Bold),  // Giảm cỡ chữ để vừa vặn
                Location = location,
                Size = new Size(180, 20),  // Điều chỉnh kích thước phù hợp
                AutoSize = false  // Không tự động thay đổi kích thước
            };
        }

        private Button CreateButton(string text, Point location, EventHandler clickHandler)
        {
            Button button = new Button
            {
                Text = text,
                Size = new Size(80, 25),  // Giảm kích thước của nút
                Location = location
            };

            button.Click += clickHandler;
            return button;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Button editButton = sender as Button;
            Panel menuPanel = editButton?.Parent as Panel;
            if (menuPanel == null) return;

            // Lấy thông tin từ các control
            string name = menuPanel.Controls.OfType<Label>()
                             .FirstOrDefault(lbl => lbl.Location == new Point(10, 210))?.Text;
            string price = menuPanel.Controls.OfType<Label>()
                              .FirstOrDefault(lbl => lbl.Text.StartsWith("Price:"))?.Text.Replace("Price: ", "");
            string description = menuPanel.Controls.OfType<Label>()
                                  .FirstOrDefault(lbl => lbl.Location == new Point(10, 250))?.Text;
            string kind = menuPanel.Controls.OfType<Label>()
                              .FirstOrDefault(lbl => lbl.Text.StartsWith("Kind:"))?.Text.Replace("Kind: ", "");
            string imagePath = menuPanel.Controls.OfType<PictureBox>().FirstOrDefault()?.Tag?.ToString();

            // Kiểm tra dữ liệu rỗng
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Missing required data. Please check the menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị form chỉnh sửa
            AC_EditFood editForm = new AC_EditFood(name, price, description, imagePath, kind);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadMenuItems(true);  // Tải lại danh sách menu sau khi chỉnh sửa
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            Button deleteButton = sender as Button;
            Panel menuPanel = deleteButton?.Parent as Panel;
            if (menuPanel == null) return;

            Label nameLabel = menuPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold);
            string name = nameLabel?.Text;

            if (string.IsNullOrEmpty(name)) return;

            DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete '{name}'?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            using (var context = new DataClasses1DataContext())
            {
                var menuItem = context.Menus.FirstOrDefault(m => m.Name == name);
                if (menuItem != null)
                {
                    context.Menus.DeleteOnSubmit(menuItem);
                    context.SubmitChanges();
                    flowLayoutPanel1.Controls.Remove(menuPanel);
                    MessageBox.Show("Food item deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Error: Food item not found.");
                }
            }
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            AC_Addfood addFoodForm = new AC_Addfood();
            if (addFoodForm.ShowDialog() == DialogResult.OK)
            {
                LoadMenuItems(true);
            }
        }
    }
}
