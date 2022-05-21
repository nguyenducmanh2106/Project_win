using Core.Constants;
using Core.Global;
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

namespace KETOANDOANHTHU
{
    public partial class txtUsername : Form
    {
        public UserBLL _dangNhapBLL = new UserBLL();

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
                if(obj.TRANGTHAI == 1)
                {
                    VariablesGlobal.Instance.UserLoginCurrent = obj;
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Show();
                    this.Hide();
                }
                else
                {
                    new ShowMessageBox().Warning("Tài khoản của bạn đã bị khóa!");
                }
            }
            else
            {
                new ShowMessageBox().Warning("Tên tài khoản hoặc mật khẩu không chính xác!");
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
