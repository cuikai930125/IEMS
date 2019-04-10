using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// WBS_ORDER - 基础表操作接口
    /// </summary>
    public interface IWbsOrderService : ITableViewService<WbsOrder>
    {
    }

    /// <summary>
    /// WBS_ORDER - 基础表操作类
    /// </summary>
    internal class WbsOrderService : TableViewService<WbsOrder>, IWbsOrderService
    {
        #region 构造方法
        public WbsOrderService() : base() { }
        public WbsOrderService(string dbName) : base(dbName) { }
        #endregion
    }
}