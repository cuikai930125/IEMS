using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSL_WEB_LOG - 基础表操作接口
    /// </summary>
    public interface ISslWebLogService : ITableViewService<SslWebLog>
    {
    }

    /// <summary>
    /// SSL_WEB_LOG - 基础表操作类
    /// </summary>
    internal class SslWebLogService : TableViewService<SslWebLog>, ISslWebLogService
    {
        #region 构造方法
        public SslWebLogService() : base() { }
        public SslWebLogService(string dbName) : base(dbName) { }
        #endregion
    }
}