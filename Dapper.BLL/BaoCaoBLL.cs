using Dapper.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Model;
using Dapper.IDAL;
using Dapper.Factory;
using System.Data;

/*
 * create by
 */

namespace Dapper.BLL
{
    public class BaoCaoBLL : IBaoCaoBLL
    {
        private static readonly IBaoCaoDAL dal = DALFactory.CreateBaoCaoDAL();

        public List<BaoCaoDoanhThuTheoHangHoaModel> GetBaoCaoDoanhThuTheoHangHoa(CoreModel obj)
        {
            return dal.GetBaoCaoDoanhThuTheoHangHoa(obj);
        }

        public List<BaoCaoDoanhThuTheoKhachHangModel> GetBaoCaoDoanhThuTheoKhachHang(CoreModel obj)
        {
            return dal.GetBaoCaoDoanhThuTheoKhachHang(obj);
        }

        public List<BaoCaoGiamTruDoanhThuModel> GetBaoCaoGiamTruDoanhThu(CoreModel obj)
        {
            return dal.GetBaoCaoGiamTruDoanhThu(obj);
        }

        public List<BaoCaoTongHopDoanhThuModel> GetBaoCaoTongHopDoanhThu(CoreModel obj)
        {
            return dal.GetBaoCaoTongHopDoanhThu(obj);
        }
    }
}
