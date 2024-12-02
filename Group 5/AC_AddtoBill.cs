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

namespace Group_5
{
    public partial class AC_AddtoBill : Form
    {
        public AC_AddtoBill(int idfood, int idorder)
        {
            InitializeComponent();


            RoundedButton addtobillbtn = new RoundedButton();
            addtobillbtn.Size = new Size(150, 50);  // Kích thước của nút
            addtobillbtn.Location = new Point(300, 200);  // Vị trí của nút
            addtobillbtn.Text = "Add to Bill";  // Văn bản của nút
            addtobillbtn.BackColor = Color.IndianRed;  // Màu nền của nút
            addtobillbtn.ForeColor = Color.White;  // Màu chữ
            addtobillbtn.BorderRadius = 20;  // Bán kính bo tròn

            // Cài đặt không có viền
            addtobillbtn.FlatStyle = FlatStyle.Flat;
            addtobillbtn.FlatAppearance.BorderSize = 0;  // Không có viền

            // Xử lý sự kiện click
            addtobillbtn.Click += new EventHandler(addtobillbtn_Click);

            // Thêm nút vào form
            this.Controls.Add(addtobillbtn);
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
    }

}
