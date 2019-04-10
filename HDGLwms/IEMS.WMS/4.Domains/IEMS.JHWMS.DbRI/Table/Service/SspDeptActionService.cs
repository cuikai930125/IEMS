using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSP_DEPT_ACTION - 基础表操作接口
    /// </summary>
    public interface ISspDeptActionService : ITableViewService<SspDeptAction>
    {
    }

    /// <summary>
    /// SSP_DEPT_ACTION - 基础表操作类
    /// </summary>
    internal class SspDeptActionService : TableViewService<SspDeptAction>, ISspDeptActionService
    {
        #region 构造方法
        public SspDeptActionService() : base() { }
        public SspDeptActionService(string dbName) : base(dbName) { }
        #endregion
    }
}