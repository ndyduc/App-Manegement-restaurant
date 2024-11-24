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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Foodname = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Kind = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.menuTableAdapter1 = new Group_5.NDYDUC_dataTableAdapters.MenuTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.mon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewFood
            // 
            this.AddNewFood.BackColor = System.Drawing.Color.Firebrick;
            this.AddNewFood.Location = new System.Drawing.Point(12, 481);
            this.AddNewFood.Name = "AddNewFood";
            this.AddNewFood.Size = new System.Drawing.Size(853, 23);
            this.AddNewFood.TabIndex = 0;
            this.AddNewFood.Text = "Add New Food";
            this.AddNewFood.UseVisualStyleBackColor = false;
            this.AddNewFood.Click += new System.EventHandler(this.AddNewFood_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mon1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 463);
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
            this.mon1.Location = new System.Drawing.Point(3, 3);
            this.mon1.Name = "mon1";
            this.mon1.Size = new System.Drawing.Size(278, 251);
            this.mon1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Foodname
            // 
            this.Foodname.AutoSize = true;
            this.Foodname.Location = new System.Drawing.Point(3, 121);
            this.Foodname.Name = "Foodname";
            this.Foodname.Size = new System.Drawing.Size(35, 13);
            this.Foodname.TabIndex = 1;
            this.Foodname.Text = "Name";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(3, 160);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            this.Description.Click += new System.EventHandler(this.label2_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(3, 147);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // Kind
            // 
            this.Kind.AutoSize = true;
            this.Kind.Location = new System.Drawing.Point(3, 134);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(28, 13);
            this.Kind.TabIndex = 3;
            this.Kind.Text = "Kind";
            this.Kind.Click += new System.EventHandler(this.Kind_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.GreenYellow;
            this.Edit.Location = new System.Drawing.Point(6, 223);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(132, 23);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Brown;
            this.Delete.Location = new System.Drawing.Point(141, 223);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 23);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // AC_Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 516);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.AddNewFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AC_Menus";
            this.Text = "Form2";
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