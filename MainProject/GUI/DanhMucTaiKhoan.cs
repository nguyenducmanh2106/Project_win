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
    public partial class DanhMucTaiKhoan : Form
    {
        public DanhMucTaiKhoan()
        {
            InitializeComponent();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Dispose(true);
        }
    }
}
