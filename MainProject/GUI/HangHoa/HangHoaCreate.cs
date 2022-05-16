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
    public partial class HangHoaCreate : Form
    {
        private readonly HangHoaBLL bll = new HangHoaBLL();
        public HangHoaCreate()
        {
            InitializeComponent();
            this.MAHH.Text = "MAKH";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.MAHH.Text) || string.IsNullOrEmpty(this.TENHH.Text) || string.IsNullOrEmpty(this.NGAYDANGKY.Text))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
                }
                else
                {
                    //if (!CustomValidate.IsValidEmail(this.EMAIL.Text))
                    //{
                    //    new ShowMessageBox().Error("Chưa đúng định dạng email");
                    //    return;
                    //}
                    //if (!CustomValidate.IsPhoneNumber(this.SDT.Text))
                    //{
                    //    new ShowMessageBox().Error("Chưa đúng định dạng số điện thoại");
                    //    return;
                    //}
                    //if (!CustomValidate.IsValidTaxCode(this.MST.Text))
                    //{
                    //    new ShowMessageBox().Error("Chưa đúng định dạng mã số thuê");
                    //    return;
                    //}
                    HangHoa model = new HangHoa()
                    {
                        MAHH = this.MAHH.Text,
                        TENHH = this.TENHH.Text,
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

        private void KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right)
                || (e.KeyCode == Keys.Left)
                || (e.KeyCode == Keys.Up)
                || (e.KeyCode == Keys.Down))
            {
                // Do nothing
            }
            else
            {
                if (e.KeyValue >= 48 && e.KeyValue <= 57 || e.KeyValue == 46)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        string[] strArr = textBox1.Text.Split(',');
                        if (strArr != null && strArr.Length > 0)
                        {
                            textBox1.Text = strArr[0];
                        }
                        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
                        var valueBefore = decimal.Parse(textBox1.Text.Replace(".", ""), System.Globalization.NumberStyles.AllowThousands);
                        textBox1.Text = String.Format(culture, "{0:N0}", valueBefore);
                        textBox1.Select(textBox1.Text.Length, 0);
                    }
                }

            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CustomHandleEvent.TextboxLimit(e))
            {
                e.Handled = true;
            }
            e.Handled = false;
        }

    }
}
