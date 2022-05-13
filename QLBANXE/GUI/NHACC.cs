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
    public partial class NHACC : Form
    {
        public NHACC()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            FeaturesProduct featuresProduct = new FeaturesProduct();
            featuresProduct.Show();
            this.Hide();
        }
        BLL_NHACC bll = new BLL_NHACC();
        private void NHACC_Load(object sender, EventArgs e)
        {
            dgvNhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCC.DataSource = bll.showNHACC();
            cbbTypeSearch.SelectedIndex = 0;
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            string MaNCC = tbMaNCC.Text.ToLower();
            string TenNCC = tbTenNCC.Text;
            string DiaChi = tbDiaChi.Text;
            string SDT = tbSDT.Text;
            Boolean check = false;
            if (String.IsNullOrEmpty(MaNCC) || String.IsNullOrEmpty(TenNCC) || String.IsNullOrEmpty(DiaChi) || String.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {
                for (int i = 0; i < dgvNhaCC.Rows.Count - 1; i++)
                {
                    if (dgvNhaCC.Rows[i].Cells[0].Value.ToString().Equals(MaNCC))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    MessageBox.Show("Mã NCC đã trùng, nhập lại");
                }
                else
                {
                    try
                    {
                        bll.insertNHACC(MaNCC, TenNCC, DiaChi, SDT);
                        MessageBox.Show("Đã thêm thành công");
                        NHACC_Load(sender, e);
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
            string MaNCC = tbMaNCC.Text.ToLower();
            string TenNCC = tbTenNCC.Text;
            string DiaChi = tbDiaChi.Text;
            string SDT = tbSDT.Text;
            Boolean check = false;
            if (String.IsNullOrEmpty(MaNCC) || String.IsNullOrEmpty(TenNCC) || String.IsNullOrEmpty(DiaChi) || String.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {
                for (int i = 0; i < dgvNhaCC.Rows.Count - 1; i++)
                {
                    if (dgvNhaCC.Rows[i].Cells[0].Value.ToString().Equals(MaNCC))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    try
                    {
                        bll.updateNHACC(MaNCC, TenNCC, DiaChi, SDT);
                        MessageBox.Show("Đã sửa thành công");
                        NHACC_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("sửa thất bại, Kiểm tra lại Mã NCC");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại Mã NCC này");
                }

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string MaNCC = tbMaNCC.Text.ToLower();
            Boolean check = false;

            if (String.IsNullOrEmpty(MaNCC))
            {
                MessageBox.Show("Không được bỏ trống Mã NCC");
            }
            else
            {
                for (int i = 0; i < dgvNhaCC.Rows.Count - 1; i++)
                {
                    if (dgvNhaCC.Rows[i].Cells[0].Value.ToString().Equals(MaNCC))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    try
                    {
                        bll.deleteNHACC(MaNCC);
                        MessageBox.Show("Đã xóa thành công");
                        NHACC_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại, Kiểm tra lại Mã NCC");
                    }
                }
                else { MessageBox.Show("Không tồn lại Mã NCC này"); }


            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            NHACC_Load(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String keySearch = tbSearch.Text;
            if (cbbTypeSearch.SelectedIndex == 0)
            {
                dgvNhaCC.DataSource = bll.searchbyMaNhaCC(keySearch);
            }
            else if (cbbTypeSearch.SelectedIndex == 1)
            {
                dgvNhaCC.DataSource = bll.searchbyTenNCC(keySearch);
            }
            else if (cbbTypeSearch.SelectedIndex == 2)
            {
                dgvNhaCC.DataSource = bll.searchbyDiaChi(keySearch);
            }
            else { MessageBox.Show("Kiểu tìm kiếm không có. lựa chọn lại"); }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhaCC.CurrentCell.RowIndex;
            tbMaNCC.Text = dgvNhaCC.Rows[index].Cells[0].Value.ToString();
            tbTenNCC.Text = dgvNhaCC.Rows[index].Cells[1].Value.ToString();
            tbDiaChi.Text = dgvNhaCC.Rows[index].Cells[2].Value.ToString();
            tbSDT.Text = dgvNhaCC.Rows[index].Cells[3].Value.ToString();
            
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
