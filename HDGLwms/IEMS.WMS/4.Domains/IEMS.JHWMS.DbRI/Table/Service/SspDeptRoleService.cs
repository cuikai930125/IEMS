using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSP_DEPT_ROLE - 基础表操作接口
    /// </summary>
    public interface ISspDeptRoleService : ITableViewService<SspDeptRole>
    {
    }

    /// <summary>
    /// SSP_DEPT_ROLE - 基础表操作类
    /// </summary>
    internal class SspDeptRoleService : TableViewService<SspDeptRole>, ISspDeptRoleService
    {
        #region 构造方法
        public SspDeptRoleService() : base() { }
        public SspDeptRoleService(string dbName) : base(dbName) { }
        #endregion
    }
}