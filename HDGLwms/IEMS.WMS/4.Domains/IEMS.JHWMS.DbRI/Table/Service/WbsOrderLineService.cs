using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// WBS_ORDER_LINE - 基础表操作接口
    /// </summary>
    public interface IWbsOrderLineService : ITableViewService<WbsOrderLine>
    {
    }

    /// <summary>
    /// WBS_ORDER_LINE - 基础表操作类
    /// </summary>
    internal class WbsOrderLineService : TableViewService<WbsOrderLine>, IWbsOrderLineService
    {
        #region 构造方法
        public WbsOrderLineService() : base() { }
        public WbsOrderLineService(string dbName) : base(dbName) { }
        #endregion
    }
}