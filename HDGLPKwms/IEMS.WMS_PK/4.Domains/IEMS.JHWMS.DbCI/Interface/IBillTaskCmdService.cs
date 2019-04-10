using MSTL.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEMS.JHWMS.DbCI
{
    public interface IBillTaskCmdService : IDbCIService
    {
        /// <summary>
        /// 获取订单主表数据
        /// </summary>
        /// <param name="pageResult"></param>
        /// <returns></returns>
        PageResult GetBillOrderDataTable(PageResult pageResult);

        /// <summary>
        /// 获取订单主表数据
        /// </summary>
        /// <param name="pageResult"></param>
        /// <returns></returns>
        PageResult GetBillOrderLineDataTable(PageResult pageResult);


        PageResult GetBillDataTable(PageResult pageResult);

        PageResult GetTaskDataTable(PageResult pageResult);

        PageResult GetCmdDataTable(PageResult pageResult);
    }
}
