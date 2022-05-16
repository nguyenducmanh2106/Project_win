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
    public partial class NhaCungCapCreate : Form
    {
        private readonly NhaCungCapBLL bll = new NhaCungCapBLL();
        public NhaCungCapCreate()
        {
            InitializeComponent();
            this.MANCC.Text = "NCC";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.MANCC.Text) || string.IsNullOrEmpty(this.TENNCC.Text))
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
                    NhaCungCap model = new NhaCungCap()
                    {
                        MANCC = this.MANCC.Text,
                        TENNCC = this.TENNCC.Text,
                        DIACHI = this.DIACHI.Text,
                        SDT = this.SDT.Text,
                        EMAIL = this.EMAIL.Text,
                        NGUNGHOPTAC = Convert.ToBoolean(this.NGUNGHOPTAC.Checked)
                    };
                    bool result = bll.Insert(model);
                    if (result)
                    {
                        new ShowMessageBox().Success(String.Format(MessageConstants.InsertSuccessMessage, "nhà cung cấp"));
                        this.Dispose(true);
                    }
                    else
                    {
                        new ShowMessageBox().Error(String.Format(MessageConstants.InsertErrorMessage, "nhà cung cấp"));
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    new ShowMessageBox().Error("Mã nhà cung cấp đã tồn tại");
                }
                else
                {
                    new ShowMessageBox().Error(ex.Message);
                }
            }
        }
    }
}
