using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMS.JHWMS.AppBiz
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    public interface IConfigManager: IAppBizManager
    {
        List<SysConfig> GetSysConfig();
    }
}
