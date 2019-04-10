namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;
    using System.Collections.Generic;

    public interface IUserActionManager : IAppBizManager
    {
        int Delete(SspUserAction entity);
        int BatchInsert(List<SspUserAction> lst);
    }
}
