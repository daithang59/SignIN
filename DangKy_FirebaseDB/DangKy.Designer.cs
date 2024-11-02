﻿namespace DangKy_FirebaseDB
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_confirmpassword = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_confirmpassword = new System.Windows.Forms.Label();
            this.lb_gmail = new System.Windows.Forms.Label();
            this.bt_registry = new System.Windows.Forms.Button();
            this.bt_showpw = new System.Windows.Forms.Button();
            this.bt_hideConfirmpw = new System.Windows.Forms.Button();
            this.bt_showConfirmpw = new System.Windows.Forms.Button();
            this.bt_hidepw = new System.Windows.Forms.Button();
            this.lb_signup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Location = new System.Drawing.Point(73, 103);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(199, 22);
            this.tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Location = new System.Drawing.Point(73, 166);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(199, 22);
            this.tb_password.TabIndex = 1;
            // 
            // tb_confirmpassword
            // 
            this.tb_confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_confirmpassword.Location = new System.Drawing.Point(73, 242);
            this.tb_confirmpassword.Name = "tb_confirmpassword";
            this.tb_confirmpassword.PasswordChar = '*';
            this.tb_confirmpassword.Size = new System.Drawing.Size(199, 22);
            this.tb_confirmpassword.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Location = new System.Drawing.Point(73, 305);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(199, 22);
            this.tb_email.TabIndex = 3;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(70, 73);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(70, 16);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(70, 147);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(67, 16);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "Password";
            // 
            // lb_confirmpassword
            // 
            this.lb_confirmpassword.AutoSize = true;
            this.lb_confirmpassword.Location = new System.Drawing.Point(70, 212);
            this.lb_confirmpassword.Name = "lb_confirmpassword";
            this.lb_confirmpassword.Size = new System.Drawing.Size(114, 16);
            this.lb_confirmpassword.TabIndex = 6;
            this.lb_confirmpassword.Text = "Confirm password";
            // 
            // lb_gmail
            // 
            this.lb_gmail.AutoSize = true;
            this.lb_gmail.Location = new System.Drawing.Point(70, 286);
            this.lb_gmail.Name = "lb_gmail";
            this.lb_gmail.Size = new System.Drawing.Size(41, 16);
            this.lb_gmail.TabIndex = 7;
            this.lb_gmail.Text = "Email";
            // 
            // bt_registry
            // 
            this.bt_registry.Location = new System.Drawing.Point(156, 356);
            this.bt_registry.Name = "bt_registry";
            this.bt_registry.Size = new System.Drawing.Size(116, 39);
            this.bt_registry.TabIndex = 8;
            this.bt_registry.Text = "Registry";
            this.bt_registry.UseVisualStyleBackColor = true;
            this.bt_registry.Click += new System.EventHandler(this.bt_registry_Click);
            // 
            // bt_showpw
            // 
            this.bt_showpw.BackColor = System.Drawing.Color.Transparent;
            this.bt_showpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_showpw.Image = ((System.Drawing.Image)(resources.GetObject("bt_showpw.Image")));
            this.bt_showpw.Location = new System.Drawing.Point(246, 166);
            this.bt_showpw.Name = "bt_showpw";
            this.bt_showpw.Size = new System.Drawing.Size(26, 22);
            this.bt_showpw.TabIndex = 25;
            this.bt_showpw.UseVisualStyleBackColor = false;
            this.bt_showpw.Click += new System.EventHandler(this.bt_showpw_Click);
            // 
            // bt_hideConfirmpw
            // 
            this.bt_hideConfirmpw.BackColor = System.Drawing.Color.Transparent;
            this.bt_hideConfirmpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hideConfirmpw.Image = ((System.Drawing.Image)(resources.GetObject("bt_hideConfirmpw.Image")));
            this.bt_hideConfirmpw.Location = new System.Drawing.Point(246, 242);
            this.bt_hideConfirmpw.Name = "bt_hideConfirmpw";
            this.bt_hideConfirmpw.Size = new System.Drawing.Size(26, 22);
            this.bt_hideConfirmpw.TabIndex = 21;
            this.bt_hideConfirmpw.UseVisualStyleBackColor = false;
            this.bt_hideConfirmpw.Click += new System.EventHandler(this.bt_hideConfirmpw_Click);
            // 
            // bt_showConfirmpw
            // 
            this.bt_showConfirmpw.BackColor = System.Drawing.Color.Transparent;
            this.bt_showConfirmpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_showConfirmpw.Image = ((System.Drawing.Image)(resources.GetObject("bt_showConfirmpw.Image")));
            this.bt_showConfirmpw.Location = new System.Drawing.Point(246, 242);
            this.bt_showConfirmpw.Name = "bt_showConfirmpw";
            this.bt_showConfirmpw.Size = new System.Drawing.Size(26, 22);
            this.bt_showConfirmpw.TabIndex = 25;
            this.bt_showConfirmpw.UseVisualStyleBackColor = false;
            this.bt_showConfirmpw.Click += new System.EventHandler(this.bt_showConfirmpw_Click);
            // 
            // bt_hidepw
            // 
            this.bt_hidepw.BackColor = System.Drawing.Color.Transparent;
            this.bt_hidepw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hidepw.Image = ((System.Drawing.Image)(resources.GetObject("bt_hidepw.Image")));
            this.bt_hidepw.Location = new System.Drawing.Point(246, 166);
            this.bt_hidepw.Name = "bt_hidepw";
            this.bt_hidepw.Size = new System.Drawing.Size(26, 22);
            this.bt_hidepw.TabIndex = 12;
            this.bt_hidepw.UseVisualStyleBackColor = false;
            this.bt_hidepw.Click += new System.EventHandler(this.bt_hidepw_Click);
            // 
            // lb_signup
            // 
            this.lb_signup.AutoSize = true;
            this.lb_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_signup.Location = new System.Drawing.Point(55, 22);
            this.lb_signup.Name = "lb_signup";
            this.lb_signup.Size = new System.Drawing.Size(236, 29);
            this.lb_signup.TabIndex = 26;
            this.lb_signup.Text = "Đăng Ký Tài Khoản";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 407);
            this.Controls.Add(this.lb_signup);
            this.Controls.Add(this.bt_showpw);
            this.Controls.Add(this.bt_hidepw);
            this.Controls.Add(this.bt_showConfirmpw);
            this.Controls.Add(this.bt_hideConfirmpw);
            this.Controls.Add(this.bt_registry);
            this.Controls.Add(this.lb_gmail);
            this.Controls.Add(this.lb_confirmpassword);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_confirmpassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_confirmpassword;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_confirmpassword;
        private System.Windows.Forms.Label lb_gmail;
        private System.Windows.Forms.Button bt_registry;
        private System.Windows.Forms.Button bt_showpw;
        private System.Windows.Forms.Button bt_hideConfirmpw;
        private System.Windows.Forms.Button bt_showConfirmpw;
        private System.Windows.Forms.Button bt_hidepw;
        private System.Windows.Forms.Label lb_signup;
    }
}
