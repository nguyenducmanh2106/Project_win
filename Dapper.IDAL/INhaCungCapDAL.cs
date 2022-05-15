using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.IDAL
{
    public interface INhaCungCapDAL
    {
        #region CRUD

        int Insert(NhaCungCap model);

        int Update(NhaCungCap model);

        int Delete(NhaCungCap model);

        int Delete(int id);

        IList<NhaCungCap> GetList(CoreModel obj);

        #endregion
    }
}
