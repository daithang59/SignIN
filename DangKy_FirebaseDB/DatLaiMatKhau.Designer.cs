﻿namespace DangKy_FirebaseDB
{
    partial class DatLaiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatLaiMatKhau));
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_changepw = new System.Windows.Forms.Button();
            this.lb_confirmpw = new System.Windows.Forms.Label();
            this.tb_confirmpw = new System.Windows.Forms.TextBox();
            this.bt_showpw = new System.Windows.Forms.Button();
            this.bt_hidepw = new System.Windows.Forms.Button();
            this.bt_showConfirmpw = new System.Windows.Forms.Button();
            this.bt_hideConfirmpw = new System.Windows.Forms.Button();
            this.lb_resetpw = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Location = new System.Drawing.Point(29, 101);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(219, 22);
            this.tb_password.TabIndex = 0;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_password.ForeColor = System.Drawing.Color.Maroon;
            this.lb_password.Location = new System.Drawing.Point(26, 78);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(153, 20);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Nhập mật khẩu mới: ";
            // 
            // bt_changepw
            // 
            this.bt_changepw.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bt_changepw.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_changepw.ForeColor = System.Drawing.Color.AliceBlue;
            this.bt_changepw.Location = new System.Drawing.Point(167, 211);
            this.bt_changepw.Name = "bt_changepw";
            this.bt_changepw.Size = new System.Drawing.Size(112, 42);
            this.bt_changepw.TabIndex = 4;
            this.bt_changepw.Text = "Đổi mật khẩu";
            this.bt_changepw.UseVisualStyleBackColor = false;
            this.bt_changepw.Click += new System.EventHandler(this.bt_changepw_Click);
            // 
            // lb_confirmpw
            // 
            this.lb_confirmpw.AutoSize = true;
            this.lb_confirmpw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_confirmpw.ForeColor = System.Drawing.Color.Maroon;
            this.lb_confirmpw.Location = new System.Drawing.Point(26, 145);
            this.lb_confirmpw.Name = "lb_confirmpw";
            this.lb_confirmpw.Size = new System.Drawing.Size(148, 20);
            this.lb_confirmpw.TabIndex = 6;
            this.lb_confirmpw.Text = "Xác nhận mật khẩu: ";
            // 
            // tb_confirmpw
            // 
            this.tb_confirmpw.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_confirmpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_confirmpw.Location = new System.Drawing.Point(29, 168);
            this.tb_confirmpw.Name = "tb_confirmpw";
            this.tb_confirmpw.PasswordChar = '*';
            this.tb_confirmpw.Size = new System.Drawing.Size(219, 22);
            this.tb_confirmpw.TabIndex = 5;
            // 
            // bt_showpw
            // 
            this.bt_showpw.BackColor = System.Drawing.Color.Transparent;
            this.bt_showpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_showpw.Image = ((System.Drawing.Image)(resources.GetObject("bt_showpw.Image")));
            this.bt_showpw.Location = new System.Drawing.Point(222, 101);
            this.bt_showpw.Name = "bt_showpw";
            this.bt_showpw.Size = new System.Drawing.Size(26, 22);
            this.bt_showpw.TabIndex = 8;
            this.bt_showpw.UseVisualStyleBackColor = false;
            this.bt_showpw.Click += new System.EventHandler(this.bt_showpw_Click);
            // 
            // bt_hidepw
            // 
            this.bt_hidepw.BackColor = System.Drawing.Color.Transparent;
            this.bt_hidepw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hidepw.Image = ((System.Drawing.Image)(resources.GetObject("bt_hidepw.Image")));
            this.bt_hidepw.Location = new System.Drawing.Point(222, 101);
            this.bt_hidepw.Name = "bt_hidepw";
            this.bt_hidepw.Size = new System.Drawing.Size(26, 22);
            this.bt_hidepw.TabIndex = 21;
            this.bt_hidepw.UseVisualStyleBackColor = false;
            this.bt_hidepw.Click += new System.EventHandler(this.bt_hidepw_Click);
            // 
            // bt_showConfirmpw
            // 
            this.bt_showConfirmpw.BackColor = System.Drawing.Color.Transparent;
            this.bt_showConfirmpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_showConfirmpw.Image = ((System.Drawing.Image)(resources.GetObject("bt_showConfirmpw.Image")));
            this.bt_showConfirmpw.Location = new System.Drawing.Point(222, 168);
            this.bt_showConfirmpw.Name = "bt_showConfirmpw";
            this.bt_showConfirmpw.Size = new System.Drawing.Size(26, 22);
            this.bt_showConfirmpw.TabIndex = 22;
            this.bt_showConfirmpw.UseVisualStyleBackColor = false;
            this.bt_showConfirmpw.Click += new System.EventHandler(this.bt_showConfirmpw_Click);
            // 
            // bt_hideConfirmpw
            // 
            this.bt_hideConfirmpw.BackColor = System.Drawing.Color.Transparent;
            this.bt_hideConfirmpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hideConfirmpw.Image = ((System.Drawing.Image)(resources.GetObject("bt_hideConfirmpw.Image")));
            this.bt_hideConfirmpw.Location = new System.Drawing.Point(222, 168);
            this.bt_hideConfirmpw.Name = "bt_hideConfirmpw";
            this.bt_hideConfirmpw.Size = new System.Drawing.Size(26, 22);
            this.bt_hideConfirmpw.TabIndex = 23;
            this.bt_hideConfirmpw.UseVisualStyleBackColor = false;
            this.bt_hideConfirmpw.Click += new System.EventHandler(this.bt_hideConfirmpw_Click);
            // 
            // lb_resetpw
            // 
            this.lb_resetpw.AutoSize = true;
            this.lb_resetpw.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_resetpw.ForeColor = System.Drawing.Color.Maroon;
            this.lb_resetpw.Location = new System.Drawing.Point(12, 21);
            this.lb_resetpw.Name = "lb_resetpw";
            this.lb_resetpw.Size = new System.Drawing.Size(267, 35);
            this.lb_resetpw.TabIndex = 28;
            this.lb_resetpw.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 37);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // DatLaiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_resetpw);
            this.Controls.Add(this.bt_showConfirmpw);
            this.Controls.Add(this.bt_hideConfirmpw);
            this.Controls.Add(this.bt_showpw);
            this.Controls.Add(this.bt_hidepw);
            this.Controls.Add(this.lb_confirmpw);
            this.Controls.Add(this.tb_confirmpw);
            this.Controls.Add(this.bt_changepw);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_password);
            this.Name = "DatLaiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatLaiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button bt_changepw;
        private System.Windows.Forms.Label lb_confirmpw;
        private System.Windows.Forms.TextBox tb_confirmpw;
        private System.Windows.Forms.Button bt_showpw;
        private System.Windows.Forms.Button bt_hidepw;
        private System.Windows.Forms.Button bt_showConfirmpw;
        private System.Windows.Forms.Button bt_hideConfirmpw;
        private System.Windows.Forms.Label lb_resetpw;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}