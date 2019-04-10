using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// V_SSP_USER_ALL_ACTION - 基础表操作接口
    /// </summary>
    public interface IVSspUserAllActionService : ITableViewService<VSspUserAllAction>
    {
    }

    /// <summary>
    /// V_SSP_USER_ALL_ACTION - 基础表操作类
    /// </summary>
    internal class VSspUserAllActionService : TableViewService<VSspUserAllAction>, IVSspUserAllActionService
    {
        #region 构造方法
        public VSspUserAllActionService() : base() { }
        public VSspUserAllActionService(string dbName) : base(dbName) { }
        #endregion
    }
}