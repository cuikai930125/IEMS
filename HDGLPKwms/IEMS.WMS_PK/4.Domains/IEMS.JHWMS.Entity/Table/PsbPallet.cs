using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PSB_PALLET [PSB_PALLET] - 实体类
    /// </summary>
    [Entity(TableName = "PSB_PALLET", Description = "PSB_PALLET")]
    public class PsbPallet : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PALLET_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = false, Nullable = false)]
        public string PalletNo { get; set; }
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
        [Field(FieldName = "CREATION_DATE", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? CreationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PALLET_WEIGHT", Description = "",
               DbType = "numeric(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? PalletWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOAD_STATUS", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? LoadStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "PRODUCT_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string ProductGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LAST_PRODUCT_GUID", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LastProductGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "MATER_NO", Description = "",
               DbType = "varchar(80)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string MaterNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BINDING_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? BindingTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "DELETE_FLAG", Description = "",
               DbType = "int(4)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public int? DeleteFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "RECORD_USER_ID", Description = "",
               DbType = "decimal(9)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? RecordUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "RECORD_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? RecordTime { get; set; }
    }
}
