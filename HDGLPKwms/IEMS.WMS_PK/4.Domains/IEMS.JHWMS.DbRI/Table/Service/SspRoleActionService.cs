using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSP_ROLE_ACTION - 基础表操作接口
    /// </summary>
    public interface ISspRoleActionService : ITableViewService<SspRoleAction>
    {
    }

    /// <summary>
    /// SSP_ROLE_ACTION - 基础表操作类
    /// </summary>
    internal class SspRoleActionService : TableViewService<SspRoleAction>, ISspRoleActionService
    {
        #region 构造方法
        public SspRoleActionService() : base() { }
        public SspRoleActionService(string dbName) : base(dbName) { }
        #endregion
    }
}