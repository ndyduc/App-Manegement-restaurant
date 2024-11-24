namespace Group_5
{
    partial class AC_Addfood
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
            this.AddProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Done = new System.Windows.Forms.Button();
            this.AddName = new System.Windows.Forms.Label();
            this.AddType = new System.Windows.Forms.Label();
            this.AddPrice = new System.Windows.Forms.Label();
            this.AddDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddImage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.AutoSize = true;
            this.AddProduct.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(12, 9);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(255, 62);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.AddPrice);
            this.panel1.Controls.Add(this.AddDescription);
            this.panel1.Controls.Add(this.AddType);
            this.panel1.Controls.Add(this.AddName);
            this.panel1.Location = new System.Drawing.Point(15, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 364);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.AddImage);
            this.panel2.Location = new System.Drawing.Point(414, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 298);
            this.panel2.TabIndex = 2;
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.Firebrick;
            this.Done.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(414, 378);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(374, 60);
            this.Done.TabIndex = 3;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // AddName
            // 
            this.AddName.AutoSize = true;
            this.AddName.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddName.Location = new System.Drawing.Point(3, 0);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(167, 47);
            this.AddName.TabIndex = 0;
            this.AddName.Text = "Add Name";
            // 
            // AddType
            // 
            this.AddType.AutoSize = true;
            this.AddType.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddType.Location = new System.Drawing.Point(3, 84);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(153, 47);
            this.AddType.TabIndex = 1;
            this.AddType.Text = "Add Type";
            // 
            // AddPrice
            // 
            this.AddPrice.AutoSize = true;
            this.AddPrice.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrice.Location = new System.Drawing.Point(206, 84);
            this.AddPrice.Name = "AddPrice";
            this.AddPrice.Size = new System.Drawing.Size(157, 47);
            this.AddPrice.TabIndex = 3;
            this.AddPrice.Text = "Add Price";
            // 
            // AddDescription
            // 
            this.AddDescription.AutoSize = true;
            this.AddDescription.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDescription.Location = new System.Drawing.Point(3, 168);
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(241, 47);
            this.AddDescription.TabIndex = 2;
            this.AddDescription.Text = "Add Description";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 31);
            this.textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(214, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 31);
            this.textBox3.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(362, 141);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // AddImage
            // 
            this.AddImage.AutoSize = true;
            this.AddImage.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImage.Location = new System.Drawing.Point(3, 0);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(201, 57);
            this.AddImage.TabIndex = 0;
            this.AddImage.Text = "Add Image";
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 166);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bao",
            "Bowls",
            "Sides",
            "Dessert",
            "Drink"});
            this.comboBox1.Location = new System.Drawing.Point(11, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 36);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AC_Addfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddProduct);
            this.Name = "AC_Addfood";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AC_Addfood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label AddPrice;
        private System.Windows.Forms.Label AddDescription;
        private System.Windows.Forms.Label AddType;
        private System.Windows.Forms.Label AddName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label AddImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}