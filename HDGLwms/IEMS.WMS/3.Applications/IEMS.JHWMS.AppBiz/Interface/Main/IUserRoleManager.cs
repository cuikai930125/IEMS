namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;
    using System.Collections.Generic;

    public interface IUserRoleManager : IAppBizManager
    {
        int Delete(SspUserRole entity);
        IList<SspUserRole> GetEntityList(SspUserRole entity);
        int BatchInsert(List<SspUserRole> lst);
        int Insert(SspUserRole entity);
    }
}
