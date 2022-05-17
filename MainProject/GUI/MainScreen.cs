using Core.Global;
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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            var fullName = VariablesGlobal.Instance.UserLoginCurrent?.TENTK;

            this.UserName.Text = fullName;
        }
        private void btn_HOA_DON_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
            this.Hide();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void listUserMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucTaiKhoan danhMucTaiKhoan = new DanhMucTaiKhoan();
            danhMucTaiKhoan.Show();
            this.Dispose(true);
        }

        private void UserLoginInfor_Click(object sender, EventArgs e)
        {
            UserLoginInfor userInfor = new UserLoginInfor();
            userInfor.Show();
            this.Dispose(true);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            txtUsername login = new txtUsername();
            login.Show();
            this.Dispose();
        }

        private void NhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NhaCungCapList().Show();
            this.Dispose(true);
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KhachHangList().Show();
            this.Dispose(true);
        }

        private void HangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HangHoaList().Show();
            this.Dispose(true);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            //// no larger than screen size
            //this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (int)System.Windows.SystemParameters.PrimaryScreenHeight);

            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void HoaDonGTGTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HoaDonGTGTList().Show();
            this.Dispose(true);
        }
    }
}
