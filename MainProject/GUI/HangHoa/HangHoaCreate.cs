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
        private readonly NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
        public HangHoaCreate()
        {
            InitializeComponent();
            this.MAHH.Text = "MAHH";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.MAHH.Text) || string.IsNullOrEmpty(this.TENHH.Text))
                {
                    new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
                }
                else
                {
                    int? nullInt = null;
                    decimal? nullDec = null;
                    HangHoa model = new HangHoa()
                    {
                        MAHH = this.MAHH.Text,
                        TENHH = this.TENHH.Text,
                        DVT = this.DVT.Text,
                        //NhaCungCapID = this.MANCC.SelectedValue != null ? Convert.ToInt32(this.MANCC.SelectedValue) : nullInt,
                        //SOLUONG = Convert.ToInt32(this.SOLUONG.Value),
                        //GIAXUAT = !string.IsNullOrEmpty(this.GIAXUAT.Text) ? Convert.ToDecimal(this.GIAXUAT.Text) : nullDec,
                        //GIANHAP = !string.IsNullOrEmpty(this.GIANHAP.Text) ? Convert.ToDecimal(this.GIANHAP.Text) : nullDec,
                        HINHANH = CustomConvert.ImageToByteArray(this.HINHANH.Image)
                    };
                    bool result = bll.Insert(model);
                    if (result)
                    {
                        new ShowMessageBox().Success(String.Format(MessageConstants.InsertSuccessMessage, "hàng hóa"));
                        this.Dispose(true);
                    }
                    else
                    {
                        new ShowMessageBox().Error(String.Format(MessageConstants.InsertErrorMessage, "hàng hóa"));
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    new ShowMessageBox().Error("Mã hàng hóa đã tồn tại");
                }
                else
                {
                    new ShowMessageBox().Error(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                //if (!string.IsNullOrEmpty(GIAXUAT.Text))
                //{
                //    string[] strArr = GIAXUAT.Text.Split(',');
                //    if (strArr != null && strArr.Length > 0)
                //    {
                //        GIAXUAT.Text = strArr[0];
                //    }
                //    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
                //    var valueBefore = decimal.Parse(GIAXUAT.Text.Replace(".", ""), System.Globalization.NumberStyles.AllowThousands);
                //    GIAXUAT.Text = String.Format(culture, "{0:N0}", valueBefore);
                //    GIAXUAT.Select(GIAXUAT.Text.Length, 0);
                //}

            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CustomHandleEvent.TextboxContainNumber(e))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void KeyUpGIANHAP(object sender, KeyEventArgs e)
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
                //if (!string.IsNullOrEmpty(GIANHAP.Text))
                //{
                //    string[] strArr = GIANHAP.Text.Split(',');
                //    if (strArr != null && strArr.Length > 0)
                //    {
                //        GIANHAP.Text = strArr[0];
                //    }
                //    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
                //    var valueBefore = decimal.Parse(GIANHAP.Text.Replace(".", ""), System.Globalization.NumberStyles.AllowThousands);
                //    GIANHAP.Text = String.Format(culture, "{0:N0}", valueBefore);
                //    GIANHAP.Select(GIANHAP.Text.Length, 0);
                //}

            }
        }

        private void HangHoaCreate_Load(object sender, EventArgs e)
        {
            //MANCC.DataSource = nhaCungCapBLL.GetListActive();
            //MANCC.DisplayMember = "MANCC";
            //MANCC.ValueMember = "ID";
            //MANCC.SelectedIndex = -1;
        }

        private void HINHANH_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                HINHANH.Image = new Bitmap(opnfd.FileName);
                HINHANH.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
