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
    public partial class DanhMucTaiKhoanKeToanUpdate : Form
    {
        private readonly DanhMucTaiKhoanBLL bll = new DanhMucTaiKhoanBLL();
        public DanhMucTaiKhoanKeToanUpdate()
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
                    DanhMucTaiKhoanKeToanModel dangNhap = new DanhMucTaiKhoanKeToanModel()
                    {
                        ID = Convert.ToInt32(this.ID.Text),
                        MATK = this.MATK.Text,
                        TENTK = this.TENTK.Text,
                        CAPTK = !string.IsNullOrEmpty(this.CAPTK.SelectedItem?.ToString()) ? Convert.ToInt32(this.CAPTK.SelectedItem) : nullInt,
                        TKCT = Convert.ToInt32(this.TKCT.SelectedValue)
                    };
                    bool result = bll.Update(dangNhap);
                    if (result)
                    {
                        new ShowMessageBox().Success(String.Format(MessageConstants.UpdateSuccessMessage, "tài khoản"));
                        this.Dispose(true);

                    }
                    else
                    {
                        new ShowMessageBox().Error(String.Format(MessageConstants.UpdateErrorMessage, "tài khoản"));
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

        private void DanhMucTaiKhoanKeToanUpdate_Load(object sender, EventArgs e)
        {
            int id = 0;
            Int32.TryParse(this.ID.Text, out id);

            var listTaiKhoan = bll.GetListActive(id);
            this.TKCT.DataSource = listTaiKhoan;
            this.TKCT.DisplayMember = "TENTK";
            this.TKCT.ValueMember = "ID";
            this.TKCT.SelectedIndex = -1;

            var editRecord = bll.GetEntity(id);
            this.MATK.Text = editRecord?.MATK;
            this.TENTK.Text = editRecord?.TENTK;
            this.CAPTK.SelectedItem = editRecord?.CAPTK?.ToString();
            this.TKCT.SelectedValue = editRecord?.TKCT ?? -1;
        }
    }
}
