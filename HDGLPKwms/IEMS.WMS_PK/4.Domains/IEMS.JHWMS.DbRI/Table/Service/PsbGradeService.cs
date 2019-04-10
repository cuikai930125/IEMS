using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PSB_GRADE - 基础表操作接口
    /// </summary>
    public interface IPsbGradeService : ITableViewService<PsbGrade>
    {
    }

    /// <summary>
    /// PSB_GRADE - 基础表操作类
    /// </summary>
    internal class PsbGradeService : TableViewService<PsbGrade>, IPsbGradeService
    {
        #region 构造方法
        public PsbGradeService() : base() { }
        public PsbGradeService(string dbName) : base(dbName) { }
        #endregion
    }
}