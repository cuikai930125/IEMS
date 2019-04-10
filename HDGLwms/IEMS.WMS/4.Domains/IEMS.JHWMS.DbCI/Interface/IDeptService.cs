namespace IEMS.JHWMS.DbCI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    public interface IDeptService : IDbCIService
    {
        SsbDept GetByObjId(int ObjId);
    }
}
