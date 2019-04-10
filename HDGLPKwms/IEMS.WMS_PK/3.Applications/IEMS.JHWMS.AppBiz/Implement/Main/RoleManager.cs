namespace IEMS.JHWMS.AppBiz
{
    using IEMS.JHWMS.Entity;
    using IEMS.JHWMS.DbRI;
    using System.Collections.Generic;
    using MSTL.DbAccess;

    internal class RoleManager:IRoleManager
    {
        private ISspRoleService basicService = TableViewServiceFactory.CreateInstance<ISspRoleService>();
        public  IList<SspRole> GetEntityList(SspRole entity)
        {
            return this.basicService.GetEntityList(entity);
        }
        public IList<SspRole> GetEntityList(SspRole entity, string orderby)
        {
            return this.basicService.GetEntityList(entity, orderby);
        }
    }
}
