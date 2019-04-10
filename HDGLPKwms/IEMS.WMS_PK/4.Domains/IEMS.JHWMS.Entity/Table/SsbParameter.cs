using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSB_PARAMETER [SSB_PARAMETER] - 实体类
    /// </summary>
    [Entity(TableName = "SSB_PARAMETER", Description = "SSB_PARAMETER")]
    public class SsbParameter : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PARAM_NO", Description = "",
               DbType = "varchar(20)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string ParamNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PARAM_DESC", Description = "",
               DbType = "varchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string ParamDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PARAM_TYPE", Description = "",
               DbType = "varchar(20)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string ParamType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PARAM_VALUE", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = false)]
        public string ParamValue { get; set; }
    }
}
