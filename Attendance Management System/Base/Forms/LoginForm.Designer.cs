namespace Attendance_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lgBtn = new System.Windows.Forms.Button();
            this.lbForget = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.saparateLine = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(705, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login to your account";
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleDescription = "";
            this.txtUsername.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(24)))), ((int)(((byte)(222)))));
            this.txtUsername.Location = new System.Drawing.Point(679, 196);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(319, 37);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Tag = "";
            this.txtUsername.TextChanged += new System.EventHandler(this.usernameChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(24)))), ((int)(((byte)(222)))));
            this.txtPassword.Location = new System.Drawing.Point(679, 287);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(319, 34);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Tag = "";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lgBtn
            // 
            this.lgBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.lgBtn.FlatAppearance.BorderSize = 0;
            this.lgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgBtn.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lgBtn.Location = new System.Drawing.Point(624, 397);
            this.lgBtn.Name = "lgBtn";
            this.lgBtn.Size = new System.Drawing.Size(225, 44);
            this.lgBtn.TabIndex = 0;
            this.lgBtn.Text = "Login";
            this.lgBtn.UseVisualStyleBackColor = false;
            this.lgBtn.Click += new System.EventHandler(this.lgBtn_Click);
            this.lgBtn.MouseLeave += new System.EventHandler(this.btnLeave);
            this.lgBtn.MouseHover += new System.EventHandler(this.btnHover);
            // 
            // lbForget
            // 
            this.lbForget.AutoSize = true;
            this.lbForget.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForget.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbForget.Location = new System.Drawing.Point(873, 406);
            this.lbForget.Name = "lbForget";
            this.lbForget.Size = new System.Drawing.Size(176, 23);
            this.lbForget.TabIndex = 12;
            this.lbForget.Text = "Forgot Password?";
            this.lbForget.MouseLeave += new System.EventHandler(this.forgetLeave);
            this.lbForget.MouseHover += new System.EventHandler(this.forgetHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(675, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Invalid Username and Password";
            this.label5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(47, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(385, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(619, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(624, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Attendance_Management_System.Properties.Resources._6343825;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbUsername.Location = new System.Drawing.Point(679, 162);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(89, 18);
            this.lbUsername.TabIndex = 16;
            this.lbUsername.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(679, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password :";
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.ForeColor = System.Drawing.Color.White;
            this.btnHidePassword.Image = global::Attendance_Management_System.Properties.Resources.hiding;
            this.btnHidePassword.Location = new System.Drawing.Point(1001, 276);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(48, 45);
            this.btnHidePassword.TabIndex = 0;
            this.btnHidePassword.UseVisualStyleBackColor = false;
            this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
            // 
            // saparateLine
            // 
            this.saparateLine.BackColor = System.Drawing.Color.SlateBlue;
            this.saparateLine.Location = new System.Drawing.Point(552, 124);
            this.saparateLine.Name = "saparateLine";
            this.saparateLine.Size = new System.Drawing.Size(5, 400);
            this.saparateLine.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 636);
            this.Controls.Add(this.saparateLine);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbForget);
            this.Controls.Add(this.lgBtn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button lgBtn;
        private System.Windows.Forms.Label lbForget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Panel saparateLine;
    }
}

