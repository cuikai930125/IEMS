using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// WBS_TASK [WBS_TASK] - 实体类
    /// </summary>
    [Entity(TableName = "WBS_TASK", Description = "WBS_TASK")]
    public class WbsTask : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string TaskGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_NO", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? TaskNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "EMERGENCY", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? Emergency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "IO_TYPE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string IoType { get; set; }
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
        [Field(FieldName = "PALLET_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string PalletNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PACKAGE_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string PackageGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CREATION_DATE", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public DateTime? CreationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_EXEC_START_DT", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? TaskExecStartDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_EXEC_END_DT", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? TaskExecEndDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LAST_UPDATE_DATE", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? LastUpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "FINISH_FLAG", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? FinishFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ERR_NO", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? ErrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BinNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PALLET_TYPE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string PalletType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_STEP", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string TaskStep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "FINISH_DESC", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string FinishDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ROUTE_NOS", Description = "",
               DbType = "varchar(200)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string RouteNos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "UNEXE_ROUTE_NO", Description = "",
               DbType = "varchar(200)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string UnexeRouteNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_REQUEST_ID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? OrderRequestId { get; set; }
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
        [Field(FieldName = "SORT_ID", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? SortId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REQUEST_CMD_OBJID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? RequestCmdObjid { get; set; }
    }
}
