using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTraCongCu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text; // Lấy tên người dùng từ textbox
            string password = txtpassword.Text; // Lấy mật khẩu từ textbox

            // Kiểm tra nếu username và password đúng
            if (username == "admin" && password == "admin")
            {
                // Nếu đúng, hiển thị thông báo đăng nhập thành công và chuyển qua trang mới
                MessageBox.Show("Đăng nhập thành công!");
                Form2 form2 = new Form2();
                // Hiển thị Form2
                form2.Show();
                this.Hide();
            }
            else
            {
                // Nếu sai, hiển thị thông báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
