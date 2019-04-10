using MSTL.DbAccess;
using MSTL.LogAgent;
using MSTL.ResultStruct.McException;
using IEMS.JHWMS.Entity;
using IEMS.JHWMS.DbRI;
using IEMS.JHWMS.DbCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace IEMS.JHWMS.AppBiz
{
    internal class TaskManager : ITaskManager
    {
        #region 系统日志  log
        private ILog log { get { return Log.Store[this.GetType().FullName]; } }
        #endregion

        #region GetWbsTask
        public WbsTask GetWbsTask(long taskNo)
        {
            var service = TableViewServiceFactory.CreateInstance<IWbsTaskService>();
            return service.GetEntityList(new WbsTask() { TaskNo = taskNo }).FirstOrDefault();
        }
        #endregion

        #region  获取任务信息
        public PageResult GetTaskData(PageResult pageResult)
        {
            var service = DbCIServiceFactory.CreateInstance<ITaskService>();
            return service.GetTaskData(pageResult);
        }
        #endregion

        #region 堆垛机任务维护
        /// <summary>
        /// 堆垛机指令重发
        /// </summary>
        /// <param name="Objid"></param>
        /// <returns></returns>
        public int ResendWbsTaskCmd(string Objid)
        {
            try
            {
                if (string.IsNullOrEmpty(Objid) || Objid.Equals("0"))
                {
                    return 0;
                }
                var service = TableViewServiceFactory.CreateInstance<IWbsTaskCmdService>();
                return service.Update(new WbsTaskCmd() { CmdStep = "00" }, new WbsTaskCmd() {ObjId = int.Parse(Objid) });
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return 0;
            }
        }
        /// <summary>
        /// 堆垛机指令结束
        /// </summary>
        /// <param name="Objid"></param>
        /// <returns></returns>
        public bool FinishWbsTaskCmd(string Objid)
        {
            try
            {
                if (string.IsNullOrEmpty(Objid) || Objid.Equals("0"))
                {
                    return false;
                }
                var errCode = 0;
                var errDesc = string.Empty;
                var service = ProcedureServiceFactory.CreateInstance<IProcWmsFinishCmdService>();
                service.ExcuteProcedure(new ProcWmsFinishCmd() { IParamObjid = int.Parse(Objid), OErrCode = errCode, OErrDesc = errDesc });
                if (errCode == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return false;
            }
        }
        /// <summary>
        /// 堆垛机指令删除
        /// </summary>
        /// <param name="Objid"></param>
        /// <returns></returns>
        public bool DeleteWbsTaskCmd(string Objid)
        {
            try
            {
                if (string.IsNullOrEmpty(Objid) || Objid.Equals("0"))
                {
                    return false;
                }
                var service = ProcedureServiceFactory.CreateInstance<IProcWmsDeleteCmdService>();
                service.ExcuteProcedure(new ProcWmsDeleteCmd() { IParamObjid = int.Parse(Objid) });
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return false;
            }
        }
        /// <summary>
        /// 任务删除
        /// </summary>
        /// <param name="Objid"></param>
        /// <returns></returns>
        public bool DeleteWbsTask(string TaskNo)
        {
            try
            {
                if (string.IsNullOrEmpty(TaskNo))
                {
                    return false;
                }
                var service = ProcedureServiceFactory.CreateInstance<IProcWmsDeleteTaskService>();
                service.ExcuteProcedure(new ProcWmsDeleteTask() { ITaskNo = int.Parse(TaskNo) });
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return false;
            }
        }
        #endregion
        /// <summary>
        /// 任务请求
        /// </summary>
        public string RequestTaskCmd(string palletNo, string sLocNo)
        {
            var taskSeq = SequenceServiceFactory.CreateInstance<ISeqTproc0100TaskRequestService>();
            var taskTable = TableViewServiceFactory.CreateInstance<ITproc0100TaskRequestService>();
            var taskSever = ProcedureServiceFactory.CreateInstance<IProc0100TaskRequestService>();

            var cmdSeq = SequenceServiceFactory.CreateInstance<ISeqTproc0200CmdRequestService>();
            var cmdTable = TableViewServiceFactory.CreateInstance<ITproc0200CmdRequestService>();
            var cmdSever = ProcedureServiceFactory.CreateInstance<IProc0200CmdRequestService>();

            try
            {
                var taskId = taskSeq.NEXTVAL;
                taskTable.Insert(new Tproc0100TaskRequest()
                {
                    ObjId = taskId,
                    PalletNo = palletNo,
                    SlocNo = sLocNo,
                    OrderTypeNo = "100064"
                });
                var TaskResult = taskSever.ExcuteProcedure(new Proc0100TaskRequest() { IParamObjid = taskId, OTaskNo = 0, OErrCode = 0, OErrDesc = ""});
                var taskNo = TaskResult.OTaskNo;
                var errCode = TaskResult.OErrCode;
                var errDesc = TaskResult.OErrDesc;
                if (errCode != 0 || taskNo == 0)
                {
                    return errDesc;
                }
                var cmdId = cmdSeq.NEXTVAL;
                cmdTable.Insert(new Tproc0200CmdRequest()
                {
                    ObjId = cmdId,
                    TaskNo = taskNo,
                    CurrLocNo = sLocNo
                });
                var CmdResult = cmdSever.ExcuteProcedure(new Proc0200CmdRequest() { IParamObjid = cmdId, OCmdObjid = 0, OErrCode = 0, OErrDesc = "" });
                var cmdObjid = CmdResult.OCmdObjid;
                errCode = CmdResult.OErrCode;
                errDesc = CmdResult.OErrDesc;
                if (errCode != 0 || cmdObjid == 0)
                {
                    return errDesc;
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw ex;
            }
        }

        /// <summary>
        /// 堆垛机状态获取
        /// </summary>
        /// <returns></returns>
        public DataTable GetCrnForkErrorStatus()
        {
            var service = DbCIServiceFactory.CreateInstance<ITaskService>();
            return service.GetCrnForkErrorStatus();
        }
    }
}