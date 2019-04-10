using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// WBS_ORDER [WBS_ORDER] - 实体类
    /// </summary>
    [Entity(TableName = "WBS_ORDER", Description = "WBS_ORDER")]
    public class WbsOrder : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string OrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_STATUS", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? OrderStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_TYPE_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string OrderTypeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_TYPE_MODULE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string OrderTypeModule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CREATION_DATE", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? CreationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CREATED_BY", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "FMEM", Description = "",
               DbType = "varchar(200)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Fmem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_PRIORITY", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? OrderPriority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "SOURCE_TYPE", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? SourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REQUEST_OBJID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? RequestObjid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ELOC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ElocNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "USER_NAME", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string UserName { get; set; }
    }
}
