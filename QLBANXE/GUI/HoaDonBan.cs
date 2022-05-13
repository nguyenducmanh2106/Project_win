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
    public partial class HoaDonBan : Form
    {
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
            this.Hide();
        }
        //xử lý với lớp BLL
        BLL_HOADONXUAT bll = new BLL_HOADONXUAT();
        //xử lý Hóa đơn xuất
        private void btn_Them_HOA_DON_XUAT_Click(object sender, EventArgs e)
        {
            string sopx = txtSoPx.Text.ToLower();
            string ngayXuat = dtpNgayXuat.Value.ToString("yyyy-MM-dd");
            string maKh = cbbMakh.Text;
            if (sopx == "")
            {
                MessageBox.Show("Không để trống dữ liệu");

            }
            else
            {
                try
                {
                    bll.insertHoaDonXuat(sopx, ngayXuat, maKh);
                    HoaDonBan_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại");
                }
            }
        }

        private void btn_DELETE_HOA_DON_XUAT_Click(object sender, EventArgs e)
        {
            string sopx = txtSoPx.Text.ToLower();
            if (sopx == "")
            {
                MessageBox.Show("Không để trống dữ liệu");
            }
            else
            {
                Boolean check = false;
                for (int i = 0; i < dgvHoaDonBan.Rows.Count - 1; i++)
                {
                    if (dgvHoaDonBan.Rows[i].Cells[0].Value.ToString() == sopx)
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    try
                    {
                        DialogResult rs = MessageBox.Show("thông báo", "Bạn có muốn xóa bản ghi này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            bll.deleteHoaDonXuat(sopx);
                            HoaDonBan_Load(sender, e);
                            MessageBox.Show("Xóa thành công");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại số phiếu");
                }
            }
        }

        private void btn_EDIT_HOA_DON_XUAT_Click(object sender, EventArgs e)
        {
            string sopx = txtSoPx.Text.ToLower();
            string ngayXuat = dtpNgayXuat.Value.ToString("yyyy-MM-dd");
            string maKh = cbbMakh.Text;
            if (sopx == "")
            {
                MessageBox.Show("Không để trống dữ liệu");

            }
            else
            {
                Boolean check = false;
                for (int i = 0; i < dgvHoaDonBan.Rows.Count - 1; i++)
                {
                    if (dgvHoaDonBan.Rows[i].Cells[0].Value.ToString() == sopx)
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    try
                    {
                        bll.updateHoaDonXuat(sopx, ngayXuat, maKh);
                        HoaDonBan_Load(sender, e);
                        MessageBox.Show("Update thành công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Update dữ liệu thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại số phiếu");
                }
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dgvHoaDonBan.DataSource = bll.showHoaDonXuat();
            cbbMakh.DataSource = bll.getMaKhachHang();
            cbbMakh.DisplayMember = "Makh".ToLower();
            cbbMakh.ValueMember = "Makh";
            cbbSearchofHoaDonXuat.DataSource = bll.getSoPx();
            cbbSearchofHoaDonXuat.DisplayMember = "SoPx";
            cbbSearchofHoaDonXuat.ValueMember = "SoPx";

            cbbSearchofHoaDonXuat.SelectedIndex = 0;
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string search = cbbSearchofHoaDonXuat.Text;
                dgvHoaDonBan.DataSource = bll.searchHoaDonXuat(search);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
        //xử lý chi tiế hóa đơn xuất
        //hàm thêm chi tiết hóa đơn xuất
        private void btn_THEM_CTHOA_DON_XUAT_Click(object sender, EventArgs e)
        {
            if (txtSoLuongBan.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
            else
            {
                string soPx = cbbSoPx.Text.ToLower();
                string maSP = cbbMaSP.Text.ToLower();
                Boolean check = false;
                for (int i = 0; i < dgvChiTietHoaDonXuat.RowCount - 1; i++)
                {
                    if (dgvChiTietHoaDonXuat.Rows[i].Cells[0].Value.ToString() == soPx && dgvChiTietHoaDonXuat.Rows[i].Cells[1].Value.ToString() == maSP)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    try
                    {
                        int soluong = Int32.Parse(txtSoLuongBan.Text);
                        int donGiaXuat = Int32.Parse(cbbDonGia.Text);
                        bll.insertChiTietHoaDonXuat(soPx, maSP, soluong, donGiaXuat);
                        dgvChiTietHoaDonXuat.DataSource = bll.showChiTietHoaDonXuat();
                        MessageBox.Show("Thêm thành công");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Số lượng sản phẩm xuất phải nhỏ hơn Số lượng sản phẩm nhập");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("dữ liệu nhập vào chưa đúng định dạng");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã tồn tại");
                }
            }
        }

        private void btnUPDATE_CTHOA_DON_XUAT_Click(object sender, EventArgs e)
        {
            if (txtSoLuongBan.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
            else
            {
                try
                {
                    string soPx = cbbSoPx.Text.ToLower();
                    string maSP = cbbMaSP.Text.ToLower();
                    int soluong = Int32.Parse(txtSoLuongBan.Text);
                    int donGia = Int32.Parse(cbbDonGia.Text);
                    Boolean check = false;
                    for (int i = 0; i < dgvChiTietHoaDonXuat.Rows.Count - 1; i++)
                    {
                        if (dgvChiTietHoaDonXuat.Rows[i].Cells[0].Value.ToString() == soPx && dgvChiTietHoaDonXuat.Rows[i].Cells[1].Value.ToString() == maSP)
                        {
                            check = true;
                            break;
                        }

                    }
                    if (check)
                    {
                        bll.updateChiTietHoaDonXuat(soPx, maSP, soluong, donGia);
                        dgvChiTietHoaDonXuat.DataSource = bll.showChiTietHoaDonXuat();
                        MessageBox.Show("Update thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy số phiếu bán và mã sản phẩm cần update");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Update thất bại: Việc update sẽ làm cho sản phẩm bán lớn hơn sản phẩm nhập");
                }
                catch (FormatException)
                {
                    MessageBox.Show("dữ liệu nhập vào chưa đúng định dạng");
                }
            }
        }

        private void btn_DELETE_CTHOA_DON_XUAT_Click(object sender, EventArgs e)
        {
            string soPx = cbbSoPx.Text.ToLower();
            string maSP = cbbMaSP.Text.ToLower();
            Boolean check = false;
            for (int i = 0; i < dgvChiTietHoaDonXuat.Rows.Count - 1; i++)
            {
                if (dgvChiTietHoaDonXuat.Rows[i].Cells[0].Value.ToString() == soPx && dgvChiTietHoaDonXuat.Rows[i].Cells[1].Value.ToString() == maSP)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                try
                {
                    DialogResult rs = MessageBox.Show("thông báo", "Bạn có muốn xóa bản ghi này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        bll.deleteChiTietHoaDonXuat(soPx, maSP);
                        dgvChiTietHoaDonXuat.DataSource = bll.showChiTietHoaDonXuat();
                        MessageBox.Show("Xóa thành công");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Delete thất bại: Việc delete sẽ làm cho sản phẩm bán lớn hơn sản phẩm nhập");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại số phiếu");
            }
        }

        private void btn_RELOAD_CTHOA_DON_XUAT_Click(object sender, EventArgs e)
        {
            //chi tiết hóa đơn xuất
            dgvChiTietHoaDonXuat.DataSource = bll.showChiTietHoaDonXuat();
            cbbSoPx.DataSource = bll.getSoPx();
            cbbSoPx.DisplayMember = "SoPx";
            cbbSoPx.ValueMember = "SoPx";
            cbbMaSP.DataSource = bll.getMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
            string maSP = cbbMaSP.Text.ToString();
            cbbDonGia.DataSource = bll.getDonGiaXuat(maSP);
            cbbDonGia.DisplayMember = "giaban";
            cbbDonGia.ValueMember = "MaSP";
            cbbValueToSearch.SelectedIndex = 0;
        }

        private void btn_TimKiem(object sender, EventArgs e)
        {
            string soPx = cbbSoPx.Text;
            string maSP = cbbMaSP.Text;
            if (cbbValueToSearch.SelectedIndex == 0)
            {
                dgvChiTietHoaDonXuat.DataSource = bll.searchChiTietHoaDonXuatWithSoPx(soPx);
            }
            if (cbbValueToSearch.SelectedIndex == 1)
            {
                dgvChiTietHoaDonXuat.DataSource = bll.searchChiTietHoaDonXuatWithMaSP(maSP);
            }
            if (cbbValueToSearch.SelectedIndex == 2)
            {
                dgvChiTietHoaDonXuat.DataSource = bll.searchChiTietHoaDonXuatWithSoPnandMaSP(soPx, maSP);
            }
        }
        //hàm form_load 
        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            //Hóa đơn xuất
            dgvHoaDonBan.DataSource = bll.showHoaDonXuat();
            cbbMakh.DataSource = bll.getMaKhachHang();
            cbbMakh.DisplayMember = "Makh".ToLower();
            cbbMakh.ValueMember = "Makh";
            cbbSearchofHoaDonXuat.DataSource = bll.getSoPx();
            cbbSearchofHoaDonXuat.DisplayMember = "SoPx";
            cbbSearchofHoaDonXuat.ValueMember = "SoPx";

            //chi tiết hóa đơn xuất
            dgvChiTietHoaDonXuat.DataSource = bll.showChiTietHoaDonXuat();
            cbbSoPx.DataSource = bll.getSoPx();
            cbbSoPx.DisplayMember = "SoPx";
            cbbSoPx.ValueMember = "SoPx";
            cbbMaSP.DataSource = bll.getMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
            string maSP = cbbMaSP.Text.ToString();
            cbbDonGia.DataSource = bll.getDonGiaXuat(maSP);
            cbbDonGia.DisplayMember = "giaban";
            cbbDonGia.ValueMember = "MaSP";
            cbbValueToSearch.SelectedIndex = 0;
        }

        private void btn_SEARCH_DATE(object sender, EventArgs e)
        {
            try
            {
                string ngayBd = dtpNgayBD.Value.ToString("yyyy-MM-dd");
                string ngayKt = dtpNgayKT.Value.ToString("yyyy-MM-dd");

                dgvHoaDonBan.DataSource = bll.searchHoaDonXuatWithDate(ngayBd, ngayKt);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
        //hàm bắt sự kiện khi thay đổi mã sản phẩm thì combobox đơn giá sẽ lấy bảng giá mới theo mã sản phẩm thay đổi
        private void ChangePriceToProduct(object sender, EventArgs e)
        {
            string maSP = cbbMaSP.Text.ToString();
            cbbDonGia.DataSource = bll.getDonGiaXuat(maSP);
            cbbDonGia.DisplayMember = "giaban";
            cbbDonGia.ValueMember = "MaSP";
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHoaDonBan.CurrentCell.RowIndex;
            txtSoPx.Text = dgvHoaDonBan.Rows[index].Cells[0].Value.ToString();
            dtpNgayXuat.Text = dgvHoaDonBan.Rows[index].Cells[1].Value.ToString();
            cbbMakh.Text = dgvHoaDonBan.Rows[index].Cells[2].Value.ToString();
        }

        private void CellClick_CTHOADONXUAT(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChiTietHoaDonXuat.CurrentCell.RowIndex;
            cbbSoPx.Text = dgvChiTietHoaDonXuat.Rows[i].Cells[0].Value.ToString();
            cbbMaSP.Text = dgvChiTietHoaDonXuat.Rows[i].Cells[1].Value.ToString();
            txtSoLuongBan.Text = dgvChiTietHoaDonXuat.Rows[i].Cells[2].Value.ToString();
            cbbDonGia.Text = dgvChiTietHoaDonXuat.Rows[i].Cells[3].Value.ToString();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
