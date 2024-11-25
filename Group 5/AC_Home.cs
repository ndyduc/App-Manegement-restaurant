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
    public partial class AC_Home : Form
    {
        private AC_Menus menuForm;

        public AC_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_menus_Click(object sender, EventArgs e)
        {
            if (menuForm == null || menuForm.IsDisposed) // Nếu form chưa tồn tại hoặc đã bị đóng
            {
                menuForm = new AC_Menus(); // Tạo form mới
                Shareds.GeneralFunct.ShowFormInPanel(menuForm, panel); // Hiển thị trong panel
            }

            menuForm.RefreshFullMenu();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            AC_Tables t = new AC_Tables();
            Shareds.GeneralFunct.ShowFormInPanel(t, panel);        }

        private void AC_Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_bao_Click(object sender, EventArgs e)
        {
            if (menuForm == null || menuForm.IsDisposed)
            {
                menuForm = new AC_Menus(); // Tạo form mới nếu cần
                Shareds.GeneralFunct.ShowFormInPanel(menuForm, panel);
            }
            menuForm.RefreshMenuItems("Bao");
        }

        private void btn_sides_Click(object sender, EventArgs e)
        {
            if (menuForm == null || menuForm.IsDisposed)
            {
                menuForm = new AC_Menus();
                Shareds.GeneralFunct.ShowFormInPanel(menuForm, panel);
            }
            menuForm.RefreshMenuItems("Sides");
        }

        private void btn_bowls_Click(object sender, EventArgs e)
        {
            if (menuForm == null || menuForm.IsDisposed)
            {
                menuForm = new AC_Menus();
                Shareds.GeneralFunct.ShowFormInPanel(menuForm, panel);
            }
            menuForm.RefreshMenuItems("Bowls");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dessert_Click(object sender, EventArgs e)
        {
            if (menuForm == null || menuForm.IsDisposed)
            {
                menuForm = new AC_Menus();
                Shareds.GeneralFunct.ShowFormInPanel(menuForm, panel);
            }
            menuForm.RefreshMenuItems("Dessert");
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            if (menuForm == null || menuForm.IsDisposed)
            {
                menuForm = new AC_Menus();
                Shareds.GeneralFunct.ShowFormInPanel(menuForm, panel);
            }
            menuForm.RefreshMenuItems("Drinks");
        }
    }
}
