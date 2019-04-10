using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_CRN_FORK [PSB_CRN_FORK] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_CRN_FORK", Description = "PSB_CRN_FORK")]
    public class PsbCrnFork : BaseEntity
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
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string CrnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_FORK_NAME", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string CrnForkName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_FORK_IDX", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? CrnForkIdx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_FORK_ENABLE", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public int? CrnForkEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "CRN_FORK_PLC_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string CrnForkPlcNo { get; set; }
    }
}
