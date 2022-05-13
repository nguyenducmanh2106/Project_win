using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANXE
{
    public partial class txtUsername : Form
    {
        public txtUsername()
        {
            InitializeComponent();
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void btn_LOGIN_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "nhom4" && txtPassword.Text == "123")
            {
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("mật khẩu hoặc tài khoản không chính xác", "thông báo");
            }

        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Load(object sender, EventArgs e)
        {

        }
    }
}
