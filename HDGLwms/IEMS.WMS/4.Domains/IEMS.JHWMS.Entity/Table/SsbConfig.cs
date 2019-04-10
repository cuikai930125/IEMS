using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSB_CONFIG [SSB_CONFIG] - 实体类
    /// </summary>
    [Entity(TableName = "SSB_CONFIG", Description = "SSB_CONFIG")]
    public class SsbConfig : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "OBJID", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = true, Nullable = false)]
        public decimal? ObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CONFIG_KEY", Description = "",
               DbType = "varchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ConfigKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CONFIG_VALUE", Description = "",
               DbType = "varchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ConfigValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "DELETE_FLAG", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? DeleteFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "RECORD_USER_ID", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? RecordUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "RECORD_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? RecordTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BAKUP_FLAG", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? BakupFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BAKUP_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? BakupTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REMARK", Description = "",
               DbType = "varchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Remark { get; set; }
    }
}
