using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSP_USER_ROLE - 基础表操作接口
    /// </summary>
    public interface ISspUserRoleService : ITableViewService<SspUserRole>
    {
    }

    /// <summary>
    /// SSP_USER_ROLE - 基础表操作类
    /// </summary>
    internal class SspUserRoleService : TableViewService<SspUserRole>, ISspUserRoleService
    {
        #region 构造方法
        public SspUserRoleService() : base() { }
        public SspUserRoleService(string dbName) : base(dbName) { }
        #endregion
    }
}