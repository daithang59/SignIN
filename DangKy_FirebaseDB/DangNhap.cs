using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace DangKy_FirebaseDB
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig
        {
            AuthSecret = "ptadAFZjKIegVxEFzWhRrhn5VUj0qbWM0upbVKEa",
            BasePath = "https://bombmaster-14f3a-default-rtdb.asia-southeast1.firebasedatabase.app"
        };
        IFirebaseClient Client;
        private void bt_login_Click(object sender, EventArgs e)
        {
            string tentk = tb_username.Text;
            string matkhau = tb_password.Text;
            if (tentk == "" || matkhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            try
            {
                Client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server");
                return;
            }
            // Truy vấn trực tiếp đến tài khoản cụ thể
            FirebaseResponse res = Client.Get("Users/" + tentk);
            Register acc = res.ResultAs<Register>();

            if (res.Body == "null" || acc == null)
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else
            {
                if (acc.Password == matkhau)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    // Chuyển sang form khác
                    BombMaster.Dashboard db = new BombMaster.Dashboard();
                    db.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
            }

        }

        private void llb_registry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }

        private void llb_forgetedpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.Show();
            this.Hide();
        }

        private void bt_hide_Click(object sender, EventArgs e)
        {
            if(tb_password.PasswordChar == '\0')
            {
                tb_password.PasswordChar = '*';
                bt_show.BringToFront();
            }
            
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            if (tb_password.PasswordChar == '*')
            {
                tb_password.PasswordChar = '\0';
                bt_hide.BringToFront();
            }
        }
    }
}
