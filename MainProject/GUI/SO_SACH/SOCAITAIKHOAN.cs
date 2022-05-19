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

namespace QLBANXE
{
    public partial class SoCaiTaiKhoan : Form
    {
        private readonly DangNhap userLoginInfor = VariablesGlobal.Instance.UserLoginCurrent;
        private UserBLL _dangNhapBLL = new UserBLL();
        public SoCaiTaiKhoan()
        {
            InitializeComponent();
        }


        private DialogResult Show(string title, out string passWordOld)
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
            passWordOld = StartDateTextBox.Text;
            return dialogResult;
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
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
            string filter = "";
            if (Show("Tham số báo cáo", out filter) == DialogResult.OK)
            {
            }
        }


        private void BaoCaoDoanhThuTheoHangHoa_Load(object sender, EventArgs e)
        {
            List<BaoCaoDoanhThuTheoHangHoaModel> data = new List<BaoCaoDoanhThuTheoHangHoaModel>();
            for (var index = 0; index < 5; index++)
            {
                BaoCaoDoanhThuTheoHangHoaModel model = new BaoCaoDoanhThuTheoHangHoaModel()
                {
                    MAHH = $"MAHH00{index}",
                    TENHH = index == 1 ? "Chăn lông cừu" : index == 2 ? "Nệm ép" : index == 3 ? "Gối chống chào Hi Mom" : index == 4 ? "Nệm sông Hồng" : "Chăn sông Hồng",
                    DOANHTHU = (decimal)(index + 2 * 100000)
                };
                data.Add(model);
            };
            this.gridViewBaoCao.DataSource = data;

            var dt = new DataTable();
            dt.Columns.Add("Ngày tháng ghi sổ");
            dt.Columns.Add("Số hiệu");
            dt.Columns.Add("Ngày, tháng");
            dt.Columns.Add("Diễn giải");

            dt.Rows.Add("ksdsd", "aa", "a", "a");
            dt.Rows.Add(1, "aa", "xx", "a");
            dt.Rows.Add(2, "bb", "yy", "a");
            dt.Rows.Add(3, "cc", "zz", "a");
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.AutoSize = true;

            for (int i = 0; i < 3; i++)
            {

                var l = new Label();
                //l.Dock = DockStyle.Fill;
                l.Text = i == 0 ? "Ngày tháng ghi sổ" : i == 1 ? "Chứng từ" : "Diễn giải";
                if(i == 1)
                {
                    tableLayoutPanel1.Controls.Add(l, i, 0);
                    tableLayoutPanel1.SetColumnSpan(l, 2);
                }
                else
                {
                    tableLayoutPanel1.Controls.Add(l, i, 0);
                }
                //tableLayoutPanel1.Controls.Add(l, i, 0);
                //if (i == 1)
                //{
                //    tableLayoutPanel1.SetColumnSpan(l, 2);
                //}
            }
            for (int i = 0; i < dt.Columns.Count; i++)
            {

                var l = new Label();
                //l.Dock = DockStyle.Fill;
                l.Text = dt.Columns[i].ColumnName;
                tableLayoutPanel1.Controls.Add(l, i, 1);
                //if (i == 1)
                //{
                //    tableLayoutPanel1.SetColumnSpan(l, 2);
                //}
            }
            //var emptyLabel = new Label();
            //emptyLabel.Text = "Empty label";
            //tableLayoutPanel1.Controls.Add(emptyLabel, 4, 0);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Rows[i].ItemArray.Length; j++)
                {
                    var tb = new Label();
                    tb.Text = "Empty label";
                    tb.Dock = DockStyle.Fill;
                    tb.Text = dt.Rows[i][j].ToString();
                    tableLayoutPanel1.Controls.Add(tb, j, i + 2);
                    //if (i == 1 && j == 2)
                    //    tableLayoutPanel1.SetColumnSpan(tb, 2);
                }
            }
        }
    }

}
