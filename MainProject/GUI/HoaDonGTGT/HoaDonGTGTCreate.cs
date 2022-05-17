using Core.Constants;
using Core.Global;
using Core.Utils;
using Dapper.BLL;
using Dapper.Model;
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
    public partial class HoaDonGTGTCreate : Form
    {
        private readonly HangHoaBLL bll = new HangHoaBLL();
        private readonly KhachHangBLL khachHangBLL = new KhachHangBLL();
        private readonly UserBLL userBLL = new UserBLL();
        public HoaDonGTGTCreate()
        {
            InitializeComponent();
            this.SOHD.Text = "SoHD";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.SOHD.Text) || string.IsNullOrEmpty(this.MST.Text))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
                }
                else
                {
                    int? nullInt = null;
                    decimal? nullDec = null;
                    HangHoa model = new HangHoa()
                    {
                        //MAHH = this.MAHH.Text,
                        //TENHH = this.TENHH.Text,
                        //DVT = this.DVT.Text,
                        //NhaCungCapID = this.MANCC.SelectedValue != null ? Convert.ToInt32(this.MANCC.SelectedValue) : nullInt,
                        //SOLUONG = Convert.ToInt32(this.SOLUONG.Value),
                        //GIAXUAT = !string.IsNullOrEmpty(this.GIAXUAT.Text) ? Convert.ToDecimal(this.GIAXUAT.Text) : nullDec,
                        //GIANHAP = !string.IsNullOrEmpty(this.GIANHAP.Text) ? Convert.ToDecimal(this.GIANHAP.Text) : nullDec,
                    };
                    bool result = bll.Insert(model);
                    if (result)
                    {
                        new ShowMessageBox().Success(String.Format(MessageConstants.InsertSuccessMessage, "hàng hóa"));
                        this.Dispose(true);
                    }
                    else
                    {
                        new ShowMessageBox().Error(String.Format(MessageConstants.InsertErrorMessage, "hàng hóa"));
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    new ShowMessageBox().Error("Mã hàng hóa đã tồn tại");
                }
                else
                {
                    new ShowMessageBox().Error(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right)
                || (e.KeyCode == Keys.Left)
                || (e.KeyCode == Keys.Up)
                || (e.KeyCode == Keys.Down))
            {
                // Do nothing
            }
            else
            {
                //if (!string.IsNullOrEmpty(GIAXUAT.Text))
                //{
                //    string[] strArr = GIAXUAT.Text.Split(',');
                //    if (strArr != null && strArr.Length > 0)
                //    {
                //        GIAXUAT.Text = strArr[0];
                //    }
                //    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
                //    var valueBefore = decimal.Parse(GIAXUAT.Text.Replace(".", ""), System.Globalization.NumberStyles.AllowThousands);
                //    GIAXUAT.Text = String.Format(culture, "{0:N0}", valueBefore);
                //    GIAXUAT.Select(GIAXUAT.Text.Length, 0);
                //}

            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CustomHandleEvent.TextboxContainNumber(e))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void KeyUpGIANHAP(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right)
                || (e.KeyCode == Keys.Left)
                || (e.KeyCode == Keys.Up)
                || (e.KeyCode == Keys.Down))
            {
                // Do nothing
            }
            else
            {
                //if (!string.IsNullOrEmpty(GIANHAP.Text))
                //{
                //    string[] strArr = GIANHAP.Text.Split(',');
                //    if (strArr != null && strArr.Length > 0)
                //    {
                //        GIANHAP.Text = strArr[0];
                //    }
                //    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
                //    var valueBefore = decimal.Parse(GIANHAP.Text.Replace(".", ""), System.Globalization.NumberStyles.AllowThousands);
                //    GIANHAP.Text = String.Format(culture, "{0:N0}", valueBefore);
                //    GIANHAP.Select(GIANHAP.Text.Length, 0);
                //}

            }
        }

        private void HangHoaCreate_Load(object sender, EventArgs e)
        {
            CoreModel obj = new CoreModel();
            obj.CustomData = new Dictionary<string, object>();
            obj.CustomData.Add("TextSearch", null);
            MAKH.DisplayMember = "MAKH";
            MAKH.ValueMember = "ID";
            MAKH.DataSource = khachHangBLL.GetList(obj);
            //this.MAKH.SelectedIndex = -1;

            //lấy thông tin các tài khoản
            IList<DangNhap> TKNOTHANHTOAN = userBLL.GetListActive();
            this.TKNOTHANHTOAN.DataSource = TKNOTHANHTOAN;
            this.TKNOTHANHTOAN.DisplayMember = "TENTK";
            this.TKNOTHANHTOAN.ValueMember = "ID";
            this.TKNOTHANHTOAN.SelectedIndex = -1;

            List<DangNhap> TKCODOANHTHU = new List<DangNhap>(TKNOTHANHTOAN);
            this.TKCODOANHTHU.DataSource = TKCODOANHTHU;
            this.TKCODOANHTHU.DisplayMember = "TENTK";
            this.TKCODOANHTHU.ValueMember = "ID";
            this.TKCODOANHTHU.SelectedIndex = -1;

            List<DangNhap> TKCOTHUE = new List<DangNhap>(TKNOTHANHTOAN);
            this.TKCOTHUE.DataSource = TKCOTHUE;
            this.TKCOTHUE.DisplayMember = "TENTK";
            this.TKCOTHUE.ValueMember = "ID";
            this.TKCOTHUE.SelectedIndex = -1;

            List<DangNhap> TKCK = new List<DangNhap>(TKNOTHANHTOAN);
            this.TKCK.DataSource = TKCK;
            this.TKCK.DisplayMember = "TENTK";
            this.TKCK.ValueMember = "ID";
            this.TKCK.SelectedIndex = -1;

            this.BindDataSourceForColumnCombobox(-1);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void ChangeCombobox(object sender, EventArgs e)
        {
            int khachHangID = 0;
            System.Windows.Forms.ComboBox comboBoxKH = sender as System.Windows.Forms.ComboBox;
            Int32.TryParse(comboBoxKH.SelectedValue?.ToString(), out khachHangID);
            if (khachHangID > 0)
            {
                KhachHang khachHang = khachHangBLL.GetEntity(khachHangID);
                this.TENKH.Text = khachHang?.TENKH ?? null;
                this.MST.Text = khachHang?.MST ?? null;
                this.SDT.Text = khachHang?.SDT ?? null;
                this.DIACHI.Text = khachHang?.DIACHI ?? null;
            }
        }

        private void BindDataSourceForColumnCombobox(int id)
        {
            var columns = (gridViewHangHoa.Columns["MAHH1"] as System.Windows.Forms.DataGridViewComboBoxColumn);
            columns.DataSource = bll.GetListCanUse(id);
            columns.DisplayMember = "TENHH";
            columns.ValueMember = "ID";


        }
        private void AddRow()
        {
            gridViewHangHoa.Rows.Add(1);

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewHangHoa.Columns[e.ColumnIndex].Name == "ACTION")
            {
                gridViewHangHoa.Rows.RemoveAt(e.RowIndex);
            }

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            AddRow();
        }


        /// <summary>
        /// Bắt sự kiện thay đổi ô của datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                // Remove an existing event-handler, if present, to avoid 
                // adding multiple handlers when the editing control is reused.
                combo.SelectedIndexChanged -=
                    new EventHandler(ComboBox_SelectedIndexChanged);

                // Add the event handler. 
                combo.SelectedIndexChanged +=
                    new EventHandler(ComboBox_SelectedIndexChanged);
            }

            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                // Remove an existing event-handler, if present, to avoid 
                // adding multiple handlers when the editing control is reused.
                //textBox.TextChanged -=
                //    new EventHandler(TextChanged);

                // Add the event handler. 
                textBox.TextChanged +=
                    new EventHandler(TextChanged);
            }
        }


        /// <summary>
        /// thay đổi giá trị các ô combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int HangHoaID = 0;
            int EditingControlRowIndex = ((System.Windows.Forms.DataGridViewComboBoxEditingControl)sender).EditingControlRowIndex;
            Int32.TryParse(((ComboBox)sender).SelectedValue?.ToString(), out HangHoaID);
            if (HangHoaID > 0)
            {
                HangHoa hangHoa = bll.GetEntity(HangHoaID);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TENHH1"].Value = hangHoa?.TENHH;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["DVT1"].Value = hangHoa?.DVT;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["KHO"].Value = hangHoa?.SOLUONG;
            }
        }


        /// <summary>
        /// xử lý sự kiện thay đổi giá trị các ô textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// xử lý sự kiện nhập dữ liệu cho các ô text box có dạng số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("SOLUONG1")
                    || gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("THUESUAT")
                    || gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("TYLECK"))
                {
                    if (e.Value != null && e.Value?.ToString() != "")
                    {
                        double d = 0;
                        double.TryParse(e.Value?.ToString(), out d);
                        if (gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("SOLUONG1"))
                        {
                            double kho = 0;
                            double.TryParse(gridViewHangHoa.Rows[e.RowIndex].Cells["KHO"].Value?.ToString(), out kho);
                            if (d > kho)
                            {
                                d = kho;
                            }
                        }
                        e.Value = d.ToString("n0");
                        //e.Value = d.ToString("n");
                    }
                }
                if (gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("DONGIA")
                    || gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("TIENTHUE")
                    || gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("TIENCK"))
                {
                    if (e.Value != null && e.Value?.ToString() != "")
                    {
                        double d = 0;
                        double.TryParse(e.Value?.ToString(), out d);
                        e.Value = d.ToString("n2");
                    }
                }
            }
        }

        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int EditingControlRowIndex = e.RowIndex;
            int EditingControlColumnIndex = e.ColumnIndex;
            if (EditingControlRowIndex < 0) return;
            if (gridViewHangHoa.Rows[EditingControlRowIndex].Cells["KHO"].Value?.ToString() == "NaN")
            {
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value = 0;
            }
            if (gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value?.ToString() == "NaN")
            {
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value = 0;
            }
            if (gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THUESUAT"].Value?.ToString() == "NaN")
            {
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THUESUAT"].Value = 0;
            }
            if (gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TYLECK"].Value?.ToString() == "NaN")
            {
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TYLECK"].Value = 0;
            }
            if (gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENCK"].Value?.ToString() == "NaN")
            {
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENCK"].Value = 0;
            }
            double soLuongKho = 0;
            double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["KHO"].Value?.ToString(), out soLuongKho);

            #region tự tính thuế suất và tiền thuế cho mỗi hàng hóa
            if (gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("THUESUAT")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("SOLUONG1")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("DONGIA")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("TYLECK")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("TIENCK"))
            {
                double soLuong = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["SOLUONG1"].Value?.ToString(), out soLuong);

                double donGia = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["DONGIA"].Value?.ToString(), out donGia);

                double thueSuat = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THUESUAT"].Value?.ToString(), out thueSuat);

                double tienCK = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENCK"].Value?.ToString(), out tienCK);

                if (soLuong > soLuongKho)
                {
                    soLuong = soLuongKho;
                }
                double tienThue = (soLuong * donGia - tienCK) * (thueSuat * 0.01);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value = tienThue;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = (soLuong * donGia - tienCK) + tienThue;
            }
            if (gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("TIENTHUE")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("SOLUONG1")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("DONGIA")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("TYLECK")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("TIENCK"))
            {
                double soLuong = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["SOLUONG1"].Value?.ToString(), out soLuong);

                double donGia = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["DONGIA"].Value?.ToString(), out donGia);

                double tienThue = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value?.ToString(), out tienThue);

                double tienCK = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENCK"].Value?.ToString(), out tienCK);
                if (soLuong > soLuongKho)
                {
                    soLuong = soLuongKho;
                }

                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THUESUAT"].Value = (tienThue * 100) / (soLuong * donGia - tienCK);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = (soLuong * donGia - tienCK) + tienThue;
            }
            #endregion

            #region tự tính Tỷ lệ chiết khấu và tiền chiết khấu cho mỗi hàng hóa
            if (gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("TYLECK")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("SOLUONG1")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("DONGIA"))
            {
                double soLuong = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["SOLUONG1"].Value?.ToString(), out soLuong);

                double donGia = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["DONGIA"].Value?.ToString(), out donGia);

                double tyLeCK = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TYLECK"].Value?.ToString(), out tyLeCK);

                double tienThue = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value?.ToString(), out tienThue);

                if (soLuong > soLuongKho)
                {
                    soLuong = soLuongKho;
                }
                double tienCK = soLuong * donGia * (tyLeCK * 0.01);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENCK"].Value = tienCK;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = (soLuong * donGia - tienCK) + tienThue;
            }
            if (gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("TIENCK")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("SOLUONG1")
                || gridViewHangHoa.Columns[EditingControlColumnIndex].Name.Contains("DONGIA"))
            {
                double soLuong = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["SOLUONG1"].Value?.ToString(), out soLuong);

                double donGia = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["DONGIA"].Value?.ToString(), out donGia);

                double tienCK = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENCK"].Value?.ToString(), out tienCK);

                double tienThue = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value?.ToString(), out tienThue);
                if (soLuong > soLuongKho)
                {
                    soLuong = soLuongKho;
                }

                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TYLECK"].Value = (tienCK * 100) / (soLuong * donGia);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = (soLuong * donGia - tienCK) + tienThue;
            }
            #endregion
        }
    }
}
