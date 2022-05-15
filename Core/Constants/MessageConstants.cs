using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Constants
{
    public static class MessageConstants
    {
        public const string ErrorLoginMessage = "Mật khẩu hoặc tài khoản không chính xác";
        public const string UpdateSuccessMessage = "Cập nhật {0} thành công";
        public const string UpdateErrorMessage = "Cập nhật {0} thất bại";

        public const string InsertSuccessMessage = "Thêm mới {0} thành công";
        public const string InsertErrorMessage = "Thêm mới {0} thất bại";

        public const string DeletetSuccessMessage = "Xóa {0} thành công";
        public const string DeleteErrorMessage = "Xóa {0} thất bại";
    }
}
