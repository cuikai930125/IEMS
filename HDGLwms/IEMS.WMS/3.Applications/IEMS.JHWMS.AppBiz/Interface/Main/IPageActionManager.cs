using System.Data;

namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;

    public interface IPageActionManager : IAppBizManager
    {
        /// <summary>
        /// 获取所有的页面操作信息
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        DataSet GetAllPageMenuAction();

      
    }
}
