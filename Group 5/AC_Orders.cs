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

namespace Group_5
{
    public partial class AC_Orders : Form
    {
        AC_Home home;
        public AC_Orders(AC_Home home)
        {
            InitializeComponent();
            this.home = home;


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

        private void Addbtn_Click(object sender, EventArgs e)
        {
            int id_bill = create_item();
            home.Set_bill(id_bill);

        }
    }
}
