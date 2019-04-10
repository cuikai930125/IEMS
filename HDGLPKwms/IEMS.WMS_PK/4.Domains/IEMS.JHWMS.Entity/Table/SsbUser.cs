using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSB_USER [SSB_USER] - 实体类
    /// </summary>
    [Entity(TableName = "SSB_USER", Description = "SSB_USER")]
    public class SsbUser : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "OBJID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = true, Nullable = false)]
        public decimal? ObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "USER_NAME", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "USER_PWD", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string UserPwd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REAL_NAME", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string RealName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "SEX", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TELEPHONE", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Telephone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "WORK_BARCODE", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string WorkBarcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "DEPT_ID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? DeptId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "WORK_ID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? WorkId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "SHIFT_ID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? ShiftId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CLASS_ID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? ClassId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "WORKSHOP_ID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? WorkshopId { get; set; }
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
        [Field(FieldName = "REMARK", Description = "",
               DbType = "nvarchar(1000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "IS_EMPLOYEE", Description = "",
               DbType = "decimal(5)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? IsEmployee { get; set; }
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
        [Field(FieldName = "FOREIGN_NO", Description = "",
               DbType = "nvarchar(1000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ForeignNo { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "USER_NO", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string UserNo { get; set; }
    }
}
