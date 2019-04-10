using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSB_YES_NO [SSB_YES_NO] - 实体类
    /// </summary>
    [Entity(TableName = "SSB_YES_NO", Description = "SSB_YES_NO")]
    public class SsbYesNo : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "OBJID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = true, Nullable = false)]
        public decimal? ObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "YES_NO_NAME", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string YesNoName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "DELETE_FLAG", Description = "",
               DbType = "numeric(5)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? DeleteFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REMARK", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "RECORD_USER_ID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
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
               DbType = "numeric(5)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? BakupFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BAKUP_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? BakupTime { get; set; }
    }
}
