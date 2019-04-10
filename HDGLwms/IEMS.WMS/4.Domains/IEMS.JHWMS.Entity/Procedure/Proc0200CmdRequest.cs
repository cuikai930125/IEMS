using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IEMS.JHWMS.Entity
{
    using MSTL.DbAccess;

    /// <summary>
    /// PROC_0200_CMD_REQUEST [PROC_0200_CMD_REQUEST] - 实体类
    /// </summary>
    [Entity(TableName = "PROC_0200_CMD_REQUEST", Description = "PROC_0200_CMD_REQUEST")]
    public class Proc0200CmdRequest : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "I_PARAM_OBJID", Description = "", DbType = "numeric(13)")]
        public decimal? IParamObjid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "O_CMD_OBJID", Description = "", DbType = "numeric(13)")]
        public decimal? OCmdObjid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "O_ERR_CODE", Description = "", DbType = "numeric(9)")]
        public decimal? OErrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Field(FieldName = "O_ERR_DESC", Description = "", DbType = "varchar(80)")]
        public string OErrDesc { get; set; }
        /// <summary>
        /// 存储过程返回 DataSet 数据
        /// </summary>
        public DataSet ProcedureDataSetResult { get; set; }
    }
}
