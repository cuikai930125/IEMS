using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PROC_0300_CMD_FINISH - 存储过程操作接口
    /// </summary>
    public interface IProc0300CmdFinishService :IProcedureService
    {
	    /// <summary>
        /// PROC_0300_CMD_FINISH 执行存储过程
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Proc0300CmdFinish ExcuteProcedure(Proc0300CmdFinish param);
    }

    /// <summary>
    /// PROC_0300_CMD_FINISH - 存储过程操作类
    /// </summary>
    internal class Proc0300CmdFinishService : DbCIService, IProc0300CmdFinishService
    {
	    /// <summary>
        /// PROC_0300_CMD_FINISH 执行存储过程
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public Proc0300CmdFinish ExcuteProcedure(Proc0300CmdFinish param)
		{
		    var result = this.GetDataSetByStatement("PROC_0300_CMD_FINISH", param);
            param.ProcedureDataSetResult = result;
            return param;
		}
    }
}