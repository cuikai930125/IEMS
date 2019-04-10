using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PSB_LOC - 基础表操作接口
    /// </summary>
    public interface IPsbLocService : ITableViewService<PsbLoc>
    {
    }

    /// <summary>
    /// PSB_LOC - 基础表操作类
    /// </summary>
    internal class PsbLocService : TableViewService<PsbLoc>, IPsbLocService
    {
        #region 构造方法
        public PsbLocService() : base() { }
        public PsbLocService(string dbName) : base(dbName) { }
        #endregion
    }
}