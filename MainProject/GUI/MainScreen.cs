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
            var a = VariablesGlobal.Instance.UserLoginCurrent;
        }

        private void btn_QLSANPHAM_Click(object sender, EventArgs e)
        {
            FeaturesProduct featuresProduct = new FeaturesProduct();
            featuresProduct.Show();
            this.Hide();
        }

        private void btn_KHACH_HANG_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.Show();
            this.Hide();
        }

        private void btn_HANG_TON_Click(object sender, EventArgs e)
        {
            HangTon hangTon = new HangTon();
            hangTon.Show();
            this.Hide();
        }

        private void btn_THONG_KE_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername login = new txtUsername();
            login.Show();
            this.Hide();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
