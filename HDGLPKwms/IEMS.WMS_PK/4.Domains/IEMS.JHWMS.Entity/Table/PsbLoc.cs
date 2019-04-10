using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_LOC [PSB_LOC] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_LOC", Description = "PSB_LOC")]
    public class PsbLoc : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string LocNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_PLC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LocPlcNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_TYPE_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LocTypeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_NAME", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LocName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_INDEX", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? LocIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "MAX_BUFFER", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? MaxBuffer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_GROUP_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LocGroupNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_PRIORITY", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? LocPriority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_ENABLE", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? LocEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "AREA_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string AreaNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TRANSFER_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string TransferNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_CMD_QTY", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? LimitCmdQty { get; set; }
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
        [Field(FieldName = "LOC_MES_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LocMesNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_AGV_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LocAgvNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BPALLET_REQUEST", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? BpalletRequest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIND_ELOC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BindElocNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOCK_REQUEST_LOC", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? LockRequestLoc { get; set; }
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
        [Field(FieldName = "BIND_PALLET_TYPE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BindPalletType { get; set; }
    }
}
