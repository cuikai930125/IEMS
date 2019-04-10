using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_GRADE [PSB_GRADE] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_GRADE", Description = "PSB_GRADE")]
    public class PsbGrade : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "GRADE_NO", Description = "",
               DbType = "varchar(50)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string GradeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "GRADE_DESC", Description = "",
               DbType = "varchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string GradeDesc { get; set; }
    }
}
