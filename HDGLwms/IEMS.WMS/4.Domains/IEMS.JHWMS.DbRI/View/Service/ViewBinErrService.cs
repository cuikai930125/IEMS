using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// VIEW_BIN_ERR - 基础表操作接口
    /// </summary>
    public interface IViewBinErrService : ITableViewService<ViewBinErr>
    {
    }

    /// <summary>
    /// VIEW_BIN_ERR - 基础表操作类
    /// </summary>
    internal class ViewBinErrService : TableViewService<ViewBinErr>, IViewBinErrService
    {
        #region 构造方法
        public ViewBinErrService() : base() { }
        public ViewBinErrService(string dbName) : base(dbName) { }
        #endregion
    }
}