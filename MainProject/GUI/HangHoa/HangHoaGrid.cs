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
    public partial class HangHoaList : Form
    {
        private readonly HangHoaBLL bll = new HangHoaBLL();
        private HangHoa recordEdit = null;
        public HangHoaList()
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
            HangHoaCreate frame = new HangHoaCreate();
            frame.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (recordEdit == null)
            {
                new ShowMessageBox().Warning("Chưa chọn bản ghi");
                return;
            }

            HangHoaUpdate frame = new HangHoaUpdate();
            //frame.MAKH.Text = recordEdit.MAKH;
            //frame.TENKH.Text = recordEdit.TENKH;
            //frame.DIACHI.Text = recordEdit.DIACHI;
            //frame.SDT.Text = recordEdit.SDT;
            //frame.EMAIL.Text = recordEdit.EMAIL;
            //frame.MST.Text = recordEdit.MST;
            //frame.NGAYDANGKY.Value = recordEdit.NGAYDANGKY;
            frame.MAHH.Text = recordEdit.MAHH.ToString();
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
            recordEdit = new HangHoa();
            recordEdit.MAHH = gridView.Rows[index].Cells["MAHH"].Value.ToString();
            recordEdit.TENHH = gridView.Rows[index].Cells["TENHH"].Value.ToString();
            //recordEdit.DVT = gridView.Rows[index].Cells["DVT"].Value?.ToString();
            //recordEdit.NhaCungCapID = Convert.ToInt32(gridView.Rows[index].Cells["NhaCungCapID"].Value);
            //recordEdit.SOLUONG = Convert.ToInt32(gridView.Rows[index].Cells["SOLUONG"].Value);
            //recordEdit.GIANHAP = Convert.ToDecimal(gridView.Rows[index].Cells["GIANHAP"].Value);
            //recordEdit.GIAXUAT = Convert.ToDecimal(gridView.Rows[index].Cells["GIAXUAT"].Value);
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
            string name = recordEdit.TENHH;
            if (Show("Xóa hàng hóa", name) == DialogResult.OK)
            {
                var result = bll.Delete(recordEdit.ID);
                if (result)
                {
                    new ShowMessageBox().Success(String.Format(MessageConstants.DeletetSuccessMessage, "hàng hóa"));
                    Frame_Load(sender, e);
                }
                else
                {
                    new ShowMessageBox().Error(String.Format(MessageConstants.DeleteErrorMessage, "hàng hóa"));
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

            //set height cho hàng
            gridView.RowTemplate.Height = 70;
            gridView.AutoGenerateColumns = false;
            //((DataGridViewImageColumn)this.gridView.Columns["HINHANH"]).DefaultCellStyle.NullValue = null;
            //binding data
            gridView.DataSource = data;

            gridView.AutoGenerateColumns = false;
        }
    }
}
