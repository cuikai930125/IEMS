using System.Collections.Generic;

namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;

    public interface IRoleManager : IAppBizManager
    {
        IList<SspRole> GetEntityList(SspRole entity);
        IList<SspRole> GetEntityList(SspRole entity,string orderby);
    }
}
