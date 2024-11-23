using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        }
    }
}
