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
    public partial class BaoCaoDoanhThuTheoHangHoa : Form
    {
        private readonly DangNhap userLoginInfor = VariablesGlobal.Instance.UserLoginCurrent;
        private UserBLL _dangNhapBLL = new UserBLL();
        public BaoCaoDoanhThuTheoHangHoa()
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
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(gridViewBaoCao, saveFileDialog1.FileName);
            }
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý học sinh";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(gridViewBaoCao, saveFileDialog1.FileName);
            }
        }
    }

}
