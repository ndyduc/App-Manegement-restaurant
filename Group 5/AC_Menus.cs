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

namespace Group_5
{
    public partial class AC_Menus : Form
    {
        private string selectedKind = null;

        public AC_Menus()
        {
            InitializeComponent();
        }

        public AC_Menus(string kind)
        {
            InitializeComponent();
            selectedKind = kind; // Gán giá trị `kind` truyền vào
        }
        private void AC_Menus_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(selectedKind))
            {
                // Không có `kind`, hiển thị tất cả sản phẩm
                DisplayMenuItems();
            }
            else
            {
                // Có `kind`, hiển thị sản phẩm theo loại
                DisplayMenuItemsByKind(selectedKind, false);
            }
        }

        private void LoadMenuItems()
        {
            if (string.IsNullOrEmpty(selectedKind))
            {
                DisplayMenuItems();
            }
            else
            {
                DisplayMenuItemsByKind(selectedKind, false);
            }
        }

        public void RefreshFullMenu()
        {
            flowLayoutPanel1.Controls.Clear();
            // Ví dụ: Tải toàn bộ danh sách món ăn từ cơ sở dữ liệu
            DisplayMenuItems(); // Giả sử đây là phương thức để load tất cả món ăn
        }

        public void RefreshMenuItems(string kind, Boolean ismanage)
        {
            selectedKind = kind; // Cập nhật loại món ăn
            flowLayoutPanel1.Controls.Clear(); // Xóa tất cả các mục hiện tại trong giao diện
            if (string.IsNullOrEmpty(kind))
            {
                DisplayMenuItems(); // Hiển thị tất cả món ăn
            }
            else if(!ismanage)
            {
                DisplayMenuItemsByKind(kind, ismanage); // Hiển thị món ăn theo loại
            }
        }


        public void DisplayMenuItemsByKind(string kind, Boolean ismanage)
        {
            using (var context = new DataClasses1DataContext())  // Sử dụng DataContext của LINQ
            {
                try
                {
                    var menuItems = context.Menus  // Truy vấn bảng Menu từ DataContext
                        .Where(item => item.Kind == kind)  // Lọc theo loại món ăn (Kind)
                        .Select(item => new
                        {
                            item.Name,
                            item.Price,
                            item.Kind,
                            item.Description,
                            item.Imagecover
                        })
                        .ToList();

                    for (int i = 0; i < menuItems.Count; i++)
                    {
                        var menuItem = menuItems[i];

                        // Tạo đối tượng MenuItem từ kết quả truy vấn
                        MenuItem item = new MenuItem
                        {
                            Name = menuItem.Name,
                            Price = menuItem.Price.ToString(),  // Nếu Price là int, chuyển sang string
                            Kind = menuItem.Kind,
                            Description = menuItem.Description,
                            ImageCover = menuItem.Imagecover
                        };

                        // Gọi phương thức để hiển thị món ăn
                        CreateMenuItemPanel(item, ismanage);
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
                    var menuItems = context.Menus
                        .Select(item => new
                        {
                            item.Name,
                            item.Price,
                            item.Kind,
                            item.Description,
                            item.Imagecover
                        })
                        .ToList();

                    for (int i = 0; i < menuItems.Count; i++)
                    {
                        var menuItem = menuItems[i];

                        // Tạo đối tượng MenuItem từ kết quả truy vấn
                        MenuItem item = new MenuItem
                        {
                            Name = menuItem.Name,
                            Price = menuItem.Price.ToString(),  // Nếu Price là int, chuyển sang string
                            Kind = menuItem.Kind,
                            Description = menuItem.Description,
                            ImageCover = menuItem.Imagecover
                        };

                        // Gọi phương thức để hiển thị món ăn
                        CreateMenuItemPanel(item, true);
                    }

                    Console.WriteLine(flowLayoutPanel1.Height);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private async void CreateMenuItemPanel(MenuItem item,Boolean ismanage)
        {
            // Tạo một Panel cho món ăn
            Panel menuItemPanel = new Panel();
            menuItemPanel.Size = new Size(200, 0);  // Khởi tạo chiều cao panel là 0, sẽ tính toán sau
            menuItemPanel.BorderStyle = BorderStyle.FixedSingle;
            menuItemPanel.Margin = new Padding(10);

            // Tạo PictureBox cho ảnh món ăn (ở trên cùng)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(200, 130); // Kích thước ảnh
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Tạo Label cho tên món ăn
            Label nameLabel = new Label();
            nameLabel.Text = item.Name;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Location = new Point(10, 150);  // Dưới ảnh
            nameLabel.Size = new Size(180, 20);


            // Tạo Label cho loại món ăn
            Label kindLabel = new Label();
            kindLabel.Text = "Kind: " + item.Kind;
            kindLabel.Location = new Point(10, 210);  // Dưới giá món ăn
            kindLabel.Size = new Size(180, 20);
            kindLabel.Visible = false;

            // Tạo Label cho mô tả món ăn
            Label descriptionLabel = new Label();
            descriptionLabel.Text = item.Description;
            descriptionLabel.Location = new Point(10, 175);  // Dưới loại món ăn
            descriptionLabel.Size = new Size(180, 30);

            // Tạo Label cho giá món ăn
            Label priceLabel = new Label();
            priceLabel.Text = "Price:        " + item.Price + " VND";
            priceLabel.Location = new Point(10, 210);  // Dưới tên món ăn
            priceLabel.Size = new Size(180, 20);

            // Tạo Button Edit
            Button editButton = new Button();
            editButton.Text = "Edit";
            editButton.Size = new Size(80, 30);
            editButton.Location = new Point(10, 230);  // Dưới mô tả món ăn
            editButton.Click += Edit_Click;  // Gọi sự kiện khi nhấn nút Edit

            // Tạo Button Delete
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Size = new Size(80, 30);
            deleteButton.Location = new Point(110, 230);  // Cạnh nút Edit
            deleteButton.Click += Delete_Click;  // Gọi sự kiện khi nhấn nút Delete

            // Thêm các điều khiển vào Panel
            menuItemPanel.Controls.Add(pictureBox);
            menuItemPanel.Controls.Add(nameLabel);
            menuItemPanel.Controls.Add(priceLabel);
            menuItemPanel.Controls.Add(kindLabel);
            menuItemPanel.Controls.Add(descriptionLabel);
            menuItemPanel.Controls.Add(editButton);
            menuItemPanel.Controls.Add(deleteButton);


            // Tải ảnh bất đồng bộ
            await Task.Run(() => LoadImageAsync(item.ImageCover, pictureBox));

            // Tính toán chiều cao của Panel để phù hợp với các điều khiển
            int totalHeight = 10 - 50 + pictureBox.Height + 10 + nameLabel.Height + 10 + priceLabel.Height + 10 + kindLabel.Height + 10 + descriptionLabel.Height + 10 + editButton.Height + 10;
            menuItemPanel.Height = totalHeight;  // Cập nhật chiều cao của Panel

            if (!ismanage)
            {
                editButton.Visible = false;
                deleteButton.Visible = false;
                menuItemPanel.Height -= 30;

            }
            // Thêm Panel vào FlowLayoutPanel
            this.flowLayoutPanel1.Controls.Add(menuItemPanel);
        }

        private void LoadImageAsync(string imagePath, PictureBox pictureBox)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    // Kiểm tra xem đó có phải là một URL hợp lệ hay không
                    Uri uriResult;
                    bool isValidUrl = Uri.TryCreate(imagePath, UriKind.Absolute, out uriResult)
                                      && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                    if (isValidUrl)
                    {
                        // Tải ảnh từ URL và thay đổi kích thước
                        using (var webClient = new WebClient())
                        {
                            byte[] imageBytes = webClient.DownloadData(imagePath);
                            using (var stream = new MemoryStream(imageBytes))
                            {
                                Image originalImage = Image.FromStream(stream); // Tải hình ảnh gốc

                                // Tạo một thumbnail (giảm kích thước ảnh)
                                int thumbnailWidth = 230; // Kích thước ảnh mới
                                int thumbnailHeight = 130;
                                // Kiểm tra nếu handle đã được tạo ra trước khi gọi Invoke
                                if (pictureBox.IsHandleCreated)
                                {
                                    pictureBox.Invoke((Action)(() =>
                                    {
                                        pictureBox.Image = originalImage.GetThumbnailImage(thumbnailWidth, thumbnailHeight, null, IntPtr.Zero); // Thay đổi kích thước ảnh
                                    }));
                                }
                            }
                        }
                    }
                    else if (File.Exists(imagePath))
                    {
                        // Nếu không phải URL nhưng là file cục bộ
                        Image originalImage = Image.FromFile(imagePath);  // Hiển thị ảnh từ file cục bộ

                        // Tạo một thumbnail (giảm kích thước ảnh)
                        int thumbnailWidth = 230; // Kích thước ảnh mới
                        int thumbnailHeight = 130;
                        // Kiểm tra nếu handle đã được tạo ra trước khi gọi Invoke
                        if (pictureBox.IsHandleCreated)
                        {
                            pictureBox.Invoke((Action)(() =>
                            {
                                pictureBox.Image = originalImage.GetThumbnailImage(thumbnailWidth, thumbnailHeight, null, IntPtr.Zero); // Thay đổi kích thước ảnh
                            }));
                        }
                    }
                    else
                    {
                        // Nếu không phải URL và không phải file tồn tại
                        if (pictureBox.IsHandleCreated)
                        {
                            pictureBox.Invoke((Action)(() =>
                            {
                                pictureBox.Image = null;  // Hoặc sử dụng ảnh mặc định nếu không có ảnh
                            }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (pictureBox.IsHandleCreated)
                    {
                        pictureBox.Invoke((Action)(() =>
                        {
                            MessageBox.Show("Error loading image: " + ex.Message);
                        }));
                    }
                }
            }
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
            // Tìm thông tin món ăn trong panel hiện tại
            Button editButton = sender as Button;
            if (editButton == null) return;

            Panel menuItemPanel = editButton.Parent as Panel;
            if (menuItemPanel == null) return;

            // Lấy thông tin từ các control trong panel
            string name = menuItemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold)?.Text;
            string price = menuItemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Price:"))?.Text.Replace("Price: ", "");
            string kind = menuItemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Kind:"))?.Text.Replace("Kind: ", "");
            string description = menuItemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Description:"))?.Text.Replace("Description: ", "");
            string imagePath = menuItemPanel.Controls.OfType<PictureBox>().FirstOrDefault()?.Tag?.ToString();
            //Console.WriteLine(description + "abc");
            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(kind)) return;

            // Hiển thị form chỉnh sửa
            AC_EditFood editForm = new AC_EditFood(name, price, kind, description, imagePath);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật giao diện sau khi chỉnh sửa thành công
                LoadMenuItems();
            }
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

            using (var context = new DataClasses1DataContext())  // Sử dụng LINQ DataContext
            {
                // Tìm món ăn theo tên
                var menuItem = context.Menus.FirstOrDefault(m => m.Name == name);
                if (menuItem != null)
                {
                    try
                    {
                        // Xóa món ăn khỏi cơ sở dữ liệu
                        context.Menus.DeleteOnSubmit(menuItem);
                        context.SubmitChanges();

                        // Xóa Panel khỏi giao diện
                        flowLayoutPanel1.Controls.Remove(menuItemPanel);

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
            addFoodForm.Show();

        }
    }
}
