using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// WBS_ORDER_LINE [WBS_ORDER_LINE] - 实体类
    /// </summary>
    [Entity(TableName = "WBS_ORDER_LINE", Description = "WBS_ORDER_LINE")]
    public class WbsOrderLine : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_LINE_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string OrderLineGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string OrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LINE_ID", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? LineId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LINE_STATUS", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? LineStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "DELETE_FLAG", Description = "",
               DbType = "varchar(1)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string DeleteFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "SORT_ID", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? SortId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "MATERIAL_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string MaterialNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PRODUCT_GRADE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ProductGrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "SLOC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string SlocNo { get; set; }
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
        [Field(FieldName = "REQUIRE_QTY", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? RequireQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACT_QTY", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? ActQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "SHIP_QTY", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? ShipQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_DATE_START", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? LimitDateStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_DATE_END", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? LimitDateEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_BIN_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LimitBinNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_PRODUCT_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LimitProductGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_BATCH_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LimitBatchNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_PALLET_ID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LimitPalletId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LINE_PRIORITY", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? LinePriority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LAST_TASK_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? LastTaskTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_ERR_DESC", Description = "",
               DbType = "varchar(200)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BinErrDesc { get; set; }
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
        [Field(FieldName = "LOCK_END_LOC", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? LockEndLoc { get; set; }
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
        [Field(FieldName = "PAREA_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string PareaNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIND_ORDER_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BindOrderNo { get; set; }
    }
}
