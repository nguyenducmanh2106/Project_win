using QLBANXE.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANXE
{
    public partial class BangGia : Form
    {
        public BangGia()
        {
            InitializeComponent();
        }
        BLL_BANGGIA bll = new BLL_BANGGIA();
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            FeaturesProduct featuresProduct = new FeaturesProduct();
            featuresProduct.Show();
            this.Hide();
        }

        private void BangGia_Load(object sender, EventArgs e)
        {
            dgvBangGia.DataSource = bll.getTablePrice();
            cbbMaSP.DataSource = bll.getMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvBangGia.CurrentCell.RowIndex;
            cbbMaSP.Text = dgvBangGia.Rows[index].Cells[0].Value.ToString();
            dtpNgaylamgia.Text= dgvBangGia.Rows[index].Cells[1].Value.ToString();
            txtDonGiaBan.Text= dgvBangGia.Rows[index].Cells[2].Value.ToString();
            txtDonGiaMua.Text= dgvBangGia.Rows[index].Cells[3].Value.ToString();
            //string a = dgvBangGia.Rows[index].Cells[1].Value.ToString();
            //string b = a.Substring(0,a.Length-12)=="2/9/2020"?"true":"false";
            //MessageBox.Show(b);

        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            if (txtDonGiaMua.Text == "" || txtDonGiaBan.Text == "")
            {
                MessageBox.Show("không để trống dữ liệu");
            }
            else
            {
                try
                {
                    string masp = cbbMaSP.Text.ToLower();
                    int giaban = Int32.Parse(txtDonGiaBan.Text);
                    int giamua = Int32.Parse(txtDonGiaMua.Text);
                    bll.addPrice(masp, giaban, giamua);
                    BangGia_Load(sender, e);
                    MessageBox.Show("Thêm thành công");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai định dạng dữ liệu");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Đã tồn tại bản ghi");
                }
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtDonGiaMua.Text == "" || txtDonGiaBan.Text == "")
            {
                MessageBox.Show("không để trống dữ liệu");
            }
            else
            {
                try
                {
                    string masp = cbbMaSP.Text.ToLower();
                    string date = dtpNgaylamgia.Value.ToString("yyyy-MM-dd");
                    int giaban = Int32.Parse(txtDonGiaBan.Text);
                    int giamua = Int32.Parse(txtDonGiaMua.Text);
                    bll.editPrice(masp, date, giaban, giamua);
                    BangGia_Load(sender, e);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai định dạng dữ liệu");
                }
            }
        }

        private void btn_RELOAD_Click(object sender, EventArgs e)
        {
            BangGia_Load(sender, e);
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            string masp = cbbMaSP.Text;
            string date = dtpNgaylamgia.Value.ToString("yyyy-MM-dd");
            Boolean check = false;
           
            for (int i = 0; i < dgvBangGia.RowCount - 1; i++)
            {
                string index = dgvBangGia.Rows[i].Cells[1].Value.ToString();
                if (dgvBangGia.Rows[i].Cells[0].Value.ToString() == masp && index.Substring(0, index.Length-12) == dtpNgaylamgia.Text.ToString())
                {
                    check = true;
                }

            }
            if (check)
            {
                DialogResult rs = MessageBox.Show("Thông báo", "Bạn có muốn xóa dữ liệu này", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bll.deletePrice(masp, date);
                    BangGia_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại dữ liệu để xóa");
            }
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            string maSP = cbbMaSP.Text;
            dgvBangGia.DataSource = bll.searchPriceWithMaSP(maSP);
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
