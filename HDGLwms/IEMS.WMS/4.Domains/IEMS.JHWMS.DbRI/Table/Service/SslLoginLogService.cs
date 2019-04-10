using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSL_LOGIN_LOG - 基础表操作接口
    /// </summary>
    public interface ISslLoginLogService : ITableViewService<SslLoginLog>
    {
    }

    /// <summary>
    /// SSL_LOGIN_LOG - 基础表操作类
    /// </summary>
    internal class SslLoginLogService : TableViewService<SslLoginLog>, ISslLoginLogService
    {
        #region 构造方法
        public SslLoginLogService() : base() { }
        public SslLoginLogService(string dbName) : base(dbName) { }
        #endregion
    }
}