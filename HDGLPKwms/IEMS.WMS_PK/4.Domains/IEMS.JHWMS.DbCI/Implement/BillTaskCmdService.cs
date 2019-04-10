using MSTL.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEMS.JHWMS.DbCI
{
    internal class BillTaskCmdService : DbCIService, IBillTaskCmdService
    {
        /// <summary>
        /// 获取订单数据
        /// </summary>
        /// <param name="pageResult"></param>
        /// <returns></returns>
        public PageResult GetBillOrderDataTable(PageResult pageResult)
        {
            string stmtId = "GetBillOrderDataTable";
            pageResult.StatementId = stmtId;
            return this.GetPageDataByReader(pageResult);
        }
        /// <summary>
        /// 获取订单行项目
        /// </summary>
        /// <param name="pageResult"></param>
        /// <returns></returns>
        public PageResult GetBillOrderLineDataTable(PageResult pageResult)
        {
            string stmtId = "GetBillOrderLineDataTable";
            pageResult.StatementId = stmtId;
            var result = GetPageDataByReader(pageResult);
            return result;
        }

        public PageResult GetBillDataTable(PageResult pageResult)
        {
            string stmtId = "GetBillDataTable";
            pageResult.StatementId = stmtId;
            return this.GetPageDataByReader(pageResult);
        }

        public PageResult GetTaskDataTable(PageResult pageResult)
        {
            string stmtId = "GetTaskDataTable";
            pageResult.StatementId = stmtId;
            return this.GetPageDataByReader(pageResult);
        }

        public PageResult GetCmdDataTable(PageResult pageResult)
        {
            string stmtId = "GetCmdDataTable";
            pageResult.StatementId = stmtId;
            return this.GetPageDataByReader(pageResult);
        }
    }
}
