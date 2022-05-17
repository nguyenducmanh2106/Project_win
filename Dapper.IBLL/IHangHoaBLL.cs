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
    public interface IHangHoaBLL
    {
        #region CRUD

        bool Insert(HangHoa book);

        bool Update(HangHoa book);

        bool Delete(HangHoa book);

        bool Delete(int id);

        IList<HangHoaModel> GetList(CoreModel obj);

        HangHoaModel GetEntity(string code);

        /// <summary>
        /// Lấy hàng hóa có số lượng > 0 (vẫn có hàng trong kho)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        IList<HangHoaModel> GetListCanUse();

        #endregion
    }
}
