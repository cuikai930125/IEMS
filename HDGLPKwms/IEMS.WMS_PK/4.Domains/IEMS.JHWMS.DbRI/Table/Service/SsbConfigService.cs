using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSB_CONFIG - 基础表操作接口
    /// </summary>
    public interface ISsbConfigService : ITableViewService<SsbConfig>
    {
    }

    /// <summary>
    /// SSB_CONFIG - 基础表操作类
    /// </summary>
    internal class SsbConfigService : TableViewService<SsbConfig>, ISsbConfigService
    {
        #region 构造方法
        public SsbConfigService() : base() { }
        public SsbConfigService(string dbName) : base(dbName) { }
        #endregion
    }
}