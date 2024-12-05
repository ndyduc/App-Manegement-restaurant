namespace Group_5.Properties
{
    partial class AC_Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBilltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_less = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTenmon = new System.Windows.Forms.Label();
            this.img_bill = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nDYDUC_data = new Group_5.NDYDUC_data();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new Group_5.NDYDUC_dataTableAdapters.MenuTableAdapter();
            this.orderTableAdapter = new Group_5.NDYDUC_dataTableAdapters.OrderTableAdapter();
            this.grpDelivery = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblPhoneCus = new System.Windows.Forms.Label();
            this.lblAdressCus = new System.Windows.Forms.Label();
            this.lblNameCus = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDYDUC_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.grpDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBilltitle
            // 
            this.lblBilltitle.AutoSize = true;
            this.lblBilltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilltitle.Location = new System.Drawing.Point(11, 7);
            this.lblBilltitle.Name = "lblBilltitle";
            this.lblBilltitle.Size = new System.Drawing.Size(56, 25);
            this.lblBilltitle.TabIndex = 0;
            this.lblBilltitle.Text = "BILL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_less);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblTenmon);
            this.panel1.Controls.Add(this.img_bill);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 80);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(262, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_less
            // 
            this.btn_less.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_less.Location = new System.Drawing.Point(214, 42);
            this.btn_less.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_less.Name = "btn_less";
            this.btn_less.Size = new System.Drawing.Size(43, 26);
            this.btn_less.TabIndex = 6;
            this.btn_less.Text = "-";
            this.btn_less.UseVisualStyleBackColor = true;
            // 
            // txt_amount
            // 
            this.txt_amount.AutoSize = true;
            this.txt_amount.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(115, 41);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(25, 25);
            this.txt_amount.TabIndex = 5;
            this.txt_amount.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(228, 10);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblTenmon
            // 
            this.lblTenmon.AutoSize = true;
            this.lblTenmon.Location = new System.Drawing.Point(94, 10);
            this.lblTenmon.Name = "lblTenmon";
            this.lblTenmon.Size = new System.Drawing.Size(44, 16);
            this.lblTenmon.TabIndex = 2;
            this.lblTenmon.Text = "Name";
            // 
            // img_bill
            // 
            this.img_bill.Location = new System.Drawing.Point(0, 0);
            this.img_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_bill.Name = "img_bill";
            this.img_bill.Size = new System.Drawing.Size(89, 80);
            this.img_bill.TabIndex = 1;
            this.img_bill.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.orderBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.nDYDUC_data;
            // 
            // nDYDUC_data
            // 
            this.nDYDUC_data.DataSetName = "NDYDUC_data";
            this.nDYDUC_data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.nDYDUC_data;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // grpDelivery
            // 
            this.grpDelivery.CausesValidation = false;
            this.grpDelivery.Controls.Add(this.lblTo);
            this.grpDelivery.Controls.Add(this.lblDis);
            this.grpDelivery.Controls.Add(this.lblSub);
            this.grpDelivery.Controls.Add(this.lblPhoneCus);
            this.grpDelivery.Controls.Add(this.lblAdressCus);
            this.grpDelivery.Controls.Add(this.lblNameCus);
            this.grpDelivery.Controls.Add(this.lblTotal);
            this.grpDelivery.Controls.Add(this.btnCheckout);
            this.grpDelivery.Controls.Add(this.lblDiscount);
            this.grpDelivery.Controls.Add(this.lblSubtotal);
            this.grpDelivery.Controls.Add(this.lblPhone);
            this.grpDelivery.Controls.Add(this.lblAddress);
            this.grpDelivery.Controls.Add(this.lblName);
            this.grpDelivery.Cursor = System.Windows.Forms.Cursors.No;
            this.grpDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDelivery.Location = new System.Drawing.Point(11, 284);
            this.grpDelivery.Name = "grpDelivery";
            this.grpDelivery.Size = new System.Drawing.Size(320, 282);
            this.grpDelivery.TabIndex = 4;
            this.grpDelivery.TabStop = false;
            this.grpDelivery.Text = "Delivery";
            this.grpDelivery.Enter += new System.EventHandler(this.grpDelivery_Enter);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(259, 188);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(44, 16);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "label7";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDis.Location = new System.Drawing.Point(259, 162);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(44, 16);
            this.lblDis.TabIndex = 11;
            this.lblDis.Text = "label6";
            this.lblDis.Click += new System.EventHandler(this.lblDis_Click);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(259, 134);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(44, 16);
            this.lblSub.TabIndex = 10;
            this.lblSub.Text = "label3";
            this.lblSub.Click += new System.EventHandler(this.lblSub_Click);
            // 
            // lblPhoneCus
            // 
            this.lblPhoneCus.AutoSize = true;
            this.lblPhoneCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneCus.Location = new System.Drawing.Point(259, 88);
            this.lblPhoneCus.Name = "lblPhoneCus";
            this.lblPhoneCus.Size = new System.Drawing.Size(44, 16);
            this.lblPhoneCus.TabIndex = 9;
            this.lblPhoneCus.Text = "label2";
            this.lblPhoneCus.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAdressCus
            // 
            this.lblAdressCus.AutoSize = true;
            this.lblAdressCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdressCus.Location = new System.Drawing.Point(259, 61);
            this.lblAdressCus.Name = "lblAdressCus";
            this.lblAdressCus.Size = new System.Drawing.Size(44, 16);
            this.lblAdressCus.TabIndex = 8;
            this.lblAdressCus.Text = "label1";
            this.lblAdressCus.Click += new System.EventHandler(this.lblAdress_Click);
            // 
            // lblNameCus
            // 
            this.lblNameCus.AutoSize = true;
            this.lblNameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCus.Location = new System.Drawing.Point(259, 34);
            this.lblNameCus.Name = "lblNameCus";
            this.lblNameCus.Size = new System.Drawing.Size(44, 16);
            this.lblNameCus.TabIndex = 7;
            this.lblNameCus.Text = "label5";
            this.lblNameCus.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(16, 188);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckout.Location = new System.Drawing.Point(85, 228);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(149, 35);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(16, 162);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 16);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(16, 134);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(56, 16);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(14, 88);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(94, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(14, 61);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // AC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 574);
            this.Controls.Add(this.grpDelivery);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBilltitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AC_Bill";
            this.Text = "bill";
            this.Load += new System.EventHandler(this.AC_Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDYDUC_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.grpDelivery.ResumeLayout(false);
            this.grpDelivery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTenmon;
        private System.Windows.Forms.PictureBox img_bill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_less;
        private System.Windows.Forms.Label txt_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private NDYDUC_data nDYDUC_data;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private NDYDUC_dataTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private NDYDUC_dataTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.GroupBox grpDelivery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNameCus;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblPhoneCus;
        private System.Windows.Forms.Label lblAdressCus;
    }
}