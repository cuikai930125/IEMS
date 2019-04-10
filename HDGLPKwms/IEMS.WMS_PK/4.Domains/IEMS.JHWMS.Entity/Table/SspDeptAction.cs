using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSP_DEPT_ACTION [SSP_DEPT_ACTION] - 实体类
    /// </summary>
    [Entity(TableName = "SSP_DEPT_ACTION", Description = "SSP_DEPT_ACTION")]
    public class SspDeptAction : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "objid", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = true, Nullable = false)]
        public int? ObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "dept_id", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? DeptId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "action_id", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? ActionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "record_user_id", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? RecordUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "record_time", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public DateTime? RecordTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "bakup_flag", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? BakupFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "bakup_time", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? BakupTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "foreign_no", Description = "",
               DbType = "nvarchar(600)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ForeignNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "seq_index", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? SeqIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "remark", Description = "",
               DbType = "nvarchar(1200)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "delete_flag", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? DeleteFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "backup_flag", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? BackupFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "backup_time", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public DateTime? BackupTime { get; set; }
    }
}
