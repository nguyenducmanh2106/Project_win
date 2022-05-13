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
    public partial class Hangxe : Form
    {
        public Hangxe()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            FeaturesProduct featuresProduct = new FeaturesProduct();
            featuresProduct.Show();
            this.Hide();
        }
        BLL_HANGXE bll = new BLL_HANGXE();
        private void Hangxe_Load(object sender, EventArgs e)
        {
            dgvHangXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangXe.DataSource = bll.showHANGXE();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            string mahangxe = tbMaHangXe.Text.ToLower();
            string tenhang = tbTenXe.Text;
            Boolean check = false;
            if (String.IsNullOrEmpty(mahangxe) || String.IsNullOrEmpty(tenhang))
            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {
                for(int i = 0; i < dgvHangXe.Rows.Count - 1; i++)
                {
                    if (dgvHangXe.Rows[i].Cells[0].Value.ToString().Equals(mahangxe))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    MessageBox.Show("Mã hãng xe đã trùng, nhập lại");
                }
                else
                {
                    try
                    {
                        bll.insertHANGXE(mahangxe, tenhang);
                        MessageBox.Show("Đã thêm thành công");
                        Hangxe_Load(sender, e);
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
            string mahangxe = tbMaHangXe.Text.ToLower();
            string tenhang = tbTenXe.Text;
            
            Boolean check = false;
            if (String.IsNullOrEmpty(mahangxe) || String.IsNullOrEmpty( tenhang))

            {
                MessageBox.Show("Không được bỏ trống bất kỳ dữ liệu nào dòng nào");
            }
            else
            {

                for (int i = 0; i < dgvHangXe.Rows.Count - 1; i++)
                {
                    if (dgvHangXe.Rows[i].Cells[0].Value.ToString().Equals(mahangxe))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    try
                    {
                        bll.updateHANGXE(mahangxe, tenhang);
                        MessageBox.Show("Đã sửa thành công");
                        Hangxe_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("sửa thất bại, Kiểm tra lại mã hãng xe");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã hãng xe này");
                }


            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string mahangxe = tbMaHangXe.Text.ToLower();
            Boolean check = false;

            if (String.IsNullOrEmpty(mahangxe))
            {
                MessageBox.Show("Không được bỏ trống mã hãng xe");
            }
            else
            {
                for (int i = 0; i < dgvHangXe.Rows.Count - 1; i++)
                {
                    if (dgvHangXe.Rows[i].Cells[0].Value.ToString().Equals(mahangxe))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    try
                    {
                        bll.deleteHANGXE(mahangxe);
                        MessageBox.Show("Đã xóa thành công");
                        Hangxe_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại, Kiểm tra lại mã hãng xe");
                    }
                }
                else { MessageBox.Show("Không tồn lại mã hãng xe này"); }


            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String mahangxe = tbMaHangXe.Text;
            if (String.IsNullOrEmpty(mahangxe))
            {
                MessageBox.Show("Mã hãng xe không được bỏ trống");
            }
            else {dgvHangXe.DataSource= bll.searchHANGXE(mahangxe); }
            
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            Hangxe_Load(sender, e);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHangXe.CurrentCell.RowIndex;
            tbMaHangXe.Text = dgvHangXe.Rows[index].Cells[0].Value.ToString();
            tbTenXe.Text = dgvHangXe.Rows[index].Cells[1].Value.ToString();
           
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
