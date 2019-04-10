
namespace IEMS.JHWMS.DbCI
{
    using MSTL.DbAccess;
    using System.Data;

    public interface ITaskService : IDbCIService
    {
        /// <summary>
        /// 获取任务
        /// </summary>
        PageResult GetTaskData(PageResult pageResult);
        /// <summary>
        /// 获取堆垛机状态
        /// </summary>
        DataTable GetCrnForkErrorStatus();
    }
}
