using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PROC_PAGE_MENU_ACTION_ALL [PROC_PAGE_MENU_ACTION_ALL] - 实体类
    /// </summary>
    [Entity(TableName = "PROC_PAGE_MENU_ACTION_ALL", Description = "PROC_PAGE_MENU_ACTION_ALL")]
    public class ProcPageMenuActionAll : BaseEntity
    {
        /// <summary>
        /// 存储过程返回 DataSet 数据
        /// </summary>
        public DataSet ProcedureDataSetResult { get; set; }
    }
}
