using System.Collections.Generic;
namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;

    public interface IDeptRoleManager : IAppBizManager
    {
        IList<SspDeptRole> GetEntityList(SspDeptRole entity);
        int Delete(SspDeptRole entity);
        int BatchInsert(List<SspDeptRole> lst);
        int GetRowCount(SspDeptRole entity);
    }
}
