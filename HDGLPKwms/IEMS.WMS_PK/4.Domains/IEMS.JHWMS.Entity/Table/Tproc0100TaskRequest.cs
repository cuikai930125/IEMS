using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// TPROC_0100_TASK_REQUEST [TPROC_0100_TASK_REQUEST] - 实体类
    /// </summary>
    [Entity(TableName = "TPROC_0100_TASK_REQUEST", Description = "TPROC_0100_TASK_REQUEST")]
    public class Tproc0100TaskRequest : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "OBJID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public decimal? ObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ERR_CODE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? ErrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ERR_DESC", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ErrDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PROC_STATUS", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? ProcStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PROC_CREATE_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public DateTime? ProcCreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PROC_EXCUTE_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? ProcExcuteTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PROC_FINISH_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? ProcFinishTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ORDER_TYPE_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string OrderTypeNo { get; set; }
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
        [Field(FieldName = "SOURCE_TYPE", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? SourceType { get; set; }
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
        [Field(FieldName = "SLOC_TYPE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string SlocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "SLOC_AREA", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string SlocArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ELOC_TYPE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ElocType { get; set; }
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
        [Field(FieldName = "ORDER_TYPE_MODULE", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string OrderTypeModule { get; set; }
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
        [Field(FieldName = "PACKAGE_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string PackageGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string TaskGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_NO", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? TaskNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ELOC_AREA", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ElocArea { get; set; }
    }
}
