using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PROC_PAGE_MENU_USER [PROC_PAGE_MENU_USER] - 实体类
    /// </summary>
    [Entity(TableName = "PROC_PAGE_MENU_USER", Description = "PROC_PAGE_MENU_USER")]
    public class ProcPageMenuUser : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "UserID", Description = "", DbType = "decimal(13)")]
        public decimal? Userid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "MenuLevel", Description = "", DbType = "varchar(100)")]
        public string Menulevel { get; set; }
        /// <summary>
        /// 存储过程返回 DataSet 数据
        /// </summary>
        public DataSet ProcedureDataSetResult { get; set; }
    }
}
