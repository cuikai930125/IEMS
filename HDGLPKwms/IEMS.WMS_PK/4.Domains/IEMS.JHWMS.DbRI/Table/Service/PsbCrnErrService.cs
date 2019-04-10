using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PSB_CRN_ERR - 基础表操作接口
    /// </summary>
    public interface IPsbCrnErrService : ITableViewService<PsbCrnErr>
    {
    }

    /// <summary>
    /// PSB_CRN_ERR - 基础表操作类
    /// </summary>
    internal class PsbCrnErrService : TableViewService<PsbCrnErr>, IPsbCrnErrService
    {
        #region 构造方法
        public PsbCrnErrService() : base() { }
        public PsbCrnErrService(string dbName) : base(dbName) { }
        #endregion
    }
}