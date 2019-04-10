using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// Z50_WBS_TASK - 基础表操作接口
    /// </summary>
    public interface IZ50WbsTaskService : ITableViewService<Z50WbsTask>
    {
    }

    /// <summary>
    /// Z50_WBS_TASK - 基础表操作类
    /// </summary>
    internal class Z50WbsTaskService : TableViewService<Z50WbsTask>, IZ50WbsTaskService
    {
        #region 构造方法
        public Z50WbsTaskService() : base() { }
        public Z50WbsTaskService(string dbName) : base(dbName) { }
        #endregion
    }
}