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
            this.allbtn = new System.Windows.Forms.Button();
            this.donebtn = new System.Windows.Forms.Button();
            this.presentbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mum
            // 
            this.mum.Location = new System.Drawing.Point(0, 102);
            this.mum.Name = "mum";
            this.mum.Size = new System.Drawing.Size(1600, 600);
            this.mum.TabIndex = 0;
            // 
            // allbtn
            // 
            this.allbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.allbtn.FlatAppearance.BorderSize = 0;
            this.allbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allbtn.Location = new System.Drawing.Point(324, 32);
            this.allbtn.Name = "allbtn";
            this.allbtn.Size = new System.Drawing.Size(107, 37);
            this.allbtn.TabIndex = 1;
            this.allbtn.Text = "ALL";
            this.allbtn.UseVisualStyleBackColor = false;
            // 
            // donebtn
            // 
            this.donebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.donebtn.FlatAppearance.BorderSize = 0;
            this.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebtn.Location = new System.Drawing.Point(180, 32);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(109, 37);
            this.donebtn.TabIndex = 2;
            this.donebtn.Text = "Check out";
            this.donebtn.UseVisualStyleBackColor = false;
            // 
            // presentbtn
            // 
            this.presentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.presentbtn.FlatAppearance.BorderSize = 0;
            this.presentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presentbtn.Location = new System.Drawing.Point(40, 32);
            this.presentbtn.Name = "presentbtn";
            this.presentbtn.Size = new System.Drawing.Size(107, 37);
            this.presentbtn.TabIndex = 3;
            this.presentbtn.Text = "Current";
            this.presentbtn.UseVisualStyleBackColor = false;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Location = new System.Drawing.Point(904, 32);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(182, 37);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "New Order";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1600, 700);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.presentbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.allbtn);
            this.Controls.Add(this.mum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AC_Orders";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AC_Orders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mum;
        private System.Windows.Forms.Button allbtn;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button presentbtn;
        private System.Windows.Forms.Button Addbtn;
    }
}