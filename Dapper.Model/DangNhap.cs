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
    public class DangNhap
    {
        public DangNhap()
        {
            //Reviews = new List<BookReview>();
        }
        public int ID { get; set; }

        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string MATK { get; set; }// mã tài khoản
        public int? CAPTK { get; set; }// cấp tài khoản
        public int? TKCT { get; set; }// tài khoản cấp trên
        public string FullName { get; set; }// họ tên

        //public virtual List<BookReview> Reviews { get; set; }

        //public override string ToString()
        //{
        //    return string.Format("[{0}]------《{1}》", Id, Name);
        //}
    }

    //public class BookMapper : ClassMapper<Book>
    //{
    //    public BookMapper()
    //    {
    //        Table("Books");
    //        Map(b => b.Reviews).Ignore();
    //        AutoMap();
    //    }
    //}
}
