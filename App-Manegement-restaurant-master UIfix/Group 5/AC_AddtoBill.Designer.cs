namespace Group_5
{
    partial class AC_AddtoBill
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
            this.imgfood = new System.Windows.Forms.PictureBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.lessbtn = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.Label();
            this.morebtn = new System.Windows.Forms.Button();
            this.bill_here = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgfood
            // 
            this.imgfood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imgfood.Location = new System.Drawing.Point(0, 0);
            this.imgfood.Margin = new System.Windows.Forms.Padding(0);
            this.imgfood.Name = "imgfood";
            this.imgfood.Size = new System.Drawing.Size(200, 195);
            this.imgfood.TabIndex = 0;
            this.imgfood.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(491, 0);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(42, 43);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Text = "X";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // lessbtn
            // 
            this.lessbtn.FlatAppearance.BorderSize = 0;
            this.lessbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessbtn.ForeColor = System.Drawing.Color.Maroon;
            this.lessbtn.Location = new System.Drawing.Point(43, 233);
            this.lessbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lessbtn.Name = "lessbtn";
            this.lessbtn.Size = new System.Drawing.Size(27, 26);
            this.lessbtn.TabIndex = 3;
            this.lessbtn.Text = "-";
            this.lessbtn.UseVisualStyleBackColor = true;
            this.lessbtn.Click += new System.EventHandler(this.lessbtn_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.AutoSize = true;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(83, 233);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(24, 26);
            this.txt_amount.TabIndex = 5;
            this.txt_amount.Text = "1";
            // 
            // morebtn
            // 
            this.morebtn.FlatAppearance.BorderSize = 0;
            this.morebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.morebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morebtn.ForeColor = System.Drawing.Color.Maroon;
            this.morebtn.Location = new System.Drawing.Point(130, 233);
            this.morebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.morebtn.Name = "morebtn";
            this.morebtn.Size = new System.Drawing.Size(27, 26);
            this.morebtn.TabIndex = 6;
            this.morebtn.Text = "+";
            this.morebtn.UseVisualStyleBackColor = true;
            this.morebtn.Click += new System.EventHandler(this.morebtn_Click);
            // 
            // bill_here
            // 
            this.bill_here.FormattingEnabled = true;
            this.bill_here.Location = new System.Drawing.Point(269, 22);
            this.bill_here.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bill_here.Name = "bill_here";
            this.bill_here.Size = new System.Drawing.Size(82, 21);
            this.bill_here.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(202, 13);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(45, 30);
            this.txt_name.TabIndex = 9;
            this.txt_name.Text = "Bill:";
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            // 
            // txt_price
            // 
            this.txt_price.AutoSize = true;
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(201, 61);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(63, 30);
            this.txt_price.TabIndex = 11;
            this.txt_price.Text = "Price:";
            this.txt_price.Click += new System.EventHandler(this.txt_price_Click);
            // 
            // txt_note
            // 
            this.txt_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_note.BackColor = System.Drawing.SystemColors.Control;
            this.txt_note.Location = new System.Drawing.Point(269, 120);
            this.txt_note.Margin = new System.Windows.Forms.Padding(0);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(255, 91);
            this.txt_note.TabIndex = 12;
            this.txt_note.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.Control;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_description.Location = new System.Drawing.Point(268, 61);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(253, 30);
            this.txt_description.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group_5.Properties.Resources.Border;
            this.pictureBox1.Location = new System.Drawing.Point(25, 222);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AC_AddtoBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.morebtn);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lessbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bill_here);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.imgfood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AC_AddtoBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AC_AddtoBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgfood;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button lessbtn;
        private System.Windows.Forms.Label txt_amount;
        private System.Windows.Forms.Button morebtn;
        private System.Windows.Forms.ComboBox bill_here;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label txt_price;
        private System.Windows.Forms.RichTextBox txt_note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}