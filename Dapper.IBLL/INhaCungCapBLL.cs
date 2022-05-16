using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by ndmanh 
 */

namespace Dapper.IBLL
{
    public interface INhaCungCapBLL
    {
        #region CRUD

        bool Insert(NhaCungCap book);

        bool Update(NhaCungCap book);

        bool Delete(NhaCungCap book);

        bool Delete(int id);

        IList<NhaCungCap> GetList(CoreModel obj);
        IList<NhaCungCap> GetListActive();

        #endregion
    }
}
