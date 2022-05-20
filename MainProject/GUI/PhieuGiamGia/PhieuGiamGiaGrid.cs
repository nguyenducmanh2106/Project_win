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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANXE
{
    public partial class PhieuGiamGiaList : Form
    {
        private readonly PhieuGiamGiaBLL bll = new PhieuGiamGiaBLL();
        private PhieuGiamGiaModel recordEdit = null;
        public PhieuGiamGiaList()
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


        private void CreateButton_Click(object sender, EventArgs e)
        {
            PhieuGiamGiaCreate frame = new PhieuGiamGiaCreate();
            frame.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (recordEdit == null)
            {
                new ShowMessageBox().Warning("Chưa chọn bản ghi");
                return;
            }

            PhieuGiamGiaUpdate frame = new PhieuGiamGiaUpdate();
            frame.ID.Text = recordEdit.ID.ToString();
            frame.Show();
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.inputSearch.Text = null;
            recordEdit = null;
            Frame_Load(sender, e);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridView.CurrentCell.RowIndex;
            recordEdit = new PhieuGiamGiaModel();
            recordEdit.SOHD = gridView.Rows[index].Cells["SOHD"].Value.ToString();
            recordEdit.ID = Convert.ToInt32(gridView.Rows[index].Cells["ID"].Value);
        }

        private DialogResult Show(string title, string name)
        {
            Form form = new Form();
            Label userNameLabel = new Label();

            TextBox userNameTextBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            userNameLabel.Text = $"Bạn có muốn xóa: {name} ?";

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
            string name = recordEdit.SOHD;
            if (Show("Xóa Phiếu giảm giá", name) == DialogResult.OK)
            {
                var result = bll.Delete(recordEdit.ID);
                if (result)
                {
                    new ShowMessageBox().Success(String.Format(MessageConstants.DeletetSuccessMessage, "phiếu giảm giá"));
                    Frame_Load(sender, e);
                }
                else
                {
                    new ShowMessageBox().Error(String.Format(MessageConstants.DeleteErrorMessage, "phiếu giảm giá"));
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Frame_Load(sender, e);
        }

        private void Frame_Load(object sender, EventArgs e)
        {
            CoreModel obj = new CoreModel();
            obj.CustomData = new Dictionary<string, object>();
            obj.CustomData.Add("TextSearch", this.inputSearch.Text);
            var data = bll.GetList(obj);

            this.gridView.AutoGenerateColumns = false;
            //set height cho hàng
            gridView.RowTemplate.Height = 50;
            //binding data
            gridView.DataSource = data;
            //cbbMaSP.DataSource = bll.getMaSP();
            //cbbMaSP.DisplayMember = "MaSP";
            //cbbMaSP.ValueMember = "MaSP";
        }
    }
}
