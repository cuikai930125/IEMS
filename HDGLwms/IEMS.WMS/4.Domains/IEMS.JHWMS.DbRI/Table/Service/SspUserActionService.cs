using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSP_USER_ACTION - 基础表操作接口
    /// </summary>
    public interface ISspUserActionService : ITableViewService<SspUserAction>
    {
    }

    /// <summary>
    /// SSP_USER_ACTION - 基础表操作类
    /// </summary>
    internal class SspUserActionService : TableViewService<SspUserAction>, ISspUserActionService
    {
        #region 构造方法
        public SspUserActionService() : base() { }
        public SspUserActionService(string dbName) : base(dbName) { }
        #endregion
    }
}