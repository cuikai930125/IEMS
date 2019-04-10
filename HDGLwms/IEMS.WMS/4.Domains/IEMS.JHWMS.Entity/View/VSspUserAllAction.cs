using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// V_SSP_USER_ALL_ACTION [V_SSP_USER_ALL_ACTION] - 实体类
    /// </summary>
    [Entity(TableName = "V_SSP_USER_ALL_ACTION", Description = "V_SSP_USER_ALL_ACTION")]
    public class VSspUserAllAction : BaseEntity
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [Field(FieldName = "USER_ID", Description = "用户编号",
               DbType = "NUMBER", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? UserId { get; set; }
        /// <summary>
        /// 功能编号
        /// </summary>
        [Field(FieldName = "ACTION_ID", Description = "功能编号",
               DbType = "NUMBER(20)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public long? ActionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "M", Description = "",
               DbType = "NUMBER", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? M { get; set; }
    }
}
