using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by ndmanh
 */

namespace Dapper.Model
{
    public class DanhMucTaiKhoanKeToanModel
    {
        public DanhMucTaiKhoanKeToanModel()
        {
            //Reviews = new List<BookReview>();
        }
        public int ID { get; set; }

        public string MATK { get; set; }
        public string TENTK { get; set; }
        public int? CAPTK { get; set; }
        public int? TKCT { get; set; }

        public string TKCT_TEXT { get; set; }
    }
}
