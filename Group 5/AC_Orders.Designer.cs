namespace Group_5
{
    partial class AC_Orders
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
            this.mum = new System.Windows.Forms.FlowLayoutPanel();
            this.donebtn = new System.Windows.Forms.Button();
            this.presentbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mum
            // 
            this.mum.AutoScroll = true;
            this.mum.Location = new System.Drawing.Point(0, 82);
            this.mum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mum.Name = "mum";
            this.mum.Size = new System.Drawing.Size(1511, 660);
            this.mum.TabIndex = 0;
            this.mum.Paint += new System.Windows.Forms.PaintEventHandler(this.mum_Paint);
            // 
            // donebtn
            // 
            this.donebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.donebtn.FlatAppearance.BorderSize = 0;
            this.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.Location = new System.Drawing.Point(157, 29);
            this.donebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(114, 30);
            this.donebtn.TabIndex = 2;
            this.donebtn.Text = "Check out";
            this.donebtn.UseVisualStyleBackColor = false;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // presentbtn
            // 
            this.presentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.presentbtn.FlatAppearance.BorderSize = 0;
            this.presentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presentbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentbtn.Location = new System.Drawing.Point(33, 29);
            this.presentbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.presentbtn.Name = "presentbtn";
            this.presentbtn.Size = new System.Drawing.Size(112, 30);
            this.presentbtn.TabIndex = 3;
            this.presentbtn.Text = "Current";
            this.presentbtn.UseVisualStyleBackColor = false;
            this.presentbtn.Click += new System.EventHandler(this.presentbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(1183, 31);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(162, 30);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "New Order";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1422, 694);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.presentbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.mum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AC_Orders";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AC_Orders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mum;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button presentbtn;
        private System.Windows.Forms.Button Addbtn;
    }
}