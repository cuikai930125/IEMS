using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSB_USER - 基础表操作接口
    /// </summary>
    public interface ISsbUserService : ITableViewService<SsbUser>
    {
    }

    /// <summary>
    /// SSB_USER - 基础表操作类
    /// </summary>
    internal class SsbUserService : TableViewService<SsbUser>, ISsbUserService
    {
        #region 构造方法
        public SsbUserService() : base() { }
        public SsbUserService(string dbName) : base(dbName) { }
        #endregion
    }
}