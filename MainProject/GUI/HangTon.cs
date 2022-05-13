using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QLBANXE.BLL;

namespace QLBANXE
{
    public partial class HangTon : Form
    {
        public HangTon()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }
        BLL_HANGTON bll = new BLL_HANGTON();
        private void HangTon_Load(object sender, EventArgs e)
        {
            dgvHangTon.DataSource = bll.getTableHangTon();
            cbbMaSP.DataSource = bll.getMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHangTon.CurrentCell.RowIndex;
            cbbMaSP.Text = dgvHangTon.Rows[index].Cells[0].Value.ToString();
            txtTongSlNhap.Text = dgvHangTon.Rows[index].Cells[1].Value.ToString();
            txtTongSlXuat.Text = dgvHangTon.Rows[index].Cells[2].Value.ToString();
            txtSlCon.Text = dgvHangTon.Rows[index].Cells[3].Value.ToString(); 
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            string maSP = cbbMaSP.Text;
            dgvHangTon.DataSource = bll.getTableHangTonWithMaSP(maSP);
        }

        private void btn_RELOAD_Click(object sender, EventArgs e)
        {
            dgvHangTon.DataSource = bll.getTableHangTon();
            cbbMaSP.DataSource = bll.getMaSP();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
