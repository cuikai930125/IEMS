using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PEM_CRN_FORK_STATUS - 基础表操作接口
    /// </summary>
    public interface IPemCrnForkStatusService : ITableViewService<PemCrnForkStatus>
    {
    }

    /// <summary>
    /// PEM_CRN_FORK_STATUS - 基础表操作类
    /// </summary>
    internal class PemCrnForkStatusService : TableViewService<PemCrnForkStatus>, IPemCrnForkStatusService
    {
        #region 构造方法
        public PemCrnForkStatusService() : base() { }
        public PemCrnForkStatusService(string dbName) : base(dbName) { }
        #endregion
    }
}