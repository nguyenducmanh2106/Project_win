using Core.Box;
using Core.Constants;
using Core.Global;
using Dapper.BLL;
using Dapper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KETOANDOANHTHU
{
    public partial class SoChiTietTaiKhoan : Form
    {
        private readonly DangNhap userLoginInfor = VariablesGlobal.Instance.UserLoginCurrent;
        private DanhMucTaiKhoanBLL taiKhoanBLL = new DanhMucTaiKhoanBLL();
        private SoSachBLL bll = new SoSachBLL();
        public SoChiTietTaiKhoan()
        {
            InitializeComponent();
        }


        private DialogResult Show(string title, out DateTime StartDate, out DateTime EndDate, out int taiKhoan, out string tenTaiKhoan)
        {
            Form form = new Form();
            Label StartDateLabel = new Label();
            Label EndDateLabel = new Label();
            Label taiKhoanLabel = new Label();

            DateTimePicker StartDateTextBox = new DateTimePicker();
            DateTimePicker EndDateTextBox = new DateTimePicker();
            ComboBox taiKhoanCombobox = new ComboBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;

            StartDateTextBox.CustomFormat = "dd/MM/yyyy";
            EndDateTextBox.CustomFormat = "dd/MM/yyyy";

            StartDateLabel.Text = "Từ ngày:";
            EndDateLabel.Text = "Đến ngày:";
            taiKhoanLabel.Text = "Tài khoản:";


            taiKhoanCombobox.DataSource = taiKhoanBLL.GetListActive(0);
            taiKhoanCombobox.DisplayMember = "TENTK";
            taiKhoanCombobox.ValueMember = "ID";
            taiKhoanCombobox.SelectedIndex = -1;

            StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taiKhoanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            StartDateLabel.SetBounds(9, 20, 372, 13);
            StartDateTextBox.SetBounds(12, 47, 372, 20);

            EndDateLabel.SetBounds(9, 80, 372, 13);
            EndDateTextBox.SetBounds(12, 104, 372, 20);

            taiKhoanLabel.SetBounds(9, 137, 372, 13);
            taiKhoanCombobox.SetBounds(12, 164, 372, 20);


            buttonOk.SetBounds(228, 222, 75, 23);
            buttonCancel.SetBounds(309, 222, 75, 23);


            StartDateLabel.AutoSize = true;
            StartDateTextBox.Anchor = StartDateTextBox.Anchor | AnchorStyles.Right;

            EndDateLabel.AutoSize = true;
            EndDateTextBox.Anchor = EndDateTextBox.Anchor | AnchorStyles.Right;

            taiKhoanLabel.AutoSize = true;
            taiKhoanCombobox.Anchor = taiKhoanCombobox.Anchor | AnchorStyles.Right;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 280);
            form.Controls.AddRange(
                new Control[] {
                    StartDateLabel,StartDateTextBox,
                    EndDateLabel,EndDateTextBox,
                    taiKhoanLabel,taiKhoanCombobox,
                    buttonOk, buttonCancel
            });

            form.ClientSize = new Size(Math.Max(400, StartDateLabel.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            StartDate = StartDateTextBox.Value;
            EndDate = EndDateTextBox.Value;
            taiKhoan = Convert.ToInt32(taiKhoanCombobox.SelectedValue);
            tenTaiKhoan = taiKhoanCombobox.Text;
            return dialogResult;
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
            this.Dispose(true);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
            this.Dispose(true);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            int taiKhoan;
            string tenTaiKhoan;

            if (Show("Tham số báo cáo", out startDate, out endDate, out taiKhoan, out tenTaiKhoan) == DialogResult.OK)
            {
                this.TimeReport.Text = $"Từ ngày {startDate.ToString("dd/MM/yyyy")} đến {endDate.ToString("dd/MM/yyyy")}";
                this.TaiKhoanLabel.Text = $"Tài khoản: {tenTaiKhoan}";
                CoreModel obj = new CoreModel();
                obj.CustomData = new Dictionary<string, object>();
                obj.CustomData["StartDate"] = startDate;
                obj.CustomData["EndDate"] = endDate;
                obj.CustomData["TaiKhoan"] = taiKhoan;
                DrawingTableLayout(obj);
            }
        }


        private void BaoCaoDoanhThuTheoHangHoa_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            this.TimeReport.Text = $"Từ ngày {firstDayOfMonth.ToString("dd/MM/yyyy")} đến {lastDayOfMonth.ToString("dd/MM/yyyy")}";
            this.TaiKhoanLabel.Text = $"Tài khoản: ";
            CoreModel obj = new CoreModel();
            obj.CustomData = new Dictionary<string, object>();
            obj.CustomData["StartDate"] = firstDayOfMonth;
            obj.CustomData["EndDate"] = lastDayOfMonth;
            obj.CustomData["TaiKhoan"] = null;
            DrawingTableLayout(obj);


        }

        private void DrawingTableLayout(CoreModel obj)
        {
            this.tableLayoutPanel1.Visible = false;

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            Dictionary<string, object> headers = new Dictionary<string, object>();
            headers["col1"] = "Ngày tháng ghi sổ";
            headers["col2"] = "Chứng từ";
            headers["col3"] = "Diễn giải";
            headers["col5"] = "Số hiệu TK đối ứng";
            headers["col6"] = "Số tiền";
            var dt = new DataTable();
            dt.Columns.Add("Ngày tháng ghi sổ");
            dt.Columns.Add("Số hiệu");
            dt.Columns.Add("Ngày, tháng");
            dt.Columns.Add("Diễn giải");
            dt.Columns.Add("Số hiệu TK đối ứng");
            dt.Columns.Add("Nợ");
            dt.Columns.Add("Có");
            dt.Columns.Add("Tồn");
            Dictionary<string, object> headers3 = new Dictionary<string, object>();
            headers3["col1"] = "A";
            headers3["col2"] = "B";
            headers3["col3"] = "C";
            headers3["col4"] = "D";
            headers3["col5"] = "E";
            headers3["col6"] = "1";
            headers3["col7"] = "2";
            headers3["col8"] = "3";


            var result = bll.GetDataTableSoChiTietTaiKhoan(obj);
            foreach (var item in result)
            {
                string NgayThangGhiSo = item.NgayThangGhiSo != null ? Convert.ToDateTime(item.NgayThangGhiSo).ToString("dd/MM/yyyy") : "";
                string NgayThangChungTu = item.NgayThangChungTu != null ? Convert.ToDateTime(item.NgayThangChungTu).ToString("dd/MM/yyyy") : "";
                dt.Rows.Add(NgayThangGhiSo, item.SoHieu, NgayThangChungTu, item.DIENGIAI, item.TKDOIUNG, item.SONO?.ToString("n2"), item.CO?.ToString("n2"), item.TON?.ToString("n2"));
            }
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = dt.Columns.Count;
            tableLayoutPanel1.AutoSize = true;
            int index = 0;
            foreach (var dic in headers)
            {
                var l = new Label();
                l.Dock = DockStyle.Fill;
                l.Text = dic.Value?.ToString();
                l.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
                l.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                if (dic.Key == "col2")
                {
                    tableLayoutPanel1.SetColumnSpan(l, 2);

                }
                if (dic.Key == "col6")
                {
                    tableLayoutPanel1.SetColumnSpan(l, 2);

                }
                if (dic.Key == "col1" || dic.Key == "col3" || dic.Key == "col5")
                {
                    tableLayoutPanel1.SetRowSpan(l, 2);

                }
                tableLayoutPanel1.Controls.Add(l, index, 0);
                index++;

            }

            for (int i = 0; i < dt.Columns.Count; i++)
            {

                var l = new Label();
                l.Dock = DockStyle.Fill;
                l.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.Text = dt.Columns[i].ColumnName;
                if (i == 0 || i == 3 || i == 6)
                {
                    continue;
                }
                tableLayoutPanel1.Controls.Add(l, i, 1);
            }

            var index3 = 0;
            foreach (var dic in headers3)
            {
                var l = new Label();
                l.Dock = DockStyle.Fill;
                l.Text = dic.Value?.ToString();
                l.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tableLayoutPanel1.Controls.Add(l, index3, 2);
                index3++;

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Rows[i].ItemArray.Length; j++)
                {
                    var tb = new Label();
                    tb.Text = "Empty label";
                    tb.Dock = DockStyle.Fill;
                    tb.Text = dt.Rows[i][j].ToString();
                    tableLayoutPanel1.Controls.Add(tb, j, i + 3);
                    //if (i == 1 && j == 2)
                    //    tableLayoutPanel1.SetColumnSpan(tb, 2);
                }
            }

            setStyleForTablelayout(tableLayoutPanel1);

            //tạo scroll 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = false;

        }

        /// <summary>
        /// set style for TableLayoutPanel
        /// </summary>
        /// <param name="TableLayoutPanel"></param>
        private void setStyleForTablelayout(TableLayoutPanel TableLayoutPanel)
        {
            TableLayoutColumnStyleCollection styles = TableLayoutPanel.ColumnStyles;

            foreach (ColumnStyle style in styles)
            {

                if (style.SizeType == SizeType.Absolute)
                {
                    style.SizeType = SizeType.AutoSize;
                }
                else if (style.SizeType == SizeType.AutoSize)
                {
                    //style.SizeType = SizeType.Percent;
                    style.Width = 33;
                }
                else
                {
                    // Set the column width to 50 pixels.
                    style.SizeType = SizeType.Absolute;
                    style.Width = 50;
                }
            }

            TableLayoutRowStyleCollection styleRows = TableLayoutPanel.RowStyles;

            foreach (RowStyle style in styleRows)
            {
                if (style.SizeType == SizeType.Absolute)
                {
                    style.SizeType = SizeType.AutoSize;
                }
                else if (style.SizeType == SizeType.AutoSize)
                {
                    style.SizeType = SizeType.Percent;
                    // of the TableLayoutPanel control's width.
                    style.Height = 20;
                }
                else
                {
                    style.SizeType = SizeType.Absolute;
                    style.Height = 24;
                }
            }


            this.tableLayoutPanel1.Visible = true;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuTheoHangHoa_Load(sender, e);
        }
    }

}
