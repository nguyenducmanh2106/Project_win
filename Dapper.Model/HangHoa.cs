using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Dapper.Model
{
    public class HangHoa
    {
        public int ID { get; set; }
        public string MAHH { get; set; }
        public string TENHH { get; set; }
        public string DVT { get; set; }// đơn vị tính
        public int? NhaCungCapID { get; set; }// id của nhà cung cấp
        public int? SOLUONG { get; set; }
        public decimal? GIAXUAT { get; set; }
        public decimal? GIANHAP { get; set; }
        public byte[] HINHANH { get; set; }
    }

    public class HangHoaModel: HangHoa
    {
        public string MANCC { get; set; }
        //public dynamic IMAGE { get; set; }
    }

}
