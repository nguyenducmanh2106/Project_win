using Core.Constants;
using Dapper.BLL;
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
        public DangNhapBLL _dangNhapBLL = new DangNhapBLL();

        public BookBLL _bookBLL = new BookBLL();
        public txtUsername()
        {
            InitializeComponent();
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void btn_LOGIN_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;
            var obj = _dangNhapBLL.Login(userName, password);
            if (obj != null)
            {
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(MessageConstants.ErrorLoginMessage, TypeDialogConstants.NotificationTitle);
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
