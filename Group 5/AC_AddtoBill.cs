using Group_5.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Group_5.AC_Menus;
using Group_5.Model;
using System.IO;

namespace Group_5
{
    public partial class AC_AddtoBill : Form
    {
        int id_bill;
        public AC_AddtoBill(int idfood, int idorder, int id_bill)
        {
            InitializeComponent();


            RoundedButton addtobillbtn = new RoundedButton();
            addtobillbtn.Size = new Size(150, 30); // Kích thước của nút
            addtobillbtn.Location = new Point(320, 230);  // Vị trí của nút
            addtobillbtn.Text = "Add to Bill";  // Văn bản của nút
            addtobillbtn.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            addtobillbtn.BackColor = Color.FromArgb(192, 255, 192);
            addtobillbtn.ForeColor = Color.IndianRed;
            addtobillbtn.BorderRadius = 20;
            addtobillbtn.FlatStyle = FlatStyle.Flat;
            addtobillbtn.FlatAppearance.BorderSize = 0;  // Không có viền
            addtobillbtn.TextAlign = ContentAlignment.MiddleCenter;

            // Xử lý sự kiện click
            addtobillbtn.Click += new EventHandler(addtobillbtn_Click);

            Menui wy = GetMenuItem(idfood);

            txt_name.Text = wy.Name;
            txt_description.Text = wy.Description;
            txt_price.Text = "- " + wy.Price + " VND";

            AC_Menus me = new AC_Menus();
            imgfood.SizeMode = PictureBoxSizeMode.Zoom;
            me.LoadImageFromUrl(wy.ImageCover, imgfood); // load anh

            this.Controls.Add(addtobillbtn);
            this.id_bill = id_bill;
        }

        private Menui GetMenuItem(int idfood)
        {
            using (var context = new DataClasses1DataContext())
            {
                try
                {
                    var menuItem = context.Menus
                        .Where(item => item.ID == idfood)  // Lọc theo ID món ăn
                        .Select(item => new
                        {
                            item.ID,
                            item.Name,
                            item.Price,
                            item.Kind,
                            item.Description,
                            item.Imagecover
                        })
                        .FirstOrDefault(); // Lấy kết quả đầu tiên nếu có

                    Menui wy = new Menui
                    {
                        Id = menuItem.ID,
                        Name = menuItem.Name,
                        Price = menuItem.Price.ToString(),  // Nếu Price là int, chuyển sang string
                        Kind = menuItem.Kind,
                        Description = menuItem.Description,
                        ImageCover = menuItem.Imagecover
                    };

                    return wy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void addtobillbtn_Click(object sender, EventArgs e)
        {
            // Thực hiện hành động khi nút "Add to Bill" được click
            MessageBox.Show("Item added to bill!");  // Ví dụ hiển thị thông báo
        }


        // Sự kiện click nút Exit
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AC_AddtoBill_Load(object sender, EventArgs e)
        {
            bill_here.DataSource = null;
            using (var context = new DataClasses1DataContext())
            {
                try
                {
                    DateTime today = DateTime.Today;

                    var orders = context.Orders
                        .Where(order => order.Status == 0 && order.Time.Date == today)
                        .Select(order => new { order.ID, order.Name })  // Chọn các cột cần thiết
                        .ToList();

                    bill_here.DataSource = orders;
                    bill_here.DisplayMember = "Name"; // Hiển thị tên đơn hàng
                    bill_here.ValueMember = "ID";    // Giá trị của mỗi mục là ID của đơn hàng
                }
                catch (Exception ex) { MessageBox.Show("Error loading data: " + ex.Message); }
            }
            if (id_bill != null) bill_here.SelectedValue = id_bill;
        }
    }

}
