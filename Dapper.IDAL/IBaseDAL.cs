﻿using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by
 */

namespace Dapper.IDAL
{
    public interface IBaseDAL
    {
        #region CRUD

        T GenerationCode<T>(string tableName);
        #endregion
    }
}
