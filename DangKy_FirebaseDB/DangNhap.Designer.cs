namespace DangKy_FirebaseDB
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.llb_registry = new System.Windows.Forms.LinkLabel();
            this.lb_password = new System.Windows.Forms.Label();
            this.llb_forgotpw = new System.Windows.Forms.LinkLabel();
            this.bt_hide = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            this.lb_signin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Location = new System.Drawing.Point(57, 292);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(180, 22);
            this.tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Location = new System.Drawing.Point(57, 358);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(180, 22);
            this.tb_password.TabIndex = 1;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_login.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_login.ForeColor = System.Drawing.Color.Brown;
            this.bt_login.Location = new System.Drawing.Point(265, 309);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(134, 46);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "ĐĂNG NHẬP";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_username.ForeColor = System.Drawing.Color.Lime;
            this.lb_username.Location = new System.Drawing.Point(53, 269);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(91, 23);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "Username:";
            // 
            // llb_registry
            // 
            this.llb_registry.AutoSize = true;
            this.llb_registry.BackColor = System.Drawing.Color.Transparent;
            this.llb_registry.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llb_registry.LinkColor = System.Drawing.Color.Lime;
            this.llb_registry.Location = new System.Drawing.Point(112, 392);
            this.llb_registry.Name = "llb_registry";
            this.llb_registry.Size = new System.Drawing.Size(115, 23);
            this.llb_registry.TabIndex = 4;
            this.llb_registry.TabStop = true;
            this.llb_registry.Text = "Tạo tài khoản";
            this.llb_registry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_registry_LinkClicked);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_password.ForeColor = System.Drawing.Color.Lime;
            this.lb_password.Location = new System.Drawing.Point(53, 332);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(86, 23);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "Password:";
            // 
            // llb_forgotpw
            // 
            this.llb_forgotpw.AutoSize = true;
            this.llb_forgotpw.BackColor = System.Drawing.Color.Transparent;
            this.llb_forgotpw.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llb_forgotpw.LinkColor = System.Drawing.Color.Lime;
            this.llb_forgotpw.Location = new System.Drawing.Point(261, 357);
            this.llb_forgotpw.Name = "llb_forgotpw";
            this.llb_forgotpw.Size = new System.Drawing.Size(138, 23);
            this.llb_forgotpw.TabIndex = 6;
            this.llb_forgotpw.TabStop = true;
            this.llb_forgotpw.Text = "Quên mật khẩu?";
            this.llb_forgotpw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_forgetedpw_LinkClicked);
            // 
            // bt_hide
            // 
            this.bt_hide.BackColor = System.Drawing.Color.Silver;
            this.bt_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hide.Image = ((System.Drawing.Image)(resources.GetObject("bt_hide.Image")));
            this.bt_hide.Location = new System.Drawing.Point(211, 358);
            this.bt_hide.Name = "bt_hide";
            this.bt_hide.Size = new System.Drawing.Size(26, 22);
            this.bt_hide.TabIndex = 20;
            this.bt_hide.UseVisualStyleBackColor = false;
            this.bt_hide.Click += new System.EventHandler(this.bt_hide_Click);
            // 
            // bt_show
            // 
            this.bt_show.BackColor = System.Drawing.Color.Silver;
            this.bt_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_show.Image = ((System.Drawing.Image)(resources.GetObject("bt_show.Image")));
            this.bt_show.Location = new System.Drawing.Point(211, 358);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(26, 22);
            this.bt_show.TabIndex = 5;
            this.bt_show.UseVisualStyleBackColor = false;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // lb_signin
            // 
            this.lb_signin.AutoSize = true;
            this.lb_signin.BackColor = System.Drawing.Color.Transparent;
            this.lb_signin.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_signin.ForeColor = System.Drawing.Color.Lime;
            this.lb_signin.Location = new System.Drawing.Point(108, 212);
            this.lb_signin.Name = "lb_signin";
            this.lb_signin.Size = new System.Drawing.Size(237, 46);
            this.lb_signin.TabIndex = 27;
            this.lb_signin.Text = "ĐĂNG NHẬP";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 512);
            this.Controls.Add(this.lb_signin);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.bt_hide);
            this.Controls.Add(this.llb_forgotpw);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.llb_registry);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.LinkLabel llb_registry;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.LinkLabel llb_forgotpw;
        private System.Windows.Forms.Button bt_hide;
        private System.Windows.Forms.Button bt_show;
        private System.Windows.Forms.Label lb_signin;
    }
}