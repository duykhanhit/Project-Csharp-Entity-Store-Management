using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Entity_Store_Management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        StoreEntities db = new StoreEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User account = db.Users.Where(u => u.username == username).SingleOrDefault();

            if (account == null)
            {
                MessageBox.Show("Không tồn tại tài khoản!", "Thông báo!");
                return;
            }

            if (!account.password.Equals(password))
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo!");
                return;
            }

            MessageBox.Show("Đăng nhập thành công!");

            //User account = new User();
            //account.username = "demo";
            //account.password = "123";
            //account.role = "staff";
            //account.position = "staff";
            //account.phone = "123123";
            //account.address = "TQ";
            //account.fullname = "Nguyen Van A";

            //db.Users.Add(account);
            //db.SaveChanges();
            //MessageBox.Show("Đăng nhập thành công!");
        }
    }
}
