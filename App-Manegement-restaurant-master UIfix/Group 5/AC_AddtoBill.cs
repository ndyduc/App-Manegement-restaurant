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
using System.Reflection.Emit;

namespace Group_5
{
    public partial class AC_AddtoBill : Form
    {
        int id_food;
        public AC_AddtoBill(int idfood, AC_Home home)
        {
            InitializeComponent();
            this.id_food = idfood;

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

            set_Combo();
            int? selectedBill = home.Get_bill();

            // Kiểm tra nếu selectedBill không phải là null, thì gán giá trị cho SelectedValue
            if (selectedBill.HasValue)
            {
                bill_here.SelectedValue = selectedBill.Value;
            }
            else
            {
                // Nếu selectedBill là null, không chọn gì trong ComboBox
                bill_here.SelectedIndex = -1;
            }


            AC_Menus me = new AC_Menus(home);
            imgfood.SizeMode = PictureBoxSizeMode.Zoom;
            me.LoadImageFromUrl(wy.ImageCover,imgfood); // load anh

            this.Controls.Add(addtobillbtn);

        }

        private void AC_AddtoBill_Load(object sender, EventArgs e)
        {
        }

        private void set_Combo()
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
            using (var context = new DataClasses1DataContext())
            {
                try
                {
                    var menuItem = context.Menus.FirstOrDefault(m => m.ID == id_food);
                    if (menuItem == null)
                    {
                        MessageBox.Show("Món ăn không tồn tại!");
                        return;
                    }
                    decimal price = menuItem.Price;
                    decimal itemTotal = int.Parse(txt_amount.Text) * price;

                    var newOrderItem = new Item_Order
                    {
                        Amount = int.Parse(txt_amount.Text),
                        ID_Order = (int)bill_here.SelectedValue,
                        Note = string.IsNullOrEmpty(txt_note.Text) ? null : txt_note.Text,
                        ID_Menu = id_food
                    };

                    context.Item_Orders.InsertOnSubmit(newOrderItem);

                    var order = context.Orders.FirstOrDefault(o => o.ID == (int)bill_here.SelectedValue);
                    if (order != null)
                    {
                        order.Total = (order.Total ?? 0) + (int)itemTotal; 
                    }

                    context.SubmitChanges();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }




        // Sự kiện click nút Exit
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void morebtn_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txt_amount.Text, out result))
            {
                txt_amount.Text = (result + 1 ).ToString();
            }
        }

        private void lessbtn_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txt_amount.Text, out result))
            {
                if(result > 1) txt_amount.Text = (result - 1).ToString();
            }
        }

        private void txt_name_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_Click(object sender, EventArgs e)
        {

        }
    }

}
