using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// SSL_LOGIN_LOG [SSL_LOGIN_LOG] - 实体类
    /// </summary>
    [Entity(TableName = "SSL_LOGIN_LOG", Description = "SSL_LOGIN_LOG")]
    public class SslLoginLog : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "OBJID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = true, IsIdentity = true, Nullable = false)]
        public decimal? ObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "USER_ID", Description = "",
               DbType = "numeric(13)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOGIN_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? LoginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOGIN_IP", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LoginIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOGOUT_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? LogoutTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "LOGOUT_IP", Description = "",
               DbType = "nvarchar(100)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string LogoutIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "REMARK", Description = "",
               DbType = "nvarchar(1000)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BAKUP_FLAG", Description = "",
               DbType = "numeric(5)", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public decimal? BakupFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "BAKUP_TIME", Description = "",
               DbType = "datetime", DefaultValue = "",
               IsPrimaryKey = false, IsIdentity = false, Nullable = true)]
        public DateTime? BakupTime { get; set; }
    }
}
