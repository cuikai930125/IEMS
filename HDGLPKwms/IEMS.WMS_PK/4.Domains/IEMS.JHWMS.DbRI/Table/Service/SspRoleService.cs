using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSP_ROLE - 基础表操作接口
    /// </summary>
    public interface ISspRoleService : ITableViewService<SspRole>
    {
    }

    /// <summary>
    /// SSP_ROLE - 基础表操作类
    /// </summary>
    internal class SspRoleService : TableViewService<SspRole>, ISspRoleService
    {
        #region 构造方法
        public SspRoleService() : base() { }
        public SspRoleService(string dbName) : base(dbName) { }
        #endregion
    }
}