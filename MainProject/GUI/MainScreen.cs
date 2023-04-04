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

namespace KETOANDOANHTHU
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            var fullName = VariablesGlobal.Instance.UserLoginCurrent?.TENTK;

            this.UserName.Text = fullName;
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void listUserMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucTaiKhoanKeToan danhMucTaiKhoan = new DanhMucTaiKhoanKeToan();
            danhMucTaiKhoan.Show();
            this.Dispose(true);
        }

        /// <summary>
        /// Tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserLoginInfor_Click(object sender, EventArgs e)
        {
            UserLoginInfor userInfor = new UserLoginInfor();
            userInfor.Show();
            this.Dispose(true);
        }

        /// <summary>
        /// Đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Quản lý đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucTaiKhoan danhMucTaiKhoan = new DanhMucTaiKhoan();
            danhMucTaiKhoan.Show();
            this.Dispose(true);
        }

        private void BaoCaoDoanhThuTheoKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuTheoKhachHang frame = new BaoCaoDoanhThuTheoKhachHang();
            frame.Show();
            this.Dispose(true);
        }

        private void BaoCaoDoanhThuTheoHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuTheoHangHoa frame = new BaoCaoDoanhThuTheoHangHoa();
            frame.Show();
            this.Dispose(true);
        }

        private void BaoCaoGiamTruDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoGiamTruDoanhThu frame = new BaoCaoGiamTruDoanhThu();
            frame.Show();
            this.Dispose(true);
        }

        private void BaoCaoTongHopDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTongHopDoanhThu frame = new BaoCaoTongHopDoanhThu();
            frame.Show();
            this.Dispose(true);
        }

        private void SoCaiTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoCaiTaiKhoan frame = new SoCaiTaiKhoan();
            frame.Show();
            this.Dispose(true);
        }

        private void SoChiTietTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoChiTietTaiKhoan frame = new SoChiTietTaiKhoan();
            frame.Show();
            this.Dispose(true);
        }

        private void PhieuGiamGiaDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuGiamGiaList frame = new PhieuGiamGiaList();
            frame.Show();
            this.Dispose(true);
        }

        private void BackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance frame = new Maintenance();
            frame.Show();
            this.Dispose(true);
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance frame = new Maintenance();
            frame.Show();
            this.Dispose(true);
        }

        private void SoftwareInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance frame = new Maintenance();
            frame.Show();
            this.Dispose(true);
        }

        private void ContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance frame = new Maintenance();
            frame.Show();
            this.Dispose(true);
        }
    }
}
