using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// TPROC_0300_CMD_FINISH - 基础表操作接口
    /// </summary>
    public interface ITproc0300CmdFinishService : ITableViewService<Tproc0300CmdFinish>
    {
    }

    /// <summary>
    /// TPROC_0300_CMD_FINISH - 基础表操作类
    /// </summary>
    internal class Tproc0300CmdFinishService : TableViewService<Tproc0300CmdFinish>, ITproc0300CmdFinishService
    {
        #region 构造方法
        public Tproc0300CmdFinishService() : base() { }
        public Tproc0300CmdFinishService(string dbName) : base(dbName) { }
        #endregion
    }
}