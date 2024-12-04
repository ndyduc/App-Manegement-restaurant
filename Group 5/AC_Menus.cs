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
using System.Net;
using System.Net.Http;
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
            selectedKind = kind; // Gán giá trị `kind` truyền vào
            this.home = home;
        }
        private void AC_Menus_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(selectedKind))
            {
                DisplayMenuItems();
            }
            else
            {
                // Có `kind`, hiển thị sản phẩm theo loại
                DisplayMenuItemsByKind(selectedKind);
            }
        }

        private void LoadMenuis()
        {
            if (string.IsNullOrEmpty(selectedKind))
            {
                DisplayMenuItems();
            }
            else
            {
                DisplayMenuItemsByKind(selectedKind);
            }
        }

        public void RefreshFullMenu()
        {
            addbtn.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            // Ví dụ: Tải toàn bộ danh sách món ăn từ cơ sở dữ liệu
            DisplayMenuItems(); // Giả sử đây là phương thức để load tất cả món ăn
        }

        public void RefreshMenuItems(string kind, Boolean ismanage)
        {
            addbtn.Visible = false;
            selectedKind = kind; // Cập nhật loại món ăn
            flowLayoutPanel1.Controls.Clear(); // Xóa tất cả các mục hiện tại trong giao diện
            if (string.IsNullOrEmpty(kind))
            {
                DisplayMenuItems(); // Hiển thị tất cả món ăn
            }
            else if(!ismanage)
            {
                DisplayMenuItemsByKind(kind); // Hiển thị món ăn theo loại
            }
        }


        public void DisplayMenuItemsByKind(string kind)
        {
            using (var context = new DataClasses1DataContext())  // Sử dụng DataContext của LINQ
            {
                try
                {
                    // Xóa tất cả các điều khiển trong flowLayoutPanel1 trước khi thêm mới
                    flowLayoutPanel1.Controls.Clear();

                    var Menuis = context.Menus  // Truy vấn bảng Menu từ DataContext
                        .Where(item => item.Kind == kind)  // Lọc theo loại món ăn (Kind)
                        .Select(item => new
                        {
                            item.ID,
                            item.Name,
                            item.Price,
                            item.Kind,
                            item.Description,
                            item.Imagecover
                        })
                        .ToList();

                    for (int i = 0; i < Menuis.Count; i++)
                    {
                        var Menui = Menuis[i];

                        // Tạo đối tượng Menui từ kết quả truy vấn
                        Menui item = new Menui
                        {
                            Id = Menui.ID,
                            Name = Menui.Name,
                            Price = Menui.Price.ToString() + " VND",  // Nếu Price là int, chuyển sang string
                            Kind = Menui.Kind,
                            Description = Menui.Description,
                            ImageCover = Menui.Imagecover
                        };
                        CreateMenuiPanel(item);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public void DisplayMenuItems()
        {
            using (var context = new DataClasses1DataContext())
            {
                try
                {
                    // Xóa tất cả các điều khiển trong flowLayoutPanel1 trước khi thêm mới
                    flowLayoutPanel1.Controls.Clear();

                    var Menuis = context.Menus
                        .Select(item => new
                        {
                            item.ID,
                            item.Name,
                            item.Price,
                            item.Kind,
                            item.Description,
                            item.Imagecover
                        })
                        .ToList();

                    for (int i = 0; i < Menuis.Count; i++)
                    {
                        var Menui = Menuis[i];

                        // Tạo đối tượng Menui từ kết quả truy vấn
                        Menui item = new Menui
                        {
                            Id = Menui.ID,
                            Name = Menui.Name,
                            Price = Menui.Price.ToString() + " VND",  // Nếu Price là int, chuyển sang string
                            Kind = Menui.Kind,
                            Description = Menui.Description,
                            ImageCover = Menui.Imagecover
                        };

                        // Gọi phương thức để hiển thị món ăn
                        CreateMenuiAll(item);
                    }

                    Console.WriteLine(flowLayoutPanel1.Height);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private async void CreateMenuiPanel(Menui item)
        {
            // Tạo một Panel cho món ăn
            Panel MenuiPanel = new Panel();
            MenuiPanel.Size = new Size(200, 0);  // Khởi tạo chiều cao panel là 0, sẽ tính toán sau
            MenuiPanel.BorderStyle = BorderStyle.FixedSingle;
            MenuiPanel.Margin = new Padding(10,5,10,5);

            // Tạo PictureBox cho ảnh món ăn (ở trên cùng)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(200, 200); // Kích thước ảnh
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


            // Tạo Label cho tên món ăn
            Label nameLabel = new Label();
            nameLabel.Text = item.Name;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Location = new Point(10, 210);  // Dưới ảnh
            nameLabel.Size = new Size(180, 20);

            // Tạo Label cho loại món ăn
            Label kindLabel = new Label();
            kindLabel.Text = "Kind: " + item.Kind;
            kindLabel.Visible = false;

            // Tạo Label cho mô tả món ăn
            Label descriptionLabel = new Label();
            descriptionLabel.Text = item.Description;
            descriptionLabel.Location = new Point(10, 230);  // Dưới loại món ăn
            descriptionLabel.Size = new Size(180, 30);

            // Tạo Label cho giá món ăn
            Label priceLabel = new Label();
            priceLabel.Text = "Price: " + item.Price;
            priceLabel.Location = new Point(100, 270);  // Dưới tên món ăn
            priceLabel.Size = new Size(180, 20);

            // Thêm các điều khiển vào Panel
            MenuiPanel.Controls.Add(pictureBox);
            MenuiPanel.Controls.Add(nameLabel);
            MenuiPanel.Controls.Add(priceLabel);
            MenuiPanel.Controls.Add(kindLabel);
            MenuiPanel.Controls.Add(descriptionLabel);

            LoadImageFromUrl(item.ImageCover, pictureBox);

            // Tính toán chiều cao của Panel để phù hợp với các điều khiển
            int totalHeight =   pictureBox.Height + nameLabel.Height + priceLabel.Height + kindLabel.Height + 10 + descriptionLabel.Height;
            MenuiPanel.Height = totalHeight;  // Cập nhật chiều cao của Panel

            // Thêm Panel vào FlowLayoutPanel
            this.flowLayoutPanel1.Controls.Add(MenuiPanel);

            // Tạo sự kiện click cho Panel
            MenuiPanel.Click += (sender, e) =>
            {
                AC_AddtoBill addToBillForm = new AC_AddtoBill(item.Id, home);
                addToBillForm.Show();
            };
        }


        private async void CreateMenuiAll(Menui item)
        {
            // Tạo một Panel cho món ăn
            Panel MenuiPanel = new Panel();
            MenuiPanel.Size = new Size(200, 0);  // Khởi tạo chiều cao panel là 0, sẽ tính toán sau
            MenuiPanel.BorderStyle = BorderStyle.FixedSingle;
            MenuiPanel.Margin = new Padding(10,5,10,5);

            // Tạo PictureBox cho ảnh món ăn (ở trên cùng)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(200, 200); // Kích thước ảnh
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Tạo Label cho tên món ăn
            Label nameLabel = new Label();
            nameLabel.Text = item.Name;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Location = new Point(10, 215);  // Dưới ảnh
            nameLabel.Size = new Size(180, 20);


            // Tạo Label cho loại món ăn
            Label kindLabel = new Label();
            kindLabel.Text = "Kind: " + item.Kind;
            kindLabel.Location = new Point(10, 240);  // Dưới giá món ăn
            kindLabel.Size = new Size(180, 20);

            // Tạo Label cho mô tả món ăn
            Label descriptionLabel = new Label();
            descriptionLabel.Text = item.Description;
            descriptionLabel.Location = new Point(10, 265);  // Dưới loại món ăn
            descriptionLabel.Size = new Size(180, 30);

            // Tạo Label cho giá món ăn
            Label priceLabel = new Label();
            priceLabel.Text = "Price:        " + item.Price;
            priceLabel.Location = new Point(10, 305);  // Dưới tên món ăn
            priceLabel.Size = new Size(180, 20);

            // Tạo Button Edit
            Button editButton = new Button();
            editButton.Text = "Edit";
            editButton.Size = new Size(80, 30);
            editButton.Location = new Point(10, 330);  // Dưới mô tả món ăn
            editButton.Click += Edit_Click;  // Gọi sự kiện khi nhấn nút Edit

            // Tạo Button Delete
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Size = new Size(80, 30);
            deleteButton.Location = new Point(110, 330);  // Cạnh nút Edit
            deleteButton.Click += Delete_Click;  // Gọi sự kiện khi nhấn nút Delete

            // Thêm các điều khiển vào Panel
            MenuiPanel.Controls.Add(pictureBox);
            MenuiPanel.Controls.Add(nameLabel);
            MenuiPanel.Controls.Add(priceLabel);
            MenuiPanel.Controls.Add(kindLabel);
            MenuiPanel.Controls.Add(descriptionLabel);
            MenuiPanel.Controls.Add(editButton);
            MenuiPanel.Controls.Add(deleteButton);

            LoadImageFromUrl(item.ImageCover, pictureBox);

            // Tính toán chiều cao của Panel để phù hợp với các điều khiển
            int totalHeight = pictureBox.Height + nameLabel.Height + 10 + priceLabel.Height + 10 + kindLabel.Height + 10 + descriptionLabel.Height + 10 + editButton.Height + 10;
            MenuiPanel.Height = totalHeight;  // Cập nhật chiều cao của Panel

            this.flowLayoutPanel1.Controls.Add(MenuiPanel);
        }

        public async void LoadImageFromUrl(string imageUrl, PictureBox pictureBox)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
            {
                pictureBox.Image = null; // Đặt ảnh mặc định hoặc để trống
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(imageUrl);
                    response.EnsureSuccessStatusCode();

                    byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image originalImage = Image.FromStream(ms);

                        // Cắt ảnh thành hình vuông
                        Image croppedImage = CropImageToSquare(originalImage);

                        // Đặt ảnh đã cắt vào PictureBox
                        pictureBox.Image = croppedImage;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Không thể tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                pictureBox.Image = null; // Đặt ảnh mặc định hoặc để trống
            }
        }

        private Image CropImageToSquare(Image originalImage)
        {
            // Tìm cạnh ngắn nhất của ảnh (chiều rộng hoặc chiều cao)
            int squareSize = Math.Min(originalImage.Width, originalImage.Height);

            // Tính toán vị trí cắt để phần hình vuông ở giữa
            int cropX = (originalImage.Width - squareSize) / 2;
            int cropY = (originalImage.Height - squareSize) / 2;

            // Tạo ảnh mới hình vuông
            Bitmap squareImage = new Bitmap(squareSize, squareSize);
            using (Graphics g = Graphics.FromImage(squareImage))
            {
                g.DrawImage(originalImage,
                    new Rectangle(0, 0, squareSize, squareSize), // Vùng vẽ ảnh
                    new Rectangle(cropX, cropY, squareSize, squareSize), // Vùng cắt ảnh
                    GraphicsUnit.Pixel);
            }

            return squareImage;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Kind_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            // Tìm thông tin món ăn trong panel hiện tại
            Button editButton = sender as Button;
            if (editButton == null) return;

            Panel MenuiPanel = editButton.Parent as Panel;
            if (MenuiPanel == null) return;

            // Lấy thông tin từ các control trong panel
            string name = MenuiPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold)?.Text;
            string price = MenuiPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Price:"))?.Text.Replace("Price: ", "");
            if (price != null)
            {
                // Xóa " VND" nếu có
                price = price.Replace(" VND", "").Trim();
            }
            string kind = MenuiPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Kind:"))?.Text.Replace("Kind: ", "");
            string description = MenuiPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Description:"))?.Text.Replace("Description: ", "");
            string imagePath = MenuiPanel.Controls.OfType<PictureBox>().FirstOrDefault()?.Tag?.ToString();
            //Console.WriteLine(description + "abc");
            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(kind)) return;

            // Hiển thị form chỉnh sửa
            AC_EditFood editForm = new AC_EditFood(name, price, kind, description, imagePath);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật giao diện sau khi chỉnh sửa thành công
                LoadMenuis();
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            // Xác định Button nào được nhấn
            Button deleteButton = sender as Button;
            if (deleteButton == null)
                return;

            // Lấy Panel chứa Button này
            Panel MenuiPanel = deleteButton.Parent as Panel;
            if (MenuiPanel == null)
                return;

            // Tìm Label chứa tên món ăn trong Panel
            Label nameLabel = MenuiPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold); // Tên món ăn là Label in đậm
            if (nameLabel == null)
                return;

            string name = nameLabel.Text; // Lấy tên món ăn từ Label

            // Hiện hộp thoại xác nhận xóa
            DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete '{name}'?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            using (var context = new DataClasses1DataContext())  // Sử dụng LINQ DataContext
            {
                // Tìm món ăn theo tên
                var Menui = context.Menus.FirstOrDefault(m => m.Name == name);
                if (Menui != null)
                {
                    try
                    {
                        // Xóa món ăn khỏi cơ sở dữ liệu
                        context.Menus.DeleteOnSubmit(Menui);
                        context.SubmitChanges();

                        // Xóa Panel khỏi giao diện
                        flowLayoutPanel1.Controls.Remove(MenuiPanel);

                        MessageBox.Show("Food item deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting data: " + ex.Message);
                    }
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
                LoadMenuis();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
