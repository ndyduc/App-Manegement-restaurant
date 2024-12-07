using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Group_5
{
    public partial class TableReservationForm : Form
    {
        private readonly string placeholderName = "Name";
        private readonly string placeholderPhone = "Phone Number";
        private readonly string placeholderEmail = "Email";

        private Table table;
        private AC_Tables parentForm;
        private DataClasses1DataContext db = new DataClasses1DataContext();


        public TableReservationForm(Table selectedTable, AC_Tables parent)
        {
            InitializeComponent();
            table = selectedTable;
            parentForm = parent;

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ShowInTaskbar = false;

            AttachPlaceholderEvents(txtName, placeholderName);
            AttachPlaceholderEvents(txtPhone, placeholderPhone);
            AttachPlaceholderEvents(txtEmail, placeholderEmail);

            btnAddOrder.Click += btnAddOrder_Click;
            btnConfirm.Click += btnConfirm_Click;


            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;
        }

        private void AttachPlaceholderEvents(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void UpdateForm()
        {
            lblTableName.Text = table.Name;
            Customer existingCustomer = db.Customers.FirstOrDefault(c => c.TableId == table.Id);

            if (table.Status == 1 || table.Status == 2)
            {
                btnConfirm.Text = "Hủy đặt bàn";
                btnAddOrder.Visible = table.Status == 1;
                DisableInputFields();
            }
            else
            {
                btnConfirm.Text = "Xác nhận đặt bàn";
                btnAddOrder.Visible = false;
                EnableInputFields();
            }

            if (existingCustomer != null)
            {
                txtName.Text = existingCustomer.Name;
                txtName.ForeColor = Color.Black;
                txtPhone.Text = existingCustomer.Phone;
                txtPhone.ForeColor = Color.Black;
                txtEmail.Text = existingCustomer.Email;
                txtEmail.ForeColor = Color.Black;
                dateTimePicker1.Value = existingCustomer.Arrived.HasValue ? existingCustomer.Arrived.Value : DateTime.Now;

                if (existingCustomer.Leave.HasValue)
                {
                    dateTimePicker2.Value = DateTime.Today.Add(existingCustomer.Leave.Value);
                }
                else
                {
                    dateTimePicker2.Value = DateTime.Now;
                }
            }
            else
            {
                ResetPlaceholders();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
            }
        }

        private void ResetPlaceholders()
        {
            txtName.Text = placeholderName;
            txtName.ForeColor = Color.Gray;
            txtPhone.Text = placeholderPhone;
            txtPhone.ForeColor = Color.Gray;
            txtEmail.Text = placeholderEmail;
            txtEmail.ForeColor = Color.Gray;
        }

        private void DisableInputFields()
        {
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void EnableInputFields()
        {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == placeholderName)
            {
                MessageBox.Show("Tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text == placeholderPhone)
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPhone.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại không được vượt quá 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == placeholderEmail)
            {
                MessageBox.Show("Email không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải có đuôi @gmail.com!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan leaveTime = dateTimePicker2.Value.TimeOfDay;

            if (table.Status == 0)
            {
                Customer newCustomer = new Customer
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Arrived = dateTimePicker1.Value,
                    Leave = leaveTime,
                    TableId = table.Id
                };
                db.Customers.InsertOnSubmit(newCustomer);
                table.Status = 1;
            }
            else
            {
                Customer existingCustomer = db.Customers.FirstOrDefault(c => c.TableId == table.Id);
                if (existingCustomer != null)
                {
                    db.Customers.DeleteOnSubmit(existingCustomer);
                }
                table.Status = 0;
            }

            db.SubmitChanges();
            parentForm.LoadTables();
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            table.Status = 2;
            db.SubmitChanges();
            UpdateForm();
            parentForm.LoadTables();
            this.Close();
        }

        private void TableReservationForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void InitializeComponent()
        {
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime1 = new System.Windows.Forms.Label();
            this.lblDateTime2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(12, 9);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(229, 69);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Tên bàn ";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddOrder.Location = new System.Drawing.Point(363, 9);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(212, 48);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtName.Location = new System.Drawing.Point(12, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(563, 64);
            this.txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtPhone.Location = new System.Drawing.Point(12, 202);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(563, 64);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtEmail.Location = new System.Drawing.Point(12, 310);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(560, 64);
            this.txtEmail.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 450);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 36);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker2.Location = new System.Drawing.Point(363, 450);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(212, 36);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblDateTime1
            // 
            this.lblDateTime1.AutoSize = true;
            this.lblDateTime1.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime1.Location = new System.Drawing.Point(69, 390);
            this.lblDateTime1.Name = "lblDateTime1";
            this.lblDateTime1.Size = new System.Drawing.Size(250, 57);
            this.lblDateTime1.TabIndex = 7;
            this.lblDateTime1.Text = "Đặt bàn lúc";
            // 
            // lblDateTime2
            // 
            this.lblDateTime2.AutoSize = true;
            this.lblDateTime2.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime2.Location = new System.Drawing.Point(377, 390);
            this.lblDateTime2.Name = "lblDateTime2";
            this.lblDateTime2.Size = new System.Drawing.Size(211, 57);
            this.lblDateTime2.TabIndex = 8;
            this.lblDateTime2.Text = "Thời gian";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Brown;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(129, 510);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(350, 57);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Xác nhận đặt bàn";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // TableReservationForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 603);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDateTime2);
            this.Controls.Add(this.lblDateTime1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblTableName);
            this.Name = "TableReservationForm";
            this.Load += new System.EventHandler(this.TableReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblDateTime1;
        private System.Windows.Forms.Label lblDateTime2;
        private System.Windows.Forms.Button btnConfirm;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}