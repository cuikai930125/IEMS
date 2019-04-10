using System.Data;

namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;
    using IEMS.JHWMS.DbRI;
    using MSTL.DbAccess;
    using System.Collections.Generic;

    internal class UserAllActionManager: IUserAllActionManager
    {
        private IViewUserAllActionService basicService = TableViewServiceFactory.CreateInstance<IViewUserAllActionService>();
        public IList<ViewUserAllAction> GetEntityList(ViewUserAllAction entity)
        {
            return this.basicService.GetEntityList(entity);
        }
    }
}
