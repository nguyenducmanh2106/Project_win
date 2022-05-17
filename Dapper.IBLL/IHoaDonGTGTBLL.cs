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
    public interface IHoaDonGTGTBLL
    {
        #region CRUD

        bool Insert(HoaDonGTGT model,CTHDGTGT modelChiTiet);

        bool Update(HoaDonGTGT model);

        bool Delete(HoaDonGTGT model);

        bool Delete(int id);

        IList<HoaDonGTGTModel> GetList(CoreModel obj);

        HoaDonGTGTModel GetEntity(string code);

        #endregion
    }
}
