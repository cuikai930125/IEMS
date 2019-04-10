using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSP_ROLE [SSP_ROLE] - 实体类
    /// </summary>
    [Entity(TableName = "SSP_ROLE", Description = "SSP_ROLE")]
    public class SspRole : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "OBJID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = true, Nullable = false)]
        public decimal? ObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ROLE_NAME", Description = "",
               DbType = "nvarchar(1000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string RoleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REMARK", Description = "",
               DbType = "nvarchar(1000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "RECORD_USER_ID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
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
        [Field(FieldName = "SEQ_INDEX", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? SeqIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "DELETE_FLAG", Description = "",
               DbType = "decimal(5)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? DeleteFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BAKUP_FLAG", Description = "",
               DbType = "decimal(5)", DefaultValue = "",
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
        [Field(FieldName = "FOREIGN_NO", Description = "",
               DbType = "nvarchar(1000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ForeignNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BACKUP_FLAG", Description = "",
               DbType = "decimal(5)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? BackupFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BACKUP_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? BackupTime { get; set; }
    }
}
