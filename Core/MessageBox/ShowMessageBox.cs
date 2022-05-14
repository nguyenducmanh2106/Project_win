using Core.Constants;
using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Global
{
    public class ShowMessageBox: Form
    {
        public void Success(string message)
        {
            MessageBox.Show(message, TypeDialogConstants.SuccessTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void Error(string message)
        {
            MessageBox.Show(message, TypeDialogConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warning(string message)
        {
            MessageBox.Show(message, TypeDialogConstants.WarningTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
