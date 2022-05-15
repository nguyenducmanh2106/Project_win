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
    public partial class NhaCungCapUpdate : Form
    {
        private readonly NhaCungCapBLL bll = new NhaCungCapBLL();
        public NhaCungCapUpdate()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.MANCC.Text) || string.IsNullOrEmpty(this.TENNCC.Text))
            {
                new ShowMessageBox().Warning("Không được để trống trường bắt buộc!");
            }
            else
            {
                NhaCungCap model = new NhaCungCap()
                {
                    MANCC = this.MANCC.Text,
                    TENNCC = this.TENNCC.Text,
                    DIACHI = this.DIACHI.Text,
                    SDT = this.SDT.Text,
                    EMAIL = this.EMAIL.Text,
                    NGUNGHOPTAC = Convert.ToBoolean(this.NGUNGHOPTAC.Checked)
                };
                bool result = bll.Update(model);
                if (result)
                {
                    new ShowMessageBox().Success(String.Format(MessageConstants.UpdateSuccessMessage, "nhà cung cấp"));
                    this.Dispose(true);
                }
                else
                {
                    new ShowMessageBox().Error(String.Format(MessageConstants.UpdateErrorMessage, "cung cấp"));
                }
            }
        }
    }
}
