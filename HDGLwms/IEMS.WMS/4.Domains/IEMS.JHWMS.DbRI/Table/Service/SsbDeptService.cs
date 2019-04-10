using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSB_DEPT - 基础表操作接口
    /// </summary>
    public interface ISsbDeptService : ITableViewService<SsbDept>
    {
    }

    /// <summary>
    /// SSB_DEPT - 基础表操作类
    /// </summary>
    internal class SsbDeptService : TableViewService<SsbDept>, ISsbDeptService
    {
        #region 构造方法
        public SsbDeptService() : base() { }
        public SsbDeptService(string dbName) : base(dbName) { }
        #endregion
    }
}