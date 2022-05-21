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
    public partial class BaoCaoDoanhThuTheoKhachHang : Form
    {
        private readonly DangNhap userLoginInfor = VariablesGlobal.Instance.UserLoginCurrent;
        private UserBLL _dangNhapBLL = new UserBLL();
        private BaoCaoBLL bll = new BaoCaoBLL();
        public BaoCaoDoanhThuTheoKhachHang()
        {
            InitializeComponent();
        }


        private DialogResult Show(string title, out DateTime StartDate, out DateTime EndDate)
        {
            Form form = new Form();
            Label StartDateLabel = new Label();
            Label EndDateLabel = new Label();

            DateTimePicker StartDateTextBox = new DateTimePicker();
            DateTimePicker EndDateTextBox = new DateTimePicker();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;

            StartDateTextBox.CustomFormat = "dd/MM/yyyy";
            EndDateTextBox.CustomFormat = "dd/MM/yyyy";

            StartDateLabel.Text = "Từ ngày:";
            EndDateLabel.Text = "Đến ngày:";
            //textBox.Text = value;

            StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            StartDateLabel.SetBounds(9, 20, 372, 13);
            StartDateTextBox.SetBounds(12, 47, 372, 20);

            EndDateLabel.SetBounds(9, 80, 372, 13);
            EndDateTextBox.SetBounds(12, 104, 372, 20);


            buttonOk.SetBounds(228, 222, 75, 23);
            buttonCancel.SetBounds(309, 222, 75, 23);


            StartDateLabel.AutoSize = true;
            StartDateTextBox.Anchor = StartDateTextBox.Anchor | AnchorStyles.Right;

            EndDateLabel.AutoSize = true;
            EndDateTextBox.Anchor = EndDateTextBox.Anchor | AnchorStyles.Right;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 280);
            form.Controls.AddRange(
                new Control[] {
                    StartDateLabel,StartDateTextBox,
                    EndDateLabel,EndDateTextBox,
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
            if (Show("Tham số báo cáo", out startDate, out endDate) == DialogResult.OK)
            {
                this.TimeReport.Text = $"Từ ngày {startDate.ToString("dd/MM/yyyy")} đến {endDate.ToString("dd/MM/yyyy")}";
                CoreModel obj = new CoreModel();
                obj.CustomData = new Dictionary<string, object>();
                obj.CustomData["StartDate"] = startDate;
                obj.CustomData["EndDate"] = endDate;
                var data = bll.GetBaoCaoDoanhThuTheoKhachHang(obj);
                this.gridViewBaoCao.DataSource = data;
            }
        }

        private void BaoCaoDoanhThuTheoKhachHang_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            this.TimeReport.Text = $"Từ ngày {firstDayOfMonth.ToString("dd/MM/yyyy")} đến {lastDayOfMonth.ToString("dd/MM/yyyy")}";
            CoreModel obj = new CoreModel();
            obj.CustomData = new Dictionary<string, object>();
            obj.CustomData["StartDate"] = firstDayOfMonth;
            obj.CustomData["EndDate"] = lastDayOfMonth;
            var data = bll.GetBaoCaoDoanhThuTheoKhachHang(obj);
            this.gridViewBaoCao.DataSource = data;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuTheoKhachHang_Load(sender, e);
        }
    }

}
