using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

/*
 * create by 
 */

namespace Dapper.IDAL
{
    public interface IBaoCaoDAL
    {
        #region CRUD
        IDbConnection GetDbConnection();
        List<BaoCaoDoanhThuTheoKhachHangModel> GetBaoCaoDoanhThuTheoKhachHang(CoreModel obj);
        List<BaoCaoDoanhThuTheoHangHoaModel> GetBaoCaoDoanhThuTheoHangHoa(CoreModel obj);
        List<BaoCaoGiamTruDoanhThuModel> GetBaoCaoGiamTruDoanhThu(CoreModel obj);
        List<BaoCaoTongHopDoanhThuModel> GetBaoCaoTongHopDoanhThu(CoreModel obj);

        #endregion
    }
}
