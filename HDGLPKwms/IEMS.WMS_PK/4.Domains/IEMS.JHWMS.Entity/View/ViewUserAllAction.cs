using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// VIEW_USER_ALL_ACTION [VIEW_USER_ALL_ACTION] - 实体类
    /// </summary>
    [Entity(TableName = "VIEW_USER_ALL_ACTION", Description = "VIEW_USER_ALL_ACTION")]
    public class ViewUserAllAction : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "USER_ID", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACTION_ID", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? ActionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "M", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? M { get; set; }
    }
}
