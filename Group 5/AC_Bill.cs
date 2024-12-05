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

namespace Group_5.Properties
{
    public partial class AC_Bill : Form
    {
        public AC_Bill()
        {
            InitializeComponent();

            // Use a proper WebClient or HttpClient to load an image from a URL
            using (var client = new System.Net.WebClient())
            {
                using (var stream = new MemoryStream(client.DownloadData("https://images.squarespace-cdn.com/content/v1/6436ab00d4a82053ce3726a4/c43a49fc-a9dd-4161-af6f-a1a854e853f8/DSC07972.jpg?format=500w")))
                {
                    img_bill.Image = Image.FromStream(stream);
                }
            }
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
            int orderId = 1;
            OrderProcessing orderProcessing = new OrderProcessing();
            string name = orderProcessing.ShowOrderDetails(orderId, "Name");
            lblNameCus.Text = name;
        }

        //address
        private void lblAdress_Click(object sender, EventArgs e)
        {
            int orderId = 1;
            OrderProcessing orderProcessing = new OrderProcessing();
            string address = orderProcessing.ShowOrderDetails(orderId, "Address");
            lblAdressCus.Text =  address;
        }

        // phone number
        private void label2_Click(object sender, EventArgs e)
        {
            int orderId = 1;
            OrderProcessing orderProcessing = new OrderProcessing();
            string phone = orderProcessing.ShowOrderDetails(orderId, "Phone");
            lblPhoneCus.Text = phone;
        }


        private void grpDelivery_Enter(object sender, EventArgs e)
        {

        }

        // Tổng (món ăn + VAT)
        private void lblTo_Click(object sender, EventArgs e)
        {
            int orderId = 1;
            OrderProcessing orderProcessing = new OrderProcessing();

            // Lấy tổng tiền các món ăn
            decimal subtotal = orderProcessing.GetOrderSubtotal(orderId);

            // Tính tổng tiền cộng với VAT (10% trong ví dụ này)
            decimal vat = 0.10m;  // 10% VAT
            decimal total = subtotal * (1 + vat);

            // Hiển thị tổng tiền (bao gồm VAT)
            lblTo.Text =total.ToString("C2");
        }
        // Tổng tiền các món ăn (không tính VAT)
        private void lblSub_Click(object sender, EventArgs e)
        {
            int orderId = 1; // Thay đổi theo ID_Order mà bạn cần
            OrderProcessing orderProcessing = new OrderProcessing();

            // Lấy tổng tiền các món ăn (subtotal)
            decimal subtotal = orderProcessing.GetOrderSubtotal(orderId);

            // Hiển thị tổng tiền các món ăn
            lblSub.Text =subtotal.ToString("C2");
        }

        //VAT 
        private void lblDis_Click(object sender, EventArgs e)
        {

        }
    }
}



public class OrderProcessing
{
    private string connectionString = "url database ?"; // Cập nhật chuỗi kết nối

    // Lấy chi tiết đơn hàng (Name, Address, Phone)
    public string ShowOrderDetails(int orderId, string column)
    {
        string result = string.Empty;

        // Truy vấn bảng Order
        string orderQuery = $"SELECT {column} FROM [Order] WHERE ID = @ID_Order";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(orderQuery, conn);
            cmd.Parameters.AddWithValue("@ID_Order", orderId);

            result = cmd.ExecuteScalar()?.ToString(); // Lấy giá trị từ cột yêu cầu
        }

        return result;
    }

    // Tính tổng tiền các món ăn (Subtotal)
    public decimal GetOrderSubtotal(int orderId)
    {
        decimal subtotal = 0;

        // Lấy thông tin món ăn và số lượng từ Item_Order
        string itemOrderQuery = "SELECT ID_Menu, Amount FROM Item_Order WHERE ID_Order = @ID_Order";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(itemOrderQuery, conn);
            cmd.Parameters.AddWithValue("@ID_Order", orderId);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int menuId = Convert.ToInt32(reader["ID_Menu"]);
                int amount = Convert.ToInt32(reader["Amount"]);
                decimal price = GetMenuItemPrice(menuId);  // Tính giá món ăn

                subtotal += price * amount;
            }
            reader.Close();
        }

        return subtotal;
    }

    // Lấy giá của món ăn dựa trên ID_Menu
    private decimal GetMenuItemPrice(int menuId)
    {
        decimal price = 0;
        string priceQuery = "SELECT Price FROM Menu WHERE ID = @ID_Menu";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(priceQuery, conn);
            cmd.Parameters.AddWithValue("@ID_Menu", menuId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                price = Convert.ToDecimal(reader["Price"]);
            }
            reader.Close();
        }

        return price;
    }
}

