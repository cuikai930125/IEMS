using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// SSB_PARAMETER - 基础表操作接口
    /// </summary>
    public interface ISsbParameterService : ITableViewService<SsbParameter>
    {
    }

    /// <summary>
    /// SSB_PARAMETER - 基础表操作类
    /// </summary>
    internal class SsbParameterService : TableViewService<SsbParameter>, ISsbParameterService
    {
        #region 构造方法
        public SsbParameterService() : base() { }
        public SsbParameterService(string dbName) : base(dbName) { }
        #endregion
    }
}