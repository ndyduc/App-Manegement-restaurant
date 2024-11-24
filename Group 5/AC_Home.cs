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

        public AC_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_menus_Click(object sender, EventArgs e)
        {
            AC_Menus m = new AC_Menus();
            Shareds.GeneralFunct.ShowFormInPanel(m, panel);
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            AC_Tables t = new AC_Tables();
            Shareds.GeneralFunct.ShowFormInPanel(t, panel);        }

        private void AC_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
