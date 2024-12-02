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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.lessbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.morebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(736, 0);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(63, 66);
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
            this.lessbtn.Location = new System.Drawing.Point(49, 378);
            this.lessbtn.Name = "lessbtn";
            this.lessbtn.Size = new System.Drawing.Size(40, 40);
            this.lessbtn.TabIndex = 3;
            this.lessbtn.Text = "-";
            this.lessbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // morebtn
            // 
            this.morebtn.FlatAppearance.BorderSize = 0;
            this.morebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.morebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morebtn.ForeColor = System.Drawing.Color.Maroon;
            this.morebtn.Location = new System.Drawing.Point(189, 378);
            this.morebtn.Name = "morebtn";
            this.morebtn.Size = new System.Drawing.Size(40, 40);
            this.morebtn.TabIndex = 6;
            this.morebtn.Text = "+";
            this.morebtn.UseVisualStyleBackColor = true;
            // 
            // AC_AddtoBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.morebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lessbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AC_AddtoBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button lessbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button morebtn;
    }
}