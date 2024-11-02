namespace DangKy_FirebaseDB
{
    partial class QuenMatKhau
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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_getVeriCode = new System.Windows.Forms.Button();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.tb_veriCode = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_verifyCode = new System.Windows.Forms.Label();
            this.lb_signup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Location = new System.Drawing.Point(53, 119);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(178, 22);
            this.tb_email.TabIndex = 0;
            // 
            // bt_getVeriCode
            // 
            this.bt_getVeriCode.Location = new System.Drawing.Point(261, 133);
            this.bt_getVeriCode.Name = "bt_getVeriCode";
            this.bt_getVeriCode.Size = new System.Drawing.Size(87, 42);
            this.bt_getVeriCode.TabIndex = 1;
            this.bt_getVeriCode.Text = "Lấy mã ";
            this.bt_getVeriCode.UseVisualStyleBackColor = true;
            this.bt_getVeriCode.Click += new System.EventHandler(this.bt_getVeriCode_Click);
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(261, 231);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(85, 41);
            this.bt_confirm.TabIndex = 3;
            this.bt_confirm.Text = "Xác nhận";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // tb_veriCode
            // 
            this.tb_veriCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_veriCode.Location = new System.Drawing.Point(53, 204);
            this.tb_veriCode.Name = "tb_veriCode";
            this.tb_veriCode.Size = new System.Drawing.Size(178, 22);
            this.tb_veriCode.TabIndex = 2;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(50, 91);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(130, 16);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "Vui lòng nhập email: ";
            // 
            // lb_verifyCode
            // 
            this.lb_verifyCode.AutoSize = true;
            this.lb_verifyCode.Location = new System.Drawing.Point(50, 174);
            this.lb_verifyCode.Name = "lb_verifyCode";
            this.lb_verifyCode.Size = new System.Drawing.Size(124, 16);
            this.lb_verifyCode.TabIndex = 5;
            this.lb_verifyCode.Text = "Nhập mã xác nhận: ";
            // 
            // lb_signup
            // 
            this.lb_signup.AutoSize = true;
            this.lb_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_signup.Location = new System.Drawing.Point(93, 33);
            this.lb_signup.Name = "lb_signup";
            this.lb_signup.Size = new System.Drawing.Size(187, 29);
            this.lb_signup.TabIndex = 27;
            this.lb_signup.Text = "Quên mật khẩu";
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 304);
            this.Controls.Add(this.lb_signup);
            this.Controls.Add(this.lb_verifyCode);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.tb_veriCode);
            this.Controls.Add(this.bt_getVeriCode);
            this.Controls.Add(this.tb_email);
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button bt_getVeriCode;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.TextBox tb_veriCode;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_verifyCode;
        private System.Windows.Forms.Label lb_signup;
    }
}