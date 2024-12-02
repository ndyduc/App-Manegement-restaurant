using System.Windows.Forms;

namespace Group_5
{
    partial class AC_Menus
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
            this.AddNewFood = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mon1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.Kind = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Foodname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuTableAdapter1 = new Group_5.NDYDUC_dataTableAdapters.MenuTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.mon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewFood
            // 
            this.AddNewFood.BackColor = System.Drawing.Color.Firebrick;
            this.AddNewFood.Location = new System.Drawing.Point(18, 740);
            this.AddNewFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewFood.Name = "AddNewFood";
            this.AddNewFood.Size = new System.Drawing.Size(1280, 35);
            this.AddNewFood.TabIndex = 0;
            this.AddNewFood.Text = "Add New Food";
            this.AddNewFood.UseVisualStyleBackColor = false;
            this.AddNewFood.Click += new System.EventHandler(this.AddNewFood_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mon1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1600, 800);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // mon1
            // 
            this.mon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mon1.Controls.Add(this.Delete);
            this.mon1.Controls.Add(this.Edit);
            this.mon1.Controls.Add(this.Price);
            this.mon1.Controls.Add(this.Kind);
            this.mon1.Controls.Add(this.Description);
            this.mon1.Controls.Add(this.Foodname);
            this.mon1.Controls.Add(this.pictureBox1);
            this.mon1.Location = new System.Drawing.Point(4, 5);
            this.mon1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mon1.Name = "mon1";
            this.mon1.Size = new System.Drawing.Size(300, 385);
            this.mon1.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Brown;
            this.Delete.Location = new System.Drawing.Point(150, 343);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 35);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.GreenYellow;
            this.Edit.Location = new System.Drawing.Point(9, 343);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(133, 35);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(4, 226);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // Kind
            // 
            this.Kind.AutoSize = true;
            this.Kind.Location = new System.Drawing.Point(4, 206);
            this.Kind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(40, 20);
            this.Kind.TabIndex = 3;
            this.Kind.Text = "Kind";
            this.Kind.Click += new System.EventHandler(this.Kind_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(4, 246);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            this.Description.Click += new System.EventHandler(this.label2_Click);
            // 
            // Foodname
            // 
            this.Foodname.AutoSize = true;
            this.Foodname.Location = new System.Drawing.Point(4, 186);
            this.Foodname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Foodname.Name = "Foodname";
            this.Foodname.Size = new System.Drawing.Size(51, 20);
            this.Foodname.TabIndex = 1;
            this.Foodname.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // AC_Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1600, 870);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.AddNewFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AC_Menus";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AC_Menus_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mon1.ResumeLayout(false);
            this.mon1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewFood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel mon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Kind;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Foodname;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private NDYDUC_dataTableAdapters.MenuTableAdapter menuTableAdapter1;
    }
}