using Core.Constants;
using Core.Global;
using Dapper.BLL;
using Dapper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KETOANDOANHTHU
{
    public partial class DanhMucTaiKhoanBox : Form
    {
        private readonly UserBLL userBLL = new UserBLL();
        public DanhMucTaiKhoanBox()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? nullInt = null;
                if (string.IsNullOrEmpty(this.TENDANGNHAP.Text) || string.IsNullOrEmpty(this.TENTK.Text) || string.IsNullOrEmpty(this.MATKHAU.Text) || string.IsNullOrEmpty(this.CONFIRM_MATKHAU.Text))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
                }
                else
                {
                    if (this.MATKHAU.Text != this.CONFIRM_MATKHAU.Text)
                    {
                        new ShowMessageBox().Warning("Xác nhận mật khẩu chưa đúng");
                    }
                    else
                    {
                        DangNhap dangNhap = new DangNhap()
                        {
                            TENDANGNHAP = this.TENDANGNHAP.Text,
                            TENTK = this.TENTK.Text,
                            MATKHAU = this.MATKHAU.Text,
                            CAPTK = !string.IsNullOrEmpty(this.CAPTK.Text) ? Convert.ToInt32(this.CAPTK.Text) : nullInt,
                            TRANGTHAI = Convert.ToInt32(this.TRANGTHAI.Checked)
                        };
                        bool result = userBLL.Insert(dangNhap);
                        if (result)
                        {
                            new ShowMessageBox().Success(String.Format(MessageConstants.InsertSuccessMessage, "tài khoản"));
                            this.Dispose(true);
                        }
                        else
                        {
                            new ShowMessageBox().Error(String.Format(MessageConstants.InsertErrorMessage, "tài khoản"));
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                if(ex.Number == 2601)
                {
                    new ShowMessageBox().Error("Tài khoản đã tồn tại");
                }
                else
                {
                    new ShowMessageBox().Error(ex.Message);
                }
            }
        }
    }
}
