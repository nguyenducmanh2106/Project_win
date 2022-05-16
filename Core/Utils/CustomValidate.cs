using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class CustomValidate
    {

        /// <summary>
        /// Custom Validate email
        /// </summary>
        /// <param name="email">Tên email check</param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return true;
            var trimmedEmail = email.Trim();


            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// custom validate phone number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPhoneNumber(string number)
        {
            if(string.IsNullOrEmpty(number)) return true;
            return Regex.Match(number, @"^[0-9]{10}$").Success;
        }

        /// <summary>
        /// custom validate mã số thuế
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsValidTaxCode(string number)
        {
            if (string.IsNullOrEmpty(number)) return true;
            return Regex.Match(number, @"^[0-9]{10}$").Success;
        }
    }
}
