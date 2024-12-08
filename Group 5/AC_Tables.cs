using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Group_5
{
    public partial class AC_Tables : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();


        public AC_Tables()
        {
            InitializeComponent();
            LoadTables();
        }

        public void LoadTables()
        {
            tableLayoutPanel1.Controls.Clear();
            var tables = db.Tables.ToList();

            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.RowCount = (tables.Count + tableLayoutPanel1.ColumnCount - 1) / tableLayoutPanel1.ColumnCount;

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            // Chia 4 cột, mỗi cột 25%
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            }

            // Chia đều chiều cao cho các hàng
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tableLayoutPanel1.RowCount));
            }
            foreach (var table in tables)
            {

                RoundedButton btn = new RoundedButton
                {
                    Name = "btn" + table.Name,
                    Text = table.Name,
                    Font = new Font("Arial", 20, FontStyle.Bold),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(5),
                    BorderRadius = 50 
                };
                btn.Click += TableButtonClick;
                UpdateTableButtonColor(btn, table.Status);
 // Tăng kích thước font
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.BackColor = Color.White;  // Màu nền mặc định


                // Thêm hình ảnh
                Image originalImage = Image.FromFile("C:\\Users\\admin\\OneDrive\\Hình ảnh\\anhban.png"); // Đường dẫn đến hình ảnh

                // Tính toán kích thước mới cho hình ảnh 
                int newWidth = (int)(btn.Width * 4);
                int newHeight = (int)(btn.Height * 10);
                btn.Image = new Bitmap(originalImage, new Size(newWidth, newHeight));

                // Căn chỉnh hình ảnh và văn bản
                btn.ImageAlign = ContentAlignment.MiddleCenter; // Căn giữa hình ảnh
                btn.TextAlign = ContentAlignment.MiddleCenter; // Căn giữa văn bản
                btn.Padding = new Padding(0); // Không cần khoảng cách

                btn.Text = table.Name; // Đặt văn bản cho nút

                btn.Click += TableButtonClick;

                // Thêm hiệu ứng hover với chuyển tiếp mượt mà
                btn.MouseEnter += (sender, e) =>
                {
                    btn.BackColor = Color.LightBlue;
                    btn.FlatAppearance.BorderColor = Color.Blue; // Thay đổi màu viền khi hover
                };
                btn.MouseLeave += (sender, e) =>
                {
                    UpdateTableButtonColor(btn, table.Status);
                    btn.FlatAppearance.BorderColor = Color.Gray; // Khôi phục màu viền
                };

                UpdateTableButtonColor(btn, table.Status);
                tableLayoutPanel1.Controls.Add(btn);
            }

        }

        private void UpdateTableButtonColor(Button btn, int status)
        {
            switch (status)
            {
                case 0:
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    break;
                case 1:
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    break;
                case 2:
                    btn.BackColor = Color.LightGreen;
                    btn.ForeColor = Color.DarkGreen;
                    break;
            }
        }

        private void TableButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string tableName = btn.Name.Substring(3);
            Table table = db.Tables.FirstOrDefault(t => t.Name == tableName);

            if (table != null)
            {
                TableReservationForm reservationForm = new TableReservationForm(table, this);
                reservationForm.StartPosition = FormStartPosition.CenterParent;
                reservationForm.ShowDialog();
                db.SubmitChanges();
                LoadTables();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Optionally, you can draw additional custom graphics here
        }
    }
}