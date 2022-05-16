using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Model
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public string MST { get; set; }// mã số thuế
        public DateTime NGAYDANGKY { get; set; }// ngày đăng ký
    }
}
