using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_BIN_STATUS [PSB_BIN_STATUS] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_BIN_STATUS", Description = "PSB_BIN_STATUS")]
    public class PsbBinStatus : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_NO", Description = "",
               DbType = "varchar(8)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string BinNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "USED_FLAG", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? UsedFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_SIZE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string BinSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_STATUS", Description = "",
               DbType = "varchar(2)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string BinStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_BIZ_STATUS", Description = "",
               DbType = "varchar(2)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string BinBizStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_WEIGHT", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? BinWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_AREA", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BinArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string CrnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "GROUP_LOC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string GroupLocNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_LINE_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string OrderLineGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_PLC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BinPlcNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "GROUP_EXTENSION_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string GroupExtensionNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "WH_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string WhNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "OUT_BIN_BIZ_STATUS", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string OutBinBizStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REAL_GROUP_NO", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? RealGroupNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "COLUMN_INDEX", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? ColumnIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ROW_INDEX", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? RowIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LEVEL_INDEX", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? LevelIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_CLASS", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? BinClass { get; set; }
    }
}
