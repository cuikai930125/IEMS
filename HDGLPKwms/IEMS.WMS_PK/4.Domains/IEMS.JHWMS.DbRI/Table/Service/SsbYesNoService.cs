using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSB_YES_NO - 基础表操作接口
    /// </summary>
    public interface ISsbYesNoService : ITableViewService<SsbYesNo>
    {
    }

    /// <summary>
    /// SSB_YES_NO - 基础表操作类
    /// </summary>
    internal class SsbYesNoService : TableViewService<SsbYesNo>, ISsbYesNoService
    {
        #region 构造方法
        public SsbYesNoService() : base() { }
        public SsbYesNoService(string dbName) : base(dbName) { }
        #endregion
    }
}