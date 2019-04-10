
namespace IEMS.JHWMS.DbCI
{
    using MSTL.DbAccess;
    using System.Data;

    public interface ICrnService : IDbCIService
    {
        DataTable GetCrnDataTable();
        /// <summary>
        /// 获取堆垛机叉异常状态
        /// </summary>
        DataTable GetCrnForkErrorStatus();
    }
}
