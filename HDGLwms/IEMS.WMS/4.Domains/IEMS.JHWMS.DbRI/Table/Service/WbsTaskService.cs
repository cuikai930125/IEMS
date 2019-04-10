using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// WBS_TASK - 基础表操作接口
    /// </summary>
    public interface IWbsTaskService : ITableViewService<WbsTask>
    {
    }

    /// <summary>
    /// WBS_TASK - 基础表操作类
    /// </summary>
    internal class WbsTaskService : TableViewService<WbsTask>, IWbsTaskService
    {
        #region 构造方法
        public WbsTaskService() : base() { }
        public WbsTaskService(string dbName) : base(dbName) { }
        #endregion
    }
}