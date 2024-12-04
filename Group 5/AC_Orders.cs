using Group_5.Component;
using Group_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group_5
{
    public partial class AC_Orders : Form
    {
        AC_Home home;
        public AC_Orders(AC_Home home)
        {
            InitializeComponent();
            this.home = home;
            reload(0);

        }

        private void AC_Orders_Load(object sender, EventArgs e)
        {

        }

        private int create_item()
        {
            using (var context = new DataClasses1DataContext())
            {
                try
                {
                    DateTime today = DateTime.Today;
                    int i = context.Orders
                        .Where(item => item.Time.Date == today) // So sánh chỉ phần ngày
                        .Count(); // Đếm số lượng bản ghi

                    String count = "Bill #" + (i + 1);

                    Order newOrder = new Order
                    {
                        Name =  count,           
                        Phone = null,
                        Address = null,
                        Email = null,
                        Status = 0,
                        Table = null,
                        Total = null,
                        Time = DateTime.Now 
                    };

                    context.Orders.InsertOnSubmit(newOrder);
                    context.SubmitChanges();

                    var orderToSelect = context.Orders.FirstOrDefault(order => order.Name == count);

                    return orderToSelect.ID;
                }
                catch (Exception ex){ MessageBox.Show("Error loading data: " + ex.Message); }
                return 0;
            }

        }

        private void reload(int status)
        {
            using (var context = new DataClasses1DataContext())
            {
                try
                {
                    DateTime today = DateTime.Today;

                    var orders = context.Orders
                        .Where(order => order.Status == status && order.Time.Date == today)
                        .Select(order => new { 
                            order.ID,
                            order.Name,
                            order.Phone,
                            order.Address,
                            order.Email,
                            order.Status,
                            order.Total,
                            order.Time}).ToList();

                    mum.Controls.Clear();
                    
                    for (int i = 0; i < orders.Count; i++)
                    {
                        var k = orders[i];

                        Ordder item = new Ordder
                        {
                            Id = k.ID,
                            Name = k.Name,
                            Phone = k.Phone,
                            Address = k.Address,
                            Email = k.Email,
                            Status = k.Status ?? 0,
                            Total = k.Total ?? 0,
                            Time = k.Time,


                        };
                        this.mum.Controls.Add(Create_Item(item));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            int id_bill = create_item();
            home.Set_bill(id_bill);

        }

        private Panel Create_Item(Ordder order)
        {
            Panel me = new Panel();
            me.Size = new Size(200, 140);
            me.BorderStyle = BorderStyle.FixedSingle;
            me.Margin = new Padding(10, 5, 10, 5);

            Label name = new Label();
            name.Text = order.Name;
            name.Font = new Font("Arial", 12, FontStyle.Bold);
            name.Location = new Point(10, 10); 
            name.Size = new Size(180, 20);

            Label phone = new Label();
            phone.Location = new Point(10, 30);
            phone.Text = "Phone: " + order.Phone;

            Label table = new Label();
            table.Text = order.Talbe;
            table.Location = new Point(150, 30);
            table.Size = new Size(40, 10);

            Label addr = new Label();
            table.Text = order.Address;
            addr.Location = new Point(10, 50);
            addr.Size = new Size(180, 30);

            Label time = new Label();
            time.Text = order.Time.ToString();
            time.Location = new Point(80, 90);
            time.Size = new Size(150, 15);

            RoundedButton status = new RoundedButton();
            if (order.Status == 1) status.Text = "Finish";
            else status.Text = "Current";
            status.Size = new Size(80, 20);
            status.Location = new Point(10, 110);
            status.BackColor = Color.DarkRed;
            status.ForeColor = Color.White;
            status.BorderRadius = 10;
            status.Font = new Font("Serif", 12, FontStyle.Bold);
            status.Padding = new Padding(10);

            Label total = new Label();
            total.Text = "tinh sau";
            total.Size = new Size(80,20);
            total.Location = new Point(110, 110);

            me.Controls.Add(name);
            me.Controls.Add(phone);
            me.Controls.Add(table);
            me.Controls.Add(addr);
            me.Controls.Add(time);
            me.Controls.Add(status);
            me.Controls.Add(total);

            return me;
        }

        private void presentbtn_Click(object sender, EventArgs e)
        {
            reload(0);
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            reload(1);
        }
    }
}
