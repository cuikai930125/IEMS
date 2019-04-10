using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PEM_CRN_FORK_STATUS [PEM_CRN_FORK_STATUS] - 实体类
    /// </summary>
    [Entity(TableName = "PEM_CRN_FORK_STATUS", Description = "PEM_CRN_FORK_STATUS")]
    public class PemCrnForkStatus : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_FORK_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string CrnForkNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string CrnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LAST_TASK_TYPE", Description = "",
               DbType = "varchar(1)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string LastTaskType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TASK_TYPE", Description = "",
               DbType = "varchar(1)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string TaskType { get; set; }
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
        [Field(FieldName = "FROM_BIN", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string FromBin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "TO_BIN", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ToBin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "STEP", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? Step { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOADING", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? Loading { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "RETRY_COUNT", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? RetryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_MODE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? CrnMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "STATUS", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACT_POS_X", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? ActPosX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACT_POS_Y", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? ActPosY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACT_POS_Z", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? ActPosZ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACT_SPEED_X", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? ActSpeedX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACT_SPEED_Y", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? ActSpeedY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ACT_SPEED_Z", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? ActSpeedZ { get; set; }
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
        [Field(FieldName = "FAULT_NO", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? FaultNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "FIP_FLAG", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? FipFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "FIP_DATE", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? FipDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "FIP_HANDLE_RESULT", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string FipHandleResult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "FIP_FAULT_NO", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? FipFaultNo { get; set; }
    }
}
