using MSTL.DbAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace IEMS.JHWMS.DbCI
{
    internal class TaskService : DbCIService, ITaskService
    {
        public PageResult GetTaskData(PageResult pageResult)
        {
            string stmtId = "GetTaskData";
            pageResult.StatementId = stmtId;
            return this.GetPageDataByReader(pageResult);
        }

        public DataTable GetCrnForkErrorStatus()
        {
            var dTable = this.GetDataTableByStatement("GetCrnForkErrorStatus", null);
            return dTable;
        }
    }
}
