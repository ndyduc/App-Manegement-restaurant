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
            this.listbill = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nDYDUC_data = new Group_5.NDYDUC_data();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new Group_5.NDYDUC_dataTableAdapters.MenuTableAdapter();
            this.orderTableAdapter = new Group_5.NDYDUC_dataTableAdapters.OrderTableAdapter();
            this.grpDelivery = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.div_order = new System.Windows.Forms.FlowLayoutPanel();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDYDUC_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.grpDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBilltitle
            // 
            this.lblBilltitle.AutoSize = true;
            this.lblBilltitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilltitle.Location = new System.Drawing.Point(12, 33);
            this.lblBilltitle.Name = "lblBilltitle";
            this.lblBilltitle.Size = new System.Drawing.Size(86, 44);
            this.lblBilltitle.TabIndex = 0;
            this.lblBilltitle.Text = "BILL";
            // 
            // listbill
            // 
            this.listbill.DataSource = this.orderBindingSource;
            this.listbill.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbill.FormattingEnabled = true;
            this.listbill.Location = new System.Drawing.Point(248, 42);
            this.listbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbill.Name = "listbill";
            this.listbill.Size = new System.Drawing.Size(108, 30);
            this.listbill.TabIndex = 3;
            this.listbill.SelectedIndexChanged += new System.EventHandler(this.listbill_SelectedIndexChanged);
            this.listbill.SelectedValueChanged += new System.EventHandler(this.listbill_SelectedValueChanged);
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
            this.grpDelivery.Controls.Add(this.txttotal);
            this.grpDelivery.Controls.Add(this.btnchange);
            this.grpDelivery.Controls.Add(this.txtphone);
            this.grpDelivery.Controls.Add(this.txtaddr);
            this.grpDelivery.Controls.Add(this.txtname);
            this.grpDelivery.Controls.Add(this.lblTotal);
            this.grpDelivery.Controls.Add(this.btnCheckout);
            this.grpDelivery.Controls.Add(this.lblPhone);
            this.grpDelivery.Controls.Add(this.lblAddress);
            this.grpDelivery.Controls.Add(this.lblName);
            this.grpDelivery.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpDelivery.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDelivery.Location = new System.Drawing.Point(12, 474);
            this.grpDelivery.Name = "grpDelivery";
            this.grpDelivery.Size = new System.Drawing.Size(390, 257);
            this.grpDelivery.TabIndex = 4;
            this.grpDelivery.TabStop = false;
            this.grpDelivery.Text = "Delivery";
            this.grpDelivery.Enter += new System.EventHandler(this.grpDelivery_Enter);
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.AutoSize = true;
            this.txttotal.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(168, 166);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(55, 22);
            this.txttotal.TabIndex = 22;
            this.txttotal.Text = "label2";
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnchange.FlatAppearance.BorderSize = 0;
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchange.Location = new System.Drawing.Point(18, 201);
            this.btnchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(130, 38);
            this.btnchange.TabIndex = 17;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(172, 117);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(213, 29);
            this.txtphone.TabIndex = 15;
            // 
            // txtaddr
            // 
            this.txtaddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaddr.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr.Location = new System.Drawing.Point(171, 74);
            this.txtaddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(213, 29);
            this.txtaddr.TabIndex = 14;
            this.txtaddr.TextChanged += new System.EventHandler(this.txtaddr_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(172, 34);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(213, 29);
            this.txtname.TabIndex = 13;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(16, 166);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 22);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckout.Location = new System.Drawing.Point(225, 201);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(149, 42);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(16, 117);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(124, 22);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(16, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 22);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // div_order
            // 
            this.div_order.AutoScroll = true;
            this.div_order.Location = new System.Drawing.Point(14, 92);
            this.div_order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.div_order.Name = "div_order";
            this.div_order.Size = new System.Drawing.Size(390, 377);
            this.div_order.TabIndex = 5;
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(359, 23);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(52, 49);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.Text = "X";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // AC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 743);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.div_order);
            this.Controls.Add(this.grpDelivery);
            this.Controls.Add(this.listbill);
            this.Controls.Add(this.lblBilltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AC_Bill";
            this.Text = "bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AC_Bill_Load);
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
        private System.Windows.Forms.ComboBox listbill;
        private NDYDUC_data nDYDUC_data;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private NDYDUC_dataTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private NDYDUC_dataTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.GroupBox grpDelivery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.FlowLayoutPanel div_order;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label txttotal;
    }
}