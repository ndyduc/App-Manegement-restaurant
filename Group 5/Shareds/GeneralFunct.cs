using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_5.Shareds
{
    internal class GeneralFunct
    {
        public static void ShowFormInPanel(Form f, Panel panel1)
        {
            f.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }
    }
}
