using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_CRN [PSB_CRN] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_CRN", Description = "PSB_CRN")]
    public class PsbCrn : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string CrnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_NAME", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string CrnName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_FORK_COUNT", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? CrnForkCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "MAX_OUT_TASK_COUNT", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? MaxOutTaskCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "MAX_IN_TASK_COUNT", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? MaxInTaskCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_STATUS", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? CrnStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_IN_ENABLE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? CrnInEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_OUT_ENABLE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public decimal? CrnOutEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LIMIT_TASK_SIZE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? LimitTaskSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "EXTENSION_SIZE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? ExtensionSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "COL_SIZE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? ColSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LAYER_SIZE", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? LayerSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "WH_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string WhNo { get; set; }
    }
}
