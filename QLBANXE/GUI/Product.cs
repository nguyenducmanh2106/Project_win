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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FeaturesProduct featuresProduct = new FeaturesProduct();
            featuresProduct.Show();
            this.Hide();
        }
        BLL_SANPHAM bll = new BLL_SANPHAM();
        private void Product_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.DataSource = bll.showSanPham();
            cbbMaHangXe.DataSource = bll.getMaHangXe();
            cbbMaHangXe.DisplayMember = "Mahangxe".ToLower();
            cbbMaHangXe.ValueMember = "Mahangxe";
            cbbTypeSearch.SelectedIndex = 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string masp = tbMaSP.Text.ToLower();
            string tensp = tbTenSP.Text;
            string mausac = tbMauSac.Text;
            string loaixe = tbLoaiXe.Text;
            string mahangxe = cbbMaHangXe.Text;
            if(String.IsNullOrEmpty(masp) || String.IsNullOrEmpty(tensp) || String.IsNullOrEmpty(mausac) || String.IsNullOrEmpty(loaixe) || String.IsNullOrEmpty(mahangxe))
            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {
                try
                {
                    bll.insertSANPHAM(masp, tensp, mausac, loaixe, mahangxe);
                    MessageBox.Show("Đã thêm thành công");
                    Product_Load(sender, e);
                }catch(Exception ex)
                {
                    MessageBox.Show("Thêm thất bại, Kiểm tra lại masp");
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string masp = tbMaSP.Text.ToLower();
            string tensp = tbTenSP.Text;
            string mausac = tbMauSac.Text;
            string loaixe = tbLoaiXe.Text;
            string mahangxe = cbbMaHangXe.Text;
            Boolean check = false;
            if (String.IsNullOrEmpty(masp) || String.IsNullOrEmpty(tensp) || String.IsNullOrEmpty(mausac) || String.IsNullOrEmpty(loaixe) || String.IsNullOrEmpty(mahangxe))
            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {
                
                    for(int i = 0; i < dgvSanPham.Rows.Count-1; i++)
                    {
                        if (dgvSanPham.Rows[i].Cells[0].Value.ToString().Equals(masp))
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                    try
                    {
                        bll.updateSANPHAM(masp, tensp, mausac, loaixe, mahangxe);
                        MessageBox.Show("Đã sửa thành công");
                        Product_Load(sender, e);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("sửa thất bại, Kiểm tra lại masp");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại mã sản phẩm này");
                    }
                    
                
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string masp = tbMaSP.Text.ToLower();
            Boolean check = false;
            
            if (String.IsNullOrEmpty(masp))
            {
                MessageBox.Show("Không được bỏ trống mã sản phẩm");
            }
            else
            {
                    for (int i = 0; i < dgvSanPham.Rows.Count-1; i++)
                    {
                        if (dgvSanPham.Rows[i].Cells[0].Value.ToString().Equals(masp))
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                    try
                    {
                        bll.deleteSANPHAM(masp);
                        MessageBox.Show("Đã xóa thành công");
                        Product_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại, Kiểm tra lại masp");
                    }
                    }
                    else { MessageBox.Show("Không tồn lại mã sản phẩm này"); }
                    
                
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
             Product_Load(sender, e);
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String keySearch = tbSearch.Text;
            if(cbbTypeSearch.SelectedIndex==0)
            {
               dgvSanPham.DataSource = bll.searchByMaSP(keySearch);
            }else if (cbbTypeSearch.SelectedIndex == 1)
            {
                dgvSanPham.DataSource = bll.searchByTenSP(keySearch);
            } else if (cbbTypeSearch.SelectedIndex == 2)
            {
                dgvSanPham.DataSource = bll.searchByMausac(keySearch);
            }
            else { MessageBox.Show("Kiểu tìm kiếm không có. lựa chọn lại"); }
           
            
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSanPham.CurrentCell.RowIndex;
            tbMaSP.Text = dgvSanPham.Rows[index].Cells[0].Value.ToString();
            tbTenSP.Text = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            tbMauSac.Text = dgvSanPham.Rows[index].Cells[2].Value.ToString();
            tbLoaiXe.Text = dgvSanPham.Rows[index].Cells[3].Value.ToString();
            cbbMaHangXe.Text = dgvSanPham.Rows[index].Cells[4].Value.ToString();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
