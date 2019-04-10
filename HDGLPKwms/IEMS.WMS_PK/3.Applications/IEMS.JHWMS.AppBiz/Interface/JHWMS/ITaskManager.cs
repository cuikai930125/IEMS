using MSTL.DbAccess;
using IEMS.JHWMS.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMS.JHWMS.AppBiz
{
    public interface ITaskManager : IAppBizManager
    {

        /// <summary>
        /// 根据任务号获取任务信息
        /// </summary>
        WbsTask GetWbsTask(long taskNo);
        /// <summary>
        /// 获取任务信息
        /// </summary>
        PageResult GetTaskData(PageResult pageResult);
        /// <summary>
        /// 堆垛机指令重发
        /// </summary>
        int ResendWbsTaskCmd(string Objid);
        /// <summary>
        /// 堆垛机指令结束
        /// </summary>
        bool FinishWbsTaskCmd(string Objid);
        /// <summary>
        /// 堆垛机指令删除
        /// </summary>
        bool DeleteWbsTaskCmd(string Objid);
        /// <summary>
        /// 堆垛机任务删除
        /// </summary>
        bool DeleteWbsTask(string TaskNo);
        /// <summary>
        /// 任务请求
        /// </summary>
        string RequestTaskCmd(string palletNo, string sLocNo);
        /// <summary>
        /// 堆垛机状态获取
        /// </summary>
        DataTable GetCrnForkErrorStatus();
    }
}
