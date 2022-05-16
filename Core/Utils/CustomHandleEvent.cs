using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Utils
{
    public static class CustomHandleEvent
    {
        public static bool TextboxLimit(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && !char.IsDigit(ch))
            {
                e.Handled = true;
                return false;

            }
            else return true;
        }
    }
}
