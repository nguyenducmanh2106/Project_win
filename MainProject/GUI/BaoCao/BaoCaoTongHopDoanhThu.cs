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
    public partial class BaoCaoTongHopDoanhThu : Form
    {
        private readonly DangNhap userLoginInfor = VariablesGlobal.Instance.UserLoginCurrent;
        private UserBLL _dangNhapBLL = new UserBLL();
        public BaoCaoTongHopDoanhThu()
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
            List<BaoCaoGiamTruDoanhThuModel> data = new List<BaoCaoGiamTruDoanhThuModel>();
            for (var index = 0; index < 5; index++)
            {
                BaoCaoGiamTruDoanhThuModel model = new BaoCaoGiamTruDoanhThuModel()
                {
                    MAKH = $"MAKH00{index}",
                    TENKH = index == 1 ? "Nguyễn Văn Linh" : index == 2 ? "Bùi Thị Hoa" : index == 3 ? "Phan Thành Trung" : index == 4 ? "Phạm Thành Long" : "Phạm Minh Hiếu",
                    DOANHTHU = (decimal)(index + 2 * 100000),
                    GIAMTRUDOANHTHU = 0,
                    DOANHTHUTHUAN = (decimal)(index + 2 * 100000),
                };
                data.Add(model);
            };
            this.gridViewBaoCao.DataSource = data;
        }
    }

}
