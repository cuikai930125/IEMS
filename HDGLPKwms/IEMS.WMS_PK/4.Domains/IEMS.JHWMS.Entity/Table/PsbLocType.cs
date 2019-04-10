using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_LOC_TYPE [PSB_LOC_TYPE] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_LOC_TYPE", Description = "PSB_LOC_TYPE")]
    public class PsbLocType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_TYPE_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string LocTypeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_TYPE_NAME", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LocTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOC_TYPE_INDEX", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? LocTypeIndex { get; set; }
    }
}
