using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_CRN_ERR [PSB_CRN_ERR] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_CRN_ERR", Description = "PSB_CRN_ERR")]
    public class PsbCrnErr : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ERR_NO", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public int? ErrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "ERR_NAME", Description = "",
               DbType = "varchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ErrName { get; set; }
    }
}
