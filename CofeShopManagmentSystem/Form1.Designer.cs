namespace CofeShopManagmentSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Login_registerBtn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Login_showPass = new System.Windows.Forms.CheckBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Login_registerBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 522);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(54, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "Coffeshop Managment";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CofeShopManagmentSystem.Properties.Resources.coffe_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(106, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(89, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create an account";
            // 
            // Login_registerBtn
            // 
            this.Login_registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Login_registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_registerBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_registerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_registerBtn.Location = new System.Drawing.Point(12, 461);
            this.Login_registerBtn.Name = "Login_registerBtn";
            this.Login_registerBtn.Size = new System.Drawing.Size(319, 49);
            this.Login_registerBtn.TabIndex = 9;
            this.Login_registerBtn.Text = "REGISTER";
            this.Login_registerBtn.UseVisualStyleBackColor = false;
            this.Login_registerBtn.Click += new System.EventHandler(this.Login_registerBtn_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(767, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(21, 22);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "SIGN IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(372, 178);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(342, 26);
            this.login_username.TabIndex = 4;
            this.login_username.TextChanged += new System.EventHandler(this.Login_username_TextChanged);
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(372, 249);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(342, 26);
            this.login_password.TabIndex = 6;
            this.login_password.TextChanged += new System.EventHandler(this.Login_password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // Login_showPass
            // 
            this.Login_showPass.AutoSize = true;
            this.Login_showPass.Location = new System.Drawing.Point(372, 282);
            this.Login_showPass.Name = "Login_showPass";
            this.Login_showPass.Size = new System.Drawing.Size(148, 24);
            this.Login_showPass.TabIndex = 7;
            this.Login_showPass.Text = "Show Password";
            this.Login_showPass.UseVisualStyleBackColor = true;
            this.Login_showPass.CheckedChanged += new System.EventHandler(this.Login_showPass_CheckedChanged);
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Btn.Location = new System.Drawing.Point(372, 332);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(148, 49);
            this.Login_Btn.TabIndex = 8;
            this.Login_Btn.Text = "LOG IN";
            this.Login_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.UseWaitCursor = true;
            this.Login_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Login_showPass);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Login_showPass;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Login_registerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

