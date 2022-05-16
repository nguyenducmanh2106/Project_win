using Core.Constants;
using Core.Global;
using Dapper.BLL;
using Dapper.Model;
using Newtonsoft.Json;
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
    public partial class DanhMucTaiKhoan : Form
    {
        private readonly UserBLL userBLL = new UserBLL();
        private DangNhap recordEdit = null;
        public DanhMucTaiKhoan()
        {
            InitializeComponent();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Dispose(true);
        }

        private void DanhMucTaiKhoan_Load(object sender, EventArgs e)
        {
            CoreModel obj = new CoreModel();
            obj.CustomData = new Dictionary<string, object>();
            obj.CustomData.Add("TextSearch", this.inputSearch.Text);
            var data = userBLL.GetList(obj);
            gridView.DataSource = data;
            //cbbMaSP.DataSource = bll.getMaSP();
            //cbbMaSP.DisplayMember = "MaSP";
            //cbbMaSP.ValueMember = "MaSP";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DanhMucTaiKhoanBox danhMucTaiKhoanBox = new DanhMucTaiKhoanBox();
            danhMucTaiKhoanBox.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (recordEdit == null)
            {
                new ShowMessageBox().Warning("Chưa chọn bản ghi");
                return;
            }

            DanhMucTaiKhoanBoxUpdate danhMucTaiKhoanBox = new DanhMucTaiKhoanBoxUpdate();
            danhMucTaiKhoanBox.Text = "Cập nhật tài khoản";
            danhMucTaiKhoanBox.TENDANGNHAP.ReadOnly = true;
            danhMucTaiKhoanBox.TENDANGNHAP.Text = recordEdit.TENDANGNHAP;
            danhMucTaiKhoanBox.TENTK.Text = recordEdit.TENTK;
            danhMucTaiKhoanBox.CAPTK.Text = recordEdit.CAPTK?.ToString() ?? null;
            danhMucTaiKhoanBox.TRANGTHAI.Checked = Convert.ToBoolean(recordEdit.TRANGTHAI);
            danhMucTaiKhoanBox.Show();
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.inputSearch.Text = null;
            recordEdit = null;
            DanhMucTaiKhoan_Load(sender, e);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridView.CurrentCell.RowIndex;
            recordEdit = new DangNhap();
            recordEdit.TENDANGNHAP = gridView.Rows[index].Cells["TENDANGNHAP"].Value.ToString();
            recordEdit.TENTK = gridView.Rows[index].Cells["TENTK"].Value.ToString();
            recordEdit.CAPTK = Convert.ToInt32(gridView.Rows[index].Cells["CAPTK"].Value);
            recordEdit.TRANGTHAI = Convert.ToInt32(gridView.Rows[index].Cells["TRANGTHAI"].Value);
            recordEdit.ID = Convert.ToInt32(gridView.Rows[index].Cells["ID"].Value);
        }

        private DialogResult Show(string title, string userName)
        {
            Form form = new Form();
            Label userNameLabel = new Label();

            TextBox userNameTextBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            userNameLabel.Text = $"Bạn có muốn xóa: {userName} ?";

            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            userNameLabel.SetBounds(9, 20, 20, 13);
            userNameTextBox.SetBounds(145, 20, 200, 20);

            buttonOk.SetBounds(228, 150, 75, 23);
            buttonCancel.SetBounds(309, 150, 75, 23);

            userNameLabel.AutoSize = true;
            userNameTextBox.Anchor = userNameTextBox.Anchor | AnchorStyles.Right;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 200);
            form.Controls.AddRange(
                new Control[] { userNameLabel,
                    //userNameTextBox,
                    buttonOk, buttonCancel
            });

            form.ClientSize = new Size(Math.Max(300, userNameLabel.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (recordEdit == null)
            {
                new ShowMessageBox().Warning("Chưa chọn bản ghi");
                return;
            }
            string userName = recordEdit.TENDANGNHAP;
            if (Show("Xóa tài khoản", userName) == DialogResult.OK)
            {
                var result = userBLL.Delete(recordEdit.ID);
                if (result)
                {
                    new ShowMessageBox().Success(String.Format(MessageConstants.DeletetSuccessMessage, "tài khoản"));
                    DanhMucTaiKhoan_Load(sender, e);
                }
                else
                {
                    new ShowMessageBox().Error(String.Format(MessageConstants.DeleteErrorMessage, "tài khoản"));
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DanhMucTaiKhoan_Load(sender, e);
        }
    }
}
