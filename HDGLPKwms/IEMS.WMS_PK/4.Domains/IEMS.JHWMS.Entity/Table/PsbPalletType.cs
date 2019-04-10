using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_PALLET_TYPE [PSB_PALLET_TYPE] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_PALLET_TYPE", Description = "PSB_PALLET_TYPE")]
    public class PsbPalletType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PALLET_TYPE_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string PalletTypeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PALLET_TYPE_NAME", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string PalletTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIND_MATER_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string BindMaterNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BIN_CLASS", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? BinClass { get; set; }
    }
}
