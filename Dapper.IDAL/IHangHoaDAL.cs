using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by 
 */

namespace Dapper.IDAL
{
    public interface IHangHoaDAL
    {
        #region CRUD

        int Insert(HangHoa model);

        int Update(HangHoa model);

        int Delete(HangHoa model);

        int Delete(int id);

        IList<HangHoaModel> GetList(CoreModel obj);

        /// <summary>
        /// Lấy hàng hóa có số lượng > 0 (vẫn có hàng trong kho)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        IList<HangHoaModel> GetListCanUse(int id);

        HangHoaModel GetEntity(string code);
        HangHoaModel GetEntity(int id);

        #endregion
    }
}
