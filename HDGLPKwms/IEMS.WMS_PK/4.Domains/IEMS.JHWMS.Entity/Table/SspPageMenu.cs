using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSP_PAGE_MENU [SSP_PAGE_MENU] - 实体类
    /// </summary>
    [Entity(TableName = "SSP_PAGE_MENU", Description = "SSP_PAGE_MENU")]
    public class SspPageMenu : BaseEntity
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
        [Field(FieldName = "menu_level", Description = "",
               DbType = "nvarchar(300)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string MenuLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "show_name", Description = "",
               DbType = "nvarchar(300)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ShowName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "remark", Description = "",
               DbType = "nvarchar(600)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "page_url", Description = "",
               DbType = "nvarchar(3000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string PageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ico_name", Description = "",
               DbType = "nvarchar(300)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string IcoName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "is_show", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? IsShow { get; set; }
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
        [Field(FieldName = "seq_index", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? SeqIndex { get; set; }
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
        [Field(FieldName = "bakup_flag", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? BakupFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "bakup_time", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public DateTime? BakupTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "http_url", Description = "",
               DbType = "nvarchar(3000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string HttpUrl { get; set; }
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
