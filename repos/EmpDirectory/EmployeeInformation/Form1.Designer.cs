namespace EmployeeInformation
{
    partial class Form1
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
            this.txtEmployeeName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmployeeeId = new System.Windows.Forms.Label();
            this.txtemployeePhone = new System.Windows.Forms.Label();
            this.txtEmployeeAddresss = new System.Windows.Forms.Label();
            this.txtTweetId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AutoSize = true;
            this.txtEmployeeName.Location = new System.Drawing.Point(205, 139);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(81, 13);
            this.txtEmployeeName.TabIndex = 0;
            this.txtEmployeeName.Text = "EmployeeName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtEmployeeeId
            // 
            this.txtEmployeeeId.AutoSize = true;
            this.txtEmployeeeId.Location = new System.Drawing.Point(205, 175);
            this.txtEmployeeeId.Name = "txtEmployeeeId";
            this.txtEmployeeeId.Size = new System.Drawing.Size(65, 13);
            this.txtEmployeeeId.TabIndex = 2;
            this.txtEmployeeeId.Text = "Employee Id";
            // 
            // txtemployeePhone
            // 
            this.txtemployeePhone.AutoSize = true;
            this.txtemployeePhone.Location = new System.Drawing.Point(205, 228);
            this.txtemployeePhone.Name = "txtemployeePhone";
            this.txtemployeePhone.Size = new System.Drawing.Size(84, 13);
            this.txtemployeePhone.TabIndex = 3;
            this.txtemployeePhone.Text = "EmployeePhone";
            // 
            // txtEmployeeAddresss
            // 
            this.txtEmployeeAddresss.AutoSize = true;
            this.txtEmployeeAddresss.Location = new System.Drawing.Point(205, 268);
            this.txtEmployeeAddresss.Name = "txtEmployeeAddresss";
            this.txtEmployeeAddresss.Size = new System.Drawing.Size(91, 13);
            this.txtEmployeeAddresss.TabIndex = 4;
            this.txtEmployeeAddresss.Text = "EmployeeAddress";
            // 
            // txtTweetId
            // 
            this.txtTweetId.AutoSize = true;
            this.txtTweetId.Location = new System.Drawing.Point(205, 300);
            this.txtTweetId.Name = "txtTweetId";
            this.txtTweetId.Size = new System.Drawing.Size(46, 13);
            this.txtTweetId.TabIndex = 5;
            this.txtTweetId.Text = "TweetId";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(301, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(301, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(301, 300);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTweetId);
            this.Controls.Add(this.txtEmployeeAddresss);
            this.Controls.Add(this.txtemployeePhone);
            this.Controls.Add(this.txtEmployeeeId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtEmployeeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEmployeeName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtEmployeeeId;
        private System.Windows.Forms.Label txtemployeePhone;
        private System.Windows.Forms.Label txtEmployeeAddresss;
        private System.Windows.Forms.Label txtTweetId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
    }
}

