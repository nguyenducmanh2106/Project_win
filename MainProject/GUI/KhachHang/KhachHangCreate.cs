using Core.Constants;
using Core.Global;
using Core.Utils;
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

namespace QLBANXE
{
    public partial class KhachHangCreate : Form
    {
        private readonly KhachHangBLL bll = new KhachHangBLL();
        public KhachHangCreate()
        {
            InitializeComponent();
            this.MAKH.Text = "MAKH";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.MAKH.Text) || string.IsNullOrEmpty(this.TENKH.Text)|| string.IsNullOrEmpty(this.NGAYDANGKY.Text))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
                }
                else
                {
                    if (!CustomValidate.IsValidEmail(this.EMAIL.Text))
                    {
                        new ShowMessageBox().Error("Chưa đúng định dạng email");
                        return;
                    }
                    if (!CustomValidate.IsPhoneNumber(this.SDT.Text))
                    {
                        new ShowMessageBox().Error("Chưa đúng định dạng số điện thoại");
                        return;
                    }
                    if (!CustomValidate.IsValidTaxCode(this.MST.Text))
                    {
                        new ShowMessageBox().Error("Chưa đúng định dạng mã số thuê");
                        return;
                    }
                    KhachHang model = new KhachHang()
                    {
                        MAKH = this.MAKH.Text,
                        TENKH = this.TENKH.Text,
                        DIACHI = this.DIACHI.Text,
                        SDT = this.SDT.Text,
                        EMAIL = this.EMAIL.Text,
                        MST = this.MST.Text,
                        NGAYDANGKY = Convert.ToDateTime(this.NGAYDANGKY.Value),
                    };
                    bool result = bll.Insert(model);
                    if (result)
                    {
                        new ShowMessageBox().Success(String.Format(MessageConstants.InsertSuccessMessage, "khách hàng"));
                        this.Dispose(true);
                    }
                    else
                    {
                        new ShowMessageBox().Error(String.Format(MessageConstants.InsertErrorMessage, "khách hàng"));
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    new ShowMessageBox().Error("Mã khách hàng đã tồn tại");
                }
                else
                {
                    new ShowMessageBox().Error(ex.Message);
                }
            }
        }
    }
}
