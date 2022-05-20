using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by 
 */

namespace Dapper.IBLL
{
    public interface IPhieuGiamGiaBLL
    {
        #region CRUD

        bool Insert(PhieuGiamGiaModel model, List<CTPGG> modelChiTiet);

        bool Update(PhieuGiamGiaModel model, List<CTPGG> modelChiTiet);

        bool Delete(PhieuGiamGiaModel model);

        bool Delete(int id);

        IList<PhieuGiamGiaModel> GetList(CoreModel obj);

        PhieuGiamGiaDetail GetEntity(string code);
        PhieuGiamGiaDetail GetEntity(int id);

        #endregion
    }
}
