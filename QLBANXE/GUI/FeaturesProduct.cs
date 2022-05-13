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
    public partial class FeaturesProduct : Form
    {
        public FeaturesProduct()
        {
            InitializeComponent();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }

        private void btn_HangXe_Click(object sender, EventArgs e)
        {
            Hangxe hangxe = new Hangxe();
            hangxe.Show();
            this.Hide();
        }

        private void btn_NHACC_Click(object sender, EventArgs e)
        {
            NHACC nHACC = new NHACC();
            nHACC.Show();
            this.Hide();
        }

        private void btn_BANG_GIA_Click(object sender, EventArgs e)
        {
            BangGia bangGia = new BangGia();
            bangGia.Show();
            this.Hide();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
