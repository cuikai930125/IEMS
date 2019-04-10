using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSP_PAGE_MENU - 基础表操作接口
    /// </summary>
    public interface ISspPageMenuService : ITableViewService<SspPageMenu>
    {
    }

    /// <summary>
    /// SSP_PAGE_MENU - 基础表操作类
    /// </summary>
    internal class SspPageMenuService : TableViewService<SspPageMenu>, ISspPageMenuService
    {
        #region 构造方法
        public SspPageMenuService() : base() { }
        public SspPageMenuService(string dbName) : base(dbName) { }
        #endregion
    }
}