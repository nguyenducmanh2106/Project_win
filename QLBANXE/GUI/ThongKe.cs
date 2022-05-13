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
using System.Data.SqlClient;
using QLBANXE.BLL;

namespace QLBANXE
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        BLL_THONGKE bll = new BLL_THONGKE();//khai báo class BLL
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }
        //hàm reload_load
        

        private void btn_RELOAD_Click(object sender, EventArgs e)
        {
            ThongKe_Load_1(sender, e);
        }
        //hàm xử lý lấy các thông tin...
        //hàm lấy tổng số lượng nhập
        private int getTotalAmountEntered()
        {
            int sum = 0;
            for(int i = 0; i < dgvSPNHAP.RowCount - 1; i++)
            {
                sum += Int32.Parse(dgvSPNHAP.Rows[i].Cells[2].Value.ToString());
            }
            return sum;
        }
        //hàm lấy tổng số lượng xuất
        private int getTotalAmountExported()
        {
            int sum = 0;
            for (int i = 0; i < dgvSPBAN.RowCount - 1; i++)
            {
                sum += Int32.Parse(dgvSPBAN.Rows[i].Cells[2].Value.ToString());
            }
            
            return sum;
        }
        //hàm lấy tổng sản phẩm nhập
        private int getTotalProductImported()
        {
            return dgvSPNHAP.RowCount - 1;
        }
        //hàm lấy tổng sản phẩm bán
        private int getTotalProductExported()
        {
            return dgvSPBAN.RowCount - 1;
        }
        //hàm lấy tổng tiền xuất
        private int getTotalPriceExported()
        {
            int sum = 0;
            for (int i = 0; i < dgvSPBAN.RowCount - 1; i++)
            {
                sum += Int32.Parse(dgvSPBAN.Rows[i].Cells[2].Value.ToString())* Int32.Parse(dgvSPBAN.Rows[i].Cells[3].Value.ToString());
            }
            return sum;
        }
        //hàm lấy tổng tiền nhập
        private int getTotalPriceImported()
        {
            int sum = 0;
            for (int i = 0; i < dgvSPNHAP.RowCount - 1; i++)
            {
                sum += Int32.Parse(dgvSPNHAP.Rows[i].Cells[2].Value.ToString()) * Int32.Parse(dgvSPNHAP.Rows[i].Cells[3].Value.ToString());
            }
            return sum;
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            try
            {
                int month = Int32.Parse(cbbMonth.SelectedItem.ToString());
                int year = Int32.Parse(txtYear.Text);
                int preRow1 = dgvSPBAN.RowCount;
                int preRow2 = dgvSPNHAP.RowCount;
                dgvSPBAN.DataSource = bll.getTableProductExportedWithMonthandYear(month, year);
                dgvSPNHAP.DataSource = bll.getTableProductImportedWithMonthandYear(month, year);
                int currRow1 = dgvSPBAN.RowCount;
                int currRow2 = dgvSPNHAP.RowCount;
                //tính toán lại dữ liệu
                int tongSLBan = 0;
                int tongSLNHAP = 0;
                int tongSPNhap = 0;
                int tongSPBan = 0;
                //if (preRow1 != currRow1 || preRow2 != currRow2)
                //{
                    tongSLBan = getTotalAmountExported();
                    tongSLNHAP = getTotalAmountEntered();
                    tongSPNhap = getTotalProductImported();
                    tongSPBan = getTotalProductExported();
                    int sumPriceImported = getTotalPriceImported();
                    txtTongTienNhap.Text = string.Format("{0:#,##0.00}", sumPriceImported);
                    int sumPriceExported = getTotalPriceExported();
                    txtTongTienBan.Text = string.Format("{0:#,##0.00}", sumPriceExported);
                    int tienLai = sumPriceExported - sumPriceImported;
                    txtTienLai.Text = string.Format("{0:#,##0.00}", tienLai);
                //}
                txtTongSLBan.Text = tongSLBan.ToString();
                txtTongSLNhap.Text = tongSLNHAP.ToString();
                txtTongSPnhap.Text = tongSPNhap.ToString();
                txtTongSPban.Text = tongSPBan.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("dữ liệu nhập không hợp lệ");
            }

        }
        //hàm form_load
        private void ThongKe_Load_1(object sender, EventArgs e)
        {
            txtYear.Text = "";
            cbbMonth.SelectedIndex = 0;
            dgvSPBAN.DataSource = bll.showTableProductSale();
            dgvSPNHAP.DataSource = bll.showTableProductImported();
            txtTongSLBan.Text = getTotalAmountExported().ToString();
            txtTongSLNhap.Text = getTotalAmountEntered().ToString();
            txtTongSPnhap.Text = getTotalProductImported().ToString();
            txtTongSPban.Text = getTotalProductExported().ToString();
            int sumPriceImported = getTotalPriceImported();
            txtTongTienNhap.Text = string.Format("{0:#,##0.00}", sumPriceImported);
            int sumPriceExported = getTotalPriceExported();
            txtTongTienBan.Text = string.Format("{0:#,##0.00}", sumPriceExported);
            int tienLai = sumPriceExported - sumPriceImported;
            txtTienLai.Text = string.Format("{0:#,##0.00}", tienLai);
            
        }

        private void click(object sender, EventArgs e)
        {

        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
