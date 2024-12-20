﻿using System.Windows.Forms;

namespace Group_5
{
    partial class AC_Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_menus = new System.Windows.Forms.Button();
            this.btn_drinks = new System.Windows.Forms.Button();
            this.btn_sides = new System.Windows.Forms.Button();
            this.btn_bowls = new System.Windows.Forms.Button();
            this.btn_dessert = new System.Windows.Forms.Button();
            this.btn_bao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_table = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.txt_menu = new System.Windows.Forms.Label();
            this.billwhere = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.Panel_bill = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_menus);
            this.panel1.Controls.Add(this.btn_drinks);
            this.panel1.Controls.Add(this.btn_sides);
            this.panel1.Controls.Add(this.btn_bowls);
            this.panel1.Controls.Add(this.btn_dessert);
            this.panel1.Controls.Add(this.btn_bao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 756);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "MENU";
            // 
            // btn_menus
            // 
            this.btn_menus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_menus.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_menus.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menus.Location = new System.Drawing.Point(28, 358);
            this.btn_menus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menus.Name = "btn_menus";
            this.btn_menus.Size = new System.Drawing.Size(151, 50);
            this.btn_menus.TabIndex = 6;
            this.btn_menus.Text = "Manage Menu";
            this.btn_menus.UseVisualStyleBackColor = false;
            this.btn_menus.Click += new System.EventHandler(this.btn_menus_Click);
            // 
            // btn_drinks
            // 
            this.btn_drinks.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_drinks.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drinks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_drinks.Location = new System.Drawing.Point(28, 304);
            this.btn_drinks.Margin = new System.Windows.Forms.Padding(0);
            this.btn_drinks.Name = "btn_drinks";
            this.btn_drinks.Size = new System.Drawing.Size(151, 40);
            this.btn_drinks.TabIndex = 5;
            this.btn_drinks.Text = "Drinks";
            this.btn_drinks.UseVisualStyleBackColor = false;
            this.btn_drinks.Click += new System.EventHandler(this.btn_drinks_Click);
            // 
            // btn_sides
            // 
            this.btn_sides.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_sides.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sides.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sides.Location = new System.Drawing.Point(28, 153);
            this.btn_sides.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sides.Name = "btn_sides";
            this.btn_sides.Size = new System.Drawing.Size(151, 38);
            this.btn_sides.TabIndex = 4;
            this.btn_sides.Text = "Sides";
            this.btn_sides.UseVisualStyleBackColor = false;
            this.btn_sides.Click += new System.EventHandler(this.btn_sides_Click);
            // 
            // btn_bowls
            // 
            this.btn_bowls.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_bowls.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bowls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bowls.Location = new System.Drawing.Point(28, 201);
            this.btn_bowls.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bowls.Name = "btn_bowls";
            this.btn_bowls.Size = new System.Drawing.Size(151, 40);
            this.btn_bowls.TabIndex = 3;
            this.btn_bowls.Text = "Bowls";
            this.btn_bowls.UseVisualStyleBackColor = false;
            this.btn_bowls.Click += new System.EventHandler(this.btn_bowls_Click);
            // 
            // btn_dessert
            // 
            this.btn_dessert.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dessert.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dessert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dessert.Location = new System.Drawing.Point(28, 251);
            this.btn_dessert.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dessert.Name = "btn_dessert";
            this.btn_dessert.Size = new System.Drawing.Size(151, 42);
            this.btn_dessert.TabIndex = 2;
            this.btn_dessert.Text = "Dessert";
            this.btn_dessert.UseVisualStyleBackColor = false;
            this.btn_dessert.Click += new System.EventHandler(this.btn_dessert_Click);
            // 
            // btn_bao
            // 
            this.btn_bao.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_bao.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bao.Location = new System.Drawing.Point(28, 103);
            this.btn_bao.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bao.Name = "btn_bao";
            this.btn_bao.Size = new System.Drawing.Size(151, 40);
            this.btn_bao.TabIndex = 1;
            this.btn_bao.Text = "Bao";
            this.btn_bao.UseVisualStyleBackColor = false;
            this.btn_bao.Click += new System.EventHandler(this.btn_bao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAO WOW";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_table
            // 
            this.btn_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_table.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_table.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_table.Location = new System.Drawing.Point(1453, 10);
            this.btn_table.Margin = new System.Windows.Forms.Padding(0);
            this.btn_table.Name = "btn_table";
            this.btn_table.Size = new System.Drawing.Size(169, 44);
            this.btn_table.TabIndex = 1;
            this.btn_table.Text = "Tables";
            this.btn_table.UseVisualStyleBackColor = false;
            this.btn_table.Click += new System.EventHandler(this.btn_table_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Order.Location = new System.Drawing.Point(1267, 10);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(169, 44);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "Orders";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // txt_menu
            // 
            this.txt_menu.AutoSize = true;
            this.txt_menu.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_menu.Location = new System.Drawing.Point(230, 16);
            this.txt_menu.Name = "txt_menu";
            this.txt_menu.Size = new System.Drawing.Size(72, 37);
            this.txt_menu.TabIndex = 8;
            this.txt_menu.Text = "BILL";
            this.txt_menu.Click += new System.EventHandler(this.txt_menu_Click);
            // 
            // billwhere
            // 
            this.billwhere.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billwhere.FormattingEnabled = true;
            this.billwhere.Location = new System.Drawing.Point(308, 20);
            this.billwhere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billwhere.Name = "billwhere";
            this.billwhere.Size = new System.Drawing.Size(108, 30);
            this.billwhere.TabIndex = 9;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Location = new System.Drawing.Point(207, 61);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1422, 694);
            this.panel.TabIndex = 10;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // Panel_bill
            // 
            this.Panel_bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_bill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_bill.Location = new System.Drawing.Point(1243, 61);
            this.Panel_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_bill.Name = "Panel_bill";
            this.Panel_bill.Size = new System.Drawing.Size(420, 743);
            this.Panel_bill.TabIndex = 0;
            this.Panel_bill.Visible = false;
            this.Panel_bill.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_bill_Paint);
            // 
            // AC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 755);
            this.Controls.Add(this.billwhere);
            this.Controls.Add(this.txt_menu);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.btn_table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_bill);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AC_Home";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AC_Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_table;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_menus;
        private System.Windows.Forms.Button btn_drinks;
        private System.Windows.Forms.Button btn_sides;
        private System.Windows.Forms.Button btn_bowls;
        private System.Windows.Forms.Button btn_dessert;
        private System.Windows.Forms.Button btn_bao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_menu;
        private System.Windows.Forms.ComboBox billwhere;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel Panel_bill;
        //private NDYDUC_dataTableAdapters.PostsTableAdapter postsTableAdapter1;
    }
}