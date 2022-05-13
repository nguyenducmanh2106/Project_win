using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBANXE.BLL;

namespace QLBANXE
{
    public partial class HoaDonNhap : Form
    {
        
        
        public HoaDonNhap()
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
        BLL_HOADONNHAP bll = new BLL_HOADONNHAP();
        //hàm form_load 
        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            //Hóa đơn nhập
            dgvHoaDonNhap.DataSource=bll.showHoaDonNhap();
            cbbMaNcc.DataSource = bll.getMaNCC();
            cbbMaNcc.DisplayMember ="MaNhaCc".ToLower();
            cbbMaNcc.ValueMember = "MaNhaCc";
            cbbSearchofHoaDonNhap.DataSource = bll.getSoPN();
            cbbSearchofHoaDonNhap.DisplayMember = "SoPn";
            cbbSearchofHoaDonNhap.ValueMember = "SoPn";

            //chi tiết hóa đơn nhập
            dgvChiTietHoaDonNhap.DataSource = bll.showChiTietHoaDonNhap();
            cbbSoPn.DataSource = bll.getSoPN();
            cbbSoPn.DisplayMember = "SoPn";
            cbbSoPn.ValueMember = "SoPn";
            cbbMaSP.DataSource = bll.getMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
            string maSP = cbbMaSP.Text.ToString();
            cbbDonGia.DataSource = bll.getDonGiaNhap(maSP);
            cbbDonGia.DisplayMember = "giamua";
            cbbDonGia.ValueMember = "MaSP";
            cbbValueToSearch.SelectedIndex = 0;
        
        }
        //hàm lấy danh sách Hóa đơn nhập
        private void btn_Them_HOA_DON_NHAP_Click(object sender, EventArgs e)
        {
            string sopn = txtSoPn.Text.ToLower();
            string ngayNhap = dtpNgayNhap.Value.ToString("yyyy-MM-dd");
            string maNCC = cbbMaNcc.Text;
            if (sopn == "")
            {
                MessageBox.Show("Không để trống dữ liệu");
               
            }
            else
            {
                try
                {
                    bll.insertHoaDonNhap(sopn, ngayNhap, maNCC);
                    HoaDonNhap_Load(sender, e);
                    MessageBox.Show("Thêm thành công");
                }
                
                catch (SqlException)
                {
                    MessageBox.Show("Bản ghi đã tồn tại");
                }
            }
            
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHoaDonNhap.CurrentCell.RowIndex;
            txtSoPn.Text = dgvHoaDonNhap.Rows[index].Cells[0].Value.ToString();
            dtpNgayNhap.Text = dgvHoaDonNhap.Rows[index].Cells[1].Value.ToString();
            cbbMaNcc.Text = dgvHoaDonNhap.Rows[index].Cells[2].Value.ToString();
            
        }

        private void btn_EDIT_HOA_DON_NHAP_Click(object sender, EventArgs e)
        {
            string sopn = txtSoPn.Text.ToLower();
            string ngayNhap = dtpNgayNhap.Value.ToString("yyyy-MM-dd");
            string maNCC = cbbMaNcc.Text;
            if (sopn == "")
            {
                MessageBox.Show("Không để trống dữ liệu");

            }
            else
            {
                Boolean check = false;
                for (int i = 0; i < dgvHoaDonNhap.Rows.Count - 1; i++)
                {
                    if (dgvHoaDonNhap.Rows[i].Cells[0].Value.ToString() == sopn)
                    {
                        check = true;
                        break;
                    }
                }
             
                if (check)
                {
                    try
                    {
                        bll.updateHoaDonNhap(sopn,ngayNhap,maNCC);
                        HoaDonNhap_Load(sender, e);
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

        private void btn_DELETE_HOA_DON_NHAP_Click(object sender, EventArgs e)
        {

            string sopn = txtSoPn.Text.ToLower();
            if (sopn == "")
            {
                MessageBox.Show("Không để trống dữ liệu");
            }
            else
            {
                Boolean check = false;
                for(int i = 0; i < dgvHoaDonNhap.Rows.Count-1; i++)
                {
                    if (dgvHoaDonNhap.Rows[i].Cells[0].Value.ToString().Equals(sopn))
                    {
                        check = true;   
                    }
                }
                
                if (check)
                {
                    try
                    {
                        DialogResult rs = MessageBox.Show("thông báo", "Bạn có muốn xóa bản ghi này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            bll.deleteHoaDonNhap(sopn);
                            HoaDonNhap_Load(sender, e);
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

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dgvHoaDonNhap.DataSource = bll.showHoaDonNhap();
            cbbMaNcc.DataSource = bll.getMaNCC();
            cbbMaNcc.DisplayMember = "MaNhaCc".ToLower();
            cbbMaNcc.ValueMember = "MaNhaCc";
            cbbSearchofHoaDonNhap.DataSource = bll.getSoPN();
            cbbSearchofHoaDonNhap.DisplayMember = "SoPn";
            cbbSearchofHoaDonNhap.ValueMember = "SoPn";

            cbbValueToSearch.SelectedIndex = 0;

        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string search=cbbSearchofHoaDonNhap.Text;
               dgvHoaDonNhap.DataSource= bll.searchHoaDonNhap(search);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btn_SEARCH_DATE_Click(object sender, EventArgs e)
        {
            
            try
            {
                string ngayBd = dtpNgayBD.Value.ToString("yyyy-MM-dd");
                string ngayKt = dtpNgayKT.Value.ToString("yyyy-MM-dd");
               
                dgvHoaDonNhap.DataSource = bll.searchHoaDonNhapWithDate(ngayBd, ngayKt);
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        //xử lý chi tiế hóa đơn nhập
        //hàm thêm chi tiết hóa đơn nhập
        private void btn_THEM_CTHOA_DON_NHAP_Click(object sender, EventArgs e)
        {
            if (txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
            else
            {
                string soPN = cbbSoPn.Text.ToLower();
                string maSP = cbbMaSP.Text.ToLower();
                Boolean check = false;
                for (int i = 0; i < dgvChiTietHoaDonNhap.RowCount - 1; i++)
                {
                    if (dgvChiTietHoaDonNhap.Rows[i].Cells[0].Value.ToString() == soPN && dgvChiTietHoaDonNhap.Rows[i].Cells[1].Value.ToString() == maSP)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    try
                    {

                        int soluong = Int32.Parse(txtSoLuongNhap.Text);
                        int donGiaNhap = Int32.Parse(cbbDonGia.Text);
                        bll.insertChiTietHoaDonNhap(soPN, maSP, soluong, donGiaNhap);
                        dgvChiTietHoaDonNhap.DataSource = bll.showChiTietHoaDonNhap();
                        MessageBox.Show("Thêm thành công");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Số lượng sản phẩm nhập phải lớn hơn Số lượng sản phẩm bán");
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
        //hàm bắt sự kiện khi thay đổi mã sản phẩm thì combobox đơn giá sẽ lấy bảng giá mới theo mã sản phẩm thay đổi
        private void ChangePriceToProduct(object sender, EventArgs e)
        {
            string maSP = cbbMaSP.Text.ToString();
            cbbDonGia.DataSource = bll.getDonGiaNhap(maSP);
            cbbDonGia.DisplayMember = "giamua";
            cbbDonGia.ValueMember = "MaSP";
        }
        //hàm reload chi tiết hóa đơn nhập
        private void btn_RELOAD_CTHOA_DON_NHAP_Click(object sender, EventArgs e)
        {
            dgvChiTietHoaDonNhap.DataSource = bll.showChiTietHoaDonNhap();
            cbbSoPn.DataSource = bll.getSoPN();
            cbbSoPn.DisplayMember = "SoPn";
            cbbSoPn.ValueMember = "SoPn";
            cbbMaSP.DataSource = bll.getMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
            string maSP = cbbMaSP.Text.ToString();
            cbbDonGia.DataSource = bll.getDonGiaNhap(maSP);
            cbbDonGia.DisplayMember = "giamua";
            cbbDonGia.ValueMember = "MaSP";
        }
        //hàm update chi tiết hóa đơn nhập
        private void btnUPDATE_CTHOA_DONG_NHAP_Click(object sender, EventArgs e)
        {
            if (txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
            else
            {
                try
                {
                    string soPN = cbbSoPn.Text.ToLower();
                    string maSP = cbbMaSP.Text.ToLower();
                    int soluong = Int32.Parse(txtSoLuongNhap.Text);
                    int donGiaNhap = Int32.Parse(cbbDonGia.Text);
                    Boolean check = false;
                    for(int i = 0; i < dgvChiTietHoaDonNhap.Rows.Count - 1; i++)
                    {
                        if (dgvChiTietHoaDonNhap.Rows[i].Cells[0].Value.ToString()==soPN && dgvChiTietHoaDonNhap.Rows[i].Cells[1].Value.ToString()==maSP)
                        {
                            check = true;
                            break;
                        }
                        
                    }
                    if (check)
                    {
                        bll.updateChiTietHoaDonNhap(soPN, maSP, soluong, donGiaNhap);
                        dgvChiTietHoaDonNhap.DataSource = bll.showChiTietHoaDonNhap();
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

        private void btn_DELETE_CTHOA_DON_NHAP_Click(object sender, EventArgs e)
        {
            string soPN = cbbSoPn.Text.ToLower();
            string maSP = cbbMaSP.Text.ToLower();
            Boolean check = false;
            for (int i = 0; i < dgvChiTietHoaDonNhap.Rows.Count - 1; i++)
            {
                if (dgvChiTietHoaDonNhap.Rows[i].Cells[0].Value.ToString() == soPN&& dgvChiTietHoaDonNhap.Rows[i].Cells[1].Value.ToString()==maSP)
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
                        bll.deleteChiTietHoaDonNhap(soPN, maSP);
                        HoaDonNhap_Load(sender, e);
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
        //hàm bắt sự kiện thay đổi thuộc tính tìm kiếm 
        private void ChangeValueToSearch(object sender, EventArgs e)
        {

        }

        private void btn_TIM_KIEM_Click(object sender, EventArgs e)
        {
            string soPN = cbbSoPn.Text;
            string maSP = cbbMaSP.Text;
            if (cbbValueToSearch.SelectedIndex == 0)
            {
                dgvChiTietHoaDonNhap.DataSource = bll.searchChiTietHoaDonNhapWithSoPn(soPN);
            }
            if (cbbValueToSearch.SelectedIndex == 1)
            {
                dgvChiTietHoaDonNhap.DataSource = bll.searchChiTietHoaDonNhapWithMaSP(maSP);
            }
            if (cbbValueToSearch.SelectedIndex == 2)
            {
                dgvChiTietHoaDonNhap.DataSource = bll.searchChiTietHoaDonNhapWithSoPnandMaSP(soPN, maSP);
            }

        }

        private void CellClick_CTHOADONNHAP(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChiTietHoaDonNhap.CurrentCell.RowIndex;
            cbbSoPn.Text = dgvChiTietHoaDonNhap.Rows[i].Cells[0].Value.ToString();
            cbbMaSP.Text= dgvChiTietHoaDonNhap.Rows[i].Cells[1].Value.ToString();
            txtSoLuongNhap.Text= dgvChiTietHoaDonNhap.Rows[i].Cells[2].Value.ToString();
           cbbDonGia.Text= dgvChiTietHoaDonNhap.Rows[i].Cells[3].Value.ToString();

        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
