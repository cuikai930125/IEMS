using System.Data;

namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;
    using System.Collections.Generic;

    public interface IUserAllActionManager : IAppBizManager
    {
        IList<ViewUserAllAction> GetEntityList(ViewUserAllAction entity);
    }
}
