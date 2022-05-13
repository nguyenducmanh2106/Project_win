using QLBANXE.BLL;
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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }
        BLL_KHACHHANG bll = new BLL_KHACHHANG();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.DataSource = bll.showKHACHHANG();
            cbbGioiTinh.SelectedIndex = 0;
            cbbTypeSearch.SelectedIndex = 0;
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string Makh = tbMaKH.Text.ToLower();
            string Tenkh = tbTenKH.Text;
            string gt = cbbGioiTinh.Text;
            int gender = 0;
            if (gt.Equals("Nam"))
                gender = 0;
            else gender = 1;
            string DiaChi = tbDiaChi.Text;
            string SDT = tbSDT.Text;
            Boolean check = false;
            if (String.IsNullOrEmpty(Makh) || String.IsNullOrEmpty(Tenkh) || String.IsNullOrEmpty(gt) || String.IsNullOrEmpty(DiaChi) || String.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {
                for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
                {
                    if (dgvKhachHang.Rows[i].Cells[0].Value.ToString().Equals(Makh))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    MessageBox.Show("Mã KH đã trùng, nhập lại");
                }
                else
                {
                    try
                    {
                        bll.insertKHACHHANG(Makh, Tenkh,gender, DiaChi, SDT);
                        MessageBox.Show("Đã thêm thành công");
                        KhachHang_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại, Kiểm tra lại các thuộc tính");
                    }
                }

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string Makh = tbMaKH.Text.ToLower();
            string Tenkh = tbTenKH.Text;
            string gt = cbbGioiTinh.Text;
            int gender = 0;
            if (gt.Equals("Nam"))
                gender = 0;
            else gender = 1;
            string DiaChi = tbDiaChi.Text;
            string SDT = tbSDT.Text;
            Boolean check = false;
            if (String.IsNullOrEmpty(Makh) || String.IsNullOrEmpty(Tenkh) || String.IsNullOrEmpty(gt) || String.IsNullOrEmpty(DiaChi) || String.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {
                for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
                {
                    if (dgvKhachHang.Rows[i].Cells[0].Value.ToString().Equals(Makh))
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Mã KH không tồn tại, nhập lại");
                }
                else
                {
                    try
                    {
                        bll.updateKHACHHANG(Makh, Tenkh, gender, DiaChi, SDT);
                        MessageBox.Show("Đã sửa thành công");
                        KhachHang_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại, Kiểm tra lại các thuộc tính");
                    }
                }

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string MaKH = tbMaKH.Text.ToLower();
            Boolean check = false;

            if (String.IsNullOrEmpty(MaKH))
            {
                MessageBox.Show("Không được bỏ trống Mã KH");
            }
            else
            {
                for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
                {
                    if (dgvKhachHang.Rows[i].Cells[0].Value.ToString().Equals(MaKH))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    try
                    {
                        bll.deleteKHACHHANG(MaKH);
                        MessageBox.Show("Đã xóa thành công");
                        KhachHang_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại, Kiểm tra lại Mã KH");
                    }
                }
                else { MessageBox.Show("Không tồn lại Mã KH này"); }


            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            KhachHang_Load(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String keySearch = tbSearch.Text;
            if (cbbTypeSearch.SelectedIndex == 0)
            {
                dgvKhachHang.DataSource = bll.searchbyMaKHACHHANG(keySearch);
            }
            else if (cbbTypeSearch.SelectedIndex == 1)
            {
                dgvKhachHang.DataSource = bll.searchbyTenKHACHHANG(keySearch);
            }
            else if (cbbTypeSearch.SelectedIndex == 2)
            {
                dgvKhachHang.DataSource = bll.searchbyDiaChiKH(keySearch);
            }
            else { MessageBox.Show("Kiểu tìm kiếm không có. lựa chọn lại"); }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvKhachHang.CurrentCell.RowIndex;
            tbMaKH.Text = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
            tbTenKH.Text = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
            if (dgvKhachHang.Rows[index].Cells[2].Value.ToString().Equals("True"))
            {
                cbbGioiTinh.SelectedIndex = 1;
            }
            else cbbGioiTinh.SelectedIndex = 0;
            tbDiaChi.Text = dgvKhachHang.Rows[index].Cells[3].Value.ToString();
            tbSDT.Text = dgvKhachHang.Rows[index].Cells[4].Value.ToString();
        }

        private void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Nữ" : "Nam";
                    e.FormattingApplied = true;
                }
            }
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
