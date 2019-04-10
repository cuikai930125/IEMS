using System.Linq;
namespace IEMS.JHWMS.DbCI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;
    using IEMS.JHWMS.DbRI;

    internal class DeptService : DbCIService, IDeptService
    {
        private ISsbDeptService basicService;

        #region 构造方法
        public DeptService() : base() {
            basicService = TableViewServiceFactory.CreateInstance<ISsbDeptService>();
        }
        public DeptService(string dbName) : base(dbName) {
            basicService = TableViewServiceFactory.CreateInstance<ISsbDeptService>(dbName);
        }
        #endregion

        public SsbDept GetByObjId(int ObjId)
        {
            var result = this.basicService.GetEntityList(
                new SsbDept() { ObjId = ObjId }
                ).FirstOrDefault();
            return result;
        }
    }
}
