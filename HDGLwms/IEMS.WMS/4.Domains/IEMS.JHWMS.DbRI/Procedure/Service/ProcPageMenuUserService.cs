using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PROC_PAGE_MENU_USER - 存储过程操作接口
    /// </summary>
    public interface IProcPageMenuUserService :IProcedureService
    {
	    /// <summary>
        /// PROC_PAGE_MENU_USER 执行存储过程
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        ProcPageMenuUser ExcuteProcedure(ProcPageMenuUser param);
    }

    /// <summary>
    /// PROC_PAGE_MENU_USER - 存储过程操作类
    /// </summary>
    internal class ProcPageMenuUserService : DbCIService, IProcPageMenuUserService
    {
	    /// <summary>
        /// PROC_PAGE_MENU_USER 执行存储过程
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ProcPageMenuUser ExcuteProcedure(ProcPageMenuUser param)
		{
		    var result = this.GetDataSetByStatement("PROC_PAGE_MENU_USER", param);
            param.ProcedureDataSetResult = result;
            return param;
		}
    }
}