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

        #endregion
    }
}
