using Core.Constants;
using Core.Global;
using Core.Utils;
using Dapper.BLL;
using Dapper.Model;
using Newtonsoft.Json;
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
    public partial class PhieuGiamGiaUpdate : Form
    {
        private readonly PhieuGiamGiaBLL bll = new PhieuGiamGiaBLL();
        private readonly HangHoaBLL hangHoaBll = new HangHoaBLL();
        private readonly KhachHangBLL khachHangBLL = new KhachHangBLL();
        private readonly DanhMucTaiKhoanBLL taiKhoanBLL = new DanhMucTaiKhoanBLL();

        private PhieuGiamGiaModel modelEdit = new PhieuGiamGiaModel();
        public PhieuGiamGiaUpdate()
        {
            InitializeComponent();
            //this.SOHD.Text = "SoHD";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.SOHD.Text) || string.IsNullOrEmpty(this.MAKH.Text))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
                }
                else
                {
                    DateTime ngayLap = default;
                    DateTime.TryParse(this.NGAYLAP.Text, out ngayLap);
                    PhieuGiamGiaModel model = new PhieuGiamGiaModel()
                    {
                        ID = modelEdit.ID,
                        SOHD = this.SOHD.Text,
                        NGAYLAP = ngayLap,
                        KhachHangID = Convert.ToInt32(this.MAKH.SelectedValue),
                        TKNOGIAMTRU = Convert.ToInt32(this.TKNOGIAMTRU.SelectedValue),
                        TKCOTHANHTOAN = Convert.ToInt32(this.TKCOTHANHTOAN.SelectedValue),
                        TKNOTHUE = Convert.ToInt32(this.TKNOTHUE.SelectedValue),
                        TKCK = Convert.ToInt32(this.TKCK.SelectedValue),
                        TIENTHANHTOAN = Convert.ToDecimal(this.TONGTHANHTOAN.Text),
                        DIENGIAI = this.DIENGIAI.Text,
                        LOAITIEN = this.LOAITIEN.Text,
                        TONGTIENCK = Convert.ToDecimal(this.TIENCK1.Text),
                        TONGTIENTHUE = Convert.ToDecimal(this.TIENTHUE1.Text),
                    };

                    List<CTPGG> cTHDGTGT = new List<CTPGG>();
                    cTHDGTGT = CalculationChiTietHoaDonGTGT(gridViewHangHoa);
                    bool result = bll.Update(model, cTHDGTGT);
                    if (result)
                    {
                        new ShowMessageBox().Success(String.Format(MessageConstants.UpdateSuccessMessage, "phiếu giảm giá"));
                        this.Dispose(true);
                    }
                    else
                    {
                        new ShowMessageBox().Error(String.Format(MessageConstants.UpdateErrorMessage, "phiếu giám giá"));
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    new ShowMessageBox().Error("Mã phiếu giảm giá đã tồn tại");
                }
                else
                {
                    new ShowMessageBox().Error(ex.Message);
                }
            }
            catch (Exception ex)
            {
                new ShowMessageBox().Error(ex.Message);
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
                //    var valueBefore = double.Parse(GIAXUAT.Text.Replace(".", ""), System.Globalization.NumberStyles.AllowThousands);
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
                //    var valueBefore = double.Parse(GIANHAP.Text.Replace(".", ""), System.Globalization.NumberStyles.AllowThousands);
                //    GIANHAP.Text = String.Format(culture, "{0:N0}", valueBefore);
                //    GIANHAP.Select(GIANHAP.Text.Length, 0);
                //}

            }
        }

        private void HangHoaUpdate_Load(object sender, EventArgs e)
        {
            CoreModel obj = new CoreModel();
            obj.CustomData = new Dictionary<string, object>();
            obj.CustomData.Add("TextSearch", null);
            MAKH.DisplayMember = "MAKH";
            MAKH.ValueMember = "ID";
            MAKH.DataSource = khachHangBLL.GetList(obj);
            //this.MAKH.SelectedIndex = -1;

            //lấy thông tin các tài khoản
            IList<DanhMucTaiKhoanKeToanModel> TKNOTHANHTOAN = taiKhoanBLL.GetListActive(0);
            this.TKNOTHUE.DataSource = TKNOTHANHTOAN;
            this.TKNOTHUE.DisplayMember = "TENTK";
            this.TKNOTHUE.ValueMember = "ID";
            this.TKNOTHUE.SelectedIndex = -1;

            List<DanhMucTaiKhoanKeToanModel> TKCODOANHTHU = new List<DanhMucTaiKhoanKeToanModel>(TKNOTHANHTOAN);
            this.TKCOTHANHTOAN.DataSource = TKCODOANHTHU;
            this.TKCOTHANHTOAN.DisplayMember = "TENTK";
            this.TKCOTHANHTOAN.ValueMember = "ID";
            this.TKCOTHANHTOAN.SelectedIndex = -1;

            List<DanhMucTaiKhoanKeToanModel> TKCOTHUE = new List<DanhMucTaiKhoanKeToanModel>(TKNOTHANHTOAN);
            this.TKNOGIAMTRU.DataSource = TKCOTHUE;
            this.TKNOGIAMTRU.DisplayMember = "TENTK";
            this.TKNOGIAMTRU.ValueMember = "ID";
            this.TKNOGIAMTRU.SelectedIndex = -1;

            List<DanhMucTaiKhoanKeToanModel> TKCK = new List<DanhMucTaiKhoanKeToanModel>(TKNOTHANHTOAN);
            this.TKCK.DataSource = TKCK;
            this.TKCK.DisplayMember = "TENTK";
            this.TKCK.ValueMember = "ID";
            this.TKCK.SelectedIndex = -1;

            this.BindDataSourceForColumnCombobox(-1);

            int id = 0;
            Int32.TryParse(this.ID.Text, out id);
            PhieuGiamGiaDetail hoaDonGTGTDetail = bll.GetEntity(id);
            if (hoaDonGTGTDetail != null && !string.IsNullOrEmpty(hoaDonGTGTDetail.ChiTiet))
            {
                modelEdit.ID = hoaDonGTGTDetail.ID;
                var ChiTietHoaDonGTGT = JsonConvert.DeserializeObject<DataTable>(hoaDonGTGTDetail.ChiTiet);

                this.SOHD.Text = hoaDonGTGTDetail.SOHD;
                this.MAKH.SelectedValue = hoaDonGTGTDetail.KhachHangID;
                this.DIENGIAI.Text = hoaDonGTGTDetail.DIENGIAI;
                this.LOAITIEN.SelectedText = hoaDonGTGTDetail.LOAITIEN;
                this.NGAYLAP.Value = hoaDonGTGTDetail.NGAYLAP ?? default;
                this.TKCK.SelectedValue = hoaDonGTGTDetail.TKCK;
                this.TKCOTHANHTOAN.SelectedValue = hoaDonGTGTDetail.TKCOTHANHTOAN;
                this.TKNOGIAMTRU.SelectedValue = hoaDonGTGTDetail.TKNOGIAMTRU;
                this.TKNOTHUE.SelectedValue = hoaDonGTGTDetail.TKNOTHUE;
                this.TIENCK1.Text = hoaDonGTGTDetail.TONGTIENCK?.ToString("n2");
                this.TIENTHUE1.Text = hoaDonGTGTDetail.TONGTIENTHUE?.ToString("n2");
                this.TONGTHANHTOAN.Text = hoaDonGTGTDetail.TIENTHANHTOAN?.ToString("n2");
                this.TONGTIEN.Text = (hoaDonGTGTDetail.TIENTHANHTOAN + hoaDonGTGTDetail.TONGTIENCK - hoaDonGTGTDetail.TONGTIENTHUE)?.ToString("n2");
                this.gridViewHangHoa.AutoGenerateColumns = false;
                this.gridViewHangHoa.DataSource = ChiTietHoaDonGTGT;
            }
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
            var result = hangHoaBll.GetListCanUse(id);
            var dt = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(result));
            columns.DataSource = dt;
            columns.DisplayMember = "TENHH";
            columns.ValueMember = "ID";
        }
        private void AddRow()
        {
            DataTable dataTable = (DataTable)gridViewHangHoa.DataSource ?? new DataTable();
            DataRow drToAdd = dataTable.NewRow();
            dataTable.Rows.Add(drToAdd);
            //gridViewHangHoa.Rows.Add();

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
                //textBox.TextChanged +=
                //    new EventHandler(TextChanged);
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
                HangHoa hangHoa = hangHoaBll.GetEntity(HangHoaID);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TENHH1"].Value = hangHoa?.TENHH;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["DVT1"].Value = hangHoa?.DVT;
                //gridViewHangHoa.Rows[EditingControlRowIndex].Cells["KHO"].Value = hangHoa?.SOLUONG;
            }
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
                        //if (gridViewHangHoa.Columns[e.ColumnIndex].Name.Contains("SOLUONG1"))
                        //{
                        //    double kho = 0;
                        //    double.TryParse(gridViewHangHoa.Rows[e.RowIndex].Cells["KHO"].Value?.ToString(), out kho);
                        //    if (d > kho)
                        //    {
                        //        d = kho;
                        //    }
                        //}
                        e.Value = d.ToString("n0");
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
            Dictionary<string, object> dics = new Dictionary<string, object>();
            //if (gridViewHangHoa.Rows[EditingControlRowIndex].Cells["KHO"].Value?.ToString() == "NaN")
            //{
            //    gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value = 0;
            //}
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
            //double soLuongKho = 0;
            //double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["KHO"].Value?.ToString(), out soLuongKho);

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

                //if (soLuong > soLuongKho)
                //{
                //    soLuong = soLuongKho;
                //}
                double tienThue = (soLuong * donGia - tienCK) * (thueSuat / 100);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENTHUE"].Value = tienThue;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = soLuong * donGia - tienCK + tienThue;

                dics = CalculationSumary(gridViewHangHoa);
                this.TONGTIEN.Text = dics["TONGTIEN"]?.ToString();
                this.TIENCK1.Text = dics["TIENCK"]?.ToString();
                this.TIENTHUE1.Text = dics["TIENTHUE"]?.ToString();
                this.TONGTHANHTOAN.Text = dics["TONGTHANHTOAN"]?.ToString();

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
                //if (soLuong > soLuongKho)
                //{
                //    soLuong = soLuongKho;
                //}

                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THUESUAT"].Value = soLuong * donGia - tienCK > 0 ? (tienThue * 100) / (soLuong * donGia - tienCK) : 0;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = (soLuong * donGia - tienCK) + tienThue;

                dics = CalculationSumary(gridViewHangHoa);
                this.TONGTIEN.Text = dics["TONGTIEN"]?.ToString();
                this.TIENCK1.Text = dics["TIENCK"]?.ToString();
                this.TIENTHUE1.Text = dics["TIENTHUE"]?.ToString();
                this.TONGTHANHTOAN.Text = dics["TONGTHANHTOAN"]?.ToString();
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

                double thueSuat = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THUESUAT"].Value?.ToString(), out thueSuat);


                //if (soLuong > soLuongKho)
                //{
                //    soLuong = soLuongKho;
                //}
                double tienCK = soLuong * donGia * (tyLeCK / 100);
                double tienThue = (soLuong * donGia - tienCK) * (thueSuat / 100);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TIENCK"].Value = tienCK;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = (soLuong * donGia - tienCK) + tienThue;

                dics = CalculationSumary(gridViewHangHoa);
                this.TONGTIEN.Text = dics["TONGTIEN"]?.ToString();
                this.TIENCK1.Text = dics["TIENCK"]?.ToString();
                this.TIENTHUE1.Text = dics["TIENTHUE"]?.ToString();
                this.TONGTHANHTOAN.Text = dics["TONGTHANHTOAN"]?.ToString();
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

                double thueSuat = 0;
                double.TryParse(gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THUESUAT"].Value?.ToString(), out thueSuat);

                double tienThue = (soLuong * donGia - tienCK) * (thueSuat / 100);
                //if (soLuong > soLuongKho)
                //{
                //    soLuong = soLuongKho;
                //}

                double tyLeCk = (tienCK * 100) / (soLuong * donGia);
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["TYLECK"].Value = tyLeCk;
                gridViewHangHoa.Rows[EditingControlRowIndex].Cells["THANHTIEN"].Value = soLuong * donGia - tienCK + tienThue;

                dics = CalculationSumary(gridViewHangHoa);
                this.TONGTIEN.Text = dics["TONGTIEN"]?.ToString();
                this.TIENCK1.Text = dics["TIENCK"]?.ToString();
                this.TIENTHUE1.Text = dics["TIENTHUE"]?.ToString();
                this.TONGTHANHTOAN.Text = dics["TONGTHANHTOAN"]?.ToString();
            }
            #endregion
        }
        private Dictionary<string, object> CalculationSumary(DataGridView dgv)
        {
            Dictionary<string, object> dics = new Dictionary<string, object>();
            double tongTien = 0;
            double tienCK = 0;
            double tienThue = 0;
            double tongThanhToan = 0;
            for (var index = 0; index < dgv.RowCount; index++)
            {
                double soLuong = 0;
                double.TryParse(gridViewHangHoa.Rows[index].Cells["SOLUONG1"].Value?.ToString(), out soLuong);

                double donGia = 0;
                double.TryParse(gridViewHangHoa.Rows[index].Cells["DONGIA"].Value?.ToString(), out donGia);
                tongTien += soLuong * donGia;

                double tienCK1 = 0;
                double.TryParse(gridViewHangHoa.Rows[index].Cells["TIENCK"].Value?.ToString(), out tienCK1);
                tienCK += tienCK1;

                double tienThue1 = 0;
                double.TryParse(gridViewHangHoa.Rows[index].Cells["TIENTHUE"].Value?.ToString(), out tienThue1);
                tienThue += tienThue1;



            }
            tongThanhToan += (tongTien - tienCK + tienThue);
            dics["TONGTIEN"] = tongTien.ToString("n2");
            dics["TIENCK"] = tienCK.ToString("n2");
            dics["TIENTHUE"] = tienThue.ToString("n2");
            dics["TONGTHANHTOAN"] = tongThanhToan.ToString("n2");

            return dics;
        }

        private List<CTPGG> CalculationChiTietHoaDonGTGT(DataGridView dgv)
        {
            List<CTPGG> dics = new List<CTPGG>();
            for (var index = 0; index < dgv.RowCount; index++)
            {
                CTPGG dic = new CTPGG();
                int soLuong = 0;
                Int32.TryParse(gridViewHangHoa.Rows[index].Cells["SOLUONG1"].Value?.ToString(), out soLuong);

                int MAHH = 0;
                Int32.TryParse(gridViewHangHoa.Rows[index].Cells["MAHH1"].Value?.ToString(), out MAHH);

                Decimal donGia = 0;
                Decimal.TryParse(gridViewHangHoa.Rows[index].Cells["DONGIA"].Value?.ToString(), out donGia);

                Decimal tienCK = 0;
                Decimal.TryParse(gridViewHangHoa.Rows[index].Cells["TIENCK"].Value?.ToString(), out tienCK);

                Decimal tyLeCK = 0;
                Decimal.TryParse(gridViewHangHoa.Rows[index].Cells["TYLECK"].Value?.ToString(), out tyLeCK);

                Decimal thueSuat = 0;
                Decimal.TryParse(gridViewHangHoa.Rows[index].Cells["THUESUAT"].Value?.ToString(), out thueSuat);

                Decimal tienThue = 0;
                Decimal.TryParse(gridViewHangHoa.Rows[index].Cells["TIENTHUE"].Value?.ToString(), out tienThue);

                dic.HangHoaID = MAHH;
                dic.SOLUONG = soLuong;
                dic.DONGIA = donGia;
                dic.TYLECK = tyLeCK;
                dic.TIENCK = tienCK;
                dic.THUESUAT = thueSuat;
                dic.TIENTHUE = tienThue;
                dics.Add(dic);
            }

            return dics;
        }

    }
}
