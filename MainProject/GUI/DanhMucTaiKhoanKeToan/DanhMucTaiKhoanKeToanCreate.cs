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
    public partial class DanhMucTaiKhoanKeToanCreate : Form
    {
        private readonly DanhMucTaiKhoanBLL bll = new DanhMucTaiKhoanBLL();
        public DanhMucTaiKhoanKeToanCreate()
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
                if (string.IsNullOrEmpty(this.MATK.Text) || string.IsNullOrEmpty(this.TENTK.Text))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
                }
                else
                {
                    DanhMucTaiKhoanKeToanModel model = new DanhMucTaiKhoanKeToanModel()
                    {
                        MATK = this.MATK.Text,
                        TENTK = this.TENTK.Text,
                        TKCT = !string.IsNullOrEmpty(this.TKCT.SelectedValue?.ToString()) ? Convert.ToInt32(this.TKCT.SelectedValue) : nullInt,
                        CAPTK = !string.IsNullOrEmpty(this.CAPTK.SelectedItem?.ToString()) ? Convert.ToInt32(this.CAPTK.SelectedItem) : nullInt,
                    };
                    bool result = bll.Insert(model);
                    if (result)
                    {
                        new ShowMessageBox().Success(String.Format(MessageConstants.InsertSuccessMessage, "tài khoản kế toán"));
                        this.Dispose(true);
                    }
                    else
                    {
                        new ShowMessageBox().Error(String.Format(MessageConstants.InsertErrorMessage, "tài khoản kế toán"));
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    new ShowMessageBox().Error("Tài khoản đã tồn tại");
                }
                else
                {
                    new ShowMessageBox().Error(ex.Message);
                }
            }
        }

        private void DanhMucTaiKhoanKeToanCreate_Load(object sender, EventArgs e)
        {
            var listTaiKhoan = bll.GetListActive(0);
            this.TKCT.DataSource = listTaiKhoan;
            this.TKCT.DisplayMember = "TENTK";
            this.TKCT.ValueMember = "ID";
            this.CAPTK.SelectedIndex = -1;
        }
    }
}
