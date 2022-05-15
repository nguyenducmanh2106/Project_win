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
    public partial class NhaCungCapList : Form
    {
        private readonly NhaCungCapBLL bll = new NhaCungCapBLL();
        private NhaCungCap recordEdit = null;
        public NhaCungCapList()
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
            var data = bll.GetList(obj);
            gridView.DataSource = data;
            //cbbMaSP.DataSource = bll.getMaSP();
            //cbbMaSP.DisplayMember = "MaSP";
            //cbbMaSP.ValueMember = "MaSP";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            NhaCungCapCreate frame = new NhaCungCapCreate();
            frame.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (recordEdit == null)
            {
                new ShowMessageBox().Warning("Chưa chọn bản ghi");
                return;
            }

            NhaCungCapUpdate frame = new NhaCungCapUpdate();
            frame.MANCC.Text = recordEdit.MANCC;
            frame.TENNCC.Text = recordEdit.TENNCC;
            frame.DIACHI.Text = recordEdit.DIACHI;
            frame.SDT.Text = recordEdit.SDT;
            frame.EMAIL.Text = recordEdit.EMAIL;
            frame.NGUNGHOPTAC.Checked = Convert.ToBoolean(recordEdit.NGUNGHOPTAC);
            frame.Show();
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
            recordEdit = new NhaCungCap();
            recordEdit.MANCC = gridView.Rows[index].Cells["MANCC"].Value.ToString();
            recordEdit.TENNCC = gridView.Rows[index].Cells["TENNCC"].Value.ToString();
            recordEdit.DIACHI = gridView.Rows[index].Cells["DIACHI"].Value?.ToString();
            recordEdit.SDT = gridView.Rows[index].Cells["SDT"].Value?.ToString();
            recordEdit.EMAIL = gridView.Rows[index].Cells["EMAIL"].Value?.ToString();
            recordEdit.NGUNGHOPTAC = Convert.ToBoolean(gridView.Rows[index].Cells["NGUNGHOPTAC"].Value);
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

            buttonOk.SetBounds(228, 222, 75, 23);
            buttonCancel.SetBounds(309, 222, 75, 23);

            userNameLabel.AutoSize = true;
            userNameTextBox.Anchor = userNameTextBox.Anchor | AnchorStyles.Right;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 300);
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
            string userName = recordEdit.TENNCC;
            if (Show("Xóa tài khoản", userName) == DialogResult.OK)
            {

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DanhMucTaiKhoan_Load(sender, e);
        }
    }
}
