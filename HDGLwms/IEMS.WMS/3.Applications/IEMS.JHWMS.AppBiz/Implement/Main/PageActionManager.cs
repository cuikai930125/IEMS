using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System;
namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;
    using IEMS.JHWMS.DbRI;
    using IEMS.JHWMS.DbCI;
    using MSTL.DbAccess;

    internal class PageActionManager : IPageActionManager
    {
        /// <summary>
        /// 获取所有的页面操作信息
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataSet GetAllPageMenuAction()
        {
            var service = ProcedureServiceFactory.CreateInstance<IProcPageMenuActionAllService>();
            var param = new ProcPageMenuActionAll();
            return  service.ExcuteProcedure(param).ProcedureDataSetResult;
        }
     


    }
}
