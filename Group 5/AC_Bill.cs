using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_5.Model;

namespace Group_5.Properties
{
    public partial class AC_Bill : Form
    {
        AC_Home home;

        AC_Menus us;
        Order bill;
        public AC_Bill(Order or, AC_Home home)
        {
            this.home = home;
            this.bill = or;
            us = new AC_Menus(home);
            InitializeComponent();
            home.reloadbill(listbill);
            reload_bill(or);
            div_order.HorizontalScroll.Enabled = false;

            listbill.SelectedValue = or.ID;

            txtname.Text = or.Name;
            if (or.Phone != null) txtphone.Text = or.Phone;
            if (or.Address != null) txtaddr.Text = or.Address;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void AC_Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nDYDUC_data.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.nDYDUC_data.Order);
            // TODO: This line of code loads data into the 'nDYDUC_data.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.nDYDUC_data.Menu);

        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }
        // name
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //address
        private void lblAdress_Click(object sender, EventArgs e)
        {

        }
        // phone number
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void grpDelivery_Enter(object sender, EventArgs e)
        {

        }

        // Tổng (món ăn + VAT)
        private void lblTo_Click(object sender, EventArgs e)
        {

        }
        // Tổng tiền các món ăn (không tính VAT)
        private void lblSub_Click(object sender, EventArgs e)
        {

        }
        //VAT 
        private void lblDis_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            home.close_bill();
        }

        private void listbill_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listbill.SelectedItem != null)
            {
                // Ensure that the SelectedItem is of type Order
                var selectedOrder = listbill.SelectedItem as Order;

                // Check if it's not null and it's a valid Order
                if (selectedOrder != null)
                {
                    this.bill = selectedOrder;

                    // Reload the order details with the selected order ID
                    LoadOrderDetails(bill.ID);
                    reload_bill(selectedOrder);
                }
                else
                {
                    // Handle the case where the selected item is not a valid order, if needed
                    Console.WriteLine("Selected item is not a valid order.");
                }
            }
            else
            {
                // Handle the case where nothing is selected, if needed
                Console.WriteLine("No item selected.");
            }
        }


        private void LoadOrderDetails(int orderId)
        {
            using (var context = new DataClasses1DataContext())
            {
                var or = context.Orders.FirstOrDefault(o => o.ID == orderId);
                if (or != null)
                {
                    txtname.Text = or.Name;
                    if (or.Phone != null) txtphone.Text = or.Phone;
                    if (or.Address != null) txtaddr.Text = or.Address;
                    txttotal.Text = or.Total.ToString()+" VND";

                }
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            using (var context = new DataClasses1DataContext())
            {
                // Tìm đơn hàng với ID tương ứng
                var orderToUpdate = context.Orders.FirstOrDefault(o => o.ID == bill.ID);

                if (orderToUpdate != null)
                {
                    orderToUpdate.Name = string.IsNullOrEmpty(txtname.Text) ? null : txtname.Text;
                    orderToUpdate.Address = string.IsNullOrEmpty(txtaddr.Text) ? null : txtaddr.Text;
                    orderToUpdate.Phone = string.IsNullOrEmpty(txtphone.Text) ? null : txtphone.Text;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SubmitChanges();
                    LoadOrderDetails(bill.ID);
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure to checkout?",
                "Confirm Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu người dùng chọn "Yes", thực hiện Checkout
            if (result == DialogResult.Yes)
            {
                using (var context = new DataClasses1DataContext())
                {
                    try
                    {
                        var order = context.Orders.FirstOrDefault(o => o.ID == (int)listbill.SelectedValue);

                        if (order != null)
                        {
                            order.Status = 1;
                            order.Time = DateTime.Now; 
                            context.SubmitChanges();

                            // Gọi các phương thức để đóng hóa đơn và tải lại danh sách đơn hàng
                            home.close_bill();
                            home.reload_orders();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private Panel create_item(Item_Order i)
        {
            Menu menu = GetMenu(i);

            Panel a = new Panel();
            a.Size = new Size(280, 100);

            PictureBox img = new PictureBox();
            img.Size = new Size(100,100);
            img.Location = new Point(0,0);
            img.SizeMode = PictureBoxSizeMode.Zoom;

            System.Windows.Forms.Label name = new System.Windows.Forms.Label();
            name.Text = menu.Name;
            name.Size = new Size(300, 15);
            name.Location = new Point(110, 10);
            name.Font = new Font("Serif", 8, FontStyle.Bold);

            System.Windows.Forms.Label note = new System.Windows.Forms.Label();
            note.Text = i.Note;
            note.Location = new Point(110, 30);
            note.Size = new Size(300, 20);

            System.Windows.Forms.Label price = new System.Windows.Forms.Label();
            price.Text = menu.Price.ToString() + " VND";
            price.Location = new Point(110, 60);
            price.AutoSize = true;

            System.Windows.Forms.Label am = new System.Windows.Forms.Label();
            am.Text = "X";
            am.Location = new Point(110, 75);
            am.Size = new Size(30, 20);
            am.Font = new Font("Serif", 12, FontStyle.Bold);

            System.Windows.Forms.Label amout = new System.Windows.Forms.Label();
            amout.Text = i.Amount.ToString();
            amout.Location = new Point(140, 75);
            amout.Size = new Size(30, 20);
            amout.Font = new Font("Serif", 12, FontStyle.Bold);

            System.Windows.Forms.Button less = new System.Windows.Forms.Button();
            less.Text = "-";
            less.Location = new Point(200, 65);
            less.Size = new Size(30, 30);
            less.Click += (sender, e) =>
            {
                if (i.Amount == 1)
                {
                    DialogResult result = MessageBox.Show("Remove confirm?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        RemoveItem(i);
                        reload_bill(bill);
                    }
                }
                else if (i.Amount > 1)
                {
                    UpdateTotal(i, false);
                    amout.Text = i.Amount.ToString();
                    reload_bill(bill);
                }
                home.reload_orders();
            };

            System.Windows.Forms.Button more = new System.Windows.Forms.Button();
            more.Text = "+";
            more.Location = new Point(240, 65);
            more.Size = new Size(30, 30);

            more.Click += (sender, e) =>
            {
                UpdateTotal(i, true);
                amout.Text = i.Amount.ToString();
                reload_bill(bill);
                home.reload_orders();
            };

            us.LoadImageFromUrl(menu.Imagecover, img);

            a.Controls.Add(img);
            a.Controls.Add(name);
            a.Controls.Add(note);
            a.Controls.Add(am);
            a.Controls.Add(price);
            a.Controls.Add(amout);
            a.Controls.Add(less);
            a.Controls.Add(more);

            return a;
        }

        private void RemoveItem(Item_Order item)
        {
            using (var context = new DataClasses1DataContext())
            {
                var orderItem = context.Item_Orders.FirstOrDefault(io => io.ID == item.ID);
                if (orderItem != null)
                {
                    context.Item_Orders.DeleteOnSubmit(orderItem);
                    context.SubmitChanges();
                }
            }
        }


        private void UpdateTotal(Item_Order item, Boolean isIncrease)
        {
            using (var context = new DataClasses1DataContext())
            {
                var menu = context.Menus.FirstOrDefault(m => m.ID == item.ID_Menu);
                if (menu != null)
                {
                    decimal menuPrice = menu.Price;
                    decimal totalChange = menuPrice * (isIncrease ? 1 : -1);

                    // Fetch the Item_Order from the database to ensure it's being tracked
                    var itemOrder = context.Item_Orders.FirstOrDefault(io => io.ID == item.ID);
                    if (itemOrder != null)
                    {
                        if (isIncrease)
                        {
                            itemOrder.Amount++; // Increase the quantity
                        }
                        else if (itemOrder.Amount > 1)
                        {
                            itemOrder.Amount--; // Decrease the quantity if greater than 1
                        }
                        // Save the changes to Item_Order
                        context.SubmitChanges();

                        // Update the total price for the order
                        var order = context.Orders.FirstOrDefault(o => o.ID == itemOrder.ID_Order);
                        if (order != null)
                        {
                            order.Total = order.Total + (int)totalChange; // Update the order total
                            context.SubmitChanges(); // Save the changes to the order total
                        }
                    }
                }
            }
        }




        private Menu GetMenu(Item_Order item)
        {
            using (var context = new DataClasses1DataContext())
            {
                var menu = context.Menus.FirstOrDefault(m => m.ID == item.ID_Menu);
                return menu;
            }
        }

        private void reload_bill(Order order)
        {
            div_order.Controls.Clear();

            using (var context = new DataClasses1DataContext())
            {
                var items = context.Item_Orders.Where(io => io.ID_Order == order.ID).ToList();

                for (int i = 0; i < items.Count; i++)
                {
                    Panel itemPanel = create_item(items[i]);
                    div_order.Controls.Add(itemPanel);
                }

                var orderDetails = context.Orders.FirstOrDefault(o => o.ID == order.ID);
                if (orderDetails != null)
                {
                    txttotal.Text = orderDetails.Total.ToString();
                }
            }
        }

        private void listbill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




