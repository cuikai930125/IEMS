using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PSB_BIN_STATUS - 基础表操作接口
    /// </summary>
    public interface IPsbBinStatusService : ITableViewService<PsbBinStatus>
    {
    }

    /// <summary>
    /// PSB_BIN_STATUS - 基础表操作类
    /// </summary>
    internal class PsbBinStatusService : TableViewService<PsbBinStatus>, IPsbBinStatusService
    {
        #region 构造方法
        public PsbBinStatusService() : base() { }
        public PsbBinStatusService(string dbName) : base(dbName) { }
        #endregion
    }
}