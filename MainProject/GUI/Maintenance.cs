using Core.Box;
using Core.Constants;
using Core.Global;
using Dapper.BLL;
using Dapper.Model;
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
    public partial class Maintenance : Form
    {
        private readonly DangNhap userLoginInfor = VariablesGlobal.Instance.UserLoginCurrent;
        private UserBLL _dangNhapBLL = new UserBLL();
        public Maintenance()
        {
            InitializeComponent();
        }


        private void Close(object sender, FormClosingEventArgs e)
        {
            MainScreen frame = new MainScreen();
            frame.Show();
            this.Dispose(true);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
            this.Dispose();
        }
    }
}
