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
                Button btn = new Button();
                btn.Name = "btn" + table.Name;
                btn.Text = table.Name;
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(5);
                btn.Click += TableButtonClick;
                UpdateTableButtonColor(btn, table.Status);

                tableLayoutPanel1.Controls.Add(btn);
            }
        }

        private void UpdateTableButtonColor(Button btn, int status)
        {
            switch (status)
            {
                case 0: btn.BackColor = Color.White; break;
                case 1: btn.BackColor = Color.Red; break;
                case 2: btn.BackColor = Color.LightGreen; break;
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
    }
}
