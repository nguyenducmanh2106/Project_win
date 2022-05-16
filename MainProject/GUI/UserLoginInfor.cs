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
    public partial class UserLoginInfor : Form
    {
        private readonly DangNhap userLoginInfor = VariablesGlobal.Instance.UserLoginCurrent;
        private UserBLL _dangNhapBLL = new UserBLL();
        public UserLoginInfor()
        {
            InitializeComponent();
            this.TENDANGNHAP.Text = userLoginInfor?.TENDANGNHAP ?? "";
            this.TENTK.Text = userLoginInfor?.TENTK ?? "";
        }

        private void UpdateUserLogin_Click(object sender, EventArgs e)
        {
            string tenTk = this.TENTK.Text;
            DangNhap model = new DangNhap()
            {
                ID = userLoginInfor.ID,
                TENTK = tenTk,
            };

            bool result = _dangNhapBLL.UpdateUserLogin(model);
            if (result)
            {
                new ShowMessageBox().Success(string.Format(MessageConstants.UpdateSuccessMessage, "thông tin tài khoản"));
            }
            else
            {
                new ShowMessageBox().Error(string.Format(MessageConstants.UpdateErrorMessage, "thông tin tài khoản"));
            }
        }

        private void ChangePassWord_Click(object sender, EventArgs e)
        {
            string passWordOld;
            string passWordNew;
            string confirmPassword;

            if (Show("Đổi mật khẩu", out passWordOld, out passWordNew, out confirmPassword) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(passWordOld) || string.IsNullOrEmpty(passWordNew) || string.IsNullOrEmpty(confirmPassword))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc");
                }
                else
                {
                    if (passWordNew != confirmPassword)
                    {
                        new ShowMessageBox().Warning("Xác nhận mật khẩu chưa đúng");
                    }
                    else
                    {
                        DangNhap model = new DangNhap()
                        {
                            ID = userLoginInfor.ID,
                            MATKHAU = passWordNew,
                            OldPassWord = passWordOld
                        };
                        bool result = _dangNhapBLL.ChangePassWord(model);
                        if (result)
                        {
                            new ShowMessageBox().Success("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            new ShowMessageBox().Error("Đổi mật khẩu thất bại");
                        }
                    }

                }
            }
        }


        private DialogResult Show(string title, out string passWordOld, out string passWordNew, out string confirmPassword)
        {
            Form form = new Form();
            Label userNameLabel = new Label();
            Label userNameTextBox = new Label();
            Label passWordOldLabel = new Label();
            Label passWordNewLabel = new Label();
            Label passWordConfirmLabel = new Label();

            TextBox passWordOldTextBox = new TextBox();
            TextBox passWordNewTextBox = new TextBox();
            TextBox passWordConfirmTextBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            userNameLabel.Text = "Tên đăng nhập:";
            userNameTextBox.Text = userLoginInfor?.TENDANGNHAP ?? "";

            passWordOldLabel.Text = "Mật khẩu(*):";
            passWordNewLabel.Text = "Mật khẩu mới(*):";
            passWordConfirmLabel.Text = "Xác nhận mật khẩu(*):";
            //textBox.Text = value;

            userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passWordOldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passWordNewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passWordConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            passWordOldTextBox.PasswordChar = '•';
            passWordNewTextBox.PasswordChar = '•';
            passWordConfirmTextBox.PasswordChar = '•';

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            userNameLabel.SetBounds(9, 20, 20, 13);
            userNameTextBox.SetBounds(145, 20, 200, 20);

            passWordOldLabel.SetBounds(9, 50, 372, 13);
            passWordOldTextBox.SetBounds(12, 74, 372, 20);

            passWordNewLabel.SetBounds(9, 104, 372, 13);
            passWordNewTextBox.SetBounds(12, 128, 372, 20);

            passWordConfirmLabel.SetBounds(9, 158, 372, 13);
            passWordConfirmTextBox.SetBounds(12, 182, 372, 20);

            buttonOk.SetBounds(228, 222, 75, 23);
            buttonCancel.SetBounds(309, 222, 75, 23);

            userNameLabel.AutoSize = true;
            userNameTextBox.Anchor = userNameTextBox.Anchor | AnchorStyles.Right;

            passWordOldLabel.AutoSize = true;
            passWordOldTextBox.Anchor = userNameTextBox.Anchor | AnchorStyles.Right;

            passWordNewLabel.AutoSize = true;
            passWordNewTextBox.Anchor = passWordNewTextBox.Anchor | AnchorStyles.Right;

            passWordConfirmLabel.AutoSize = true;
            passWordConfirmTextBox.Anchor = passWordConfirmTextBox.Anchor | AnchorStyles.Right;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 300);
            form.Controls.AddRange(
                new Control[] { userNameLabel, userNameTextBox,
                    passWordOldLabel,passWordOldTextBox,
                    passWordNewLabel,passWordNewTextBox,
                    passWordConfirmLabel,passWordConfirmTextBox,
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
            passWordOld = passWordOldTextBox.Text;
            passWordNew = passWordNewTextBox.Text;
            confirmPassword = passWordConfirmTextBox.Text;
            return dialogResult;
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
            this.Dispose();
        }
    }
}
